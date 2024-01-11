namespace WindowsFormsApp1
{
    partial class viewbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewbook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Refr = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bname = new System.Windows.Forms.TextBox();
            this.bprice = new System.Windows.Forms.TextBox();
            this.bpubl = new System.Windows.Forms.TextBox();
            this.bauth = new System.Windows.Forms.TextBox();
            this.bquan = new System.Windows.Forms.TextBox();
            this.updt = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.canc = new System.Windows.Forms.Button();
            this.bdate = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 103);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(323, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Book";
            // 
            // txtbookname
            // 
            this.txtbookname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbookname.Location = new System.Drawing.Point(269, 119);
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(241, 32);
            this.txtbookname.TabIndex = 2;
            this.txtbookname.TextChanged += new System.EventHandler(this.txtbookname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Book Name";
            // 
            // Refr
            // 
            this.Refr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Refr.Location = new System.Drawing.Point(529, 119);
            this.Refr.Name = "Refr";
            this.Refr.Size = new System.Drawing.Size(75, 32);
            this.Refr.TabIndex = 4;
            this.Refr.Text = "Refresh";
            this.Refr.UseVisualStyleBackColor = true;
            this.Refr.Click += new System.EventHandler(this.Refr_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(898, 286);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.bdate);
            this.panel2.Controls.Add(this.canc);
            this.panel2.Controls.Add(this.del);
            this.panel2.Controls.Add(this.updt);
            this.panel2.Controls.Add(this.bquan);
            this.panel2.Controls.Add(this.bauth);
            this.panel2.Controls.Add(this.bpubl);
            this.panel2.Controls.Add(this.bprice);
            this.panel2.Controls.Add(this.bname);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(898, 350);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Book Author Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book Publication";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(436, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Book Purchase Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(474, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Book Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(460, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Book Quantity";
            // 
            // bname
            // 
            this.bname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bname.Location = new System.Drawing.Point(162, 29);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(224, 32);
            this.bname.TabIndex = 6;
            // 
            // bprice
            // 
            this.bprice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bprice.Location = new System.Drawing.Point(621, 126);
            this.bprice.Name = "bprice";
            this.bprice.Size = new System.Drawing.Size(214, 32);
            this.bprice.TabIndex = 7;
            // 
            // bpubl
            // 
            this.bpubl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpubl.Location = new System.Drawing.Point(203, 219);
            this.bpubl.Name = "bpubl";
            this.bpubl.Size = new System.Drawing.Size(224, 32);
            this.bpubl.TabIndex = 8;
            // 
            // bauth
            // 
            this.bauth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bauth.Location = new System.Drawing.Point(244, 126);
            this.bauth.Name = "bauth";
            this.bauth.Size = new System.Drawing.Size(224, 32);
            this.bauth.TabIndex = 9;
            // 
            // bquan
            // 
            this.bquan.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bquan.Location = new System.Drawing.Point(621, 214);
            this.bquan.Name = "bquan";
            this.bquan.Size = new System.Drawing.Size(214, 32);
            this.bquan.TabIndex = 10;
            // 
            // updt
            // 
            this.updt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updt.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updt.Location = new System.Drawing.Point(423, 286);
            this.updt.Name = "updt";
            this.updt.Size = new System.Drawing.Size(75, 34);
            this.updt.TabIndex = 12;
            this.updt.Text = "Update";
            this.updt.UseVisualStyleBackColor = true;
            this.updt.Click += new System.EventHandler(this.updt_Click);
            // 
            // del
            // 
            this.del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(529, 286);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 34);
            this.del.TabIndex = 13;
            this.del.Text = "Delete";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // canc
            // 
            this.canc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.canc.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canc.Location = new System.Drawing.Point(650, 286);
            this.canc.Name = "canc";
            this.canc.Size = new System.Drawing.Size(75, 34);
            this.canc.TabIndex = 14;
            this.canc.Text = "Cancel";
            this.canc.UseVisualStyleBackColor = true;
            this.canc.Click += new System.EventHandler(this.canc_Click);
            // 
            // bdate
            // 
            this.bdate.BackColor = System.Drawing.SystemColors.Window;
            this.bdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdate.Location = new System.Drawing.Point(630, 29);
            this.bdate.Name = "bdate";
            this.bdate.Size = new System.Drawing.Size(214, 32);
            this.bdate.TabIndex = 15;
            // 
            // viewbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(941, 839);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Refr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.panel1);
            this.Name = "viewbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewbook";
            this.Load += new System.EventHandler(this.viewbook_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Refr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button canc;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button updt;
        private System.Windows.Forms.TextBox bquan;
        private System.Windows.Forms.TextBox bauth;
        private System.Windows.Forms.TextBox bpubl;
        private System.Windows.Forms.TextBox bprice;
        private System.Windows.Forms.TextBox bname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bdate;
    }
}