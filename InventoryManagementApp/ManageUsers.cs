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

namespace InventoryManagementApp
{
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\OneDrive\Documents\inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                con.Open();
                string Myquery = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "INSERT INTO UserTbl (Uname, Ufullname, Upassword, Uphone) VALUES (@uname, @fname, @pass, @tele)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@uname", Unametb.Text);
                cmd.Parameters.AddWithValue("@fname", Fnametb.Text);
                cmd.Parameters.AddWithValue("@pass", Passwordtb.Text);
                cmd.Parameters.AddWithValue("@tele", Teletb.Text);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User Successfully Added");
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

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Teletb.Text == " ")
            {
                MessageBox.Show("Enter the users phone number");
            }
            else
            {
                con.Open();
                string myquery = "delete from UserTbl where Uphone = '" + Teletb.Text + "'";
                SqlCommand cmd = new SqlCommand(myquery, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User succesfully deleted");
                con.Close();
                populate();
            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the row index is valid (avoid clicking on header)
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = UsersGV.Rows[e.RowIndex];

                // Ensure the row has data before assigning values
                if (row.Cells[0].Value != null) Unametb.Text = row.Cells[0].Value.ToString();
                if (row.Cells[1].Value != null) Fnametb.Text = row.Cells[1].Value.ToString();
                if (row.Cells[2].Value != null) Passwordtb.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value != null) Teletb.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // ✅ Correct SQL Update Syntax
                string query = "UPDATE UserTbl SET Uname = @uname, Ufullname = @fname, Upassword = @pass WHERE Uphone = @tele";

                SqlCommand cmd = new SqlCommand(query, con);

                // ✅ Add parameters to prevent SQL Injection
                cmd.Parameters.AddWithValue("@uname", Unametb.Text);
                cmd.Parameters.AddWithValue("@fname", Fnametb.Text);
                cmd.Parameters.AddWithValue("@pass", Passwordtb.Text);
                cmd.Parameters.AddWithValue("@tele", Teletb.Text);  // Fixing WHERE condition

                // ✅ Execute the query and check if a row was updated
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User Successfully Updated");
                }
                else
                {
                    MessageBox.Show("No user found with this phone number!");
                }

                con.Close();

                // ✅ Refresh DataGridView
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
