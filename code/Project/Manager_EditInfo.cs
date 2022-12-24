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
    public partial class Manager_EditInfo : Form
    {
        int managerSSN;
        Controller ControllerObj;
        string managerUsername, managerPassord;
        DataTable dt;
        public Manager_EditInfo(string username, string password, DataTable dt2, int ssn)
        {
            InitializeComponent();

            ControllerObj = new Controller();

            managerUsername = username;
            managerPassord = password;
            managerSSN = ssn;
            dt = dt2;

            comboBox1.Items.Add('M');
            comboBox1.Items.Add('F');
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBox2.Items.Add("Single");
            comboBox2.Items.Add("Married");
            comboBox2.Items.Add("Divorced");
            comboBox2.Items.Add("Widowed");
            comboBox2.Items.Add("Separated");
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            label2.Text = username;
            label4.Text = ssn.ToString();       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                int x = ControllerObj.UpdateManagerInfo(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToChar(comboBox1.Text), comboBox2.Text,textBox5.Text, managerSSN);
                if (x == 1)
                {
                    MessageBox.Show("Information is Updated Successfully", "confirmation Message");
                }
                else
                    MessageBox.Show("Failed to update your Information", "Error Message");
            }
            else
                MessageBox.Show("Enter Valid Inputs", "Error Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_form a = new Manager_form(managerUsername, managerPassord, dt);
            a.Show();
            this.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Manager_EditInfo_Load(object sender, EventArgs e)
        {
            DataTable dt2 = ControllerObj.SelectManagerByUsr(managerUsername, managerPassord);
            if (dt2 != null && dt2.Rows.Count > 0)
            {
                textBox1.Text = dt2.Rows[0]["EmployeeFname"].ToString();
                textBox2.Text = dt2.Rows[0]["EmployeeMini"].ToString();
                textBox3.Text = dt2.Rows[0]["EmployeeLname"].ToString();
                textBox4.Text = dt2.Rows[0]["EmployeeAddress"].ToString();
                textBox5.Text = dt2.Rows[0]["EmployeePhone"].ToString();

                numericUpDown1.Value = Convert.ToInt32(dt2.Rows[0]["EmployeeAge"]);
                comboBox1.SelectedItem = Convert.ToChar(dt2.Rows[0]["EmployeeGender"]);
                comboBox2.SelectedItem = Convert.ToString(dt2.Rows[0]["MaritalStat"]);
            }
            else
                MessageBox.Show("Error Retrieving Data", "Error Message");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
