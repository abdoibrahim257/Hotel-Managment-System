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
    public partial class Guest_information : Form
    {
        Controller controllerObj;
        int guestssn;
        public Guest_information()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new string[] { "M", "F" };
        }

        private void fNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void mInitxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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
            if (fNametxt.Text == "" || mInitxt.Text == "" || lNametxt.Text == "" || textBox1.Text == "" || textBox2.Text == "" || int.Parse(textBox1.Text) < 0 || int.Parse(textBox2.Text) < 0)//validation part
            {
                MessageBox.Show("invalid input");
            }
            else
            {
                guestssn = Convert.ToInt32(textBox2.Text);
                int r = controllerObj.InsertG(textBox2.Text, fNametxt.Text, mInitxt.Text, lNametxt.Text, comboBox1.Text, textBox1.Text);
                if (r == 0)
                {
                    MessageBox.Show("Guest not inserted ");
                }
                else
                {
                    MessageBox.Show("Guest inserted successfully");
                    Guest_Actions a = new Guest_Actions(guestssn);
                    a.Show();
                }
            }
        }

    }
}
