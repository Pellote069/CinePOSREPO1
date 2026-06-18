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
using CapaData;

using CinePOS;

namespace CinePOS
{
    public partial class BtnGuardarGestionFunciones : Form
    {

        private int idFuncionEditar = 0;
        public BtnGuardarGestionFunciones() // metodo para funciones nuevas 
        {
            InitializeComponent();
            this.idFuncionEditar = 0; //para nuevas funciones
            CargarDatosCombos();
            ConfigurarDateTimePicker();
        }
        public BtnGuardarGestionFunciones(int id)// metodo para añadir funcion nueva
        {
            InitializeComponent();
            this.idFuncionEditar = id;//para actualizar/editar funciones ya hechas
            CargarDatosCombos();
            ConfigurarDateTimePicker();
            CargarDatosEdicion();
        }

        // englbovar las inicializaciones para el datetimepicker
        private void ConfigurarDateTimePicker()
        {
            dtpFechaHora.Format = DateTimePickerFormat.Custom;
            dtpFechaHora.CustomFormat = "dd/MM/yyyy HH:mm";

            dtpFechaHora.ShowUpDown = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CargarDatosEdicion()
        {
            Funcion f = new FuncionNegocio().ObtenerDetalle(idFuncionEditar);
            if (f != null)
            {
                cmbPelicula.SelectedValue = f.ID_Pelicula;
                cmbSala.SelectedValue = f.ID_Sala;
                dtpFechaHora.Value = f.FechaHora;
            }


        }
        private void CargarDatosCombos()
        {
            try
            {
                var listaPeliculas = new PeliculaNegocio().Listar();
                if (listaPeliculas != null)
                {
                    cmbPelicula.DataSource = listaPeliculas;

                    cmbPelicula.DisplayMember = "Titulo"; 

                    cmbPelicula.ValueMember = "ID_Pelicula";
                }

                var listaSalas = new SalaNegocio().Listar();
                if (listaSalas != null)
                {
                    cmbSala.DataSource = listaSalas;


                    cmbSala.DisplayMember = "Nombre"; 
                    
                    
                    cmbSala.ValueMember = "ID_Sala";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error al cargar combos: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbPelicula.SelectedValue == null || cmbSala.SelectedValue == null)
            {
                MessageBox.Show("por favor selecciona na pelicula de la sala");
                return;
            }

            Funcion func = new Funcion()
            {
                ID_Funcion = idFuncionEditar,
                ID_Pelicula = Convert.ToInt32(cmbPelicula.SelectedValue),
                ID_Sala = Convert.ToInt32(cmbSala.SelectedValue),
                FechaHora = dtpFechaHora.Value
            };

            bool operacionExitosa = false;

            string mensajeResultado = "";

            if (idFuncionEditar == 0)// añadir nueva funcion 
            {
                
                operacionExitosa = new FuncionNegocio().Insertar(func, out mensajeResultado);
            }
            else
            {
                operacionExitosa = new FuncionNegocio().Actualizar(func);

                mensajeResultado = operacionExitosa ? "actualizado correctamente" : "error";
            }

            if (operacionExitosa)
            {
                this.DialogResult = DialogResult.OK; // este cuadro de dialogo nos ayuda a disparar el referesco en FormGestionFunciones
                this.Close(); 
            }
            else
            {
                MessageBox.Show(mensajeResultado); // Mmuesstra erorr y no cierrra
            }
        }





    }
}
