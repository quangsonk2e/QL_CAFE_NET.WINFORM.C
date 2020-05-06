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
    public partial class Food : Form
    {
        public Food()
        {
            InitializeComponent();
            loadcbFoodCategory();
              
        }
        private void loadcbFoodCategory(){
        	cbFoodCategory.DataSource = new FoodCategoryBUS().getFoodCategory();
            cbFoodCategory.ValueMember = "id";
            cbFoodCategory.DisplayMember = "name";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Food_Load(object sender, EventArgs e)
        {
          

            
        }

        private void cbFoodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            load();
            
        }
        void load(){
        	tbNameCatagory.DataBindings.Clear();
        	tbNameCatagory.DataBindings.Add("Text", cbFoodCategory.DataSource,"name");
        	tbCategory.DataBindings.Clear();
            tbCategory.DataBindings.Add(new Binding("Text", cbFoodCategory.DataSource, "name"));
        	 tbId.DataBindings.Clear();
            tbId.DataBindings.Add("Text", cbFoodCategory.DataSource, "id");
            tbIdFood.DataBindings.Clear();
            dgFood.DataSource = new FoodBUS().getFoodByCate(Convert.ToInt32(cbFoodCategory.SelectedValue.ToString()));
            tbIdFood.DataBindings.Add("Text", dgFood.DataSource, "id");
            tbName.DataBindings.Clear();
            tbName.DataBindings.Add("Text", dgFood.DataSource, "name");
            tbPrice.DataBindings.Clear();
            tbPrice.DataBindings.Add("Text", dgFood.DataSource, "price");
        }
        void TbPriceTextChanged(object sender, EventArgs e)
        {
        	System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
			decimal value=decimal.Parse(tbPrice.Text,System.Globalization.NumberStyles.AllowThousands);
			tbPrice.Text = String.Format(culture, "{0:N0}", value);
			tbPrice.Select(tbPrice.Text.Length, 0);
        }
        
        void Button5Click(object sender, EventArgs e)
        {
        	this.Close();
        }
        
        void Button1Click(object sender, EventArgs e)
        {
        	new FoodBUS().insert(tbName.Text,Convert.ToInt32(tbId.Text),Convert.ToDecimal(tbPrice.Text));
        	load();
        }
        
        void Button2Click(object sender, EventArgs e)
        {
        	new FoodBUS().update(tbName.Text, Convert.ToInt32(tbId.Text),Convert.ToDecimal(tbPrice.Text),Convert.ToInt32(tbIdFood.Text));
        	load();
        }
        
        void Button3Click(object sender, EventArgs e)
        {
        	DialogResult result = MessageBox.Show("Bạn thực sự muốn xóa?", "Xóa dữ liệu", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
            	try {
            		new FoodBUS().delete(Convert.ToInt32(tbIdFood.Text));
            		
            	} catch (Exception) {
            		
            		MessageBox.Show("Không thể xoá. Do đã sử dụng trong hoá đơn");
            	}
            	
            	load();
            }
        	
        }
        
        void Button6Click(object sender, EventArgs e)
        {
        	new FoodCategoryBUS().insert(tbNameCatagory.Text);
        	loadcbFoodCategory();
        }
        
        void BtFixClick(object sender, EventArgs e)
        {
        	new FoodCategoryBUS().update(tbNameCatagory.Text);
        	loadcbFoodCategory();
        }
        
        void Button8Click(object sender, EventArgs e)
        {
			try {
        		DialogResult result=MessageBox.Show("Bạn có muốn xoá?","Xoá dữ liệu",MessageBoxButtons.YesNo);
        		if(result==DialogResult.Yes){
        			new FoodCategoryBUS().delete(Convert.ToInt32(tbId.Text));
        			loadcbFoodCategory();
        			}
			} catch (Exception) {
				
        		MessageBox.Show("Bạn không thể xoá!");
			}        	
        }
        
        void Button7Click(object sender, EventArgs e)
        {
        	this.Close();
        }
    }
}
