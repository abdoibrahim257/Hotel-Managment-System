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
    public partial class Signin_Manager_Rec : Form
    {
        Controller controllerObj = new Controller();
        public Signin_Manager_Rec()
        {
            InitializeComponent();
        }

        private void Signin_Manager_Rec_Load(object sender, EventArgs e)
        {

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            string username = text_username.Text;
            string pass = text_password.Text;
            try
            {
                int result = controllerObj.ExistAccount_MGR_Rec(text_username.Text, text_password.Text);

                if (username == "" | pass == "")
                {
                    MessageBox.Show("Please, Enter All Required Information");
                }

                else if (username[0] == 'M' && username[1] == 'G' && username[2] == 'R')
                {

                    if (result == 1)
                    {
                        MessageBox.Show("Login successfully");
                        Manager_form Manager1 = new Manager_form(username, pass, null);
                        Manager1.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please, Enter Correct  password");
                    }

                }
                else if (username[0] == 'R' && username[1] == 'E' && username[2] == 'C')
                {
                    if (result == 1)
                    {
                        MessageBox.Show("Login successfully");
                        //Receptionist Receptionist1 = new Receptionist();
                        //Receptionist1.Show();
                        //this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please, Enter Correct  password");
                    }

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
    }
}
