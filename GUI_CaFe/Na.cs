using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAO_Cafe;

namespace GUI_CaFe
{
    public partial class Na : Form
    {
        public Na()
        {
            InitializeComponent();
        }

        private void Na_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = AccountDAO.Instance.getAccount();
          //  bindingNavigator1.BindingSource = bindingSource1;
            textBox1.DataBindings.Add(new Binding("Text",bindingSource1,"id"));
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "DisplayName"));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.Position++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveLast();
        }
    }
}
