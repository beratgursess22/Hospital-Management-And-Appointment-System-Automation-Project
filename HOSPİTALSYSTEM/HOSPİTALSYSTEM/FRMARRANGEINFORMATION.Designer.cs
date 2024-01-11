namespace HOSPİTALSYSTEM
{
    partial class FRMARRANGEINFORMATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMARRANGEINFORMATION));
            this.BTNSİNG = new System.Windows.Forms.Button();
            this.CMBGENDER = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TXTSURNAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTNAME = new System.Windows.Forms.TextBox();
            this.MSKTELNO = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXTPASSOR = new System.Windows.Forms.TextBox();
            this.MSKTCNOR = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNSİNG
            // 
            this.BTNSİNG.BackColor = System.Drawing.Color.Honeydew;
            this.BTNSİNG.Location = new System.Drawing.Point(184, 255);
            this.BTNSİNG.Name = "BTNSİNG";
            this.BTNSİNG.Size = new System.Drawing.Size(165, 49);
            this.BTNSİNG.TabIndex = 7;
            this.BTNSİNG.Text = "Update";
            this.BTNSİNG.UseVisualStyleBackColor = false;
            this.BTNSİNG.Click += new System.EventHandler(this.BTNSİNG_Click);
            // 
            // CMBGENDER
            // 
            this.CMBGENDER.FormattingEnabled = true;
            this.CMBGENDER.ItemHeight = 16;
            this.CMBGENDER.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.CMBGENDER.Location = new System.Drawing.Point(169, 215);
            this.CMBGENDER.Name = "CMBGENDER";
            this.CMBGENDER.Size = new System.Drawing.Size(198, 24);
            this.CMBGENDER.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(22, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Gender:";
            // 
            // TXTSURNAME
            // 
            this.TXTSURNAME.Location = new System.Drawing.Point(169, 107);
            this.TXTSURNAME.Name = "TXTSURNAME";
            this.TXTSURNAME.Size = new System.Drawing.Size(198, 22);
            this.TXTSURNAME.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Surname:";
            // 
            // TXTNAME
            // 
            this.TXTNAME.Location = new System.Drawing.Point(169, 77);
            this.TXTNAME.Name = "TXTNAME";
            this.TXTNAME.Size = new System.Drawing.Size(198, 22);
            this.TXTNAME.TabIndex = 1;
            // 
            // MSKTELNO
            // 
            this.MSKTELNO.Location = new System.Drawing.Point(169, 157);
            this.MSKTELNO.Mask = "(999) 000-0000";
            this.MSKTELNO.Name = "MSKTELNO";
            this.MSKTELNO.Size = new System.Drawing.Size(198, 22);
            this.MSKTELNO.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telephone No:";
            // 
            // TXTPASSOR
            // 
            this.TXTPASSOR.Location = new System.Drawing.Point(169, 185);
            this.TXTPASSOR.Name = "TXTPASSOR";
            this.TXTPASSOR.Size = new System.Drawing.Size(198, 22);
            this.TXTPASSOR.TabIndex = 5;
            // 
            // MSKTCNOR
            // 
            this.MSKTCNOR.Location = new System.Drawing.Point(169, 130);
            this.MSKTCNOR.Mask = "00000000000";
            this.MSKTCNOR.Name = "MSKTCNOR";
            this.MSKTCNOR.Size = new System.Drawing.Size(198, 22);
            this.MSKTCNOR.TabIndex = 3;
            this.MSKTCNOR.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(22, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Passoword:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = " TC No:";
            // 
            // FRMARRANGEİNFORMATİON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(469, 342);
            this.Controls.Add(this.BTNSİNG);
            this.Controls.Add(this.CMBGENDER);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TXTSURNAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTNAME);
            this.Controls.Add(this.MSKTELNO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXTPASSOR);
            this.Controls.Add(this.MSKTCNOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRMARRANGEİNFORMATİON";
            this.Text = "Information Arrange";
            this.Load += new System.EventHandler(this.FRMARRANGEİNFORMATİON_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNSİNG;
        private System.Windows.Forms.ComboBox CMBGENDER;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TXTSURNAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTNAME;
        private System.Windows.Forms.MaskedTextBox MSKTELNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TXTPASSOR;
        private System.Windows.Forms.MaskedTextBox MSKTCNOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}