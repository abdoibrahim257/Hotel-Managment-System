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
    public partial class Admin : Form
    {
        int adminSSN;
        string adminUsername, adminPassword;
        int SSN;
        Controller controllerObj;
        
        public Admin(string username, string password)
        {
            InitializeComponent();

            controllerObj = new Controller();

            adminUsername = username;
            adminPassword = password;

            DataTable dt = controllerObj.SelectEmployee(adminUsername, adminPassword);

            if(dt!=null)
                adminSSN = Convert.ToInt32(dt.Rows[0]["EmployeeSSN"]);


            comboBox1.Items.Add("M");
            comboBox1.Items.Add("F");


            comboBox2.Items.Add("Single");
            comboBox2.Items.Add("Married");
            comboBox2.Items.Add("Divorced");
            comboBox2.Items.Add("Widowed");
            comboBox2.Items.Add("Separated");

            comboBox3.Items.Add("M");
            comboBox3.Items.Add("F");


            comboBox6.Items.Add("Single");
            comboBox6.Items.Add("Married");
            comboBox6.Items.Add("Divorced");
            comboBox6.Items.Add("Widowed");
            comboBox6.Items.Add("Separated");
            DataTable managers = controllerObj.SelectManager();
            if (managers != null)
            {
                comboBox5.DataSource = managers;
                comboBox5.DisplayMember = "ManagerSSN";
                comboBox5.ValueMember = "ManagerSSN";
            }
            else 
            { 
                comboBox5.Items.Add("");
            }
            DataTable usersWithNoLogin = controllerObj.SelectEmployessWithNoLogin();

            if (usersWithNoLogin != null)
            {
                label30.Text = usersWithNoLogin.Rows[0]["EmployeeUsrName"].ToString();

                comboBox4.DataSource = usersWithNoLogin;
                comboBox4.DisplayMember = "EmplyeeSSN";
                comboBox4.ValueMember = "EmployeeSSN";
            }
            else
            {
                comboBox4.Items.Add("");
            }


        }



        private void button7_Click(object sender, EventArgs e)
        {
            Manager_form a = new Manager_form(adminUsername, adminPassword, null);
            a.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

       
        private void comboBox4_DropDownClosed(object sender, EventArgs e)
        {
            string selected = comboBox4.Text;
            DataTable dt = controllerObj.SelectEmployessWithNoLogin(Convert.ToInt32(selected));
            label30.Text = dt.Rows[0]["EmployeeUsrName"].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_ChangePassword a = new Admin_ChangePassword(adminPassword, adminSSN);
            a.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void MgrView_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox8.Text!="" && textBox9.Text!="" && comboBox4.SelectedIndex!=-1)
            {
                string usr = textBox8.Text;
                if(label30.Text == "m" && usr[0] == 'M' && usr[1] == 'G' && usr[2] =='R')
                {
                    int x = controllerObj.UpdateEmployeeAccount(textBox8.Text, textBox9.Text, Convert.ToInt32(comboBox4.SelectedValue));
                    if(x == 1)
                    {
                        MessageBox.Show($"You added account to Manager with SSN = {Convert.ToInt32(comboBox4.SelectedValue)}", "Confirmation Message");
                    }
                    else
                    {
                        MessageBox.Show($"Coouldn't add account to Manager with SSN = {Convert.ToInt32(comboBox4.SelectedValue)}", "Error Message");
                    }
                }
                else if (label30.Text == "r" && usr[0] == 'R' && usr[1] == 'E' && usr[2] == 'C')
                {
                    int x = controllerObj.UpdateEmployeeAccount(textBox8.Text, textBox9.Text, Convert.ToInt32(comboBox4.SelectedValue));
                    if (x == 1)
                    {
                        MessageBox.Show($"You added account to Receptionist with SSN = {Convert.ToInt32(comboBox4.SelectedValue)}", "Confirmation Message");
                    }
                    else
                    {
                        MessageBox.Show($"Coouldn't add account to Receptionist with SSN = {Convert.ToInt32(comboBox4.SelectedValue)}", "Error Message");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Username for the employee, try again", "Error Message");
                }
            }
            else
                MessageBox.Show("Invalid data inputs, try again", "Error Message");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int SSNValue;

            if (comboBox5.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Value ");

            }

            else
            {
                SSNValue= Convert.ToInt32(comboBox5.SelectedValue);
                int x = controllerObj.DeleteEmployee(SSNValue);
                if (x == 1)
                {
                    MessageBox.Show("Manager is fired Sucessfully");
                    DataTable managers = controllerObj.SelectManager();
                    if (managers != null)
                    {
                        comboBox5.DataSource = managers;
                        comboBox5.DisplayMember = "ManagerSSN";
                        comboBox5.ValueMember = "ManagerSSN";
                    }
                    else
                    {
                        comboBox5.Items.Add("");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to fire Manager,Check SSN");

                }

            } 

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (text_fname1.Text == "" || text_minit1.Text == "" || text_lname1.Text == "" || text_username1.Text == "" || text_password1.Text == "" || text_ssn1.Text == "" || text_mobile1.Text == "" || age_txt1.Text == "" || AddressMGR1.Text == "" || numericUpDown2.Value == 0 || comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the information required");
                return;

            }
            try
            {
                int existencecheck = controllerObj.CheckIfADNExists(text_ssn1.Text);
                int existencecheck1 = controllerObj.CheckLoginADNPrimary(text_username1.Text);
                if (existencecheck != 0 || existencecheck1 != 0)
                {
                    MessageBox.Show("Failed to create account. Account already exists with ID or USERNAME");
                    return;
                }
                int SSNValue;
                if (Int32.TryParse(text_ssn1.Text, out SSNValue))
                {
                    if (SSNValue < 0)
                    {
                        MessageBox.Show("Please Enter a Positive Value in Guest Id");
                        return;
                    }

                }
                int Value1;
                if (!(Int32.TryParse(text_mobile1.Text, out Value1)))
                {


                    MessageBox.Show("Please Enter a Positive Value in Mobile");
                    return;


                }
                if (Int32.TryParse(text_mobile1.Text, out Value1))
                {
                    if (Value1 < 0)
                    {
                        MessageBox.Show("Please Enter a Positive Value in Mobile");
                        return;
                    }

                }
                int value11;
                if (Int32.TryParse(age_txt1.Text, out value11))
                {
                    if (value11 < 0 || value11 > 100)
                    {
                        MessageBox.Show("Please Enter a Proper Value For Age");
                        return;
                    }

                }
                int value5;
                if (Int32.TryParse(text_username1.Text, out value5))
                {
                    if (value5 < 0)
                    {
                        MessageBox.Show("Please Cahnge Negative User Name");
                        return;
                    }

                }
                int Value2, Value3, Value4, Value44;
                if (Int32.TryParse(text_fname1.Text, out Value2) || Int32.TryParse(text_minit1.Text, out Value3) || Int32.TryParse(text_lname1.Text, out Value4))
                {
                    MessageBox.Show("Please Enter First or Middle or Last Name in Alphapet(Not integer Values)");
                    return;

                }
                if (Int32.TryParse(AddressMGR1.Text, out Value44))
                {
                    MessageBox.Show("Please Enter Address in Alphapet(Not integer Values)");
                    return;

                }
                string username = text_username1.Text;
                if (username[0] == 'A' && username[1] == 'D' && username[2] == 'N')
                {
                    int result = controllerObj.InsertAdmin(Convert.ToInt32(text_ssn1.Text), text_username1.Text.ToString(), text_password1.Text.ToString(), text_fname1.Text, text_minit1.Text, text_lname1.Text, Convert.ToInt32(age_txt1.Text), comboBox1.Text, AddressMGR1.Text, text_mobile1.Text.ToString(), Convert.ToInt16(numericUpDown2.Value), comboBox2.Text);
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to create account. Please check your information1");
                        return;
                    }
                    else if (result != 0)
                    {

                        MessageBox.Show("Account added successfully");
                    }
                }
                else
                {
                    MessageBox.Show("Please Manager Start With A D N");
                }
            }
            catch
            {
                MessageBox.Show("Failed to create account For ADMIN. Please check your information2");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AddMGR_Click(object sender, EventArgs e)
        {
            if (text_fname.Text == "" || text_minit.Text == "" || text_lname.Text == "" || text_username.Text == "" || text_password.Text == "" || text_ssn.Text == "" || text_mobile.Text == "" || age_txt.Text=="" || AddressMGR.Text == "" || numericUpDown1.Value==0 || comboBox3.SelectedIndex==-1 || comboBox6.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the information required");
                return;

            }
            try
            {
                int existencecheck = controllerObj.CheckIfMGRExists(text_ssn.Text);
                int existencecheck1 = controllerObj.CheckLoginMGRPrimary(text_username.Text);
                if (existencecheck != 0 || existencecheck1 != 0)
                {
                    MessageBox.Show("Failed to create account. Account already exists with ID or USERNAME");
                    return;
                }
                int SSNValue;
                if (Int32.TryParse(text_ssn.Text, out SSNValue))
                {
                    if (SSNValue < 0)
                    {
                        MessageBox.Show("Please Enter a Positive Value in Guest Id");
                        return;
                    }

                }
                int Value1;
                if (!(Int32.TryParse(text_mobile.Text, out Value1)))
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
                int value11;
                if (Int32.TryParse(age_txt.Text, out value11))
                {
                    if (value11 < 0 || value11>100)
                    {
                        MessageBox.Show("Please Enter a Positive Value in Age");
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
                int Value2, Value3, Value4,Value44;
                if (Int32.TryParse(text_fname.Text, out Value2) || Int32.TryParse(text_minit.Text, out Value3) || Int32.TryParse(text_lname.Text, out Value4))
                {
                    MessageBox.Show("Please Enter First or Middle or Last Name in Alphapet(Not integer Values)");
                    return;

                }
                if (Int32.TryParse(AddressMGR.Text, out Value44) )
                {
                    MessageBox.Show("Please Enter Address in Alphapet(Not integer Values)");
                    return;

                }
               string username=text_username.Text;
                if (username[0] == 'M' && username[1] == 'G' && username[2] == 'R')
                {
                    int result = controllerObj.InsertMgrEmployee_FromADN(Convert.ToInt32(text_ssn.Text), text_username.Text.ToString(), text_password.Text.ToString(), text_fname.Text, text_minit.Text, text_lname.Text, Convert.ToInt32(age_txt.Text), comboBox3.Text, AddressMGR.Text, text_mobile.Text.ToString(), Convert.ToInt16(numericUpDown1.Value), comboBox6.Text);
                    int result2 = controllerObj.ManagerAccount(text_ssn.Text,dateTimePicker1.Value.ToString("yyyy-MM-dd")); 
                    if (result == 0)
                    {
                        MessageBox.Show("Failed to create account. Please check your information1");
                        return;
                    }
                    else if (result != 0 && result2!=0)
                    {

                        MessageBox.Show("Account added successfully");



                    }
                }
                else 
                {
                    MessageBox.Show("Please Manager Start With M G R");
                }
            }
            catch
            {
                MessageBox.Show("Failed to create account For Manager. Please check your information2");
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectEmployee(adminUsername, adminPassword);
            if (dt != null)
            {
                SSN = Convert.ToInt32(dt.Rows[0]["EmployeeSSN"]);
               
            }
            Admin_EditInfo a = new Admin_EditInfo(adminUsername, adminPassword,dt,SSN);
            a.Show();
            this.Hide();
            
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

    }
}
