using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace RRHH_Proyecto
{
    public class Conexion0
{
    private SqlConnection connection;
    public Conexion0()
    {
        connection = new SqlConnection(@"Data Source=.;Initial Catalog=RRHH;Integrated Security=True;TrustServerCertificate=true");
    }

    public SqlConnection GetConnection()
    {
        if (connection == null)
        {
            throw new InvalidOperationException("La conexión de base de datos no ha sido inicializada.");
        }

        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
        return connection;
    }

    public void CloseConnection()
    {
        if (connection != null && connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    public void ExecuteNonQuery(string query)
    {
        using (SqlCommand command = new SqlCommand(query, GetConnection()))
        {
            if (connection.State != ConnectionState.Open)
                connection.Open();

            command.ExecuteNonQuery();

            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
}