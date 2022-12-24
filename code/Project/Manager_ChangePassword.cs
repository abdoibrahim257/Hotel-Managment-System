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
    public partial class Manager_ChangePassword : Form
    {
        Controller controllerObj;
        string managerPassword;
        int managerSSn;
        public Manager_ChangePassword(string password, int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            managerPassword = password;
            managerSSn = ssn;
        }

        private void Manager_ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                if(textBox1.Text == managerPassword)
                {
                    if(textBox2.Text == textBox3.Text)
                    {
                        //update password
                        int x = controllerObj.UpdateManagerPassword(textBox2.Text, managerSSn);
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
