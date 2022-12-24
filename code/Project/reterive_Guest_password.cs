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
    public partial class reterive_Guest_password : Form
    {
        Controller controllerObj=new Controller();  
        public reterive_Guest_password()
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
                    //Guest a1= new Guest();
                    a1.Show();
                    this.Hide();
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
    }
}
