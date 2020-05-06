using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using BUS_Cafe;
using DAO_Cafe;
using DTO_Cafe;

namespace GUI_CaFe
{
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
           InitializeComponent();
          
              }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
        	
        }
        
        void Button1Click(object sender, EventArgs e)
        {
        		string dateStart =Helper.Instance.convertDate(dateTimePicker1.Text);
        		string dateEnd =Helper.Instance.convertDate(dateTimePicker2.Text);
        	 dgDoanhThu.DataSource=BillInfoDao.Instance.getBillByDate(Convert.ToDateTime(dateStart), Convert.ToDateTime(dateEnd));
             if (dgDoanhThu.DataSource != null)
             {
                 dgDoanhThu.Columns["tongtien"].DefaultCellStyle.Format = "N0";
                 dgDoanhThu.Columns["tongtien"].HeaderText = "Tổng Tiền";
                 dgDoanhThu.Columns["tongtien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                 dgDoanhThu.Columns["DateCheckOut"].DefaultCellStyle.Format = "dd/MM/yyyy";
                 dgDoanhThu.Columns["DateCheckOut"].HeaderText = "Ngày hoá đơn";
                 dgDoanhThu.Columns["id"].HeaderText = "Mã số";
                 dgDoanhThu.Columns["status"].HeaderText = "Tình trạng";
                 tbId.DataBindings.Clear();
                 tbId.DataBindings.Add("Text", dgDoanhThu.DataSource, "id");
                 tbSumbyDate.Text = BillInfoDao.Instance.getBillSum(Convert.ToDateTime(dateStart), Convert.ToDateTime(dateEnd)).ToString("N0");
             }
        }
        
        void TbIdTextChanged(object sender, EventArgs e)
        {
        	addItemListFood(Convert.ToInt32(tbId.Text));
        }
        
        private void addItemListFood(int idTable)
        {
        	listView1.Items.Clear();
        	int i=1;
        	//decimal tongtien=0;
            List<BillInfo> lBI=new BillInfoBUS().getBillInfo(idTable);
            foreach (BillInfo item in lBI) {
            	ListViewItem lvItem=new ListViewItem(i.ToString());
            	i++;
            	lvItem.SubItems.Add(new FoodBUS().getFood(item.IdFood).Name.ToString());
            	lvItem.SubItems.Add(item.Count1.ToString());
                decimal price=new FoodBUS().getFood(item.IdFood).Price * item.Count1;
                
                lvItem.SubItems.Add(String.Format("{0:0,0}", price));
            	listView1.Items.Add(lvItem);
            	
            }
            //tbSumPrice.Text = String.Format("{0:0,0}", tongtien);
        }

        
        void Button3Click(object sender, EventArgs e)
        {
        	this.Close();
        }
        
        void Button2Click(object sender, EventArgs e)
        {
            string dateStart =Helper.Instance.convertDate(dateTimePicker1.Text);
        	string dateEnd =Helper.Instance.convertDate(dateTimePicker2.Text);
            report.Bill_rp rp = new report.Bill_rp(Convert.ToDateTime(dateStart),Convert.ToDateTime(dateEnd));
            rp.ShowDialog();
        }
    }
}
