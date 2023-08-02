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
    public partial class sells_Items : Form
    {
        public sells_Items()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string pay = string.Empty;
            if (RadioButton1.Checked)
            {
                pay = "Cash";
            }
            else if (RadioButton2.Checked)
            {
                pay = "Credit Card";
            }
            else if (RadioButton3.Checked)
            {
                pay = "Online";
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True");
            con.Open();

            try
            {
                string str = " INSERT INTO sell_item(c_id,c_name,mobi,g_id,g_name,type,quantity,price,p_type) VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox6 + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox5.Text + "','" + pay + "'); ";

                SqlCommand cmd = new SqlCommand(str, con);
                cmd.ExecuteNonQuery();

                //-------------------------------------------//

                string str1 = "select max(Id) from sell_item;";

                SqlCommand cmd1 = new SqlCommand(str1, con);
                SqlDataReader dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("selled Item's Information Registered Successfully..");
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";
                    TextBox6.Text = "";
                    TextBox7.Text = "";
                    TextBox8.Text = "";

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
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";
            TextBox7.Text = "";
            TextBox8.Text = "";
        }

        private void sells_Items_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True");

            con.Open();
            if (TextBox1.Text != "")
            {
                try
                {
                    string getCust = "select name,mobi from cust where id=" + Convert.ToInt32(TextBox1.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        TextBox2.Text = dr.GetValue(0).ToString();
                        TextBox3.Text = dr.GetValue(1).ToString();


                    }
                    else
                    {
                        MessageBox.Show(" Sorry ,,This ID, " + TextBox1.Text + " Customer is not Available.   ");
                        TextBox1.Text = "";
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();

            }
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\dell\documents\visual studio 2015\Projects\SuperMarketManagementSystemCSharp\SuperMarketManagementSystemCSharp\market.mdf;Integrated Security=True");

            con.Open();
            if (TextBox4.Text != "")
            {
                try
                {
                    string getCust = "select name,type,quantity,price from g_info  where id=" + Convert.ToInt32(TextBox4.Text) + " ;";

                    SqlCommand cmd = new SqlCommand(getCust, con);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        TextBox6.Text = dr.GetValue(0).ToString();
                        TextBox7.Text = dr.GetValue(1).ToString();
                        TextBox8.Text = dr.GetValue(2).ToString();
                        TextBox5.Text = dr.GetValue(3).ToString();

                    }
                    else
                    {
                        MessageBox.Show(" Sorry ,,This ID, " + TextBox1.Text + " Sells Item is not Available.   ");
                        
                    }
                }
                catch (SqlException excep)
                {
                    MessageBox.Show(excep.Message);
                }
                con.Close();


            }
        }
    }
}
