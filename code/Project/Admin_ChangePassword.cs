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
    public partial class Admin_ChangePassword : Form
    {
        string adminPassword;
        int adminSSN;
        Controller controllerObj;
        public Admin_ChangePassword(string password, int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            adminPassword = password;
            adminSSN = ssn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox1.Text == adminPassword)
                {
                    if (textBox2.Text == textBox3.Text)
                    {
                        //update password
                        int x = controllerObj.UpdateAdminPassword(textBox2.Text, adminSSN);
                        if (x == 1)
                        {
                            MessageBox.Show("Password Updated Successfully", "Confirmation Message");
                        }
                        else
                            MessageBox.Show("Password did not Update successfully", "Error Message");
                    }
                    else
                    {
                        MessageBox.Show("Password Doesnt Match", "Error Message");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Current Password", "Error Message");
                }
            }
            else
                MessageBox.Show("Please Enter Data int Required Field", "Error Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
