using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBarberia
{
    internal class Conexion
    {
        public static SqlConnection ObtenerConexion()
        {
            string cadenaConexion = @"Server=DESKTOP-JGB222I;Database=ElMejorCorteBarbershop;Integrated Security=True;TrustServerCertificate=True;";

            SqlConnection conexion = new SqlConnection(cadenaConexion);

            return conexion;
        }
    }
}
