namespace GUI_CaFe
{
    partial class Food
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
        	this.label1 = new System.Windows.Forms.Label();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.button5 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.tbId = new System.Windows.Forms.TextBox();
        	this.tbIdFood = new System.Windows.Forms.TextBox();
        	this.tbPrice = new System.Windows.Forms.TextBox();
        	this.tbName = new System.Windows.Forms.TextBox();
        	this.label6 = new System.Windows.Forms.Label();
        	this.tbCategory = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.label7 = new System.Windows.Forms.Label();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.dgFood = new System.Windows.Forms.DataGridView();
        	this.groupBox3 = new System.Windows.Forms.GroupBox();
        	this.button8 = new System.Windows.Forms.Button();
        	this.btFix = new System.Windows.Forms.Button();
        	this.button6 = new System.Windows.Forms.Button();
        	this.cbFoodCategory = new System.Windows.Forms.ComboBox();
        	this.label8 = new System.Windows.Forms.Label();
        	this.label2 = new System.Windows.Forms.Label();
        	this.tbNameCatagory = new System.Windows.Forms.TextBox();
        	this.button7 = new System.Windows.Forms.Button();
        	this.panel1.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgFood)).BeginInit();
        	this.groupBox3.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// label1
        	// 
        	this.label1.AllowDrop = true;
        	this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.Location = new System.Drawing.Point(3, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(756, 33);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Quản lý thức ăn";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	this.label1.Click += new System.EventHandler(this.label1_Click);
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.label1);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(762, 50);
        	this.panel1.TabIndex = 1;
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox1.Controls.Add(this.button5);
        	this.groupBox1.Controls.Add(this.button4);
        	this.groupBox1.Controls.Add(this.button3);
        	this.groupBox1.Controls.Add(this.button2);
        	this.groupBox1.Controls.Add(this.button1);
        	this.groupBox1.Controls.Add(this.tbId);
        	this.groupBox1.Controls.Add(this.tbIdFood);
        	this.groupBox1.Controls.Add(this.tbPrice);
        	this.groupBox1.Controls.Add(this.tbName);
        	this.groupBox1.Controls.Add(this.label6);
        	this.groupBox1.Controls.Add(this.tbCategory);
        	this.groupBox1.Controls.Add(this.label5);
        	this.groupBox1.Controls.Add(this.label4);
        	this.groupBox1.Controls.Add(this.label3);
        	this.groupBox1.Controls.Add(this.label7);
        	this.groupBox1.Location = new System.Drawing.Point(459, 93);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(303, 305);
        	this.groupBox1.TabIndex = 2;
        	this.groupBox1.TabStop = false;
        	// 
        	// button5
        	// 
        	this.button5.Location = new System.Drawing.Point(95, 235);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(86, 32);
        	this.button5.TabIndex = 2;
        	this.button5.Text = "Thoát";
        	this.button5.UseVisualStyleBackColor = true;
        	this.button5.Click += new System.EventHandler(this.Button5Click);
        	// 
        	// button4
        	// 
        	this.button4.Location = new System.Drawing.Point(170, 187);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(86, 32);
        	this.button4.TabIndex = 2;
        	this.button4.Text = "Huỷ";
        	this.button4.UseVisualStyleBackColor = true;
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(28, 187);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(86, 32);
        	this.button3.TabIndex = 2;
        	this.button3.Text = "Xoá";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.Button3Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(170, 139);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(86, 32);
        	this.button2.TabIndex = 2;
        	this.button2.Text = "Lưu - Sửa";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(28, 139);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(86, 32);
        	this.button1.TabIndex = 2;
        	this.button1.Text = "Thêm";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// tbId
        	// 
        	this.tbId.Location = new System.Drawing.Point(64, 19);
        	this.tbId.Name = "tbId";
        	this.tbId.Size = new System.Drawing.Size(28, 20);
        	this.tbId.TabIndex = 0;
        	// 
        	// tbIdFood
        	// 
        	this.tbIdFood.Location = new System.Drawing.Point(112, 19);
        	this.tbIdFood.Name = "tbIdFood";
        	this.tbIdFood.Size = new System.Drawing.Size(100, 20);
        	this.tbIdFood.TabIndex = 0;
        	// 
        	// tbPrice
        	// 
        	this.tbPrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.tbPrice.Location = new System.Drawing.Point(64, 97);
        	this.tbPrice.Name = "tbPrice";
        	this.tbPrice.Size = new System.Drawing.Size(211, 21);
        	this.tbPrice.TabIndex = 0;
        	this.tbPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	this.tbPrice.TextChanged += new System.EventHandler(this.TbPriceTextChanged);
        	// 
        	// tbName
        	// 
        	this.tbName.Location = new System.Drawing.Point(64, 71);
        	this.tbName.Name = "tbName";
        	this.tbName.Size = new System.Drawing.Size(227, 20);
        	this.tbName.TabIndex = 0;
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(17, 104);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(23, 13);
        	this.label6.TabIndex = 0;
        	this.label6.Text = "Giá";
        	// 
        	// tbCategory
        	// 
        	this.tbCategory.Location = new System.Drawing.Point(64, 45);
        	this.tbCategory.Name = "tbCategory";
        	this.tbCategory.Size = new System.Drawing.Size(227, 20);
        	this.tbCategory.TabIndex = 0;
        	// 
        	// label5
        	// 
        	this.label5.AutoSize = true;
        	this.label5.Location = new System.Drawing.Point(17, 78);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(26, 13);
        	this.label5.TabIndex = 0;
        	this.label5.Text = "Tên";
        	// 
        	// label4
        	// 
        	this.label4.AutoSize = true;
        	this.label4.Location = new System.Drawing.Point(17, 26);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(41, 13);
        	this.label4.TabIndex = 0;
        	this.label4.Text = "ID Loại";
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(17, 52);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(27, 13);
        	this.label3.TabIndex = 0;
        	this.label3.Text = "Loại";
        	// 
        	// label7
        	// 
        	this.label7.Location = new System.Drawing.Point(278, 98);
        	this.label7.Name = "label7";
        	this.label7.Size = new System.Drawing.Size(22, 23);
        	this.label7.TabIndex = 1;
        	this.label7.Text = "đ";
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox2.Controls.Add(this.dgFood);
        	this.groupBox2.Location = new System.Drawing.Point(0, 93);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(453, 305);
        	this.groupBox2.TabIndex = 2;
        	this.groupBox2.TabStop = false;
        	// 
        	// dgFood
        	// 
        	this.dgFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dgFood.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.dgFood.Location = new System.Drawing.Point(3, 16);
        	this.dgFood.Name = "dgFood";
        	this.dgFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgFood.Size = new System.Drawing.Size(447, 286);
        	this.dgFood.TabIndex = 0;
        	// 
        	// groupBox3
        	// 
        	this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox3.Controls.Add(this.button7);
        	this.groupBox3.Controls.Add(this.button8);
        	this.groupBox3.Controls.Add(this.btFix);
        	this.groupBox3.Controls.Add(this.button6);
        	this.groupBox3.Controls.Add(this.cbFoodCategory);
        	this.groupBox3.Controls.Add(this.label8);
        	this.groupBox3.Controls.Add(this.label2);
        	this.groupBox3.Controls.Add(this.tbNameCatagory);
        	this.groupBox3.Location = new System.Drawing.Point(0, 46);
        	this.groupBox3.Name = "groupBox3";
        	this.groupBox3.Size = new System.Drawing.Size(762, 49);
        	this.groupBox3.TabIndex = 3;
        	this.groupBox3.TabStop = false;
        	this.groupBox3.Text = "groupBox3";
        	// 
        	// button8
        	// 
        	this.button8.Location = new System.Drawing.Point(601, 10);
        	this.button8.Name = "button8";
        	this.button8.Size = new System.Drawing.Size(72, 33);
        	this.button8.TabIndex = 2;
        	this.button8.Text = "Xoá";
        	this.button8.UseVisualStyleBackColor = true;
        	this.button8.Click += new System.EventHandler(this.Button8Click);
        	// 
        	// btFix
        	// 
        	this.btFix.Location = new System.Drawing.Point(510, 10);
        	this.btFix.Name = "btFix";
        	this.btFix.Size = new System.Drawing.Size(72, 33);
        	this.btFix.TabIndex = 2;
        	this.btFix.Text = "Lưu - Sửa";
        	this.btFix.UseVisualStyleBackColor = true;
        	this.btFix.Click += new System.EventHandler(this.BtFixClick);
        	// 
        	// button6
        	// 
        	this.button6.Location = new System.Drawing.Point(419, 10);
        	this.button6.Name = "button6";
        	this.button6.Size = new System.Drawing.Size(72, 33);
        	this.button6.TabIndex = 2;
        	this.button6.Text = "Thêm";
        	this.button6.UseVisualStyleBackColor = true;
        	this.button6.Click += new System.EventHandler(this.Button6Click);
        	// 
        	// cbFoodCategory
        	// 
        	this.cbFoodCategory.FormattingEnabled = true;
        	this.cbFoodCategory.Location = new System.Drawing.Point(81, 17);
        	this.cbFoodCategory.Name = "cbFoodCategory";
        	this.cbFoodCategory.Size = new System.Drawing.Size(136, 21);
        	this.cbFoodCategory.TabIndex = 1;
        	this.cbFoodCategory.SelectedIndexChanged += new System.EventHandler(this.cbFoodCategory_SelectedIndexChanged);
        	// 
        	// label8
        	// 
        	this.label8.AutoSize = true;
        	this.label8.Location = new System.Drawing.Point(231, 22);
        	this.label8.Name = "label8";
        	this.label8.Size = new System.Drawing.Size(51, 13);
        	this.label8.TabIndex = 0;
        	this.label8.Text = "Chọn loại";
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(24, 20);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(51, 13);
        	this.label2.TabIndex = 0;
        	this.label2.Text = "Chọn loại";
        	// 
        	// tbNameCatagory
        	// 
        	this.tbNameCatagory.Location = new System.Drawing.Point(300, 19);
        	this.tbNameCatagory.Name = "tbNameCatagory";
        	this.tbNameCatagory.Size = new System.Drawing.Size(100, 20);
        	this.tbNameCatagory.TabIndex = 0;
        	// 
        	// button7
        	// 
        	this.button7.Location = new System.Drawing.Point(679, 10);
        	this.button7.Name = "button7";
        	this.button7.Size = new System.Drawing.Size(72, 33);
        	this.button7.TabIndex = 2;
        	this.button7.Text = "Đóng";
        	this.button7.UseVisualStyleBackColor = true;
        	this.button7.Click += new System.EventHandler(this.Button7Click);
        	// 
        	// Food
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(762, 410);
        	this.Controls.Add(this.groupBox3);
        	this.Controls.Add(this.groupBox2);
        	this.Controls.Add(this.groupBox1);
        	this.Controls.Add(this.panel1);
        	this.Name = "Food";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Food";
        	this.Load += new System.EventHandler(this.Food_Load);
        	this.panel1.ResumeLayout(false);
        	this.groupBox1.ResumeLayout(false);
        	this.groupBox1.PerformLayout();
        	this.groupBox2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.dgFood)).EndInit();
        	this.groupBox3.ResumeLayout(false);
        	this.groupBox3.PerformLayout();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox tbNameCatagory;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btFix;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label7;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgFood;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbFoodCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIdFood;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        
       
        
        
    }
}