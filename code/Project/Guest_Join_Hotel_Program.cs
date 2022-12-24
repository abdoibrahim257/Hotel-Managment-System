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
    public partial class Guest_Join_Hotel_Program : Form
    {
        Controller controllerObj;
        int guestssn;
        public Guest_Join_Hotel_Program(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            guestssn = ssn;
        }

        private void Hotel_Program_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowP();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            DataTable dta = controllerObj.PrID();
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "ProgramId";
            comboBox1.ValueMember = "ProgramId";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                if ( guestssn < 0)//validation part
                {
                    MessageBox.Show("invalid input");
                }
                else
                {
                    int r = controllerObj.JoinP(comboBox1.SelectedValue.ToString(), guestssn.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    if (r == 0)
                    {
                        MessageBox.Show("Program not joined ");
                    }
                    else
                    {
                        MessageBox.Show("Program joined successfully");
                    }
                }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
