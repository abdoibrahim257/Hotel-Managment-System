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
    public partial class Signin_guest : Form
    {
        Controller controllerObj = new Controller();
        public Signin_guest()
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
                    MessageBox.Show("Please, Enter All Required Information");
                }

                else if (result == 1)
                {
                   
                        MessageBox.Show("Login successfully");
                        Guest Guest1 = new Guest();
                        Guest1.Show();
                        this.Hide();
                   
                }
                else
                {

                    MessageBox.Show("Please, Enter Correct Username or password");
                }
            }
            catch
            {
                MessageBox.Show("Please, Enter Correct Username or password");

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
            Signup_Guest guest2=new Signup_Guest();
            guest2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Signin_Manager_Rec Signin_Manager_Rec1=new Signin_Manager_Rec();
            Signin_Manager_Rec1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reterive_Guest_password a1=new reterive_Guest_password();
            a1.Show();
            this.Hide();
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
