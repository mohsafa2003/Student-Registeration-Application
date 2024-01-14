namespace StudentRegistrationApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResidenceInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.Label();
            this.ResidenceText = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ClassText = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthText = new System.Windows.Forms.Label();
            this.StudentTable = new System.Windows.Forms.DataGridView();
            this.MajorText = new System.Windows.Forms.Label();
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.MajorCombo = new System.Windows.Forms.ComboBox();
            this.phoneNumInput = new System.Windows.Forms.MaskedTextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.GenderCombo = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.GenderCombo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LoadBtn);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.phoneNumInput);
            this.groupBox1.Controls.Add(this.MajorCombo);
            this.groupBox1.Controls.Add(this.ClassCombo);
            this.groupBox1.Controls.Add(this.MajorText);
            this.groupBox1.Controls.Add(this.DateOfBirthText);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.ClassText);
            this.groupBox1.Controls.Add(this.ResidenceInput);
            this.groupBox1.Controls.Add(this.NameInput);
            this.groupBox1.Controls.Add(this.PhoneText);
            this.groupBox1.Controls.Add(this.ResidenceText);
            this.groupBox1.Controls.Add(this.NameText);
            this.groupBox1.Location = new System.Drawing.Point(13, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // ResidenceInput
            // 
            this.ResidenceInput.Location = new System.Drawing.Point(7, 129);
            this.ResidenceInput.Name = "ResidenceInput";
            this.ResidenceInput.Size = new System.Drawing.Size(221, 22);
            this.ResidenceInput.TabIndex = 4;
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(7, 41);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(221, 22);
            this.NameInput.TabIndex = 3;
            // 
            // PhoneText
            // 
            this.PhoneText.AutoSize = true;
            this.PhoneText.Location = new System.Drawing.Point(4, 154);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(97, 16);
            this.PhoneText.TabIndex = 2;
            this.PhoneText.Text = "Phone Number";
            // 
            // ResidenceText
            // 
            this.ResidenceText.AutoSize = true;
            this.ResidenceText.Location = new System.Drawing.Point(4, 110);
            this.ResidenceText.Name = "ResidenceText";
            this.ResidenceText.Size = new System.Drawing.Size(73, 16);
            this.ResidenceText.TabIndex = 1;
            this.ResidenceText.Text = "Residence";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Location = new System.Drawing.Point(4, 22);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(44, 16);
            this.NameText.TabIndex = 0;
            this.NameText.Text = "Name";
            this.NameText.Click += new System.EventHandler(this.NameText_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.StudentTable);
            this.groupBox2.Location = new System.Drawing.Point(259, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1053, 559);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students table";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(13, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1299, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Display";
            // 
            // ClassText
            // 
            this.ClassText.AutoSize = true;
            this.ClassText.Location = new System.Drawing.Point(4, 242);
            this.ClassText.Name = "ClassText";
            this.ClassText.Size = new System.Drawing.Size(41, 16);
            this.ClassText.TabIndex = 6;
            this.ClassText.Text = "Class";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(7, 217);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(218, 22);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.Value = new System.DateTime(2024, 1, 14, 14, 45, 38, 0);
            // 
            // DateOfBirthText
            // 
            this.DateOfBirthText.AutoSize = true;
            this.DateOfBirthText.Location = new System.Drawing.Point(4, 198);
            this.DateOfBirthText.Name = "DateOfBirthText";
            this.DateOfBirthText.Size = new System.Drawing.Size(81, 16);
            this.DateOfBirthText.TabIndex = 9;
            this.DateOfBirthText.Text = "Date Of Birth";
            // 
            // StudentTable
            // 
            this.StudentTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.StudentTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.StudentName,
            this.Gender,
            this.PhoneNum,
            this.DOB,
            this.Class,
            this.Major});
            this.StudentTable.Location = new System.Drawing.Point(7, 22);
            this.StudentTable.Name = "StudentTable";
            this.StudentTable.ReadOnly = true;
            this.StudentTable.RowHeadersWidth = 51;
            this.StudentTable.RowTemplate.Height = 24;
            this.StudentTable.Size = new System.Drawing.Size(1040, 526);
            this.StudentTable.TabIndex = 0;
            // 
            // MajorText
            // 
            this.MajorText.AutoSize = true;
            this.MajorText.Location = new System.Drawing.Point(4, 288);
            this.MajorText.Name = "MajorText";
            this.MajorText.Size = new System.Drawing.Size(41, 16);
            this.MajorText.TabIndex = 10;
            this.MajorText.Text = "Major";
            // 
            // ClassCombo
            // 
            this.ClassCombo.DisplayMember = "0";
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Items.AddRange(new object[] {
            "BT1",
            "BT2",
            "BT3"});
            this.ClassCombo.Location = new System.Drawing.Point(7, 261);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(221, 24);
            this.ClassCombo.TabIndex = 0;
            this.ClassCombo.Text = "BT1";
            this.ClassCombo.ValueMember = "0";
            // 
            // MajorCombo
            // 
            this.MajorCombo.FormattingEnabled = true;
            this.MajorCombo.Items.AddRange(new object[] {
            "Accounting",
            "Graphic Design",
            "Information Technology",
            "Nurse",
            "Kindergarten"});
            this.MajorCombo.Location = new System.Drawing.Point(6, 307);
            this.MajorCombo.Name = "MajorCombo";
            this.MajorCombo.Size = new System.Drawing.Size(222, 24);
            this.MajorCombo.TabIndex = 1;
            this.MajorCombo.Text = "Accounting";
            // 
            // phoneNumInput
            // 
            this.phoneNumInput.Location = new System.Drawing.Point(56, 170);
            this.phoneNumInput.Mask = "00/000/000";
            this.phoneNumInput.Name = "phoneNumInput";
            this.phoneNumInput.Size = new System.Drawing.Size(172, 22);
            this.phoneNumInput.SkipLiterals = false;
            this.phoneNumInput.TabIndex = 13;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(6, 359);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 14;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(153, 359);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 15;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Gender";
            // 
            // Student_ID
            // 
            this.Student_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Student_ID.HeaderText = "Student_ID";
            this.Student_ID.MinimumWidth = 6;
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            this.Student_ID.Width = 125;
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "Name";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.HeaderText = "Gender";
            this.Gender.MinimumWidth = 6;
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // PhoneNum
            // 
            this.PhoneNum.HeaderText = "Phone Number";
            this.PhoneNum.MinimumWidth = 6;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.ReadOnly = true;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date of birth";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.HeaderText = "Class";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // Major
            // 
            this.Major.HeaderText = "Major";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "(+961)";
            // 
            // GenderCombo
            // 
            this.GenderCombo.FormattingEnabled = true;
            this.GenderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCombo.Location = new System.Drawing.Point(6, 85);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.Size = new System.Drawing.Size(222, 24);
            this.GenderCombo.TabIndex = 19;
            this.GenderCombo.Text = "Male";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1340, 654);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registeration App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StudentTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox ResidenceInput;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Label PhoneText;
        private System.Windows.Forms.Label ResidenceText;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label DateOfBirthText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label ClassText;
        private System.Windows.Forms.Label MajorText;
        private System.Windows.Forms.DataGridView StudentTable;
        private System.Windows.Forms.ComboBox MajorCombo;
        private System.Windows.Forms.ComboBox ClassCombo;
        private System.Windows.Forms.MaskedTextBox phoneNumInput;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GenderCombo;
    }
}

