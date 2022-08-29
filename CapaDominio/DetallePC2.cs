using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaBDatos;


namespace CapaDominio
{

    public class DetallePC2
    {
        public DetallePC objetoCD = new DetallePC();
        SqlConnection Cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public DataTable MostrarProd()
        {
            
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();

            return tabla;
        }
        public void InsertarPRod(string Codigo, string Tipo_de_Computadora, string Procesador, string Memoria_RAM, string Tipo_de_disco_duro, string Almacenamiento)
        {
           objetoCD.Insertar(Convert.ToInt32(Codigo), Tipo_de_Computadora, Procesador, Memoria_RAM, Tipo_de_disco_duro, Almacenamiento);
        }
        public void EditarProd(string Codigo, string Tipo_de_Computadora, string Procesador, string Memoria_RAM, string Tipo_de_disco_duro, string Almacenamiento)
        {
            objetoCD.Editar(Convert.ToInt32(Codigo), Tipo_de_Computadora, Procesador, Memoria_RAM, Tipo_de_disco_duro, Almacenamiento);
        }
        public void EliminarPRod(string Codigo)
        {
            objetoCD.Eliminar(Convert.ToInt32(Codigo));
        }
        public int DetallesInsertados(int Codigo)
        {
            int Contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from Detalles_Computadora where Codigo = " + Codigo + "", Cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Contador++;
                }
                dr.Close();
            }
            catch (Exception e)
            {
                string Label = "No se pudo hacer la Consulta" + e.ToString();
            }
            return Contador;
        }

    }
}
