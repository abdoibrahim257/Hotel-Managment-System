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
    public partial class Guest_RequestService : Form
    {
        Controller controllerObj;
        int guestssn;
        public Guest_RequestService(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            guestssn = ssn;
        }

        private void Hotel_Services_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowS();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            DataTable dta = controllerObj.SrID();
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "ServiceID";
            comboBox1.ValueMember = "ServiceID";
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
            int am = controllerObj.getservAm(comboBox1.SelectedValue.ToString());
            if (am == 0)
            {
                MessageBox.Show("invalid input");
            }
            else
            {

                if (guestssn < 0 || textBox2.Text == "" || int.Parse(textBox2.Text) < 0 || int.Parse(textBox2.Text) > am)//validation part
                {
                    MessageBox.Show("invalid input");
                }
                else
                {
                    int r = controllerObj.RequestS(guestssn.ToString(), comboBox1.SelectedValue.ToString(), textBox2.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    if (r == 0)
                    {
                        MessageBox.Show("Service is not requested ");
                    }
                    else
                    {
                        MessageBox.Show("Service requested successfully");
                        //update value
                        int s = controllerObj.UpdateAmountS(textBox2.Text, comboBox1.SelectedValue.ToString());
                        if (s == 0)
                        {
                            MessageBox.Show("updating Failed ");
                        }
                        else
                        {
                            MessageBox.Show("updating succeeded");
                            DataTable dt = controllerObj.ShowS();
                            dataGridView1.DataSource = dt;
                            dataGridView1.Refresh();

                            DataTable dta = controllerObj.SrID();
                            comboBox1.DataSource = dta;
                            comboBox1.DisplayMember = "ServiceID";
                            comboBox1.ValueMember = "ServiceID";
                        }

                    }


                }
            }
        }
       
    }
}
