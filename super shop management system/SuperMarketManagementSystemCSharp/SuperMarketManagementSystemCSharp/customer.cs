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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True");
            con.Open();
            String gen = string.Empty;
            if (RadioButton1.Checked)
            {
                gen = "Male";
            }
            else if (RadioButton2.Checked)
            {
                gen = "Female";
            }
            try
            {
                string str = " INSERT INTO cust(name,gen,addr,mobi,date) VALUES('" + TextBox2.Text + "','" + gen + "','" + TextBox8.Text + "','" + TextBox6.Text + "','" + TextBox7 + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from cust;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Customers Information Registered Successfully..");
                    TextBox1.Text = "";
                    TextBox2.Text = "";

                    TextBox8.Text = "";
                    TextBox7.Text = "";
                    TextBox6.Text = "";

                }
                this.Close();
            }
            catch (SqlException excep)
            {
                MessageBox.Show(excep.Message);
            }
            con.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";

            TextBox8.Text = "";
            TextBox7.Text = "";
            TextBox6.Text = "";
        }

        private void customer_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True");
            con.Open();
            string str1 = "select max(id) from cust;";

            SqlCommand cmd1 = new SqlCommand(str1, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                string val = dr[0].ToString();
                if (val == "")
                {
                    TextBox1.Text = "1";
                }
                else
                {
                    int a;
                    a = Convert.ToInt32(dr[0].ToString());
                    a = a + 1;
                    TextBox1.Text = a.ToString();
                }

            }
        }
    }
}
