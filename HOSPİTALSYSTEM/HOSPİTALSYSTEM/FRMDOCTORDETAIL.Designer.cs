namespace HOSPİTALSYSTEM
{
    partial class FRMDOCTORDETAIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDOCTORDETAIL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLNAMESURNAME = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBLTC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RTBAPDETAİL = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BTNEXİTS = new System.Windows.Forms.Button();
            this.BTNMEMORANDUMS = new System.Windows.Forms.Button();
            this.BTNARİNFORMATİON = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBLNAMESURNAME);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.LBLTC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doctor İnformation";
            // 
            // LBLNAMESURNAME
            // 
            this.LBLNAMESURNAME.AutoSize = true;
            this.LBLNAMESURNAME.Location = new System.Drawing.Point(160, 89);
            this.LBLNAMESURNAME.Name = "LBLNAMESURNAME";
            this.LBLNAMESURNAME.Size = new System.Drawing.Size(84, 17);
            this.LBLNAMESURNAME.TabIndex = 3;
            this.LBLNAMESURNAME.Text = "NULL NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name Surname:";
            // 
            // LBLTC
            // 
            this.LBLTC.AutoSize = true;
            this.LBLTC.Location = new System.Drawing.Point(160, 49);
            this.LBLTC.Name = "LBLTC";
            this.LBLTC.Size = new System.Drawing.Size(104, 17);
            this.LBLTC.TabIndex = 1;
            this.LBLTC.Text = "000000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RTBAPDETAİL);
            this.groupBox2.Location = new System.Drawing.Point(0, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 209);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Detail";
            // 
            // RTBAPDETAİL
            // 
            this.RTBAPDETAİL.Location = new System.Drawing.Point(3, 18);
            this.RTBAPDETAİL.Name = "RTBAPDETAİL";
            this.RTBAPDETAİL.Size = new System.Drawing.Size(285, 185);
            this.RTBAPDETAİL.TabIndex = 0;
            this.RTBAPDETAİL.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(300, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(524, 496);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Appointment List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(518, 475);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BTNEXİTS);
            this.groupBox4.Controls.Add(this.BTNMEMORANDUMS);
            this.groupBox4.Controls.Add(this.BTNARİNFORMATİON);
            this.groupBox4.Location = new System.Drawing.Point(3, 356);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 137);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fast Access";
            // 
            // BTNEXİTS
            // 
            this.BTNEXİTS.Location = new System.Drawing.Point(0, 75);
            this.BTNEXİTS.Name = "BTNEXİTS";
            this.BTNEXİTS.Size = new System.Drawing.Size(294, 48);
            this.BTNEXİTS.TabIndex = 3;
            this.BTNEXİTS.Text = "Exits";
            this.BTNEXİTS.UseVisualStyleBackColor = true;
            this.BTNEXİTS.Click += new System.EventHandler(this.BTNEXİTS_Click);
            // 
            // BTNMEMORANDUMS
            // 
            this.BTNMEMORANDUMS.Location = new System.Drawing.Point(146, 21);
            this.BTNMEMORANDUMS.Name = "BTNMEMORANDUMS";
            this.BTNMEMORANDUMS.Size = new System.Drawing.Size(148, 48);
            this.BTNMEMORANDUMS.TabIndex = 1;
            this.BTNMEMORANDUMS.Text = "Announcement";
            this.BTNMEMORANDUMS.UseVisualStyleBackColor = true;
            this.BTNMEMORANDUMS.Click += new System.EventHandler(this.BTNMEMORANDUMS_Click);
            // 
            // BTNARİNFORMATİON
            // 
            this.BTNARİNFORMATİON.Location = new System.Drawing.Point(3, 21);
            this.BTNARİNFORMATİON.Name = "BTNARİNFORMATİON";
            this.BTNARİNFORMATİON.Size = new System.Drawing.Size(148, 48);
            this.BTNARİNFORMATİON.TabIndex = 0;
            this.BTNARİNFORMATİON.Text = "Arrange Information";
            this.BTNARİNFORMATİON.UseVisualStyleBackColor = true;
            this.BTNARİNFORMATİON.Click += new System.EventHandler(this.BTNARİNFORMATİON_Click);
            // 
            // FRMDOCTORDETAİL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(813, 493);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRMDOCTORDETAİL";
            this.Text = "Doctor Details";
            this.Load += new System.EventHandler(this.FRMDOCTORDETAİL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLNAMESURNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBLTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RTBAPDETAİL;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BTNEXİTS;
        private System.Windows.Forms.Button BTNMEMORANDUMS;
        private System.Windows.Forms.Button BTNARİNFORMATİON;
    }
}