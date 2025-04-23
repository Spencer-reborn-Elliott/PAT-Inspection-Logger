namespace PAT_Inspection_Logger
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveBtn = new Button();
            photoPicBox = new PictureBox();
            importPhotoBtn = new Button();
            openPhotoFile = new OpenFileDialog();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox1 = new GroupBox();
            justSaveChk = new RadioButton();
            nosaveChk = new RadioButton();
            clearBtn = new Button();
            commentsText = new TextBox();
            label14 = new Label();
            passChk = new CheckBox();
            label13 = new Label();
            leakageNum = new NumericUpDown();
            label12 = new Label();
            mohmsNum = new NumericUpDown();
            label10 = new Label();
            earthOhmsNum = new NumericUpDown();
            label9 = new Label();
            fuseNum = new NumericUpDown();
            label8 = new Label();
            visPassChk = new CheckBox();
            label7 = new Label();
            locText = new TextBox();
            label6 = new Label();
            descText = new TextBox();
            label5 = new Label();
            serialText = new TextBox();
            label4 = new Label();
            inspectorText = new TextBox();
            label3 = new Label();
            classNum = new NumericUpDown();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            datePicker = new DateTimePicker();
            label11 = new Label();
            panel1 = new Panel();
            tabPage2 = new TabPage();
            clearRecordsBtn = new Button();
            loadAllRecordsBtn = new Button();
            records = new DataGridView();
            PKID = new DataGridViewTextBoxColumn();
            TestDate = new DataGridViewTextBoxColumn();
            retestDate = new DataGridViewTextBoxColumn();
            Inspector = new DataGridViewTextBoxColumn();
            serial = new DataGridViewTextBoxColumn();
            desc = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            eqClass = new DataGridViewTextBoxColumn();
            visPass = new DataGridViewCheckBoxColumn();
            fuseRating = new DataGridViewTextBoxColumn();
            ohms = new DataGridViewTextBoxColumn();
            mohms = new DataGridViewTextBoxColumn();
            leakage = new DataGridViewTextBoxColumn();
            passed = new DataGridViewCheckBoxColumn();
            comments = new DataGridViewTextBoxColumn();
            image = new DataGridViewImageColumn();
            label15 = new Label();
            searchBtn = new Button();
            searchbySerialTxt = new TextBox();
            label16 = new Label();
            ((System.ComponentModel.ISupportInitialize)photoPicBox).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)leakageNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mohmsNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)earthOhmsNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fuseNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)classNum).BeginInit();
            panel1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)records).BeginInit();
            SuspendLayout();
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(1021, 545);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(112, 44);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Save Inspection";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // photoPicBox
            // 
            photoPicBox.Location = new Point(3, 3);
            photoPicBox.Name = "photoPicBox";
            photoPicBox.Size = new Size(332, 298);
            photoPicBox.SizeMode = PictureBoxSizeMode.StretchImage;
            photoPicBox.TabIndex = 0;
            photoPicBox.TabStop = false;
            // 
            // importPhotoBtn
            // 
            importPhotoBtn.Location = new Point(1030, 316);
            importPhotoBtn.Name = "importPhotoBtn";
            importPhotoBtn.Size = new Size(91, 36);
            importPhotoBtn.TabIndex = 2;
            importPhotoBtn.Text = "Import Photo";
            importPhotoBtn.UseVisualStyleBackColor = true;
            importPhotoBtn.Click += importPhotoBtn_Click;
            // 
            // openPhotoFile
            // 
            openPhotoFile.Filter = "Image files|*.bmp;*.jpg;*.gif;*.png;*.tif|All files|*.*";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1147, 623);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = SystemColors.Control;
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(clearBtn);
            tabPage1.Controls.Add(commentsText);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(passChk);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(leakageNum);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(mohmsNum);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(earthOhmsNum);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(fuseNum);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(visPassChk);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(locText);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(descText);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(serialText);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(inspectorText);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(classNum);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(dateTimePicker2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(datePicker);
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(saveBtn);
            tabPage1.Controls.Add(panel1);
            tabPage1.Controls.Add(importPhotoBtn);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1139, 595);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Create Inspection";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(justSaveChk);
            groupBox1.Controls.Add(nosaveChk);
            groupBox1.Location = new Point(24, 456);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(403, 94);
            groupBox1.TabIndex = 52;
            groupBox1.TabStop = false;
            groupBox1.Text = "PDF Certificate Options";
            // 
            // justSaveChk
            // 
            justSaveChk.AutoSize = true;
            justSaveChk.Checked = true;
            justSaveChk.Location = new Point(15, 56);
            justSaveChk.Name = "justSaveChk";
            justSaveChk.Size = new Size(299, 19);
            justSaveChk.TabIndex = 1;
            justSaveChk.TabStop = true;
            justSaveChk.Text = "Create PDF Certificate and save in \"My Documents\".";
            justSaveChk.UseVisualStyleBackColor = true;
            // 
            // nosaveChk
            // 
            nosaveChk.AutoSize = true;
            nosaveChk.Location = new Point(15, 31);
            nosaveChk.Name = "nosaveChk";
            nosaveChk.Size = new Size(180, 19);
            nosaveChk.TabIndex = 0;
            nosaveChk.Text = "Do not create PDF Certificate.";
            nosaveChk.UseVisualStyleBackColor = true;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(903, 545);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(112, 44);
            clearBtn.TabIndex = 51;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // commentsText
            // 
            commentsText.Location = new Point(112, 412);
            commentsText.Name = "commentsText";
            commentsText.Size = new Size(803, 23);
            commentsText.TabIndex = 50;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(21, 420);
            label14.Name = "label14";
            label14.Size = new Size(69, 15);
            label14.TabIndex = 49;
            label14.Text = "Comments:";
            // 
            // passChk
            // 
            passChk.AutoSize = true;
            passChk.Location = new Point(112, 388);
            passChk.Name = "passChk";
            passChk.Size = new Size(62, 19);
            passChk.TabIndex = 48;
            passChk.Text = "Passed";
            passChk.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(22, 391);
            label13.Name = "label13";
            label13.Size = new Size(42, 15);
            label13.TabIndex = 47;
            label13.Text = "Result:";
            // 
            // leakageNum
            // 
            leakageNum.DecimalPlaces = 2;
            leakageNum.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            leakageNum.Location = new Point(112, 359);
            leakageNum.Name = "leakageNum";
            leakageNum.Size = new Size(67, 23);
            leakageNum.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(22, 367);
            label12.Name = "label12";
            label12.Size = new Size(53, 15);
            label12.TabIndex = 45;
            label12.Text = "Leakage:";
            // 
            // mohmsNum
            // 
            mohmsNum.Location = new Point(112, 330);
            mohmsNum.Name = "mohmsNum";
            mohmsNum.Size = new Size(67, 23);
            mohmsNum.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 323);
            label10.Name = "label10";
            label10.Size = new Size(62, 30);
            label10.TabIndex = 43;
            label10.Text = "Insulation \r\nMohms:";
            // 
            // earthOhmsNum
            // 
            earthOhmsNum.DecimalPlaces = 2;
            earthOhmsNum.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            earthOhmsNum.Location = new Point(112, 292);
            earthOhmsNum.Name = "earthOhmsNum";
            earthOhmsNum.Size = new Size(67, 23);
            earthOhmsNum.TabIndex = 42;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 300);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 41;
            label9.Text = "Earth Ohms:";
            // 
            // fuseNum
            // 
            fuseNum.Location = new Point(112, 257);
            fuseNum.Maximum = new decimal(new int[] { 32, 0, 0, 0 });
            fuseNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            fuseNum.Name = "fuseNum";
            fuseNum.Size = new Size(54, 23);
            fuseNum.TabIndex = 40;
            fuseNum.Value = new decimal(new int[] { 13, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 265);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 39;
            label8.Text = "Fuse Rating:";
            // 
            // visPassChk
            // 
            visPassChk.AutoSize = true;
            visPassChk.Location = new Point(112, 231);
            visPassChk.Name = "visPassChk";
            visPassChk.Size = new Size(83, 19);
            visPassChk.TabIndex = 38;
            visPassChk.Text = "Confirmed";
            visPassChk.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 234);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 37;
            label7.Text = "Visual Pass:";
            // 
            // locText
            // 
            locText.Location = new Point(112, 168);
            locText.Name = "locText";
            locText.Size = new Size(644, 23);
            locText.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 176);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 35;
            label6.Text = "Location:";
            // 
            // descText
            // 
            descText.Location = new Point(112, 139);
            descText.Name = "descText";
            descText.Size = new Size(644, 23);
            descText.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 147);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 33;
            label5.Text = "Description:";
            // 
            // serialText
            // 
            serialText.Location = new Point(112, 110);
            serialText.Name = "serialText";
            serialText.Size = new Size(287, 23);
            serialText.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 118);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 31;
            label4.Text = "Serial Number:";
            // 
            // inspectorText
            // 
            inspectorText.Location = new Point(112, 78);
            inspectorText.Name = "inspectorText";
            inspectorText.Size = new Size(287, 23);
            inspectorText.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 86);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 29;
            label3.Text = "Inspected By:";
            // 
            // classNum
            // 
            classNum.Location = new Point(112, 197);
            classNum.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            classNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            classNum.Name = "classNum";
            classNum.Size = new Size(54, 23);
            classNum.TabIndex = 28;
            classNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 205);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 27;
            label2.Text = "Class:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(112, 49);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(204, 23);
            dateTimePicker2.TabIndex = 26;
            dateTimePicker2.Value = new DateTime(2025, 4, 21, 20, 39, 58, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 55);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 25;
            label1.Text = "Retest Date:";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(112, 18);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(204, 23);
            datePicker.TabIndex = 24;
            datePicker.Value = new DateTime(2025, 4, 21, 20, 39, 58, 0);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 26);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 23;
            label11.Text = "Test Date:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(photoPicBox);
            panel1.Location = new Point(786, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 304);
            panel1.TabIndex = 1;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = SystemColors.Control;
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(searchbySerialTxt);
            tabPage2.Controls.Add(searchBtn);
            tabPage2.Controls.Add(clearRecordsBtn);
            tabPage2.Controls.Add(loadAllRecordsBtn);
            tabPage2.Controls.Add(records);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1139, 595);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Database/History";
            // 
            // clearRecordsBtn
            // 
            clearRecordsBtn.Location = new Point(1013, 543);
            clearRecordsBtn.Name = "clearRecordsBtn";
            clearRecordsBtn.Size = new Size(110, 41);
            clearRecordsBtn.TabIndex = 2;
            clearRecordsBtn.Text = "Clear";
            clearRecordsBtn.UseVisualStyleBackColor = true;
            clearRecordsBtn.Click += clearRecordsBtn_Click;
            // 
            // loadAllRecordsBtn
            // 
            loadAllRecordsBtn.Location = new Point(1013, 6);
            loadAllRecordsBtn.Name = "loadAllRecordsBtn";
            loadAllRecordsBtn.Size = new Size(110, 41);
            loadAllRecordsBtn.TabIndex = 1;
            loadAllRecordsBtn.Text = "Load All Historic Records";
            loadAllRecordsBtn.UseVisualStyleBackColor = true;
            loadAllRecordsBtn.Click += loadAllRecordsBtn_Click;
            // 
            // records
            // 
            records.AllowUserToAddRows = false;
            records.AllowUserToDeleteRows = false;
            records.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            records.Columns.AddRange(new DataGridViewColumn[] { PKID, TestDate, retestDate, Inspector, serial, desc, Location, eqClass, visPass, fuseRating, ohms, mohms, leakage, passed, comments, image });
            records.Location = new Point(17, 88);
            records.Name = "records";
            records.ReadOnly = true;
            records.Size = new Size(1106, 449);
            records.TabIndex = 0;
            // 
            // PKID
            // 
            PKID.HeaderText = "PK ID";
            PKID.Name = "PKID";
            PKID.ReadOnly = true;
            PKID.Width = 70;
            // 
            // TestDate
            // 
            TestDate.HeaderText = "Test Date";
            TestDate.Name = "TestDate";
            TestDate.ReadOnly = true;
            TestDate.Width = 150;
            // 
            // retestDate
            // 
            retestDate.HeaderText = "Retest Date";
            retestDate.Name = "retestDate";
            retestDate.ReadOnly = true;
            retestDate.Width = 150;
            // 
            // Inspector
            // 
            Inspector.HeaderText = "Inspector";
            Inspector.Name = "Inspector";
            Inspector.ReadOnly = true;
            Inspector.Width = 150;
            // 
            // serial
            // 
            serial.HeaderText = "Serial";
            serial.Name = "serial";
            serial.ReadOnly = true;
            serial.Width = 120;
            // 
            // desc
            // 
            desc.HeaderText = "Description";
            desc.Name = "desc";
            desc.ReadOnly = true;
            desc.Width = 200;
            // 
            // Location
            // 
            Location.HeaderText = "Location";
            Location.Name = "Location";
            Location.ReadOnly = true;
            Location.Width = 500;
            // 
            // eqClass
            // 
            eqClass.HeaderText = "Class";
            eqClass.Name = "eqClass";
            eqClass.ReadOnly = true;
            eqClass.Width = 70;
            // 
            // visPass
            // 
            visPass.HeaderText = "Visual Pass";
            visPass.Name = "visPass";
            visPass.ReadOnly = true;
            // 
            // fuseRating
            // 
            fuseRating.HeaderText = "Fuse Rating";
            fuseRating.Name = "fuseRating";
            fuseRating.ReadOnly = true;
            // 
            // ohms
            // 
            ohms.HeaderText = "Ohms";
            ohms.Name = "ohms";
            ohms.ReadOnly = true;
            ohms.Width = 70;
            // 
            // mohms
            // 
            mohms.HeaderText = "Mohms";
            mohms.Name = "mohms";
            mohms.ReadOnly = true;
            mohms.Width = 70;
            // 
            // leakage
            // 
            leakage.HeaderText = "Leakage";
            leakage.Name = "leakage";
            leakage.ReadOnly = true;
            leakage.Width = 70;
            // 
            // passed
            // 
            passed.HeaderText = "Passed";
            passed.Name = "passed";
            passed.ReadOnly = true;
            // 
            // comments
            // 
            comments.HeaderText = "Comments";
            comments.Name = "comments";
            comments.ReadOnly = true;
            comments.Width = 500;
            // 
            // image
            // 
            image.HeaderText = "Image";
            image.Name = "image";
            image.ReadOnly = true;
            image.SortMode = DataGridViewColumnSortMode.Automatic;
            image.Width = 275;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(16, 650);
            label15.Name = "label15";
            label15.Size = new Size(109, 15);
            label15.TabIndex = 5;
            label15.Text = "Spencer Elliott 2025";
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(303, 38);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(75, 23);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            searchBtn.Click += searchBtn_Click;
            // 
            // searchbySerialTxt
            // 
            searchbySerialTxt.Location = new Point(17, 38);
            searchbySerialTxt.Name = "searchbySerialTxt";
            searchbySerialTxt.Size = new Size(280, 23);
            searchbySerialTxt.TabIndex = 4;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 19);
            label16.Name = "label16";
            label16.Size = new Size(137, 15);
            label16.TabIndex = 5;
            label16.Text = "Search Records by Serial:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 674);
            Controls.Add(label15);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "PAT Inspection Logger v1.0";
            ((System.ComponentModel.ISupportInitialize)photoPicBox).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)leakageNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)mohmsNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)earthOhmsNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)fuseNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)classNum).EndInit();
            panel1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)records).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveBtn;
        private PictureBox photoPicBox;
        private Button importPhotoBtn;
        private OpenFileDialog openPhotoFile;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker datePicker;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private NumericUpDown classNum;
        private Label label2;
        private TextBox locText;
        private Label label6;
        private TextBox descText;
        private Label label5;
        private TextBox serialText;
        private Label label4;
        private TextBox inspectorText;
        private Label label3;
        private CheckBox visPassChk;
        private Label label7;
        private NumericUpDown fuseNum;
        private Label label8;
        private Label label9;
        private CheckBox passChk;
        private Label label13;
        private NumericUpDown leakageNum;
        private Label label12;
        private NumericUpDown mohmsNum;
        private Label label10;
        private NumericUpDown earthOhmsNum;
        private TextBox commentsText;
        private Label label14;
        private Panel panel1;
        private Button clearBtn;
        private Label label15;
        private GroupBox groupBox1;
        private RadioButton justSaveChk;
        private RadioButton nosaveChk;
        private DataGridView records;
        private Button loadAllRecordsBtn;
        private Button clearRecordsBtn;
        private DataGridViewTextBoxColumn PKID;
        private DataGridViewTextBoxColumn TestDate;
        private DataGridViewTextBoxColumn retestDate;
        private DataGridViewTextBoxColumn Inspector;
        private DataGridViewTextBoxColumn serial;
        private DataGridViewTextBoxColumn desc;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn eqClass;
        private DataGridViewCheckBoxColumn visPass;
        private DataGridViewTextBoxColumn fuseRating;
        private DataGridViewTextBoxColumn ohms;
        private DataGridViewTextBoxColumn mohms;
        private DataGridViewTextBoxColumn leakage;
        private DataGridViewCheckBoxColumn passed;
        private DataGridViewTextBoxColumn comments;
        private DataGridViewImageColumn image;
        private Label label16;
        private TextBox searchbySerialTxt;
        private Button searchBtn;
    }
}
