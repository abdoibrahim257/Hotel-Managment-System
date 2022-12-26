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
    public partial class Receptionist_guestrequest : Form
    {
        Controller controllerObj = new Controller();
        int guestid;
        public Receptionist_guestrequest(int id)
        {
            InitializeComponent();
            guestid = id;
           
            
        }
        private void Hotel_Program_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.ShowP();
            DataShow.DataSource = dt;
            DataShow.Refresh();

            DataTable dta = controllerObj.PrID();
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "ProgramId";
            comboBox1.ValueMember = "ProgramId";

            DataTable dta1 = controllerObj.ShowR();
            comboBox1.DataSource = dta;
            comboBox1.DisplayMember = "RoomID";
            comboBox1.ValueMember = "RoomID";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (guestid < 0)//validation part
            {
                MessageBox.Show("invalid input");
            }
            else
            {
                int r = controllerObj.JoinP(comboBox1.SelectedValue.ToString(), guestid.ToString(), dateTimePicker1.Value.ToString("yyyy-MM-dd"));
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
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Receptionist_AddService a = new Receptionist_AddService(guestid);
            a.Show();
        }

        private void guestrequest_Load(object sender, EventArgs e)
        {

        }
    }
}
