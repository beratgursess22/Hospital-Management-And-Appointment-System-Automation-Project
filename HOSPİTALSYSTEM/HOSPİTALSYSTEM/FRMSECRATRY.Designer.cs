namespace HOSPİTALSYSTEM
{
    partial class FRMSECRATRY
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMSECRATRY));
            this.BTNLOGİN = new System.Windows.Forms.Button();
            this.LNKSİNG = new System.Windows.Forms.LinkLabel();
            this.TXTPASSO = new System.Windows.Forms.TextBox();
            this.MSKTCNO = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNLOGİN
            // 
            this.BTNLOGİN.Location = new System.Drawing.Point(174, 217);
            this.BTNLOGİN.Name = "BTNLOGİN";
            this.BTNLOGİN.Size = new System.Drawing.Size(198, 50);
            this.BTNLOGİN.TabIndex = 13;
            this.BTNLOGİN.Text = "Login";
            this.BTNLOGİN.UseVisualStyleBackColor = true;
            this.BTNLOGİN.Click += new System.EventHandler(this.BTNLOGİN_Click);
            // 
            // LNKSİNG
            // 
            this.LNKSİNG.AutoSize = true;
            this.LNKSİNG.Location = new System.Drawing.Point(244, 282);
            this.LNKSİNG.Name = "LNKSİNG";
            this.LNKSİNG.Size = new System.Drawing.Size(36, 17);
            this.LNKSİNG.TabIndex = 12;
            this.LNKSİNG.TabStop = true;
            this.LNKSİNG.Text = "Sing";
            // 
            // TXTPASSO
            // 
            this.TXTPASSO.Location = new System.Drawing.Point(174, 179);
            this.TXTPASSO.Name = "TXTPASSO";
            this.TXTPASSO.Size = new System.Drawing.Size(198, 22);
            this.TXTPASSO.TabIndex = 11;
            this.TXTPASSO.UseSystemPasswordChar = true;
            // 
            // MSKTCNO
            // 
            this.MSKTCNO.Location = new System.Drawing.Point(174, 128);
            this.MSKTCNO.Mask = "00000000000";
            this.MSKTCNO.Name = "MSKTCNO";
            this.MSKTCNO.Size = new System.Drawing.Size(198, 22);
            this.MSKTCNO.TabIndex = 10;
            this.MSKTCNO.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Passowrod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = " TC No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "SECRATARY SYSTEM";
            // 
            // FRMSECRATRY
            // 
            this.AcceptButton = this.BTNLOGİN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(491, 329);
            this.Controls.Add(this.BTNLOGİN);
            this.Controls.Add(this.LNKSİNG);
            this.Controls.Add(this.TXTPASSO);
            this.Controls.Add(this.MSKTCNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FRMSECRATRY";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secratary System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNLOGİN;
        private System.Windows.Forms.LinkLabel LNKSİNG;
        private System.Windows.Forms.TextBox TXTPASSO;
        private System.Windows.Forms.MaskedTextBox MSKTCNO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}