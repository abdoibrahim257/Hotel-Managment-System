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

            DataTable usersWithNoLogin = controllerObj.SelectEmployessWithNoLogin();
            label30.Text = usersWithNoLogin.Rows[0]["EmployeeUsrName"].ToString();
            comboBox4.DataSource = usersWithNoLogin;
            comboBox4.DisplayMember = "EmplyeeSSN";
            comboBox4.ValueMember = "EmployeeSSN";

            DataTable managers = controllerObj.SelectManager();
            comboBox5.DataSource = managers;
            comboBox5.DisplayMember = "ManagerSSN";
            comboBox5.ValueMember = "ManagerSSN";
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

        private void comboBox4_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

    }
}
