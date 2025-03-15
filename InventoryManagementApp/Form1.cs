namespace InventoryManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
                passwordtb.UseSystemPasswordChar = false;
            else
                passwordtb.UseSystemPasswordChar = true;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void usernametb_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            usernametb.Text = "";
            passwordtb.Text = "";
        }
    }
}
