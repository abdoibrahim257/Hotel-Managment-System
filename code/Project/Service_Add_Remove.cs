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
    public partial class Service_Add_Remove : Form
    {
        Controller controllerObj;
        string managerUsrName;
        string managerPassword;
        int ManagerSSN;
        DataTable managerProfit = null;
        public Service_Add_Remove(string UsrName, string Pass, int Manager_SSN, DataTable profit)
        {
            InitializeComponent();

            controllerObj = new Controller();

            ManagerSSN = Manager_SSN;
            managerPassword = Pass;
            managerUsrName = UsrName;
            managerProfit = profit;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_form a = new Manager_form(managerUsrName, managerPassword, managerProfit);
            a.Show();
            this.Hide();
        }

        private void Service_Add_Remove_Load(object sender, EventArgs e)
        {

        }

        private void Service_Add_Remove_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int serviceID = Convert.ToInt32(numericUpDown1.Value);
            int x = controllerObj.InsertService(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(numericUpDown3.Value), ManagerSSN);
            if (x > 0)
            {
                MessageBox.Show($"Service of ID = {serviceID} is Added successfully");
            }
            else
                MessageBox.Show($"Service of ID = {serviceID} Already Exists");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int serviceID = Convert.ToInt32(numericUpDown1.Value);
            DataTable dt = controllerObj.SelectService(serviceID);
            if (dt != null && dt.Rows.Count == 1)
            {
                textBox1.Text = dt.Rows[0]["ServiceType"].ToString();
                numericUpDown2.Value = Convert.ToInt32(dt.Rows[0]["ServiceAmount"]);
                numericUpDown3.Value = Convert.ToDecimal(dt.Rows[0]["ServicePrice"]);
            }
            else
                MessageBox.Show($"Service of ID = {serviceID} not found, Try Adding it");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int serviceID = Convert.ToInt32(numericUpDown1.Value);
            DataTable dt = controllerObj.SelectService(serviceID);
            if (dt != null && dt.Rows.Count == 1)
            {
                int x = controllerObj.UpdateService(serviceID, textBox1.Text, Convert.ToInt32(numericUpDown2.Value), Convert.ToSingle(numericUpDown3.Value), ManagerSSN);
                if (x > 0)
                {
                    MessageBox.Show($"Service of ID = {serviceID}, Updated successfully");
                }
                else
                    MessageBox.Show($"Service of ID = {serviceID} attempt to Update was unsuccessfull");
            }
            else
                MessageBox.Show($"Service of ID = {serviceID} not found, Try Adding it");
        }
    }
}
