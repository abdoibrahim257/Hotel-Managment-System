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
    public partial class Employee_Get : Form
    {
        Controller controllerObj;

        string managerUsrName;
        string managerPassword;
        DataTable dt;
        DataTable ProfitTable = null;

        public Employee_Get(string Usrname, string Pass, DataTable Employee, DataTable profit)
        {
            InitializeComponent();
            controllerObj = new Controller();

            managerUsrName = Usrname;
            managerPassword = Pass;
            dt = Employee;
            ProfitTable = profit;
        }
        private void Employee_Get_Load(object sender, EventArgs e)
        {
            label12.Text = dt.Rows[0]["ManagerSSN"].ToString();
            label2.Text = dt.Rows[0]["EmployeeFname"].ToString();
            label4.Text = dt.Rows[0]["EmployeeLname"].ToString();
            label6.Text = dt.Rows[0]["ReceptionistSSN"].ToString();
            label8.Text = dt.Rows[0]["EmployeeUsrName"].ToString();
            label10.Text = dt.Rows[0]["EmployeeAge"].ToString();
            label14.Text = dt.Rows[0]["EmployeePhone"].ToString();
            numericUpDown1.Value = Convert.ToInt32(dt.Rows[0]["EmployeeSalary"]);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_form a = new Manager_form(managerUsrName, managerPassword, ProfitTable);
            a.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string value = "";
            System.Windows.Forms.DialogResult dr = MessageBox.Show("Are you sure you want to Fire this Employee?", "Firing Employee", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    if(InputBox("Confirmation", "Enter password of the Employee:", ref value) == DialogResult.OK)
                    {
                        if (value == dt.Rows[0]["EmployeePass"].ToString())
                        {
                            //call delete query
                            int x = controllerObj.DeleteEmployee(Convert.ToInt32(dt.Rows[0]["ReceptionistSSN"]));
                            if (x > 0)
                            {
                                MessageBox.Show("Employee Got Fired");
                                Manager_form a = new Manager_form(managerUsrName, managerPassword, ProfitTable);
                                a.Show();
                                this.Hide();
                            }
                            else
                                MessageBox.Show("Deletion of employee was unsuccessfull");
                        }
                        else
                            MessageBox.Show("Incorrect Password");
                    }
                    break;
                case System.Windows.Forms.DialogResult.No:
                    break;
            }

        }

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            textBox.PasswordChar = '*';

            form.Text = title;
            label.Text = promptText;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(26, 20, 372, 13);
            textBox.SetBounds(26, 40, 300, 20);
            buttonOk.SetBounds(125, 70, 100, 30);
            buttonCancel.SetBounds(230, 70, 100, 30);

            label.AutoSize = true;
            form.ClientSize = new Size(350, 120);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;

            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();

            value = textBox.Text;
            return dialogResult;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProfitTable = controllerObj.SelectProfit();
            if (ProfitTable != null && ProfitTable.Rows.Count > 0)
            {
                MessageBox.Show("Income data retreived successfully, go to 'Calculate Profit' in Manager Menu to view it", "Confirmation Message");
            }
            else
                MessageBox.Show("Not data was recorded in the Income Table, Check with your employee");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = controllerObj.UpdateBonus(Convert.ToInt32(dt.Rows[0]["ReceptionistSSN"]), Convert.ToInt32(numericUpDown2.Value), Convert.ToInt32(dt.Rows[0]["ManagerSSN"])); 
            if ( x == 1)
            {
                MessageBox.Show($"Bonus is added to Employee with ID = {Convert.ToInt32(dt.Rows[0]["ReceptionistSSN"])} successfully", "Confirmation Message");
            }
            else
                MessageBox.Show($"Unable to add Bonus to Employee with ID = {Convert.ToInt32(dt.Rows[0]["ReceptionistSSN"])}", "Error Message");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = controllerObj.UpdateSalary(Convert.ToInt32(dt.Rows[0]["ReceptionistSSN"]), Convert.ToInt32(numericUpDown1.Value));
            if(x == 1)
            {
                MessageBox.Show($"Salary of Employee with ID = {Convert.ToInt32(dt.Rows[0]["ReceptionistSSN"])}, is updated successfully", "Confirmation Message");
            }
            else
                MessageBox.Show($"Unable to Update salary of Employee with ID = {Convert.ToInt32(dt.Rows[0]["ReceptionistSSN"])}", "Error Message");
        }
    }
}
