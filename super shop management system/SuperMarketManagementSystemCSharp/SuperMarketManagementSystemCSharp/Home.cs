using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperMarketManagementSystemCSharp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier obj = new Supplier();
            obj.ShowDialog();
        }

        private void goodsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Goods_info obj1 = new Goods_info();
            obj1.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Goods_Info obj2 = new Update_Goods_Info();
            obj2.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer obj3 = new customer();
            obj3.ShowDialog();
        }

        private void sellsItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sells_Items obj4 = new sells_Items();
            obj4.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete obj5 = new Delete();
            obj5.ShowDialog();
        }

        private void updateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Report obj6 = new Report();
            obj6.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
