using PdfSharp.Charting;
using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using System.Collections;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace PAT_Inspection_Logger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            datePicker.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now.AddYears(1);
        }
        string toolName = "PAT Inspection Logger";


        void newInspection()
        {
            photoPicBox.Image = null;
            serialText.Text = "";
            descText.Text = "";
            locText.Text = "";
            classNum.Value = 1;
            visPassChk.Checked = false;
            fuseNum.Value = 13;
            earthOhmsNum.Value = 0;
            mohmsNum.Value = 0;
            leakageNum.Value = 0;
            passChk.Checked = false;
            commentsText.Text = "";
        }


        SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=PATInspections.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), toolName);
            }
            return sqlite_conn;
        }

        void CreateTable(SQLiteConnection conn)
        {
            try
            {
                SQLiteCommand sqlite_cmd;
                string Createsql =

                    "CREATE TABLE IF NOT EXISTS Inspections (" +
                    "id INTEGER PRIMARY KEY," +
                    "inspectionDate TEXT," +
                    "reInspectionDate TEXT," +
                    "inspector TEXT," +
                    "serial TEXT," +
                    "description TEXT," +
                    "location TEXT," +
                    "class INTEGER," +
                    "visualPass INTEGER," +
                    "fuseRating INTEGER," +
                    "ohms REAL," +
                    "mohms INTEGER," +
                    "leakage REAL," +
                    "passed INTEGER," +
                    "comments TEXT," +
                    "image TEXT" +
                    ");";

                sqlite_cmd = conn.CreateCommand();

                sqlite_cmd.CommandText = Createsql;
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), toolName);
            }
        }

        void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd = conn.CreateCommand();

            string inspectionDate = datePicker.Value.ToLongDateString();
            string reInspectionDate = dateTimePicker2.Value.ToLongDateString();
            string inspector = inspectorText.Text;
            string serial = serialText.Text;
            string description = descText.Text;
            string location = locText.Text;
            string equipmentClass = classNum.Value.ToString();
            string visualPass = visPassChk.Checked.ToString();
            string fuseRating = fuseNum.Value.ToString();
            string ohms = earthOhmsNum.Value.ToString();
            string mohms = mohmsNum.Value.ToString();
            string leakage = leakageNum.Value.ToString();
            string passed = passChk.Checked.ToString();
            string comments = commentsText.Text;
            string image = ConvertImageToString(compressImage(photoPicBox.Image, (double)400, (double)400));

            sqlite_cmd.CommandText =
                "INSERT INTO Inspections(inspectionDate,reInspectionDate,inspector,serial,description,location,class,visualPass,fuseRating,ohms,mohms,leakage,passed,comments,image) " +
                "VALUES(" +
                "'" + inspectionDate + "'," +
                "'" + reInspectionDate + "'," +
                "'" + inspector + "'," +
                "'" + serial + "'," +
                "'" + description + "'," +
                "'" + location + "'," +
                "'" + equipmentClass + "'," +
                "'" + visualPass + "'," +
                "'" + fuseRating + "'," +
                "'" + ohms + "'," +
                "'" + mohms + "'," +
                "'" + leakage + "'," +
                "'" + passed + "'," +
                "'" + comments + "'," +
                "'" + image + "'" +
                "); ";

            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), toolName);
            }
        }


        bool inspectionCompleted()
        {
            bool completed = false;

            //Image is not mandatory and neither are comments. 
            if (inspectorText.Text.Length > 0 && serialText.Text.Length > 0 && descText.Text.Length > 0 && locText.Text.Length > 0 && earthOhmsNum.Value > 0 && mohmsNum.Value > 0 && leakageNum.Value > 0)
            {
                completed = true;
            }
            else
            {
                MessageBox.Show("Please complete the inspection fully before trying to save it.", toolName);
            }
            return completed;
        }

        void saveInspection()
        {
            if (inspectionCompleted() == true)
            {
                bool success = false;
                try
                {
                    SQLiteConnection sqlite_conn = CreateConnection();
                    CreateTable(sqlite_conn);
                    InsertData(sqlite_conn);

                    success = true;
                    sqlite_conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), toolName);
                }
                if (success == false)
                {
                    MessageBox.Show("Failed to save inspection to Database.", toolName);
                }
            }
        }


        void choosePhoto()
        {
            openPhotoFile.ShowDialog();
            if (openPhotoFile.FileName.Length > 0)
            {
                try
                {
                    photoPicBox.Image = new Bitmap(openPhotoFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, toolName);
                }
            }
        }

        string ConvertImageToString(Image image)
        {
            if (image != null)
            {
                // First Convert image to byte array.
                byte[] byteArray = new byte[0];
                using (MemoryStream stream = new MemoryStream())
                {
                    image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    stream.Close();

                    byteArray = stream.ToArray();
                }

                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(byteArray);

                return base64String;
            }
            else
            {
                return null;
            }
        }


        Image ConvertStringToImage(string ImgAsString)
        {
            if (ImgAsString.Length > 0)
            {
                Image img = null;

                byte[] imageBytes = Convert.FromBase64String(ImgAsString);

                using (MemoryStream stream = new MemoryStream(imageBytes))
                {
                    img = Image.FromStream(stream);
                }

                return img;
            }
            else
            {
                return null;
            }
        }


        Image compressImage(Image image, double x, double y)
        {
            if (image != null)
            {
                var ratioX = x / image.Width;
                var ratioY = y / image.Height;
                var ratio = Math.Min(ratioX, ratioY);

                var newWidth = (int)(image.Width * ratio);
                var newHeight = (int)(image.Height * ratio);

                var newImage = new Bitmap(newWidth, newHeight);
                Graphics.FromImage(newImage).DrawImage(image, 0, 0, newWidth, newHeight);
                Image bmp = new Bitmap(newImage);

                return bmp;
            }
            else
            {
                return null;
            }
        }


        void createPDFCert()
        {
            if (inspectionCompleted() == true)
            {
                if (justSaveChk.Checked == true)
                {
                    try
                    {
                        //Document stuff
                        PdfDocument document = new PdfDocument();
                        document.Info.Title = "PAT Certificate - Issued by " + inspectorText.Text;
                        document.Info.Creator = inspectorText.Text;
                        document.Info.Author = inspectorText.Text;

                        //Page stuff
                        PdfPage page = document.AddPage();
                        page.Size = PdfSharp.PageSize.A4;

                        //Set up the graphics
                        GlobalFontSettings.UseWindowsFontsUnderWindows = true;
                        XGraphics gfx = XGraphics.FromPdfPage(page);
                        XFont titleFont = new XFont("Verdana", 18, XFontStyleEx.Bold);
                        XFont templateFont = new XFont("Arial", 14, XFontStyleEx.Bold);
                        XFont regularFont = new XFont("Arial", 14, XFontStyleEx.Regular);

                        //Draw the content
                        gfx.DrawString("PAT Certificate - Issued by " + inspectorText.Text, titleFont, XBrushes.Red, 15, 30);
                        gfx.DrawString("Issued " + datePicker.Value.ToShortDateString(), titleFont, XBrushes.Red, 15, 60);

                        gfx.DrawString("Serial: ", templateFont, XBrushes.Black, 15, 120);
                        gfx.DrawString(serialText.Text, regularFont, XBrushes.Black, 64, 120);

                        gfx.DrawString("Description: ", templateFont, XBrushes.Black, 15, 150);
                        gfx.DrawString(descText.Text, regularFont, XBrushes.Black, 104, 150);

                        gfx.DrawString("Location: ", templateFont, XBrushes.Black, 15, 180);
                        gfx.DrawString(locText.Text, regularFont, XBrushes.Black, 86, 180);

                        gfx.DrawString("Class: ", templateFont, XBrushes.Black, 15, 210);
                        gfx.DrawString(classNum.Value.ToString(), regularFont, XBrushes.Black, 64, 210);

                        gfx.DrawString("Visual Inspection: ", templateFont, XBrushes.Black, 15, 240);
                        gfx.DrawString(visPassChk.Checked.ToString(), regularFont, XBrushes.Black, 140, 240);

                        gfx.DrawString("Fuse Rating: ", templateFont, XBrushes.Black, 15, 270);
                        gfx.DrawString(fuseNum.Value.ToString(), regularFont, XBrushes.Black, 105, 270);

                        gfx.DrawString("Earth Ohms: ", templateFont, XBrushes.Black, 15, 300);
                        gfx.DrawString(earthOhmsNum.Value.ToString(), regularFont, XBrushes.Black, 105, 300);

                        gfx.DrawString("Insulation Mohms: ", templateFont, XBrushes.Black, 15, 330);
                        gfx.DrawString(mohmsNum.Value.ToString(), regularFont, XBrushes.Black, 147, 330);

                        gfx.DrawString("Leakage: ", templateFont, XBrushes.Black, 15, 360);
                        gfx.DrawString(leakageNum.Value.ToString(), regularFont, XBrushes.Black, 844, 360);

                        gfx.DrawString("Comments: ", templateFont, XBrushes.Black, 15, 390);
                        gfx.DrawString(commentsText.Text, regularFont, XBrushes.Black, 100, 390);

                        gfx.DrawString("Result: ", titleFont, XBrushes.Black, 15, 500);
                        if (passChk.Checked == false)
                        {
                            gfx.DrawString("Failed Inspection", titleFont, XBrushes.Red, 95, 500);
                        }
                        else
                        {
                            gfx.DrawString("Passed Inspection", titleFont, XBrushes.Green, 95, 500);
                        }

                        //If there is a photo, might as well add it to the certificate...
                        if (photoPicBox.Image != null)
                        {
                            MemoryStream strm = new MemoryStream();
                            Image img = compressImage(photoPicBox.Image, (double)275, (double)275);
                            img.Save(strm, System.Drawing.Imaging.ImageFormat.Png);
                            XImage xfoto = XImage.FromStream(strm);

                            gfx.DrawImage(xfoto, 15, 530, img.Width, img.Height);
                        }

                        string path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PAT Inspection Logger", DateTime.Now.ToString("yyyy-MM-dd"));
                        bool exists = System.IO.Directory.Exists(path);
                        if (!exists)
                        {
                            System.IO.Directory.CreateDirectory(path);
                        }
                        string filename = "PAT Certificate - " + serialText.Text + " -" + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".pdf";

                        document.Save(path + "\\" + filename);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, toolName);
                    }
                }
            }
        }


        void loadAllRecords()
        {
            records.Rows.Clear();

            try
            {
                SQLiteConnection sqlite_conn = CreateConnection();

                string result = "";
                SQLiteDataReader sqlite_datareader;
                SQLiteCommand sqlite_cmd;
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "SELECT * FROM Inspections;";

                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    records.Rows.Add(sqlite_datareader.GetInt32(0).ToString(), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2), sqlite_datareader.GetString(3), sqlite_datareader.GetString(4), sqlite_datareader.GetString(5), sqlite_datareader.GetString(6), sqlite_datareader.GetInt32(7), sqlite_datareader.GetString(8).ToString(), sqlite_datareader.GetInt32(9).ToString(), sqlite_datareader.GetDouble(10).ToString(), sqlite_datareader.GetInt32(11).ToString(), sqlite_datareader.GetDouble(12).ToString(), sqlite_datareader.GetString(13).ToString(), sqlite_datareader.GetString(14), ConvertStringToImage(sqlite_datareader.GetString(15)));
                }
                sqlite_conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, toolName);
            }
        }

        void searchbySerial()
        {
            if (searchbySerialTxt.Text.Length > 0)
            {
                records.Rows.Clear();

                try
                {
                    SQLiteConnection sqlite_conn = CreateConnection();

                    string result = "";
                    SQLiteDataReader sqlite_datareader;
                    SQLiteCommand sqlite_cmd;
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "SELECT * FROM Inspections WHERE serial LIKE '" + searchbySerialTxt.Text + "%';";

                    sqlite_datareader = sqlite_cmd.ExecuteReader();

                    while (sqlite_datareader.Read())
                    {
                        records.Rows.Add(sqlite_datareader.GetInt32(0).ToString(), sqlite_datareader.GetString(1), sqlite_datareader.GetString(2), sqlite_datareader.GetString(3), sqlite_datareader.GetString(4), sqlite_datareader.GetString(5), sqlite_datareader.GetString(6), sqlite_datareader.GetInt32(7), sqlite_datareader.GetString(8).ToString(), sqlite_datareader.GetInt32(9).ToString(), sqlite_datareader.GetDouble(10).ToString(), sqlite_datareader.GetInt32(11).ToString(), sqlite_datareader.GetDouble(12).ToString(), sqlite_datareader.GetString(13).ToString(), sqlite_datareader.GetString(14), ConvertStringToImage(sqlite_datareader.GetString(15)));
                    }
                    sqlite_conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, toolName);
                }
            }
            else
            {
                MessageBox.Show("You need to enter something in the search box.", toolName);
            }
        }

        void clearRecords()
        {
            records.Rows.Clear();
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveInspection();
            createPDFCert();
            newInspection();
        }

        private void importPhotoBtn_Click(object sender, EventArgs e)
        {
            choosePhoto();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            newInspection();
        }

        private void loadAllRecordsBtn_Click(object sender, EventArgs e)
        {
            loadAllRecords();
        }

        private void clearRecordsBtn_Click(object sender, EventArgs e)
        {
            clearRecords();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchbySerial();
        }
    }
}
