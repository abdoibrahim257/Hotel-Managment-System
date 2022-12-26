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
    public partial class Receptionist_guestpayment : Form
    {
        Controller controllerObject = new Controller();
        string username;
        public Receptionist_guestpayment(string user)
        {
            InitializeComponent();
            username = user;
            DataTable dt = controllerObject.SelectRoomNOFromReserveation();
            dt = controllerObject.SelectRoomNOFromReserveation();
            BillRoomNoCombo.DataSource = dt;
            BillRoomNoCombo.DisplayMember = "RoomID";
        }

        private void guestpayment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObject.SelectRoomPrice(BillRoomNoCombo.Text);
            CheckBillGrid.DataSource = dt;
            CheckBillGrid.Refresh();
        }
    }
}
