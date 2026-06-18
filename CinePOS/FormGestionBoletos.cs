using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CinePOS
{
    public partial class FormGestionBoletos : Form
    {
        public FormGestionBoletos()
        {
            InitializeComponent();
        }

        private void FormGestionBoletos_Load(object sender, EventArgs e)
        {
            //cargamos ya los datos disponibbmes en el combo box 
            CargarComboTipos();
        }

        private void CargarComboTipos()
        {
            // Obtenemos los tipos distintos de salas
            var listaTipos = new SalaNegocio().Listar().Select(s => s.Tipo).Distinct().ToList(); // obtenemos todos los tipos distintos de salas de la tabla salas usando la capadatos de salas
            cmbSala.DataSource = listaTipos; // se los pasamos al combo box
        }

        private void cmbTipoSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSala.SelectedItem == null) return;



            string tipoSeleccionado = cmbSala.SelectedItem.ToString();

            // tener los campos de asignacion de precio limios
            numPrecioAdulto.Value = 0;

            numPrecioNiño.Value = 0;

            numPrecioEspecial.Value = 0;

            
            bool es2D = (tipoSeleccionado == "2D"); // solo 2d tiene dos diferentis tipos de precio ( $niños, $ adult) 

            groupBox1.Visible = es2D; 

            numPrecioEspecial.Visible = !es2D; // para 3d/4dx solo asignamos un precio 
            
            //* al dessabilitar los numericupdown se evitara que las filas para 4dx y 3d tengan valores mayotees a cero en los campos de precio adulto y niño y solo tengan precio en PrecioEspecial
            

            // consultar los precios en la tabla PreciosPorTipo de la deb
            PreciosNegocio objNegocio = new PreciosNegocio();
            PreciosPorTipo precios = objNegocio.ObtenerPrecios(tipoSeleccionado);

            // 
            if (precios != null)
            {
                numPrecioAdulto.Value = precios.PrecioAdulto;
                numPrecioNiño.Value = precios.PrecioNino;
                numPrecioEspecial.Value = precios.PrecioEspecial;
            }

        }

        private void btnGuardarPrecios_Click_1(object sender, EventArgs e)
        {
            string tipo = cmbSala.SelectedItem.ToString();

            
            PreciosPorTipo p = new PreciosPorTipo
            {
                TipoSala = tipo,
                PrecioAdulto = (tipo == "2D") ? numPrecioAdulto.Value : 0,
                PrecioNino = (tipo == "2D") ? numPrecioNiño.Value : 0,                //por seguridad forzamos a que los numericupdown esten en ceros segun el tipo seleccionado en el combobox
                PrecioEspecial = (tipo != "2D") ? numPrecioEspecial.Value : 0
            };

            string mensaje;
            PreciosNegocio objNegocio = new PreciosNegocio();

            if (objNegocio.GuardarPrecios(p, out mensaje))// este metodo tambien devuelve mensaje, en caso de usarlo esto seria para detectar eroror

                MessageBox.Show("Precios guardados correctamente.");


            else
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}