namespace HOSPİTALSYSTEM
{
    partial class FRMDOCTORPANEL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDOCTORPANEL));
            this.TXTNAME = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TXTSURNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CMBDEPARTMENT = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MSKTC = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTPASSO = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BTNADD = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TXTNAME
            // 
            this.TXTNAME.Location = new System.Drawing.Point(142, 30);
            this.TXTNAME.Name = "TXTNAME";
            this.TXTNAME.Size = new System.Drawing.Size(167, 22);
            this.TXTNAME.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Name:";
            // 
            // TXTSURNAME
            // 
            this.TXTSURNAME.Location = new System.Drawing.Point(142, 65);
            this.TXTSURNAME.Name = "TXTSURNAME";
            this.TXTSURNAME.Size = new System.Drawing.Size(167, 22);
            this.TXTSURNAME.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Surname:";
            // 
            // CMBDEPARTMENT
            // 
            this.CMBDEPARTMENT.FormattingEnabled = true;
            this.CMBDEPARTMENT.Location = new System.Drawing.Point(142, 93);
            this.CMBDEPARTMENT.Name = "CMBDEPARTMENT";
            this.CMBDEPARTMENT.Size = new System.Drawing.Size(167, 24);
            this.CMBDEPARTMENT.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Department:";
            // 
            // MSKTC
            // 
            this.MSKTC.Location = new System.Drawing.Point(142, 132);
            this.MSKTC.Mask = "00000000000";
            this.MSKTC.Name = "MSKTC";
            this.MSKTC.Size = new System.Drawing.Size(169, 22);
            this.MSKTC.TabIndex = 21;
            this.MSKTC.ValidatingType = typeof(int);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "TC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Passoword:";
            // 
            // TXTPASSO
            // 
            this.TXTPASSO.Location = new System.Drawing.Point(142, 167);
            this.TXTPASSO.Name = "TXTPASSO";
            this.TXTPASSO.Size = new System.Drawing.Size(167, 22);
            this.TXTPASSO.TabIndex = 23;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(384, -2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(916, 271);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // BTNADD
            // 
            this.BTNADD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNADD.Location = new System.Drawing.Point(45, 219);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(91, 23);
            this.BTNADD.TabIndex = 25;
            this.BTNADD.Text = "Add";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.BackColor = System.Drawing.SystemColors.Highlight;
            this.BTNDELETE.Location = new System.Drawing.Point(154, 219);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(75, 23);
            this.BTNDELETE.TabIndex = 26;
            this.BTNDELETE.Text = "Delete";
            this.BTNDELETE.UseVisualStyleBackColor = false;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.BackColor = System.Drawing.Color.Brown;
            this.BTNUPDATE.Location = new System.Drawing.Point(249, 219);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(88, 23);
            this.BTNUPDATE.TabIndex = 27;
            this.BTNUPDATE.Text = "Update";
            this.BTNUPDATE.UseVisualStyleBackColor = false;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // FRMDOCTORPANELİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1299, 269);
            this.Controls.Add(this.BTNUPDATE);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTPASSO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MSKTC);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CMBDEPARTMENT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXTSURNAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTNAME);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRMDOCTORPANELİ";
            this.Text = "Doctor\' Panel";
            this.Load += new System.EventHandler(this.FRMDOCTORPANELİ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTNAME;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXTSURNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMBDEPARTMENT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox MSKTC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTPASSO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNUPDATE;
    }
}