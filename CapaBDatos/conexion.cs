using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace CapaBDatos
{

    public class Conexion
    {
       
        private SqlConnection Conexionn = new SqlConnection("Server= DESKTOP-K1IOKQ5; Initial Catalog = Computadora; Integrated Security = True");
        public SqlConnection AbrirConexion()
        {
            if (Conexionn.State == ConnectionState.Closed)
                Conexionn.Open();
            return Conexionn;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexionn.State == ConnectionState.Open)
                Conexionn.Close();
            return Conexionn;
        }
    }
}
        
    