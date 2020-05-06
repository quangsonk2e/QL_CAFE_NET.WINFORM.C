using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Cafe;
using BUS_Cafe;
using DTO_Cafe;

namespace GUI_CaFe
{
    public partial class FormChinh : Form
    {
        
        public FormChinh()
        {
            //Login login=new Login();
            //this.Hide();
            //login.ShowDialog();
            //this.Show();
            InitializeComponent();
            dt();
            load();
            loadFoodCategory();
        }
        private void dt()
        {

            //dataGridView1.DataSource = DataProvider.Instance.ExecuteQuery("EXEC dbo.getAccount @DisplayName, @UserName", "laiquangson", "laiquangson");
	       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TableDAO.Instance.Insert("Bàn 5");
        }
        void loadFoodCategory(){
        	
        	DataTable dt=new FoodCategoryBUS().getFoodCategory();
        	DataRow dtr;
        	dtr=dt.NewRow();
        	dtr["id"]=0;
        	dtr["name"]="Chọn loại";
        	dt.Rows.Add(dtr);
        	dt.DefaultView.Sort="id ASC";
        	cbFoodCategory.DataSource=dt;
        	cbFoodCategory.DisplayMember="name";
        	cbFoodCategory.ValueMember="id";
        	//cbFoodCategory.Items.Insert(0, "Chọn loại");
        }
        void load()
        {
        	flowLayoutPanel1.Controls.Clear();
            List<Table> tableList = TableDAO.Instance.LoadTableList();
            foreach (Table table in tableList)
            {
                Button bt = new Button();
                bt.Tag = table;
                bt.Text = table.Name;
                bt.Width=90;
                bt.Height=90;
                if(table.Status!="0") bt.BackColor=System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                bt.Click += new EventHandler(this.btTableFoodClick);
                flowLayoutPanel1.Controls.Add(bt);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        void CbFoodCategorySelectedIndexChanged(object sender, EventArgs e)
        	
        {
        	int id=cbFoodCategory.SelectedIndex;
            DataTable dt = new FoodBUS().getFoodByCate(id);
            if (dt.Rows.Count > 0)
            {
                cbFood.DataSource = dt;
                cbFood.DisplayMember = "name";
                cbFood.ValueMember = "id";
            }
            else
                cbFood.DataSource = null;

        	
        	//MessageBox.Show(cbFoodCategory.SelectedIndex.ToString());
        }
        
        void BtAddFoodClick(object sender, EventArgs e)
        	
        {
        	
            int monInt=0;
            string loaiStr = cbFoodCategory.Text;
            int loaiInt = (int)cbFoodCategory.SelectedValue;
            string monStr = cbFood.Text;
            if(cbFood.Items.Count>0)
                monInt = (int)cbFood.SelectedValue;
            int quantity = Decimal.ToInt32(nbFood.Value);
            if(monInt!=0 && loaiInt!=0 && !String.IsNullOrEmpty(tbIdBill.Text)){
            // inssert into billinfo
              int idBillNew=  new BillInfoBUS().insert(Convert.ToInt32(tbIdBill.Text.ToString()), monInt, quantity, Convert.ToInt32(tbTableId.Text));
              if (tbIdBill.Text == "-1")
              {
                  addItemListFood(idBillNew);
                  tbIdBill.Text = idBillNew.ToString();
              }
              else
                  addItemListFood(Convert.ToInt32(tbIdBill.Text));
              nbFood.Value = 1;
              //set staus table 
              if(tbTableStatus.Text=="0"){
              	//id bàn
              	int idtable=Convert.ToInt32(tbTableId.Text);
              	new TableBUS().update(idtable,tbtableName.Text,"1");
              	load();
              	}
              
              
            }
            else 
            	MessageBox.Show("Chưa chọn loại, chọn bàn hoặc món");
            
		    

           
        }
        void btTableFoodClick(object sender, EventArgs e)
        {
        	
        	nbFood.Value=1;
        	
            Button bt = (Button)sender;
            Table tb=(Table)bt.Tag;
            tbTableId.Text = tb.ID.ToString();
            tbtableName.Text = tb.Name;
            tbTableStatus.Text=tb.Status;
            tbIdBill.Text= BillDAO.Instance.GetUncheckBillIDByTableID(tb.ID).ToString();
            addItemListFood(BillDAO.Instance.GetUncheckBillIDByTableID(tb.ID));
         }

        private void addItemListFood(int idTable)
        {
        	listView1.Items.Clear();
        	int i=1;
        	decimal tongtien=0;
            List<BillInfo> lBI=new BillInfoBUS().getBillInfo(idTable);
            foreach (BillInfo item in lBI) {
            	ListViewItem lvItem=new ListViewItem(i.ToString());
            	i++;
            	lvItem.SubItems.Add(new FoodBUS().getFood(item.IdFood).Name.ToString());
            	lvItem.SubItems.Add(item.Count1.ToString());
                decimal price=new FoodBUS().getFood(item.IdFood).Price * item.Count1;
                tongtien+=price;
                lvItem.SubItems.Add(String.Format("{0:0,0}", price));
            	listView1.Items.Add(lvItem);
            	
            }
            tbSumPrice.Text = String.Format("{0:0,0}", tongtien);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        	DialogResult result=MessageBox.Show(" Bạn thực sự muốn thanh toán!","Thanh toán", MessageBoxButtons.YesNo);
        	if(result==DialogResult.Yes){
        		thanhtoan();
        		}
        }
        private void thanhtoan(){
        	//upadte table
        	int idTable=Convert.ToInt32(tbTableId.Text);
        	string name=tbtableName.Text;
        	string status="0";
        	int idBill=Convert.ToInt32(tbIdBill.Text);
        	new TableBUS().update(idTable,name,status);
            new BillBUS().update(DateTime.Now, DateTime.Now, idTable, 2, idBill);      
            listView1.Items.Clear();
            
        	load();
        	
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
        	
        	User user=new User();
        	user.ShowDialog();
        	
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_Table gui_table = new GUI_Table();
            gui_table.ShowDialog();
        }

        private void thứcĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            food.ShowDialog();
        }
             
        
        void HóaĐơnToolStripMenuItemClick(object sender, EventArgs e)
        {
        	DoanhThu doanhthu=new DoanhThu();
        	doanhthu.ShowDialog();
        }
        
        void ThoToolStripMenuItemClick(object sender, EventArgs e)
        {
        	Application.Exit();
        }

        private void FormChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
