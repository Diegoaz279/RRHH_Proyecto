using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace RRHH_Proyecto
{
    public class Conexion
    {

        public Conexion() 
        { 
        
        
        }
       //connection = new SqlConnection(@"Data Source=.;Initial Catalog=InventoryHall;Integrated Security=True;TrustServerCertificate=true");
        public SqlConnection Conexion_2 = new SqlConnection("Server=.;DataBase=RRHH;Integrated Security=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion_2.State == ConnectionState.Closed)
                Conexion_2.Open();
            return Conexion_2;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion_2.State == ConnectionState.Open)
                Conexion_2.Close();
            return Conexion_2;
        }
    }
}