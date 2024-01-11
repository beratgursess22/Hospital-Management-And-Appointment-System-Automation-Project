namespace HOSPİTALSYSTEM
{
    partial class FRMPATIENTDETAIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMPATIENTDETAIL));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBLNAMESURNAME = new System.Windows.Forms.Label();
            this.LBLTC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LNKARRANGEİNFORMATİON = new System.Windows.Forms.LinkLabel();
            this.BTNSİNGUP = new System.Windows.Forms.Button();
            this.RTBCOMPLAİNT = new System.Windows.Forms.RichTextBox();
            this.CMBDOCTOR = new System.Windows.Forms.ComboBox();
            this.CMBDEPARTMENT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBLNAMESURNAME);
            this.groupBox1.Controls.Add(this.LBLTC);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // LBLNAMESURNAME
            // 
            this.LBLNAMESURNAME.AutoSize = true;
            this.LBLNAMESURNAME.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLNAMESURNAME.Location = new System.Drawing.Point(162, 106);
            this.LBLNAMESURNAME.Name = "LBLNAMESURNAME";
            this.LBLNAMESURNAME.Size = new System.Drawing.Size(108, 24);
            this.LBLNAMESURNAME.TabIndex = 3;
            this.LBLNAMESURNAME.Text = "NULL NULL";
            // 
            // LBLTC
            // 
            this.LBLTC.AutoSize = true;
            this.LBLTC.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLTC.Location = new System.Drawing.Point(107, 52);
            this.LBLTC.Name = "LBLTC";
            this.LBLTC.Size = new System.Drawing.Size(120, 24);
            this.LBLTC.TabIndex = 2;
            this.LBLTC.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name  Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC No:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXTID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LNKARRANGEİNFORMATİON);
            this.groupBox2.Controls.Add(this.BTNSİNGUP);
            this.groupBox2.Controls.Add(this.RTBCOMPLAİNT);
            this.groupBox2.Controls.Add(this.CMBDOCTOR);
            this.groupBox2.Controls.Add(this.CMBDEPARTMENT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 316);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Appointment Registration";
            // 
            // TXTID
            // 
            this.TXTID.Enabled = false;
            this.TXTID.Location = new System.Drawing.Point(185, 60);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(149, 36);
            this.TXTID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "ID:";
            // 
            // LNKARRANGEİNFORMATİON
            // 
            this.LNKARRANGEİNFORMATİON.AutoSize = true;
            this.LNKARRANGEİNFORMATİON.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LNKARRANGEİNFORMATİON.Location = new System.Drawing.Point(3, 281);
            this.LNKARRANGEİNFORMATİON.Name = "LNKARRANGEİNFORMATİON";
            this.LNKARRANGEİNFORMATİON.Size = new System.Drawing.Size(134, 18);
            this.LNKARRANGEİNFORMATİON.TabIndex = 7;
            this.LNKARRANGEİNFORMATİON.TabStop = true;
            this.LNKARRANGEİNFORMATİON.Text = "Arrange Information";
            this.LNKARRANGEİNFORMATİON.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LNKARRANGEİNFORMATİON_LinkClicked);
            // 
            // BTNSİNGUP
            // 
            this.BTNSİNGUP.Location = new System.Drawing.Point(0, 209);
            this.BTNSİNGUP.Name = "BTNSİNGUP";
            this.BTNSİNGUP.Size = new System.Drawing.Size(179, 69);
            this.BTNSİNGUP.TabIndex = 2;
            this.BTNSİNGUP.Text = "Get Appointmnet";
            this.BTNSİNGUP.UseVisualStyleBackColor = true;
            this.BTNSİNGUP.Click += new System.EventHandler(this.BTNSİNGUP_Click);
            // 
            // RTBCOMPLAİNT
            // 
            this.RTBCOMPLAİNT.Location = new System.Drawing.Point(185, 177);
            this.RTBCOMPLAİNT.Name = "RTBCOMPLAİNT";
            this.RTBCOMPLAİNT.Size = new System.Drawing.Size(149, 168);
            this.RTBCOMPLAİNT.TabIndex = 6;
            this.RTBCOMPLAİNT.Text = "";
            // 
            // CMBDOCTOR
            // 
            this.CMBDOCTOR.FormattingEnabled = true;
            this.CMBDOCTOR.Location = new System.Drawing.Point(185, 138);
            this.CMBDOCTOR.Name = "CMBDOCTOR";
            this.CMBDOCTOR.Size = new System.Drawing.Size(149, 36);
            this.CMBDOCTOR.TabIndex = 5;
            this.CMBDOCTOR.SelectedIndexChanged += new System.EventHandler(this.CMBDOCTOR_SelectedIndexChanged);
            // 
            // CMBDEPARTMENT
            // 
            this.CMBDEPARTMENT.FormattingEnabled = true;
            this.CMBDEPARTMENT.Location = new System.Drawing.Point(185, 99);
            this.CMBDEPARTMENT.Name = "CMBDEPARTMENT";
            this.CMBDEPARTMENT.Size = new System.Drawing.Size(149, 36);
            this.CMBDEPARTMENT.TabIndex = 2;
            this.CMBDEPARTMENT.SelectedIndexChanged += new System.EventHandler(this.CMBDEPARTMENT_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Complaint:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 29);
            this.label6.TabIndex = 3;
            this.label6.Text = "Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Department:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Location = new System.Drawing.Point(343, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 222);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Past Appointment";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(593, 187);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(343, 240);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(599, 249);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Active Appointment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(593, 214);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // FRMPATİENTDETAİL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(944, 505);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRMPATİENTDETAİL";
            this.Text = "Patient\'s Details";
            this.Load += new System.EventHandler(this.FRMPATİENTDETAİL_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LBLNAMESURNAME;
        private System.Windows.Forms.Label LBLTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTNSİNGUP;
        private System.Windows.Forms.RichTextBox RTBCOMPLAİNT;
        private System.Windows.Forms.ComboBox CMBDOCTOR;
        private System.Windows.Forms.ComboBox CMBDEPARTMENT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.LinkLabel LNKARRANGEİNFORMATİON;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.Label label3;
    }
}