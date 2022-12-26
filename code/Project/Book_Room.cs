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
    public partial class Book_Room : Form
    {
        Controller controllerObj;
        int guestssn;
        public Book_Room(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            guestssn = ssn;
        }

        private void Book_Room_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowAvailableRoom();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            DataTable dta = controllerObj.ShowAvailableRoom();
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "RoomID";
            comboBox1.ValueMember = "RoomID";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = controllerObj.BookRoom( comboBox1.SelectedValue.ToString(), guestssn.ToString());
            if (r == 0)
            {
                MessageBox.Show("Booking Failed ");
            }
            else
            {
                MessageBox.Show("Booking succeeded");
                DataTable dt = controllerObj.ShowAvailableRoom();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                DataTable dta = controllerObj.ShowAvailableRoom();
                comboBox1.DataSource = dta;
                comboBox1.DisplayMember = "RoomID";
                comboBox1.ValueMember = "RoomID";
            }
        }
    }
}
