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
    public partial class Manager_Expenses_Add : Form
    {
        int managerSSN;
        Controller controllerObj;
        public Manager_Expenses_Add(int ssn)
        {
            controllerObj = new Controller();

            InitializeComponent();
            managerSSN = ssn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = controllerObj.InsertExpenses(Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(numericUpDown2.Value), dateTimePicker1.Value.ToString("yyyy-MM-dd"), textBox1.Text, managerSSN);
            if ( x > 0)
            {
                MessageBox.Show("Expenses Recorded successfully");
            }
            else
            {
                MessageBox.Show($"Expense with ID = {Convert.ToInt32(numericUpDown1.Value)}, already recorded");
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
