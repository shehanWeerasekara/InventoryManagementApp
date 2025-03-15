using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryManagementApp
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\OneDrive\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO CustomerTbl (Custid, Custname, Custphone) VALUES (@custid, @custname, @tele)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@custid", Custidtb.Text);
                cmd.Parameters.AddWithValue("@custname", Custnametb.Text);
                cmd.Parameters.AddWithValue("@tele", Custphonetb.Text);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer Successfully Added");
                }
                else
                {
                    MessageBox.Show("Failed to Add User");
                }

                con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            populate(); 
        }
    }
}
