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
    public partial class Statistics : Form
    {
        Controller controllerObj;

        string managerUsername, managerPassword;
        int managerSSN;
        DataTable profitTable;
        DataTable expenseTable;
        public Statistics(string usrname, string password, DataTable profit, int SSN)
        {
            controllerObj = new Controller();

            InitializeComponent();
            managerUsername = usrname;
            managerPassword = password;
            profitTable = profit;
            managerSSN = SSN;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (profitTable != null)
            {
                dataGridView2.DataSource = profitTable;
                dataGridView2.Refresh();
            }
            else
                MessageBox.Show("Request from employee the Net Income first", "Error Message");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager_form a = new Manager_form(managerUsername, managerPassword, profitTable);
            a.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expenseTable = controllerObj.SelectExpenses();
            if (expenseTable != null && expenseTable.Rows.Count > 0)
            {
                dataGridView1.DataSource = expenseTable;
                dataGridView1.Refresh();
            }
            else
                MessageBox.Show("There was no expenses recorded in the Records!, try again later");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Expenses_Add a = new Expenses_Add(managerSSN);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //get count of rows for both table
            if (profitTable != null && expenseTable != null)
            {
                int numOfExpenses = expenseTable.Rows.Count;
                int numOfIncomes = profitTable.Rows.Count;
                if (numOfExpenses == numOfIncomes)
                {
                    //check on date it equal i compute else i show error message
                    for (int i = 0; i < numOfExpenses; i++)
                    {
                        if (expenseTable.Rows[i][0].ToString() == profitTable.Rows[i][0].ToString())
                        {
                            chart1.Series["Profit"].XValueMember = expenseTable.Rows[i][0].ToString();
                            chart1.Series["Profit"].Points.AddXY(expenseTable.Rows[i][0].ToString(), (-Convert.ToDouble(expenseTable.Rows[i][1]) + Convert.ToDouble(profitTable.Rows[i][1])));
                        }
                        else
                        {
                            MessageBox.Show("Values not of same date", "Error Message");
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("there are missing Data records", "Error Message");
                }
            }
            else
                MessageBox.Show("Cant draw profit chart, due to incomplete data", "Error Message");
            
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            expenseTable = controllerObj.SelectExpenses();
        }
    }
}
