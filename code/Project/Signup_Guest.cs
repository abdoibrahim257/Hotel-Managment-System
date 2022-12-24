using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Project
{
    public partial class Signup_Guest : Form
    {
        Controller controllerObject = new Controller();
        public Signup_Guest()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            string gender = "M";
            if (radiobtn_female.Checked)
            {
                gender = "F";
            }
            if ((radiobtn_female.Checked == false && radiobtn_male.Checked == false) || text_fname.Text == "" || text_minit.Text == "" || text_lname.Text == "" || text_username.Text == "" || text_password.Text == "" || text_ssn.Text == "" || text_mobile.Text == "")
            {
                MessageBox.Show("Please fill all the information required");
                return;

            }
            try
            {
                int existencecheck = controllerObject.CheckIfUserExists(text_ssn.Text);
                int existencecheck1 = controllerObject.CheckLoginPrimary(text_username.Text);
                if (existencecheck != 0 || existencecheck1 != 0)
                {
                    MessageBox.Show("Failed to create account. Account already exists with ID or USERNAME");
                    return;
                }
                int SSNValue;
                if (!(Int32.TryParse(text_ssn.Text, out SSNValue)) )
                {
                    if (SSNValue < 0)
                    {
                        MessageBox.Show("Please Enter a Positive Value in Guest Id");
                        return;
                    }

                }
                int Value1;
                if (!(Int32.TryParse(text_mobile.Text, out Value1)) )
                {
                   
                    
                        MessageBox.Show("Please Enter a Positive Value in Mobile");
                        return;
                    

                }
                if (Int32.TryParse(text_mobile.Text, out Value1))
                {
                    if (Value1 < 0)
                    {
                        MessageBox.Show("Please Enter a Positive Value in Mobile");
                        return;
                    }

                }
                int value5;
                if (Int32.TryParse(text_username.Text, out value5))
                {
                    if (value5 < 0)
                    {
                        MessageBox.Show("Please Cahnge Negative User Name");
                        return;
                    }

                }
                int Value2, Value3, Value4;
                if (Int32.TryParse(text_fname.Text, out Value2) || Int32.TryParse(text_minit.Text, out Value3) || Int32.TryParse(text_lname.Text, out Value4))
                {
                    MessageBox.Show("Please Enter First or Middle or Last Name in Alphapet(Not integer Values)");
                    return;

                }
                int result = controllerObject.InsertGuest(text_ssn.Text, text_fname.Text, text_minit.Text, text_lname.Text,  gender,  text_mobile.Text);
                    int result2 = controllerObject.GuestAccount(text_username.Text, text_password.Text, text_ssn.Text);
                    if (result == 0 && result2==0)
                    {
                        MessageBox.Show("Failed to create account. Please check your information1");
                    }
                    else if (result != 0 && result2 != 0)
                    {
                       
                        MessageBox.Show("Account added successfully");
                        //Guest a1=new Guest();
                        //a1.Show();
                       // this.Hide();
                        
                        
                    }
            }
            catch
            {
                MessageBox.Show("Failed to create account. Please check your information2");
            }
        }

        private void text_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_ssn_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click_1(object sender, EventArgs e)
        {

        }
    }
}
