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
    public partial class Manager_Employee_Add_Remove : Form
    {
        Controller controllerObj;
        string managerUsrName;
        string managerPassword;
        DataTable managerProfit;
        public Manager_Employee_Add_Remove(string Usrname, string Pass, DataTable profit)
        {
            InitializeComponent();
            controllerObj = new Controller();

            managerUsrName = Usrname;
            managerPassword = Pass;
            managerProfit = profit;

            comboBox1.Items.Add("M");
            comboBox1.Items.Add("F");


            comboBox2.Items.Add("Single");
            comboBox2.Items.Add("Married");
            comboBox2.Items.Add("Divorced");
            comboBox2.Items.Add("Widowed");
            comboBox2.Items.Add("Separated");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_form a = new Manager_form(managerUsrName, managerPassword, managerProfit);
            a.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Employee_Add_Remove_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text!="" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                int x = controllerObj.InsertRecEmployee(Convert.ToInt32(numericUpDown1.Value), textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(numericUpDown2.Value), Convert.ToChar(comboBox1.Text), textBox5.Text, textBox4.Text, Convert.ToSingle(numericUpDown3.Value), comboBox2.Text.ToString()); 
                if(x == 1)
                {
                    MessageBox.Show($"Employee with ID = {Convert.ToInt32(numericUpDown1.Value)}, is added Successfully", "Confirmation Message");
                }
                else
                    MessageBox.Show($"Employee with ID = {Convert.ToInt32(numericUpDown1.Value)}, already exists", "Error Message");
            }
            else
                MessageBox.Show($"Enter valid input", "Error Message");
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
