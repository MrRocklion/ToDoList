using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace ToDoList
{
    class DbConecction
    {

        public SqlConnection cnx;
        public DbConecction()
        {
            try
            {
            String conexion = ConfigurationManager.ConnectionStrings["ToDoList.Properties.Settings.ListaTareasConnectionString"].ConnectionString;
                cnx = new SqlConnection(conexion);
                cnx.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex, "Ventana De Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
