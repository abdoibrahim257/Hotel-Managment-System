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
    public partial class Manager_feedback : Form
    {
        Controller controllerObj;
        public Manager_feedback()
        {
            InitializeComponent();
            controllerObj = new Controller(); 
        }

        private void feedback_Load(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectFeedBack();
            if (dt != null)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No feedbacks was written by guest, try again later", "error message");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
