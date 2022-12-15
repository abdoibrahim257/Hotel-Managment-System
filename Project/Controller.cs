using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public class Controller
    {
        //bassanttttt
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        //insert, update, delete query uses ExecuteNonQuery and return int
        //select query ---> ExecuteReader and return datatable

        //insert any query function here

    }
}
