using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login_reterive_Guest_password : Form
    {
        Controller controllerObj=new Controller();  
        public Login_reterive_Guest_password()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (text_username.Text == "" || textBox1.Text=="")
            {
                MessageBox.Show("Please Filled all information");
                return;

            }
            try
            {
                int existencecheck1 = controllerObj.CheckLoginPrimary(text_username.Text);
                if (existencecheck1 == 0)
                {
                    MessageBox.Show("InCorrect Username ,Try Again!");
                    return;
                }
                int result2 = controllerObj.UpdateGuestAccount(text_username.Text, textBox1.Text);
                if (result2 == 0)
                {
                    MessageBox.Show("Failed to create account. Please check your information");
                }
                else if (result2 != 0)
                {

                    MessageBox.Show("Password updated successfully");
                    Login_Signin_guest a = new Login_Signin_guest();
                    a.Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Failed to Update Password");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Signin_guest a = new Login_Signin_guest();
            a.Show();
            this.Close();
        }
    }
}
