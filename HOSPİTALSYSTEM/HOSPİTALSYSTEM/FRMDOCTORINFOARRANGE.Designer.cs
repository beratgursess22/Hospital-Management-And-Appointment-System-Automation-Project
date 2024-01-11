namespace HOSPİTALSYSTEM
{
    partial class FRMDOCTORINFOARRANGE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDOCTORINFOARRANGE));
            this.TXTSURNAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MSKTCNOR = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTPASSOR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CMBDEPARTMENT = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTNSİNG = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTSURNAME
            // 
            this.TXTSURNAME.Location = new System.Drawing.Point(211, 89);
            this.TXTSURNAME.Name = "TXTSURNAME";
            this.TXTSURNAME.Size = new System.Drawing.Size(198, 22);
            this.TXTSURNAME.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(64, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 19;
            this.label5.Text = "Surname:";
            // 
            // TXTNAME
            // 
            this.TXTNAME.Location = new System.Drawing.Point(211, 59);
            this.TXTNAME.Name = "TXTNAME";
            this.TXTNAME.Size = new System.Drawing.Size(198, 22);
            this.TXTNAME.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name:";
            // 
            // MSKTCNOR
            // 
            this.MSKTCNOR.Location = new System.Drawing.Point(211, 112);
            this.MSKTCNOR.Mask = "00000000000";
            this.MSKTCNOR.Name = "MSKTCNOR";
            this.MSKTCNOR.Size = new System.Drawing.Size(198, 22);
            this.MSKTCNOR.TabIndex = 16;
            this.MSKTCNOR.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(64, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = " TC No:";
            // 
            // TXTPASSOR
            // 
            this.TXTPASSOR.Location = new System.Drawing.Point(211, 169);
            this.TXTPASSOR.Name = "TXTPASSOR";
            this.TXTPASSOR.Size = new System.Drawing.Size(198, 22);
            this.TXTPASSOR.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(64, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Passoword:";
            // 
            // CMBDEPARTMENT
            // 
            this.CMBDEPARTMENT.FormattingEnabled = true;
            this.CMBDEPARTMENT.Location = new System.Drawing.Point(211, 139);
            this.CMBDEPARTMENT.Name = "CMBDEPARTMENT";
            this.CMBDEPARTMENT.Size = new System.Drawing.Size(198, 24);
            this.CMBDEPARTMENT.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(67, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Department:";
            // 
            // BTNSİNG
            // 
            this.BTNSİNG.BackColor = System.Drawing.Color.Honeydew;
            this.BTNSİNG.Location = new System.Drawing.Point(225, 197);
            this.BTNSİNG.Name = "BTNSİNG";
            this.BTNSİNG.Size = new System.Drawing.Size(165, 49);
            this.BTNSİNG.TabIndex = 31;
            this.BTNSİNG.Text = "Update";
            this.BTNSİNG.UseVisualStyleBackColor = false;
            this.BTNSİNG.Click += new System.EventHandler(this.BTNSİNG_Click);
            // 
            // FRMDOCTORİNFOARRANGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(505, 267);
            this.Controls.Add(this.BTNSİNG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CMBDEPARTMENT);
            this.Controls.Add(this.TXTPASSOR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TXTSURNAME);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TXTNAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MSKTCNOR);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FRMDOCTORİNFOARRANGE";
            this.Text = "Doctor Infromation Arrange";
            this.Load += new System.EventHandler(this.FRMDOCTORİNFOARRANGE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTSURNAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MSKTCNOR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTPASSOR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CMBDEPARTMENT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BTNSİNG;
    }
}