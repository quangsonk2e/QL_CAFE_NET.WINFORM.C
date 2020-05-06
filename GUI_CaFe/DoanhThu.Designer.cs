namespace GUI_CaFe
{
    partial class DoanhThu
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
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.label3 = new System.Windows.Forms.Label();
        	this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
        	this.label2 = new System.Windows.Forms.Label();
        	this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.dgDoanhThu = new System.Windows.Forms.DataGridView();
        	this.groupBox3 = new System.Windows.Forms.GroupBox();
        	this.tbSumbyDate = new System.Windows.Forms.TextBox();
        	this.tbId = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.groupBox4 = new System.Windows.Forms.GroupBox();
        	this.listView1 = new System.Windows.Forms.ListView();
        	this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
        	this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
        	this.panel1.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgDoanhThu)).BeginInit();
        	this.groupBox3.SuspendLayout();
        	this.groupBox4.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(750, 64);
        	this.panel1.TabIndex = 0;
        	// 
        	// label1
        	// 
        	this.label1.AllowDrop = true;
        	this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(3, 13);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(747, 39);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Doanh Thu";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox1.Controls.Add(this.button3);
        	this.groupBox1.Controls.Add(this.button2);
        	this.groupBox1.Controls.Add(this.button1);
        	this.groupBox1.Controls.Add(this.label3);
        	this.groupBox1.Controls.Add(this.dateTimePicker2);
        	this.groupBox1.Controls.Add(this.label2);
        	this.groupBox1.Controls.Add(this.dateTimePicker1);
        	this.groupBox1.Location = new System.Drawing.Point(4, 52);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(743, 72);
        	this.groupBox1.TabIndex = 1;
        	this.groupBox1.TabStop = false;
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(562, 29);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(75, 23);
        	this.button3.TabIndex = 2;
        	this.button3.Text = "Đóng";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.Button3Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(481, 30);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(75, 23);
        	this.button2.TabIndex = 2;
        	this.button2.Text = "In";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(400, 30);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(75, 23);
        	this.button1.TabIndex = 2;
        	this.button1.Text = "Xem";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(208, 30);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(53, 13);
        	this.label3.TabIndex = 1;
        	this.label3.Text = "Đến ngày";
        	// 
        	// dateTimePicker2
        	// 
        	this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
        	this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        	this.dateTimePicker2.Location = new System.Drawing.Point(267, 30);
        	this.dateTimePicker2.Name = "dateTimePicker2";
        	this.dateTimePicker2.Size = new System.Drawing.Size(92, 20);
        	this.dateTimePicker2.TabIndex = 0;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(28, 30);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(46, 13);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "Từ ngày";
        	// 
        	// dateTimePicker1
        	// 
        	this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        	this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        	this.dateTimePicker1.Location = new System.Drawing.Point(87, 30);
        	this.dateTimePicker1.Name = "dateTimePicker1";
        	this.dateTimePicker1.Size = new System.Drawing.Size(92, 20);
        	this.dateTimePicker1.TabIndex = 0;
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox2.Controls.Add(this.dgDoanhThu);
        	this.groupBox2.Location = new System.Drawing.Point(4, 130);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(393, 333);
        	this.groupBox2.TabIndex = 2;
        	this.groupBox2.TabStop = false;
        	// 
        	// dgDoanhThu
        	// 
        	this.dgDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.dgDoanhThu.Location = new System.Drawing.Point(3, 16);
        	this.dgDoanhThu.Name = "dgDoanhThu";
        	this.dgDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgDoanhThu.Size = new System.Drawing.Size(387, 314);
        	this.dgDoanhThu.TabIndex = 0;
        	// 
        	// groupBox3
        	// 
        	this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox3.Controls.Add(this.tbSumbyDate);
        	this.groupBox3.Controls.Add(this.tbId);
        	this.groupBox3.Controls.Add(this.label5);
        	this.groupBox3.Controls.Add(this.label4);
        	this.groupBox3.Location = new System.Drawing.Point(404, 130);
        	this.groupBox3.Name = "groupBox3";
        	this.groupBox3.Size = new System.Drawing.Size(340, 77);
        	this.groupBox3.TabIndex = 2;
        	this.groupBox3.TabStop = false;
        	// 
        	// tbSumbyDate
        	// 
        	this.tbSumbyDate.Location = new System.Drawing.Point(67, 42);
        	this.tbSumbyDate.Name = "tbSumbyDate";
        	this.tbSumbyDate.Size = new System.Drawing.Size(186, 20);
        	this.tbSumbyDate.TabIndex = 2;
        	// 
        	// tbId
        	// 
        	this.tbId.Location = new System.Drawing.Point(67, 13);
        	this.tbId.Name = "tbId";
        	this.tbId.Size = new System.Drawing.Size(88, 20);
        	this.tbId.TabIndex = 1;
        	this.tbId.TextChanged += new System.EventHandler(this.TbIdTextChanged);
        	// 
        	// label5
        	// 
        	this.label5.Location = new System.Drawing.Point(9, 45);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(61, 23);
        	this.label5.TabIndex = 0;
        	this.label5.Text = "Tổng tiền:";
        	// 
        	// label4
        	// 
        	this.label4.Location = new System.Drawing.Point(24, 16);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(54, 23);
        	this.label4.TabIndex = 0;
        	this.label4.Text = "Mã số:";
        	// 
        	// groupBox4
        	// 
        	this.groupBox4.Controls.Add(this.listView1);
        	this.groupBox4.Location = new System.Drawing.Point(404, 214);
        	this.groupBox4.Name = "groupBox4";
        	this.groupBox4.Size = new System.Drawing.Size(343, 249);
        	this.groupBox4.TabIndex = 3;
        	this.groupBox4.TabStop = false;
        	this.groupBox4.Text = "Hoá đơn chi tiết";
        	// 
        	// listView1
        	// 
        	this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
        	        	        	this.columnHeader1,
        	        	        	this.columnHeader2,
        	        	        	this.columnHeader3,
        	        	        	this.columnHeader4});
        	this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.listView1.GridLines = true;
        	this.listView1.Location = new System.Drawing.Point(3, 16);
        	this.listView1.Name = "listView1";
        	this.listView1.Size = new System.Drawing.Size(337, 230);
        	this.listView1.TabIndex = 0;
        	this.listView1.UseCompatibleStateImageBehavior = false;
        	this.listView1.View = System.Windows.Forms.View.Details;
        	// 
        	// columnHeader1
        	// 
        	this.columnHeader1.Text = "STT";
        	// 
        	// columnHeader2
        	// 
        	this.columnHeader2.Text = "Tên món";
        	// 
        	// columnHeader3
        	// 
        	this.columnHeader3.Text = "Số lượng";
        	// 
        	// columnHeader4
        	// 
        	this.columnHeader4.Text = "Thành Tiền";
        	// 
        	// DoanhThu
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(750, 466);
        	this.Controls.Add(this.groupBox4);
        	this.Controls.Add(this.groupBox3);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.panel1);
        	this.Name = "DoanhThu";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "DoanhThu";
        	this.Load += new System.EventHandler(this.DoanhThu_Load);
        	this.panel1.ResumeLayout(false);
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.groupBox2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.dgDoanhThu)).EndInit();
        	this.groupBox3.ResumeLayout(false);
        	this.groupBox3.PerformLayout();
        	this.groupBox4.ResumeLayout(false);
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSumbyDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgDoanhThu;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
    }
}