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
            Guest_Hotel_Services a = new Guest_Hotel_Services(guestssn);
            a.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guest_Hotel_Program a = new Guest_Hotel_Program(guestssn);
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guest_Write_Feedback a = new Guest_Write_Feedback(guestssn);
            a.Show();
        }

        private void Guest_Actions_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Guest_Book_Room a = new Guest_Book_Room(guestssn);
            a.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Guest_View_Payments a = new Guest_View_Payments(guestssn);
            a.Show();
        }
    }
}
