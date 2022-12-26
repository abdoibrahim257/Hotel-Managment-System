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
    public partial class Guest_Hotel_Program : Form
    {
        Controller controllerObj;
        int guestssn;
        public Guest_Hotel_Program(int ssn)
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

            DataTable dta = controllerObj.ProcPrID();
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "ProgramId";
            comboBox1.ValueMember = "ProgramId";
            if (comboBox1.Text == "")
            {
                dataGridView1.Visible = false;
                MessageBox.Show("Sorry, No Program available right now");

            }
            else
            {
                dataGridView1.Visible = true;
            }
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
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Sorry, No Program available right now");
                dataGridView1.Visible = false;
            }
            else
            {
                int am = controllerObj.getprogca(comboBox1.SelectedValue.ToString());
                if (am == 0)
                {
                    MessageBox.Show("invalid input");
                }
                else
                {
                    DateTime start = controllerObj.getstartprog(comboBox1.SelectedValue.ToString());
                    DateTime end = controllerObj.getendprog(comboBox1.SelectedValue.ToString());
                    int st = DateTime.Compare(start, dateTimePicker1.Value.Date);
                    int ed = DateTime.Compare(end, dateTimePicker1.Value.Date);


                    if (guestssn < 0 || st>0 || ed<0)//validation part
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
                            //update value
                            //am = am - 1;
                            int s = controllerObj.UpdateProgramC(comboBox1.SelectedValue.ToString());
                            if (s == 0)
                            {
                                MessageBox.Show("updating Failed ");
                            }
                            else
                            {
                                //MessageBox.Show("updating succeeded");
                                DataTable dt = controllerObj.ShowP();
                                dataGridView1.DataSource = dt;
                                dataGridView1.Refresh();

                                DataTable dta = controllerObj.ProcPrID();
                                comboBox1.DataSource = dta;
                                comboBox1.DisplayMember = "ProgramId";
                                comboBox1.ValueMember = "ProgramId";
                            }
                        }
                    }
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
