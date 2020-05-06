using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_Cafe;

namespace GUI_CaFe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        void dangnhap(){
            if (!string.IsNullOrEmpty(tbName.Text) && !string.IsNullOrEmpty(tbPassword.Text))
            {
                var account = new AccountBUS().getAccountLogin(tbName.Text, new Helper().mahoa(tbPassword.Text));
                if (account != null)
                {
                    this.Hide();
                    FormChinh a = new FormChinh();
                    a.ShowDialog();
                    //   this.Show();
                }
                else
                    MessageBox.Show("Tài khoản không tồn tại!!!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

              dangnhap();
			//this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
               // e.Cancel = true;
                errorProvider1.SetError(tbName, "Không được trống!!");
            }
            else
            {
               // e.Cancel = false;
                errorProvider1.SetError(tbName,null);
            }
        }

        private void tbUser_Validating(object sender, CancelEventArgs e)
        {

        }

        private void tbName_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dangnhap();
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                dangnhap();
            }
        }
    }
}
