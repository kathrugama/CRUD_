using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaBDatos
{
    public class conexion
    {
     
        public SqlConnection Con = new SqlConnection("Data Source=DESKTOP-K1IOKQ5\\Katherine Rugama; Initial Catalog=Computadora;Integrated Security=True");
            public SqlConnection AbrirConexion()
            {
                if (Con.State == ConnectionState.Closed)
                    Con.Open();
                return Con;
            }
            public SqlConnection CerrarConexion()
            {
                if (Con.State == ConnectionState.Open)
                    Con.Close();
                return Con;
            }
        
    }
}
