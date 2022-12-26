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
    public partial class Receptionist_AddService : Form
    {
        Controller controllerObj = new Controller();
        int guestid;
        public Receptionist_AddService(int id)
        {
            InitializeComponent();
            guestid = id;
        }

        private void label4_Click(object sender, EventArgs e)
        {

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

                if (guestid < 0 || textBox1.Text == "" || int.Parse(textBox1.Text) < 0 || int.Parse(textBox1.Text) > am)//validation part
                {
                    MessageBox.Show("invalid input");
                }
                else
                {
                    int r = controllerObj.RequestS(guestid.ToString(), comboBox1.SelectedValue.ToString(), textBox1.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                    if (r == 0)
                    {
                        MessageBox.Show("Service is not requested ");
                    }
                    else
                    {
                        MessageBox.Show("Service requested successfully");
                        //update value
                        int s = controllerObj.UpdateAmountS(textBox1.Text, comboBox1.SelectedValue.ToString());
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
