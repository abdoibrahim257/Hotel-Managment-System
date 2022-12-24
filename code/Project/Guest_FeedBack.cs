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
    public partial class Guest_FeedBack : Form
    {
        Controller controllerObj;
        int guestssn;
        public Guest_FeedBack(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            guestssn = ssn;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = new string[] { "Room", "Service provided", "Program provided" };
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void feedbackMeal_Click(object sender, EventArgs e)
        {
            if ( guestssn < 0 || Mdesc.Text == "" )//validation part
            {
                MessageBox.Show("invalid input");
            }
            else
            {
                int r = controllerObj.Feedback(guestssn.ToString(), comboBox1.Text, dateTimePicker1.Value.ToString("yyyy-MM-dd"), Mdesc.Text);
                if (r == 0)
                {
                    MessageBox.Show("Feedback is not submitted ");
                }
                else
                {
                    MessageBox.Show("Feedback submitted successfully");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
