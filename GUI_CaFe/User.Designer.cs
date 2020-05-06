namespace GUI_CaFe
{
    partial class User
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
        	this.components = new System.ComponentModel.Container();
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.groupBox2 = new System.Windows.Forms.GroupBox();
        	this.button5 = new System.Windows.Forms.Button();
        	this.button4 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button1 = new System.Windows.Forms.Button();
        	this.tbPassword = new System.Windows.Forms.TextBox();
        	this.tbUserName = new System.Windows.Forms.TextBox();
        	this.tbDisplayname = new System.Windows.Forms.TextBox();
        	this.label5 = new System.Windows.Forms.Label();
        	this.label4 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.tbid = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.groupBox1 = new System.Windows.Forms.GroupBox();
        	this.dgUser = new System.Windows.Forms.DataGridView();
        	this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.panel2 = new System.Windows.Forms.Panel();
        	this.label1 = new System.Windows.Forms.Label();
        	this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
        	this.button6 = new System.Windows.Forms.Button();
        	this.panel1.SuspendLayout();
        	this.groupBox2.SuspendLayout();
        	this.groupBox1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.dgUser)).BeginInit();
        	this.panel2.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.Controls.Add(this.groupBox2);
        	this.panel1.Controls.Add(this.groupBox1);
        	this.panel1.Controls.Add(this.panel2);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(629, 417);
        	this.panel1.TabIndex = 0;
        	// 
        	// groupBox2
        	// 
        	this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox2.Controls.Add(this.button5);
        	this.groupBox2.Controls.Add(this.button6);
        	this.groupBox2.Controls.Add(this.button4);
        	this.groupBox2.Controls.Add(this.button3);
        	this.groupBox2.Controls.Add(this.button2);
        	this.groupBox2.Controls.Add(this.button1);
        	this.groupBox2.Controls.Add(this.tbPassword);
        	this.groupBox2.Controls.Add(this.tbUserName);
        	this.groupBox2.Controls.Add(this.tbDisplayname);
        	this.groupBox2.Controls.Add(this.label5);
        	this.groupBox2.Controls.Add(this.label4);
        	this.groupBox2.Controls.Add(this.label3);
        	this.groupBox2.Controls.Add(this.tbid);
        	this.groupBox2.Controls.Add(this.label2);
        	this.groupBox2.Location = new System.Drawing.Point(7, 50);
        	this.groupBox2.Name = "groupBox2";
        	this.groupBox2.Size = new System.Drawing.Size(619, 153);
        	this.groupBox2.TabIndex = 1;
        	this.groupBox2.TabStop = false;
        	this.groupBox2.Text = "Chi tiết người dùng";
        	// 
        	// button5
        	// 
        	this.button5.Location = new System.Drawing.Point(272, 122);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(75, 23);
        	this.button5.TabIndex = 2;
        	this.button5.Text = "Huỷ";
        	this.button5.UseVisualStyleBackColor = true;
        	// 
        	// button4
        	// 
        	this.button4.Location = new System.Drawing.Point(462, 122);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(75, 23);
        	this.button4.TabIndex = 2;
        	this.button4.Text = "Đóng";
        	this.button4.UseVisualStyleBackColor = true;
        	this.button4.Click += new System.EventHandler(this.Button4Click);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(191, 122);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(75, 23);
        	this.button3.TabIndex = 2;
        	this.button3.Text = "Xoá";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.button3_Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(110, 123);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(75, 23);
        	this.button2.TabIndex = 2;
        	this.button2.Text = "Lưu - Sửa";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(29, 123);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(75, 23);
        	this.button1.TabIndex = 2;
        	this.button1.Text = "Thêm";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// tbPassword
        	// 
        	this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tbPassword.Location = new System.Drawing.Point(87, 93);
        	this.tbPassword.Name = "tbPassword";
        	this.tbPassword.Size = new System.Drawing.Size(197, 20);
        	this.tbPassword.TabIndex = 0;
        	this.tbPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TbPasswordValidating);
        	// 
        	// tbUserName
        	// 
        	this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tbUserName.Location = new System.Drawing.Point(87, 68);
        	this.tbUserName.Name = "tbUserName";
        	this.tbUserName.Size = new System.Drawing.Size(197, 20);
        	this.tbUserName.TabIndex = 0;
        	this.tbUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TbUserNameValidating);
        	// 
        	// tbDisplayname
        	// 
        	this.tbDisplayname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tbDisplayname.Location = new System.Drawing.Point(87, 42);
        	this.tbDisplayname.Name = "tbDisplayname";
        	this.tbDisplayname.Size = new System.Drawing.Size(197, 20);
        	this.tbDisplayname.TabIndex = 0;
        	this.tbDisplayname.Validating += new System.ComponentModel.CancelEventHandler(this.TbDisplaynameValidating);
        	// 
        	// label5
        	// 
        	this.label5.Location = new System.Drawing.Point(29, 96);
        	this.label5.Name = "label5";
        	this.label5.Size = new System.Drawing.Size(192, 23);
        	this.label5.TabIndex = 1;
        	this.label5.Text = "Mật khẩu";
        	// 
        	// label4
        	// 
        	this.label4.Location = new System.Drawing.Point(3, 71);
        	this.label4.Name = "label4";
        	this.label4.Size = new System.Drawing.Size(192, 23);
        	this.label4.TabIndex = 1;
        	this.label4.Text = "Tên đăng nhập";
        	// 
        	// label3
        	// 
        	this.label3.Location = new System.Drawing.Point(20, 45);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(192, 23);
        	this.label3.TabIndex = 1;
        	this.label3.Text = "Tên hiển thị";
        	// 
        	// tbid
        	// 
        	this.tbid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.tbid.Enabled = false;
        	this.tbid.Location = new System.Drawing.Point(88, 19);
        	this.tbid.Name = "tbid";
        	this.tbid.Size = new System.Drawing.Size(49, 20);
        	this.tbid.TabIndex = 0;
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(64, 22);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(44, 23);
        	this.label2.TabIndex = 1;
        	this.label2.Text = "ID";
        	// 
        	// groupBox1
        	// 
        	this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
        	        	        	| System.Windows.Forms.AnchorStyles.Left) 
        	        	        	| System.Windows.Forms.AnchorStyles.Right)));
        	this.groupBox1.Controls.Add(this.dgUser);
        	this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
        	this.groupBox1.Location = new System.Drawing.Point(4, 209);
        	this.groupBox1.Name = "groupBox1";
        	this.groupBox1.Size = new System.Drawing.Size(622, 205);
        	this.groupBox1.TabIndex = 1;
        	this.groupBox1.TabStop = false;
        	this.groupBox1.Text = "Danh sách nười dùng";
        	// 
        	// dgUser
        	// 
        	this.dgUser.AllowUserToAddRows = false;
        	this.dgUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dgUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
        	this.dgUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
        	        	        	this.id,
        	        	        	this.DisplayName,
        	        	        	this.UserName,
        	        	        	this.Password,
        	        	        	this.Type});
        	this.dgUser.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.dgUser.Location = new System.Drawing.Point(3, 16);
        	this.dgUser.Name = "dgUser";
        	this.dgUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dgUser.Size = new System.Drawing.Size(616, 186);
        	this.dgUser.TabIndex = 0;
        	this.dgUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgUser_CellClick);
        	// 
        	// id
        	// 
        	this.id.DataPropertyName = "id";
        	this.id.HeaderText = "ID";
        	this.id.Name = "id";
        	this.id.Visible = false;
        	// 
        	// DisplayName
        	// 
        	this.DisplayName.DataPropertyName = "DisplayName";
        	this.DisplayName.HeaderText = "Tên hiển thị";
        	this.DisplayName.Name = "DisplayName";
        	// 
        	// UserName
        	// 
        	this.UserName.DataPropertyName = "UserName";
        	this.UserName.HeaderText = "Tên đăng nhập";
        	this.UserName.Name = "UserName";
        	// 
        	// Password
        	// 
        	this.Password.DataPropertyName = "Password";
        	this.Password.HeaderText = "Mật khẩu";
        	this.Password.Name = "Password";
        	// 
        	// Type
        	// 
        	this.Type.DataPropertyName = "Type";
        	this.Type.HeaderText = "Kiểu";
        	this.Type.Name = "Type";
        	// 
        	// panel2
        	// 
        	this.panel2.Controls.Add(this.label1);
        	this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
        	this.panel2.Location = new System.Drawing.Point(0, 0);
        	this.panel2.Name = "panel2";
        	this.panel2.Size = new System.Drawing.Size(629, 43);
        	this.panel2.TabIndex = 0;
        	// 
        	// label1
        	// 
        	this.label1.AllowDrop = true;
        	this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
        	this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
        	this.label1.Location = new System.Drawing.Point(0, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(629, 23);
        	this.label1.TabIndex = 0;
        	this.label1.Text = "Quản lý người dùng";
        	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// errorProvider1
        	// 
        	this.errorProvider1.ContainerControl = this;
        	// 
        	// button6
        	// 
        	this.button6.Location = new System.Drawing.Point(364, 122);
        	this.button6.Name = "button6";
        	this.button6.Size = new System.Drawing.Size(75, 23);
        	this.button6.TabIndex = 2;
        	this.button6.Text = "In";
        	this.button6.UseVisualStyleBackColor = true;
        	this.button6.Click += new System.EventHandler(this.Button6Click);
        	// 
        	// User
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(629, 417);
        	this.Controls.Add(this.panel1);
        	this.Name = "User";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "User";
        	this.Load += new System.EventHandler(this.User_Load);
        	this.panel1.ResumeLayout(false);
        	this.groupBox2.ResumeLayout(false);
        	this.groupBox2.PerformLayout();
        	this.groupBox1.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.dgUser)).EndInit();
        	this.panel2.ResumeLayout(false);
        	((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
        	this.ResumeLayout(false);
        }
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDisplayname;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgUser;
        private System.Windows.Forms.TextBox tbid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}