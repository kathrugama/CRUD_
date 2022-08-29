
namespace CapaPresentación
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtProcesador = new System.Windows.Forms.TextBox();
            this.txtMemoria_RAM = new System.Windows.Forms.TextBox();
            this.txtTipo_de_disco_duro = new System.Windows.Forms.TextBox();
            this.txtAlmacenamiento = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbTipo_de_Computadora = new System.Windows.Forms.ComboBox();
            this.computadoraDataSet = new CapaPresentación.ComputadoraDataSet();
            this.computadoraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(889, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÓDIGO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(889, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "TIPO DE COMPUTADORA:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(889, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "PROCESADOR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(889, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "MEMORIA RAM:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(889, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "TIPO DE DISCO DURO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(889, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "ALMACENAMIENTO:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1049, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(307, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "DETALLES DE UNA COMPUTADORA";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(1114, 151);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(384, 20);
            this.txtCodigo.TabIndex = 7;
            // 
            // txtProcesador
            // 
            this.txtProcesador.Location = new System.Drawing.Point(1114, 240);
            this.txtProcesador.Name = "txtProcesador";
            this.txtProcesador.Size = new System.Drawing.Size(384, 20);
            this.txtProcesador.TabIndex = 9;
            // 
            // txtMemoria_RAM
            // 
            this.txtMemoria_RAM.Location = new System.Drawing.Point(1114, 287);
            this.txtMemoria_RAM.Name = "txtMemoria_RAM";
            this.txtMemoria_RAM.Size = new System.Drawing.Size(384, 20);
            this.txtMemoria_RAM.TabIndex = 10;
            // 
            // txtTipo_de_disco_duro
            // 
            this.txtTipo_de_disco_duro.Location = new System.Drawing.Point(1114, 334);
            this.txtTipo_de_disco_duro.Name = "txtTipo_de_disco_duro";
            this.txtTipo_de_disco_duro.Size = new System.Drawing.Size(384, 20);
            this.txtTipo_de_disco_duro.TabIndex = 11;
            // 
            // txtAlmacenamiento
            // 
            this.txtAlmacenamiento.Location = new System.Drawing.Point(1114, 383);
            this.txtAlmacenamiento.Name = "txtAlmacenamiento";
            this.txtAlmacenamiento.Size = new System.Drawing.Size(384, 20);
            this.txtAlmacenamiento.TabIndex = 12;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(1005, 476);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(96, 23);
            this.btnInsertar.TabIndex = 13;
            this.btnInsertar.Text = "GUARDAR";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1176, 476);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(95, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1358, 476);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 23);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(812, 523);
            this.dataGridView1.TabIndex = 17;
            // 
            // cmbTipo_de_Computadora
            // 
            this.cmbTipo_de_Computadora.AutoCompleteCustomSource.AddRange(new string[] {
            "Pórtatil",
            "Escritorio"});
            this.cmbTipo_de_Computadora.FormattingEnabled = true;
            this.cmbTipo_de_Computadora.Items.AddRange(new object[] {
            "Pórtatil",
            "Escritirio"});
            this.cmbTipo_de_Computadora.Location = new System.Drawing.Point(1114, 195);
            this.cmbTipo_de_Computadora.Name = "cmbTipo_de_Computadora";
            this.cmbTipo_de_Computadora.Size = new System.Drawing.Size(384, 21);
            this.cmbTipo_de_Computadora.TabIndex = 18;
            this.cmbTipo_de_Computadora.Text = "Seleccione un tipo...";
            // 
            // computadoraDataSet
            // 
            this.computadoraDataSet.DataSetName = "ComputadoraDataSet";
            this.computadoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // computadoraDataSetBindingSource
            // 
            this.computadoraDataSetBindingSource.DataSource = this.computadoraDataSet;
            this.computadoraDataSetBindingSource.Position = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 575);
            this.Controls.Add(this.cmbTipo_de_Computadora);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtAlmacenamiento);
            this.Controls.Add(this.txtTipo_de_disco_duro);
            this.Controls.Add(this.txtMemoria_RAM);
            this.Controls.Add(this.txtProcesador);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoraDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtProcesador;
        private System.Windows.Forms.TextBox txtMemoria_RAM;
        private System.Windows.Forms.TextBox txtTipo_de_disco_duro;
        private System.Windows.Forms.TextBox txtAlmacenamiento;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbTipo_de_Computadora;
        private System.Windows.Forms.BindingSource computadoraDataSetBindingSource;
        private ComputadoraDataSet computadoraDataSet;
    }
}

