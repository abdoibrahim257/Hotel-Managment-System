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
    public partial class Receptionist : Form
    {
        Controller controllerObject = new Controller();
        string username;
        private int id;
        public Receptionist(string user)
        {
            InitializeComponent();
            username = user;
        }

        private void receptionist_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookroom a = new bookroom(username);
            a.Show();
            //this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            changepassword a = new changepassword(username);
            a.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guestrequest a = new guestrequest(id);
            a.Show();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            guestpayment a = new guestpayment(username);
            a.Show();
           // this.Hide();
        }
    }
    }

