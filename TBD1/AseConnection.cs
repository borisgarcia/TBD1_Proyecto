using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBD1
{
    class AseConnection
    {
        public static OdbcConnection Connect()
        {
            OdbcConnection con = null;
            string conString = "Dsn=Sybase2;uid=sa;pwd=BorisGarcia17";
            con = new OdbcConnection(conString);
            con.Open();
            return con;
        }

        public static void Close(OdbcConnection con)
        {
            con.Close();
        }


        public static void messageBox(string mensaje)
        {
            string caption = "Mi Cooperativa";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(mensaje, caption, buttons);
        }
    }
}
