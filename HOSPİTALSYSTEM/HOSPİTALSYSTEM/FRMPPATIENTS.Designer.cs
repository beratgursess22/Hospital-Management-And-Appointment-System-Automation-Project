namespace HOSPİTALSYSTEM
{
    partial class FRMPPATIENTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPPATIENTS));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MSKTCNO = new System.Windows.Forms.MaskedTextBox();
            this.TXTPASSO = new System.Windows.Forms.TextBox();
            this.LNKSİNG = new System.Windows.Forms.LinkLabel();
            this.BTNLOGİN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(126, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = " TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Passoword:";
            // 
            // MSKTCNO
            // 
            this.MSKTCNO.Location = new System.Drawing.Point(217, 124);
            this.MSKTCNO.Mask = "00000000000";
            this.MSKTCNO.Name = "MSKTCNO";
            this.MSKTCNO.Size = new System.Drawing.Size(198, 36);
            this.MSKTCNO.TabIndex = 3;
            this.MSKTCNO.ValidatingType = typeof(int);
            // 
            // TXTPASSO
            // 
            this.TXTPASSO.Location = new System.Drawing.Point(217, 198);
            this.TXTPASSO.Name = "TXTPASSO";
            this.TXTPASSO.Size = new System.Drawing.Size(198, 36);
            this.TXTPASSO.TabIndex = 4;
            this.TXTPASSO.UseSystemPasswordChar = true;
            // 
            // LNKSİNG
            // 
            this.LNKSİNG.AutoSize = true;
            this.LNKSİNG.Location = new System.Drawing.Point(273, 314);
            this.LNKSİNG.Name = "LNKSİNG";
            this.LNKSİNG.Size = new System.Drawing.Size(59, 29);
            this.LNKSİNG.TabIndex = 5;
            this.LNKSİNG.TabStop = true;
            this.LNKSİNG.Text = "Sing";
            this.LNKSİNG.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNKSİNG_LinkClicked);
            // 
            // BTNLOGİN
            // 
            this.BTNLOGİN.Location = new System.Drawing.Point(217, 249);
            this.BTNLOGİN.Name = "BTNLOGİN";
            this.BTNLOGİN.Size = new System.Drawing.Size(198, 50);
            this.BTNLOGİN.TabIndex = 6;
            this.BTNLOGİN.Text = "Login";
            this.BTNLOGİN.UseVisualStyleBackColor = true;
            this.BTNLOGİN.Click += new System.EventHandler(this.BTNLOGİN_Click);
            // 
            // FRMPPATIENTS
            // 
            this.AcceptButton = this.BTNLOGİN;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(562, 371);
            this.Controls.Add(this.BTNLOGİN);
            this.Controls.Add(this.LNKSİNG);
            this.Controls.Add(this.TXTPASSO);
            this.Controls.Add(this.MSKTCNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FRMPPATIENTS";
            this.Text = "Patient System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MSKTCNO;
        private System.Windows.Forms.TextBox TXTPASSO;
        private System.Windows.Forms.LinkLabel LNKSİNG;
        private System.Windows.Forms.Button BTNLOGİN;
    }
}