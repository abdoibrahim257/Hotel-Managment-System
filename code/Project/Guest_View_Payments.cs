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
    public partial class Guest_View_Payments : Form
    {
        Controller controllerObj;
        int guestssn;
        public Guest_View_Payments(int ssn)
        {
            InitializeComponent();
            controllerObj = new Controller();
            guestssn = ssn;
        }

        private void View_Payments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DataTable hamada = controllerObj.ShowGuestRoom(guestssn.ToString());
            //if (hamada != null)
            //{
            object float1 = controllerObj.TotalBook(guestssn.ToString());
            object float2 = controllerObj.TotalSer(guestssn.ToString());
            object float3 = controllerObj.TotalProg(guestssn.ToString());
            

            if (float1.ToString() == "" )
                textBox1.Text = "0";
            else
                textBox1.Text = float1.ToString();



            if (float2.ToString() == "")
                textBox2.Text = "0";
            else
                textBox2.Text = float2.ToString();


            if (float3.ToString() == "")
               textBox3.Text = "0";
            else
                textBox3.Text = float3.ToString();


            //object float3 = controllerObj.TotalSer(guestssn.ToString());
            float total = float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text);
            //textBox1.Text = float1.ToString();
            //textBox2.Text = float2.ToString();
            //textBox3.Text = float3.ToString();
            //textBox4.Text = total.ToString();
            //Single total = float1 + float2 + float3;
            textBox4.Text = total.ToString();

        }
    }
}
