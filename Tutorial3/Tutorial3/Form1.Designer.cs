namespace Tutorial3
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
            this.lblStaffNo = new System.Windows.Forms.Label();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.lblJoinFrom = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblStaffType = new System.Windows.Forms.Label();
            this.lblNrc = new System.Windows.Forms.Label();
            this.txtStaffNo = new System.Windows.Forms.TextBox();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtNrcNo = new System.Windows.Forms.TextBox();
            this.lblRqStaffName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneone = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cbStaffType = new System.Windows.Forms.ComboBox();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhonetwo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.btnCFile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.txtJoinFrom = new System.Windows.Forms.DateTimePicker();
            this.txtDob = new System.Windows.Forms.DateTimePicker();
            this.btnAddUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStaffNo
            // 
            this.lblStaffNo.AutoSize = true;
            this.lblStaffNo.Location = new System.Drawing.Point(41, 13);
            this.lblStaffNo.Name = "lblStaffNo";
            this.lblStaffNo.Size = new System.Drawing.Size(49, 13);
            this.lblStaffNo.TabIndex = 0;
            this.lblStaffNo.Text = "Staff No.";
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Location = new System.Drawing.Point(41, 59);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(60, 13);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Staff Name";
            // 
            // lblJoinFrom
            // 
            this.lblJoinFrom.AutoSize = true;
            this.lblJoinFrom.Location = new System.Drawing.Point(41, 104);
            this.lblJoinFrom.Name = "lblJoinFrom";
            this.lblJoinFrom.Size = new System.Drawing.Size(52, 13);
            this.lblJoinFrom.TabIndex = 2;
            this.lblJoinFrom.Text = "Join From";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(41, 154);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(66, 13);
            this.lblDob.TabIndex = 3;
            this.lblDob.Text = "Date of Birth";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(44, 203);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(26, 13);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // lblStaffType
            // 
            this.lblStaffType.AutoSize = true;
            this.lblStaffType.Location = new System.Drawing.Point(44, 259);
            this.lblStaffType.Name = "lblStaffType";
            this.lblStaffType.Size = new System.Drawing.Size(56, 13);
            this.lblStaffType.TabIndex = 5;
            this.lblStaffType.Text = "Staff Type";
            // 
            // lblNrc
            // 
            this.lblNrc.AutoSize = true;
            this.lblNrc.Location = new System.Drawing.Point(44, 315);
            this.lblNrc.Name = "lblNrc";
            this.lblNrc.Size = new System.Drawing.Size(50, 13);
            this.lblNrc.TabIndex = 6;
            this.lblNrc.Text = "NRC No.";
            // 
            // txtStaffNo
            // 
            this.txtStaffNo.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtStaffNo.Location = new System.Drawing.Point(135, 6);
            this.txtStaffNo.Name = "txtStaffNo";
            this.txtStaffNo.ReadOnly = true;
            this.txtStaffNo.Size = new System.Drawing.Size(100, 20);
            this.txtStaffNo.TabIndex = 7;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(135, 52);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(100, 20);
            this.txtStaffName.TabIndex = 8;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtAge.Location = new System.Drawing.Point(135, 195);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 11;
            // 
            // txtNrcNo
            // 
            this.txtNrcNo.Location = new System.Drawing.Point(135, 307);
            this.txtNrcNo.Name = "txtNrcNo";
            this.txtNrcNo.Size = new System.Drawing.Size(100, 20);
            this.txtNrcNo.TabIndex = 13;
            // 
            // lblRqStaffName
            // 
            this.lblRqStaffName.AutoSize = true;
            this.lblRqStaffName.ForeColor = System.Drawing.Color.Maroon;
            this.lblRqStaffName.Location = new System.Drawing.Point(241, 55);
            this.lblRqStaffName.Name = "lblRqStaffName";
            this.lblRqStaffName.Size = new System.Drawing.Size(11, 13);
            this.lblRqStaffName.TabIndex = 14;
            this.lblRqStaffName.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(241, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(241, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(241, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(241, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "*";
            // 
            // txtPhoneone
            // 
            this.txtPhoneone.Location = new System.Drawing.Point(444, 55);
            this.txtPhoneone.Name = "txtPhoneone";
            this.txtPhoneone.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneone.TabIndex = 19;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(364, 10);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 20;
            this.lblGender.Text = "Gender";
            // 
            // cbStaffType
            // 
            this.cbStaffType.FormattingEnabled = true;
            this.cbStaffType.Items.AddRange(new object[] {
            "Full Time",
            "Part Time"});
            this.cbStaffType.Location = new System.Drawing.Point(135, 251);
            this.cbStaffType.Name = "cbStaffType";
            this.cbStaffType.Size = new System.Drawing.Size(100, 21);
            this.cbStaffType.TabIndex = 21;
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Location = new System.Drawing.Point(444, 6);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(51, 17);
            this.rdoOther.TabIndex = 23;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Other";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(501, 6);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(48, 17);
            this.rdoMale.TabIndex = 23;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(555, 6);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(59, 17);
            this.rdoFemale.TabIndex = 23;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(364, 58);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(61, 13);
            this.lblPhoneNo.TabIndex = 24;
            this.lblPhoneNo.Text = " Phone No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(367, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Phone No.";
            // 
            // txtPhonetwo
            // 
            this.txtPhonetwo.Location = new System.Drawing.Point(444, 104);
            this.txtPhonetwo.Name = "txtPhonetwo";
            this.txtPhonetwo.Size = new System.Drawing.Size(100, 20);
            this.txtPhonetwo.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Image";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(444, 154);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(100, 62);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPreview.TabIndex = 27;
            this.pictureBoxPreview.TabStop = false;
            // 
            // btnCFile
            // 
            this.btnCFile.Location = new System.Drawing.Point(550, 154);
            this.btnCFile.Name = "btnCFile";
            this.btnCFile.Size = new System.Drawing.Size(75, 23);
            this.btnCFile.TabIndex = 28;
            this.btnCFile.Text = "Choose File";
            this.btnCFile.UseVisualStyleBackColor = true;
            this.btnCFile.Click += new System.EventHandler(this.btnCFile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Address";
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(444, 248);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(181, 69);
            this.rtxtAddress.TabIndex = 31;
            this.rtxtAddress.Text = "";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(44, 410);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1131, 150);
            this.dataGridView.TabIndex = 32;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // txtJoinFrom
            // 
            this.txtJoinFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtJoinFrom.Location = new System.Drawing.Point(135, 101);
            this.txtJoinFrom.Name = "txtJoinFrom";
            this.txtJoinFrom.Size = new System.Drawing.Size(100, 20);
            this.txtJoinFrom.TabIndex = 33;
            // 
            // txtDob
            // 
            this.txtDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDob.Location = new System.Drawing.Point(135, 153);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(100, 20);
            this.txtDob.TabIndex = 34;
            // 
            // btnAddUpdate
            // 
            this.btnAddUpdate.Location = new System.Drawing.Point(135, 360);
            this.btnAddUpdate.Name = "btnAddUpdate";
            this.btnAddUpdate.Size = new System.Drawing.Size(103, 23);
            this.btnAddUpdate.TabIndex = 35;
            this.btnAddUpdate.Text = "Add / Update";
            this.btnAddUpdate.UseVisualStyleBackColor = true;
            this.btnAddUpdate.Click += new System.EventHandler(this.btnAddUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(280, 360);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 36;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(392, 360);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 37;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(550, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 665);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddUpdate);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtJoinFrom);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.rtxtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCFile);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.cbStaffType);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtPhonetwo);
            this.Controls.Add(this.txtPhoneone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRqStaffName);
            this.Controls.Add(this.txtNrcNo);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtStaffName);
            this.Controls.Add(this.txtStaffNo);
            this.Controls.Add(this.lblNrc);
            this.Controls.Add(this.lblStaffType);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblJoinFrom);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.lblStaffNo);
            this.Name = "Form1";
            this.Text = "Staff Data Entry";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStaffNo;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Label lblJoinFrom;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblStaffType;
        private System.Windows.Forms.Label lblNrc;
        private System.Windows.Forms.TextBox txtStaffNo;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtNrcNo;
        private System.Windows.Forms.Label lblRqStaffName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cbStaffType;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhonetwo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button btnCFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtAddress;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker txtJoinFrom;
        private System.Windows.Forms.DateTimePicker txtDob;
        private System.Windows.Forms.Button btnAddUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label8;
    }
}

