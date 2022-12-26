using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class Admin_EditInfo : Form
    {
        string adminUsername, adminPassword;
        DataTable dt2;
        Controller ControllerObj = new Controller();
        int ssn;
        public Admin_EditInfo(string username, string password,DataTable dt,int SSN)
        {
            InitializeComponent();
           

            adminUsername = username;
            adminPassword = password;
            dt2 = dt;
            ssn=SSN;
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
            {
                MessageBox.Show("Error Retrieving Data", "Error Message");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                int Value1;
                if (!(Int32.TryParse(textBox5.Text, out Value1)))
                {
                    MessageBox.Show("Please Enter a Positive Value in Mobile");
                    return;
                }
                if (Int32.TryParse(textBox5.Text, out Value1))
                {
                    if (Value1 < 0)
                    {
                        MessageBox.Show("Please Enter a Positive Value in Mobile");
                        return;
                    }
                }
                int Value2, Value3, Value4, Value44;
                if (Int32.TryParse(textBox1.Text, out Value2) || Int32.TryParse(textBox2.Text, out Value3) || Int32.TryParse(textBox3.Text, out Value4) || Int32.TryParse(textBox4.Text, out Value44))
                {
                    MessageBox.Show("Please Enter First or Middle or Last Name or Address in Alphapet(Not integer Values)");
                    return;

                }
                int x = ControllerObj.UpdateAdminInfo(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(numericUpDown1.Value), Convert.ToChar(comboBox1.Text), comboBox2.Text, textBox5.Text, ssn);
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
            Admin a = new Admin(adminUsername, adminPassword);
            a.Show();
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Admin_EditInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
