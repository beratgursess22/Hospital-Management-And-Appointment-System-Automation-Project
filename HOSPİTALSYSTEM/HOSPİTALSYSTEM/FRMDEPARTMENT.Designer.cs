namespace HOSPİTALSYSTEM
{
    partial class FRMDEPARTMENT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDEPARTMENT));
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXTDEPARTMENTNAME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXTDEPARTMENTID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.BackColor = System.Drawing.Color.Brown;
            this.BTNUPDATE.Location = new System.Drawing.Point(254, 119);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(79, 23);
            this.BTNUPDATE.TabIndex = 41;
            this.BTNUPDATE.Text = "Update";
            this.BTNUPDATE.UseVisualStyleBackColor = false;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.BackColor = System.Drawing.SystemColors.Highlight;
            this.BTNDELETE.Location = new System.Drawing.Point(149, 119);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(89, 23);
            this.BTNDELETE.TabIndex = 40;
            this.BTNDELETE.Text = "Delete";
            this.BTNDELETE.UseVisualStyleBackColor = false;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTNADD.Location = new System.Drawing.Point(55, 119);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(75, 23);
            this.BTNADD.TabIndex = 39;
            this.BTNADD.Text = "Add";
            this.BTNADD.UseVisualStyleBackColor = false;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(354, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(378, 157);
            this.dataGridView1.TabIndex = 38;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TXTDEPARTMENTNAME
            // 
            this.TXTDEPARTMENTNAME.Location = new System.Drawing.Point(181, 80);
            this.TXTDEPARTMENTNAME.Name = "TXTDEPARTMENTNAME";
            this.TXTDEPARTMENTNAME.Size = new System.Drawing.Size(167, 22);
            this.TXTDEPARTMENTNAME.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Department Name:";
            // 
            // TXTDEPARTMENTID
            // 
            this.TXTDEPARTMENTID.Location = new System.Drawing.Point(181, 45);
            this.TXTDEPARTMENTID.Name = "TXTDEPARTMENTID";
            this.TXTDEPARTMENTID.Size = new System.Drawing.Size(167, 22);
            this.TXTDEPARTMENTID.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Department ID:";
            // 
            // FRMDEPARTMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(733, 164);
            this.Controls.Add(this.BTNUPDATE);
            this.Controls.Add(this.BTNDELETE);
            this.Controls.Add(this.BTNADD);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TXTDEPARTMENTNAME);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXTDEPARTMENTID);
            this.Controls.Add(this.label5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FRMDEPARTMENT";
            this.Text = "Department ";
            this.Load += new System.EventHandler(this.FRMDEPARTMENT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXTDEPARTMENTNAME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TXTDEPARTMENTID;
        private System.Windows.Forms.Label label5;
    }
}