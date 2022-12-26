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
    public partial class Guest_Actions : Form
    {
        int guestssn;
        public Guest_Actions(int ssn)
        {
            InitializeComponent();
            guestssn = ssn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hotel_Services a = new Hotel_Services(guestssn);
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel_Program a = new Hotel_Program(guestssn);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Feedback a = new Feedback(guestssn);
            a.Show();
        }

        private void Guest_Actions_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Book_Room a = new Book_Room(guestssn);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            View_Payments a = new View_Payments(guestssn);
            a.Show();
        }
    }
}
