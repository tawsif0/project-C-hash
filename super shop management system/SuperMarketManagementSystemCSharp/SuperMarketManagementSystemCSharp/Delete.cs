using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SuperMarketManagementSystemCSharp
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True"))
                {

                    string str = "SELECT * FROM g_info ";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }

            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True"))
                {

                    string str = "SELECT * FROM sell_item";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True"))
                {

                    string str = "SELECT * FROM supplier";
                    SqlCommand cmd = new SqlCommand(str, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = new BindingSource(dt, null);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex == 0)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True");
                    con.Open();

                    string str = "DELETE FROM g_info WHERE id = '" + TextBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Goods Record Delete Successfully");
                    this.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please Enter Goods Registration number..");
                }
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True");
                    con.Open();

                    string str = "DELETE FROM sell_item WHERE id = '" + TextBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Selled Item Record Delete Successfully");
                    this.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please Enter Selled Item Registration number..");
                }
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True");
                    con.Open();

                    string str = "DELETE FROM supplier WHERE id = '" + TextBox1.Text + "'";

                    SqlCommand cmd = new SqlCommand(str, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(" Supplier's Record Delete Successfully");
                    this.Close();
                }

                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show("Please Enter Supplier's Registration number..");
                }
            }
        }
    }
}
