using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS_Cafe;
using DAO_Cafe;
namespace GUI_CaFe
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
            
          
            
        }
        private void loadGrid(){
        	DataTable dt = new AccountBUS().getAccount();
        	dgUser.DataSource = dt;
            tbid.DataBindings.Clear();
            tbid.DataBindings.Add("Text", dgUser.DataSource, "id");
            tbDisplayname.DataBindings.Clear();
            tbDisplayname.DataBindings.Add("Text", dgUser.DataSource, "Displayname",false,DataSourceUpdateMode.OnPropertyChanged);
            tbUserName.DataBindings.Clear();
             tbUserName.DataBindings.Add("Text", dgUser.DataSource, "UserName");
             //tbPassword.DataBindings.Clear();
             // tbPassword.DataBindings.Add("Text", dgUser.DataSource, "Password");

              resetText(false);
              
        }
        private void User_Load(object sender, EventArgs e)
        {
            
             loadGrid();
        	
        }

        private void dgUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  dgUser.DataBindings.Add("text", tbName, "DisplayName");
          resetText(true);

        }
        
        void Button4Click(object sender, EventArgs e)
        {
        	//Application.Exit();
        	this.Close();
        	
        }
        
        void TbDisplaynameValidating(object sender, CancelEventArgs e)
        {
        	if(string.IsNullOrEmpty(tbDisplayname.Text)){
        		
        		errorProvider1.SetError(tbDisplayname,"Lỗi");
        		
        	}
        	else
        		{
        		
        		errorProvider1.SetError(tbDisplayname,null);
        		}
        }
        
        void Button1Click(object sender, EventArgs e)
        {
        	if(!tbDisplayname.Enabled) resetText(true);
        	else
        	{
                if (!string.IsNullOrEmpty(tbPassword.Text))
                {
                    new AccountBUS().insert(tbDisplayname.Text, tbUserName.Text, new Helper().mahoa(tbPassword.Text), 0);
                    loadGrid();
                }
        	}
        }
        
        void TbUserNameValidating(object sender, CancelEventArgs e)
        {
        	if(string.IsNullOrEmpty(tbUserName.Text)){
        		
        		errorProvider1.SetError(tbUserName,"Lỗi");
        		
        	}
        	else
        		{
        		
        		errorProvider1.SetError(tbUserName,null);
        		}
        }
        private void resetText(bool kt){
        	
        	tbDisplayname.Enabled=kt;
        	tbUserName.Enabled=kt;
        	tbPassword.Enabled=kt;
        	tbid.Enabled=kt;
        	
        }
        
        void TbPasswordValidating(object sender, CancelEventArgs e)
        {
        	if(string.IsNullOrEmpty(tbPassword.Text)){
        		
        		errorProvider1.SetError(tbPassword,"Lỗi");
        		
        	}
        	else
        		{
        		
        		errorProvider1.SetError(tbPassword,null);
        		}
        }
        
        void Button2Click(object sender, EventArgs e)
        {
			
        	if(tbDisplayname.Enabled) 
        	{
                if (!string.IsNullOrEmpty(tbPassword.Text))
                {
                    new AccountBUS().update(tbDisplayname.Text, tbUserName.Text, tbPassword.Text, 0, Convert.ToInt32(tbid.Text));
                    loadGrid();
                }
                else
                {
                    new AccountBUS().update(tbDisplayname.Text, tbUserName.Text, tbPassword.Text, 0, Convert.ToInt32(tbid.Text));
                    loadGrid();
                }
        	}        	
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa?", "Xóa dữ liẹu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                AccountDAO.Instance.delete(Convert.ToInt32(tbid.Text));
                loadGrid();
            }
        }
        
        void Button6Click(object sender, EventArgs e)
        {
            report.Account_rp a = new report.Account_rp();
            a.ShowDialog();
        }
    }
}
