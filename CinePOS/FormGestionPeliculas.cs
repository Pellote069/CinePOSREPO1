using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;
using System.Security.Cryptography.X509Certificates;
namespace CinePOS
{
    public partial class FormGestionPeliculas : Form
    {
        PeliculaNegocio negocio = new PeliculaNegocio();
        public FormGestionPeliculas()
        {
            InitializeComponent();

            // tuve que asignar los eventos para cada uno de nuestros metdodos para los botones manualmente pq corrompi el designer.cs ;)
            this.Load += new System.EventHandler(this.FormGestionPeliculas_Load);

            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);

            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);

            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);

            this.btnLimpiarCamps.Click += new System.EventHandler(this.btnLimpiarCamps_Click);
            this.btnLimpRuta.Click += new System.EventHandler(this.btnLimpRuta_Click);
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);

        }
        private void FormGestionPeliculas_Load(object sender, EventArgs e) // al cargar el form establecemos propieedades para el grid y tambien lo cargamos 
        {
            CargarGrid();
            dataGridView1.AllowUserToAddRows = false;

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = true;

        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = negocio.Listar();// usamos nuestro metodo listar para alimentarnos de la db


        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Index >= 0) // primero confonfirmamos que hayan datos en las filas selccionadas
            {
                

                txtTitulo.Text = dataGridView1.CurrentRow.Cells["Titulo"].Value?.ToString() ?? ""; // para el campo de titulo en el form añsiganos su valor si hay datos en la fila seleccionada sino string vacio

                
                object duracionVal = dataGridView1.CurrentRow.Cells["Duracion"].Value;// cuando un campo enl abase de datos se representa como DBnull
                numDuracion.Value = (duracionVal != DBNull.Value) ? Convert.ToDecimal(duracionVal) : 1; // si hay datos asignamos el valor del campo al campo del formulario sino por defecto un 1

                cmbClasificacion.Text = dataGridView1.CurrentRow.Cells["Clasificacion"].Value?.ToString() ?? "";
                txtSinopsis.Text = dataGridView1.CurrentRow.Cells["Sinopsis"].Value?.ToString() ?? "";
                txtRutaPoster.Text = dataGridView1.CurrentRow.Cells["RutaImagen"].Value?.ToString() ?? "";
            }



        }

        // accion de btn examinar
        private void btnExaminar_Click(object sender,EventArgs e)
        { 
            OpenFileDialog open = new OpenFileDialog(); // abrimos una ventana para examinar archivos pormedio de su ruta en los directorios del pc
            open.Filter = "Imagenes|*.jpg;*.png;*.jpeg"; // filtro por defecto apra que nos aparezcan solo esos archivos
            if(open.ShowDialog() == DialogResult.OK)
            {
                txtRutaPoster.Text = open.FileName;
            }

        }
        // accon del boton agregar

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Pelicula p = new Pelicula
            {
                Titulo = txtTitulo.Text,
                Duracion = (int)numDuracion.Value,
                Clasificacion = cmbClasificacion.Text,
                Sinopsis = txtSinopsis.Text,
                RutaImagen = txtRutaPoster.Text,


            };

            if (negocio.Insertar(p))
            {
                MessageBox.Show("Pelicula Agregada");
                CargarGrid();

            }

        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count > 0) // verficamos q hayan datos( filas) en el grid
            {
                
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    fila.Selected = true; // les asignamos que estan seleccionadas a todas
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult confirmacion = MessageBox.Show("¿vas a eliminar estos: " + dataGridView1.SelectedRows.Count + " elementos?", "Confirma la eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(confirmacion == DialogResult.Yes)
                {
                    foreach(DataGridViewRow fila in dataGridView1.SelectedRows)
                    {
                        int ID = Convert.ToInt32(fila.Cells["ID_Pelicula"].Value);

                        negocio.Eliminar(ID); // utlizamos nuestro metodo para eliminar en la tabla peliculas dela db

                        
                    }
                    MessageBox.Show("eliminaion finalizadaa");
                    CargarGrid();




                }
                else
                {
                    MessageBox.Show("seleccione almenos una fila");

                }




            }


         

            
                
            
        }
        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtSinopsis.Clear();
            txtRutaPoster.Clear();
            numDuracion.Value = 1; // el valor minimo
            cmbClasificacion.SelectedIndex = -1;  // quitamos cualquier seleccion en el Combobox
            dataGridView1.ClearSelection();

        }

        private void btnLimpiarCamps_Click(Object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        private void btnLimpRuta_Click(Object sender, EventArgs e)
        {
            txtRutaPoster.Clear();

        }
        private void btnActualizar_Click(Object sender,EventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                Pelicula p = new Pelicula
                {
                    ID_Pelicula = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ID_Pelicula"].Value),

                    Titulo = txtTitulo.Text,
                    Duracion = (int)numDuracion.Value,
                    Clasificacion = cmbClasificacion.Text,
                    Sinopsis = txtSinopsis.Text,
                    RutaImagen = txtRutaPoster.Text

                };

                if (negocio.Actualizar(p))
                {
                    MessageBox.Show("pelicula actualizada correctamente");
                    CargarGrid(); // refrescar la tabla de elementos
                }
                else
                {
                    MessageBox.Show("error al actualizar");
                }


            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormGestionPeliculas_Load_1(object sender, EventArgs e)
        {

        }
    }
}


