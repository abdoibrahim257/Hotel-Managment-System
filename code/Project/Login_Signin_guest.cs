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
    public partial class Login_Signin_guest : Form
    {
        int guestSSN;
        Controller controllerObj = new Controller();
        public Login_Signin_guest()
        {
            InitializeComponent();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string username = text_username.Text;
            string pass = text_password.Text;
            try
            {
                int result = controllerObj.ExistAccount(text_username.Text, text_password.Text);

                if (username == "" | pass == "")
                {
                    MessageBox.Show("Please, Enter All Required Information", "Error Message");
                }

                else if (result == 1)
                {
                   
                    MessageBox.Show("Login successfully", "Confirmation Message");
                    DataTable dt = controllerObj.ProcSelectGuestID(text_username.Text, text_password.Text);
                    if(dt!=null)
                    {
                        guestSSN = Convert.ToInt32(dt.Rows[0]["Guestid"]);
                        Guest_Actions a = new Guest_Actions(guestSSN);
                        a.Show();
                        this.Hide();
                    }
                   
                }
                else
                {

                    MessageBox.Show("Please, Enter Correct Username or password", "Error Message");
                }
            }
            catch
            {
                MessageBox.Show("Please, Enter Correct Username or password", "Error Message");

            }
        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            Login_Signup_Guest guest2=new Login_Signup_Guest();
            guest2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Manager_Rec Signin_Manager_Rec1=new Login_Manager_Rec();
            Signin_Manager_Rec1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_reterive_Guest_password a1=new Login_reterive_Guest_password();
            a1.Show();
            this.Hide();
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void text_username_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
