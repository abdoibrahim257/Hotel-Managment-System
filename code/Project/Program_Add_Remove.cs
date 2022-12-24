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
    public partial class Program_Add_Remove : Form
    {
        Controller controllerObj;

        int managerSSN;
        string managerUsername;
        string managerPassword;
        DataTable managerProfit;
        public Program_Add_Remove(string usrName, string pass, int ssn, DataTable profit)
        {
            InitializeComponent();

            controllerObj = new Controller();

            managerUsername = usrName;
            managerPassword = pass;
            managerSSN = ssn;
            managerProfit = profit;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_form a = new Manager_form(managerUsername, managerPassword, managerProfit);
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != "" && textBox1.Text != "" && textBox5.Text !="")
            {
                int programID = Convert.ToInt32(numericUpDown1.Value);
                int x = controllerObj.InsertProgram(Convert.ToInt32(numericUpDown1.Value), textBox5.Text, Convert.ToInt32(numericUpDown2.Value), textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Convert.ToSingle(numericUpDown2.Value), managerSSN);
                if (x < 1)
                {
                    MessageBox.Show($"Program of ID = {programID} already exists", "Error Message");
                }
                else
                    MessageBox.Show($"Program of ID = {programID} is Added Successfully", "Confirmation Message");
            }
            else
            {
                MessageBox.Show("Enter A Valid Input", "Error Message");
            }

            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                int programID = Convert.ToInt32(numericUpDown1.Value);
                DataTable dt = controllerObj.SelectProgram(Convert.ToInt32(numericUpDown1.Value));
                if(dt!=null && dt.Rows.Count == 1)
                {
                    numericUpDown2.Value = Convert.ToInt32(dt.Rows[0]["ProgramCapacity"]);
                    numericUpDown3.Value = Convert.ToInt32(dt.Rows[0]["ProgramFees"]);

                    textBox1.Text = dt.Rows[0]["ProgramType"].ToString();
                    textBox2.Text = dt.Rows[0]["ProgramLocation"].ToString();
                    textBox5.Text = dt.Rows[0]["ProgramDescription"].ToString();

                    dateTimePicker1.Text = dt.Rows[0]["ProgramStartTime"].ToString();
                    dateTimePicker2.Text = dt.Rows[0]["ProgramEndTime"].ToString();

                }
                else
                    MessageBox.Show($"Program of ID = {programID} not found, Try Adding it");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox1.Text != "" && textBox5.Text != "")
            {
                int programID = Convert.ToInt32(numericUpDown1.Value);
                DataTable dt = controllerObj.SelectProgram(programID);
                if (dt != null && dt.Rows.Count > 0)
                {
                    int x = controllerObj.UpdateProgram(programID, textBox5.Text, Convert.ToInt32(numericUpDown2.Value), textBox1.Text, textBox2.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), dateTimePicker2.Value.ToString("yyyy-MM-dd"), Convert.ToSingle(numericUpDown2.Value), managerSSN);
                    if (x > 0)
                    {
                        MessageBox.Show($"Program of ID = {programID}, Updated Successfully");
                    }
                    else
                        MessageBox.Show($"Program of ID = { programID} attempt to Update was unsuccessfull");
                }
                else
                    MessageBox.Show($"Program of ID = {programID} not found, Try Adding it");
            }
            else
            {
                MessageBox.Show("Enter A Valid Input", "Error Message");
            }
        }
    }
}
