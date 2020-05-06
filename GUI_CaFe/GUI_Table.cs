/*
 * Created by SharpDevelop.
 * User: MRQUANGSON
 * Date: 3/10/2020
 * Time: 2:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using BUS_Cafe;
using DAO_Cafe;
using DTO_Cafe;

namespace GUI_CaFe
{
	/// <summary>
	/// Description of GUI_Table.
	/// </summary>
	public partial class GUI_Table : Form
	{
		public GUI_Table()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void load(){
			dgTable.DataSource=TableDAO.Instance.LoadTableList();
			dgTable.Columns["ID"].Visible=false;
			tbName.DataBindings.Clear();
			tbName.DataBindings.Add("Text",dgTable.DataSource,"Name");
			tbStatus.DataBindings.Clear();
			tbStatus.DataBindings.Add("Text",dgTable.DataSource,"Status");
			tbId.DataBindings.Clear();
			tbId.DataBindings.Add("Text",dgTable.DataSource,"ID");
			
		}
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void GUI_TableLoad(object sender, EventArgs e)
		{
			load();
		}
		
		void TbNameTextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			TableDAO.Instance.insert(tbName.Text,tbStatus.Text);
			load();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			TableDAO.Instance.update(new Table(Convert.ToInt32(tbId.Text),tbName.Text,tbStatus.Text));
			load();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			DialogResult result=MessageBox.Show("Bạn thực sự muốn xoá","Xoá dữ liệu",MessageBoxButtons.YesNo);
			
			
			try {
				if(result==DialogResult.Yes){
					TableDAO.Instance.delete(Convert.ToInt32(tbId.Text));
					load();
				}
				
			} catch (Exception) {
				
				MessageBox.Show("Không thể xoá dữ liệu");
			}
		}
	}
}
