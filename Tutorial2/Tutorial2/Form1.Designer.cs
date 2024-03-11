namespace Tutorial2
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
            this.lbl_lamount = new System.Windows.Forms.Label();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lbl_intrate = new System.Windows.Forms.Label();
            this.lbl_lduration = new System.Windows.Forms.Label();
            this.lbl_intamount = new System.Windows.Forms.Label();
            this.lbl_totalamount = new System.Windows.Forms.Label();
            this.lbl_resultinterest = new System.Windows.Forms.Label();
            this.lbl_resulttotal = new System.Windows.Forms.Label();
            this.tbox_lamount = new System.Windows.Forms.TextBox();
            this.tbox_intrate = new System.Windows.Forms.TextBox();
            this.tbox_lduration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_lamount
            // 
            this.lbl_lamount.AutoSize = true;
            this.lbl_lamount.Location = new System.Drawing.Point(272, 84);
            this.lbl_lamount.Name = "lbl_lamount";
            this.lbl_lamount.Size = new System.Drawing.Size(70, 13);
            this.lbl_lamount.TabIndex = 0;
            this.lbl_lamount.Text = "Loan Amount";
            this.lbl_lamount.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_calculate
            // 
            this.btn_calculate.Location = new System.Drawing.Point(368, 222);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_calculate.TabIndex = 1;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lbl_intrate
            // 
            this.lbl_intrate.AutoSize = true;
            this.lbl_intrate.Location = new System.Drawing.Point(272, 131);
            this.lbl_intrate.Name = "lbl_intrate";
            this.lbl_intrate.Size = new System.Drawing.Size(85, 13);
            this.lbl_intrate.TabIndex = 2;
            this.lbl_intrate.Text = "Interest Rate (%)";
            // 
            // lbl_lduration
            // 
            this.lbl_lduration.AutoSize = true;
            this.lbl_lduration.Location = new System.Drawing.Point(272, 177);
            this.lbl_lduration.Name = "lbl_lduration";
            this.lbl_lduration.Size = new System.Drawing.Size(112, 13);
            this.lbl_lduration.TabIndex = 3;
            this.lbl_lduration.Text = "Loan Duration (month)";
            // 
            // lbl_intamount
            // 
            this.lbl_intamount.AutoSize = true;
            this.lbl_intamount.Location = new System.Drawing.Point(276, 274);
            this.lbl_intamount.Name = "lbl_intamount";
            this.lbl_intamount.Size = new System.Drawing.Size(81, 13);
            this.lbl_intamount.TabIndex = 4;
            this.lbl_intamount.Text = "Interest Amount";
            // 
            // lbl_totalamount
            // 
            this.lbl_totalamount.AutoSize = true;
            this.lbl_totalamount.Location = new System.Drawing.Point(276, 309);
            this.lbl_totalamount.Name = "lbl_totalamount";
            this.lbl_totalamount.Size = new System.Drawing.Size(70, 13);
            this.lbl_totalamount.TabIndex = 5;
            this.lbl_totalamount.Text = "Total Amount";
            // 
            // lbl_resultinterest
            // 
            this.lbl_resultinterest.AutoSize = true;
            this.lbl_resultinterest.Location = new System.Drawing.Point(423, 274);
            this.lbl_resultinterest.Name = "lbl_resultinterest";
            this.lbl_resultinterest.Size = new System.Drawing.Size(0, 13);
            this.lbl_resultinterest.TabIndex = 6;
            // 
            // lbl_resulttotal
            // 
            this.lbl_resulttotal.AutoSize = true;
            this.lbl_resulttotal.Location = new System.Drawing.Point(423, 309);
            this.lbl_resulttotal.Name = "lbl_resulttotal";
            this.lbl_resulttotal.Size = new System.Drawing.Size(0, 13);
            this.lbl_resulttotal.TabIndex = 7;
            // 
            // tbox_lamount
            // 
            this.tbox_lamount.Location = new System.Drawing.Point(426, 81);
            this.tbox_lamount.Name = "tbox_lamount";
            this.tbox_lamount.Size = new System.Drawing.Size(100, 20);
            this.tbox_lamount.TabIndex = 8;
            // 
            // tbox_intrate
            // 
            this.tbox_intrate.Location = new System.Drawing.Point(426, 128);
            this.tbox_intrate.Name = "tbox_intrate";
            this.tbox_intrate.Size = new System.Drawing.Size(100, 20);
            this.tbox_intrate.TabIndex = 9;
            // 
            // tbox_lduration
            // 
            this.tbox_lduration.Location = new System.Drawing.Point(426, 174);
            this.tbox_lduration.Name = "tbox_lduration";
            this.tbox_lduration.Size = new System.Drawing.Size(100, 20);
            this.tbox_lduration.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbox_lduration);
            this.Controls.Add(this.tbox_intrate);
            this.Controls.Add(this.tbox_lamount);
            this.Controls.Add(this.lbl_resulttotal);
            this.Controls.Add(this.lbl_resultinterest);
            this.Controls.Add(this.lbl_totalamount);
            this.Controls.Add(this.lbl_intamount);
            this.Controls.Add(this.lbl_lduration);
            this.Controls.Add(this.lbl_intrate);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.lbl_lamount);
            this.Name = "Form1";
            this.Text = "Calculate Interest Gains";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_lamount;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_intrate;
        private System.Windows.Forms.Label lbl_lduration;
        private System.Windows.Forms.Label lbl_intamount;
        private System.Windows.Forms.Label lbl_totalamount;
        private System.Windows.Forms.Label lbl_resultinterest;
        private System.Windows.Forms.Label lbl_resulttotal;
        private System.Windows.Forms.TextBox tbox_lamount;
        private System.Windows.Forms.TextBox tbox_intrate;
        private System.Windows.Forms.TextBox tbox_lduration;
    }
}

