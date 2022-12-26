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
    public partial class Receptionist_BookRoom : Form
    {
        Controller controllerObject = new Controller();
        string username;
        public Receptionist_BookRoom(string user)
        {
            InitializeComponent();
            username = user;
            DataTable dt = controllerObject.SelectRoomType();
            CheckRoomTypeCombo.DataSource = dt;
            CheckRoomTypeCombo.DisplayMember = "RoomType";

            dt = controllerObject.SelectRoomView();
            CheckRoomViewCombo.DataSource = dt;
            CheckRoomViewCombo.DisplayMember = "RoomView";

            dt = controllerObject.SelectUserSSN();
            CheckUSSN.DataSource = dt;
            CheckUSSN.DisplayMember = "ReceptionistSSN";

            dt = controllerObject.SelectRoomNOFromReserveation();
            CheckRoomNO.DataSource = dt;
            CheckRoomNO.DisplayMember = "RoomID";



            dt = controllerObject.SelectRoomNOFromReserveation();
            CheckOutRoomNOCombo.DataSource = dt;
            CheckOutRoomNOCombo.DisplayMember = "RoomID";

            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckRoomAvailableBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckStartDate.Value > CheckEndDate.Value || CheckStartDate.Value < DateTime.Today)
                {
                    MessageBox.Show("Invalid dates");
                    return;
                }

                CheckRoomNO.Items.Clear();

                //int check = controllerObject.ExistRoomToReserve(CheckRoomTypeCombo.Text, CheckRoomViewCombo.Text, CheckStartDate.Text, CheckEndDate.Text);

                DataTable dt = controllerObject.SelectAvailableRoomNumber(CheckRoomTypeCombo.Text, CheckRoomViewCombo.Text, CheckStartDate.Text, CheckEndDate.Text);

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string RoomID = dt.Rows[i][0].ToString();
                    CheckRoomNO.Items.Add(RoomID);
                }

                MessageBox.Show("Room is available");
            }
            catch
            {
                MessageBox.Show("Room isn't available");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ReserveBTN_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckUSSN.Text.Length == 0 || CheckRoomNO.Text.Length == 0 || CheckRoomTypeCombo.Text.Length == 0 || CheckRoomViewCombo.Text.Length == 0)
                {
                    MessageBox.Show("Complete info pls!");
                    return;
                }

                int yy1 = CheckStartDate.Value.Year, mm1 = CheckStartDate.Value.Month;

                if (mm1 <= 2)
                {
                    yy1 = yy1 - 1;
                    mm1 = mm1 + 13;
                }

                int NoDays1 = (146097 * yy1) / 400 + (153 * mm1 + 8) / 5 + CheckStartDate.Value.Day;

                int yy2 = CheckEndDate.Value.Year, mm2 = CheckEndDate.Value.Month;

                if (mm2 <= 2)
                {
                    yy2 = yy2 - 1;
                    mm2 = mm2 + 13;
                }

                int NoDays2 = (146097 * yy2) / 400 + (153 * mm2 + 8) / 5 + CheckEndDate.Value.Day;

                int difference = NoDays2 - NoDays1;


                int check = controllerObject.InsertRerservation(CheckStartDate.Text, CheckEndDate.Text, CheckUSSN.Text, CheckRoomNO.Text, difference);
                MessageBox.Show("Room reserved");
            }
            catch
            {
                MessageBox.Show("Room reservation failed");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Receptionist myform = new Receptionist(username);
            myform.Show();
            this.Hide();
        }

        private void bookroom_Load(object sender, EventArgs e)
        {

        }
    }
    }

