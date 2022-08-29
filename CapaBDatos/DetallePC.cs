using System;
using System.Data;
using System.Data.SqlClient;
namespace CapaBDatos
{
public class DetallePC
{
        private Conexion Con = new Conexion();

        SqlDataReader Leer;
        SqlConnection Conecta;
        DataTable tabla = new DataTable();
        SqlCommand Comando = new SqlCommand();
        SqlCommand cmd;


        public DataTable Mostrar()
        {

            Comando.Connection = Con.AbrirConexion();

            //string consulta = "select *from Detalles_Computadora";
            //Comando.CommandType = CommandType.StoredProcedure;
            //SqlDataAdapter adaptador = new SqlDataAdapter(consulta, Conecta);
            //adaptador.Fill(tabla);

            
            Comando.CommandText = "MostrarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            Leer = Comando.ExecuteReader();
            tabla.Load(Leer);
            


            Comando.Connection = Con.CerrarConexion();
            return tabla;

        }

        public void Insertar(int Codigo, string Tipo_de_Computadora, string Procesador, string Memoria_RAM, string Tipo_de_disco_duro, string Almacenamiento)
        {
            Comando.Connection = Con.AbrirConexion();
            Comando.CommandText = "InsetarProductos";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Codigo", Codigo);
            Comando.Parameters.AddWithValue("@Tipo_de_Computadora", Tipo_de_Computadora);
            Comando.Parameters.AddWithValue("@Procesador", Procesador);
            Comando.Parameters.AddWithValue("@Memoria_RAM", Memoria_RAM);
            Comando.Parameters.AddWithValue("@Tipo_de_disco_duro", Tipo_de_disco_duro);
            Comando.Parameters.AddWithValue("@Almacenamiento", Almacenamiento);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Con.CerrarConexion();
        }
        public void Editar(int Codigo, string Tipo_de_Computadora, string Procesador, string Memoria_RAM, string Tipo_de_disco_duro, string Almacenamiento)
        {
            Comando.Connection = Con.AbrirConexion();
            Comando.CommandText = "EditarProductos"; 
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Codigo", Codigo);
            Comando.Parameters.AddWithValue("@Tipo_de_Computadora", Tipo_de_Computadora);
            Comando.Parameters.AddWithValue("@Procesador", Procesador);
            Comando.Parameters.AddWithValue("@Memoria_RAM", Memoria_RAM);
            Comando.Parameters.AddWithValue("@Tipo_de_disco_duro", Tipo_de_disco_duro);
            Comando.Parameters.AddWithValue("@Almacenamiento", Almacenamiento);
           
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = Con.CerrarConexion();
        }
        public void Eliminar(int Codigo)
        {
            Comando.Connection = Con.AbrirConexion();
            Comando.CommandText = "EliminarProducto";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Codigo", Codigo);

            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
            Comando.Connection = Con.CerrarConexion();
        }
    }
}
