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
    public partial class Manager_form : Form
    {
        string managerUsrName;
        string managerPassword;
        int SSN;
        Controller controllerObj;
        DataTable profitTable = null;
        public Manager_form()
        {
            InitializeComponent();

        }
        //public Manager_form(string usrName, string passWrd)
        //{
        //    InitializeComponent();
        //    controllerObj = new Controller();

        //    managerUsrName = usrName;
        //    managerPassword = passWrd;

        //    DataTable dt = controllerObj.SelectReceptionists();
        //    comboBox1.DataSource = dt;
        //    comboBox1.DisplayMember = "ReceptionistSSN";
        //    comboBox1.ValueMember = "ReceptionistSSN";
        //}

        public Manager_form(string usrName, string passWrd, DataTable profit)
        {
            InitializeComponent();
            controllerObj = new Controller();

            managerUsrName = usrName;
            managerPassword = passWrd;

            DataTable dt = controllerObj.SelectReceptionists();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ReceptionistSSN";
            comboBox1.ValueMember = "ReceptionistSSN";
            profitTable = profit;

        }

        private void Manager_form_Load(object sender, EventArgs e)
        {
            //get manager first name and last name and ssn and show in label
            string firstName, lastName;
            string ManagerName;
            DataTable dt = controllerObj.SelectEmployee(managerUsrName, managerPassword);
            if (dt != null && dt.Rows.Count > 0)
            {
                string usr = dt.Rows[0]["EmployeeUsrName"].ToString();
                if(usr[0] == 'A' && usr[1] == 'D' && usr[2] == 'N')
                {
                    label2.Text = "Admin";
                    DataTable adminInfo = controllerObj.SelectEmployee(managerUsrName, managerPassword);
                    if (adminInfo != null)
                    {
                        SSN = Convert.ToInt32(adminInfo.Rows[0]["EmployeeSSN"]);
                        label4.Text = SSN.ToString();
                    }
                }
                else if (usr[0] == 'M' && usr[1] == 'G' && usr[2] == 'R')
                {
                    firstName = dt.Rows[0]["EmployeeFname"].ToString();
                    lastName = dt.Rows[0]["EmployeeLname"].ToString();
                    SSN = Convert.ToInt32(dt.Rows[0]["EmployeeSSN"]);
                    ManagerName = firstName + " " + lastName;
                    label2.Text = ManagerName;
                    label4.Text = SSN.ToString();//
                }
                else
                {
                    MessageBox.Show("You dont have access to this form", "Error Message");
                }
            }
            else
            {
                MessageBox.Show("You Are not In employee Data", "Error Message");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //open new form to add / fire employee
            Employee_Add_Remove a = new Employee_Add_Remove(managerUsrName, managerPassword, profitTable);
            a.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //assign bonus and promote employee and fire employee
            if (comboBox1.SelectedIndex != -1)
            {
                int EmployeeSSN = Convert.ToInt32(comboBox1.SelectedValue);

                DataTable dt = controllerObj.SelectReceptionistBySSN(EmployeeSSN);
                if(dt!=null && dt.Rows.Count == 1)
                {
                    Employee_Get a = new Employee_Get(managerUsrName, managerPassword, dt, profitTable);
                    a.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error Retreiving Employee");
                }
            }
            else
                MessageBox.Show("Please select an Employee first");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service_Add_Remove a = new Service_Add_Remove(managerUsrName, managerPassword, SSN, profitTable);
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Statistics a = new Statistics(managerUsrName, managerPassword, profitTable, SSN);
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Program_Add_Remove a = new Program_Add_Remove(managerUsrName, managerPassword, SSN, profitTable);
            a.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Manager_feedback a = new Manager_feedback();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Manager_EditInfo a = new Manager_EditInfo(managerUsrName, managerPassword, profitTable, SSN);
            a.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Manager_ChangePassword a = new Manager_ChangePassword(managerPassword, SSN);
            a.Show();
        }
    }
}
