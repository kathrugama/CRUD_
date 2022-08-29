using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;

using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentación
{
    public partial class Form1 : Form
    {
        
        DetallePC2 objetoCD = new DetallePC2();
        private string Codigo = null;
        private bool Editar = false;
        SqlConnection Cn;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        } 
        private void MostrarProductos()
        {
           
            DetallePC2 objetoCD = new DetallePC2();
            dataGridView1.DataSource = objetoCD.MostrarProd();

       
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
                {
                    try
                    {
                        objetoCD.InsertarPRod(txtCodigo.Text, cmbTipo_de_Computadora.Text, txtProcesador.Text, txtMemoria_RAM.Text, txtTipo_de_disco_duro.Text, txtAlmacenamiento.Text);
                        MessageBox.Show("se inserto correctamente");
                        MostrarProductos();
                        limpiarForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se pudo insertar los datos por: " + ex);
                    }
                }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    objetoCD.EditarProd(txtCodigo.Text, cmbTipo_de_Computadora.Text, txtProcesador.Text, txtMemoria_RAM.Text, txtTipo_de_disco_duro.Text, txtAlmacenamiento.Text);
                    MessageBox.Show("se edito correctamente");
                    MostrarProductos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }

            }
        }
       

        public void limpiarForm()
        {
            txtCodigo.Clear();
            cmbTipo_de_Computadora.Text = "";
            txtProcesador.Clear();
            txtMemoria_RAM.Clear();
            txtTipo_de_disco_duro.Clear();
            txtAlmacenamiento.Clear();
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Codigo = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                objetoCD.EliminarPRod(txtCodigo.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarProductos();
            }
            else
                MessageBox.Show("seleccione una fila por favor");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;
                txtCodigo.Text = dataGridView1.CurrentRow.Cells["Codigo"].Value.ToString();
                cmbTipo_de_Computadora.Text = dataGridView1.CurrentRow.Cells["Tipo_de_Computadora"].Value.ToString();
                txtProcesador.Text = dataGridView1.CurrentRow.Cells["Procesador"].Value.ToString();
                txtMemoria_RAM.Text = dataGridView1.CurrentRow.Cells["Memoria_RAM"].Value.ToString();
                txtTipo_de_disco_duro.Text = dataGridView1.CurrentRow.Cells["Tipo_de_disco_duro"].Value.ToString();
                txtAlmacenamiento.Text = dataGridView1.CurrentRow.Cells["Almacenamiento"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
