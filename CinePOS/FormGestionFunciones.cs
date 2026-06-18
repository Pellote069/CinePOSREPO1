using CapaEntidad;
using System;
using CapaData;
using CapaNegocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace CinePOS
{
    public partial class FormGestionFunciones : Form
    {
        public FormGestionFunciones()
        {
            InitializeComponent();

        }

        private void FormGestionFunciones_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20, 20, 20);
            flpContenedor.BackColor = Color.FromArgb(20, 20, 20);
            flpContenedor.AutoScroll = true;
            flpContenedor.Padding = new Padding(20);

            // Cargar Salas en el ComboBox
            List<Sala> salas = new SalaNegocio().Listar();
            cmbSelectorSala.DataSource = salas;
            cmbSelectorSala.DisplayMember = "Nombre";
            cmbSelectorSala.ValueMember = "ID_Sala";

            

            // eventos para recargar el flowgrid al cambiar de sala 
            cmbSelectorSala.SelectedIndexChanged += (s, ev) => CargarDashboard();
            dtpSelectorFecha.ValueChanged += (s, ev) => CargarDashboard();

            txtBuscador.TextChanged += (s, ev) => CargarDashboard();

            CargarDashboard();
        }

        public void CargarDashboard()
        {
            if (cmbSelectorSala.SelectedValue == null) return;

            int idSalaSeleccionada = (int)cmbSelectorSala.SelectedValue;

            DateTime fechaSeleccionada = dtpSelectorFecha.Value.Date;


            String textoBusqueda = txtBuscador.Text.ToLower();


            flpContenedor.Controls.Clear(); 

            List<Funcion> listaFunciones = new FuncionNegocio().Listar();

            var funcionesFiltradas = listaFunciones.FindAll(f =>
                f.ID_Sala == idSalaSeleccionada &&
                f.FechaHora.Date == fechaSeleccionada &&
                f.NombrePelicula.ToLower().Contains(textoBusqueda)
            ).OrderBy(f => f.FechaHora).ToList();

            foreach (Funcion f in funcionesFiltradas)
            {
                // tarjetas para las funciones
                Panel card = new Panel() { Size = new Size(300, 120), Margin = new Padding(15) };
                card.BackColor = Color.FromArgb(45, 45, 48);




                // indicador de color( estado de la funcion) 
                Panel indicador = new Panel() { Width = 8, Dock = DockStyle.Left };
                if (f.EstadoFuncion == "Corriendo") indicador.BackColor = Color.LimeGreen;
                else if (f.EstadoFuncion == "Vencida") indicador.BackColor = Color.Gray;
                else indicador.BackColor = Color.Gold;
                card.Controls.Add(indicador);

                // Info de la película
                Label lblInfo = new Label()
                {
                    Text = $"PELÍCULA: {f.NombrePelicula}\nHORA: {f.FechaHora:HH:mm}\nSALA: {f.NombreSala}",
                    ForeColor = Color.White,

                    Location = new Point(20, 15),

                    AutoSize = true,
                    Font = new Font("Segoe UI", 9, FontStyle.Bold)
                };
                card.Controls.Add(lblInfo);

                // panel de botones
                Panel pnlBotones = new Panel() { Dock = DockStyle.Bottom, Height = 35, BackColor = Color.Transparent };
                Button btnEditar = new Button() { Text = "✏️", Size = new Size(35, 30), Dock = DockStyle.Right, FlatStyle = FlatStyle.Flat, ForeColor = Color.White };
                Button btnEliminar = new Button() { Text = "🗑️", Size = new Size(35, 30), Dock = DockStyle.Right, FlatStyle = FlatStyle.Flat, ForeColor = Color.White };
                Button btnVer = new Button() { Text = "ℹ️", Size = new Size(35, 30), Dock = DockStyle.Right, FlatStyle = FlatStyle.Flat, ForeColor = Color.White };

                // todas las funcione por panel coupan el id de la funcion a la que pertenecen estos asignaods por el foreach al recorrerlas y ser creados los elementos en ese momento
                btnEditar.Tag = f.ID_Funcion;// editar 
                btnEliminar.Tag = f.ID_Funcion;// elimiar
                btnVer.Tag = f.ID_Funcion;// para ver el detalle de la fucion 

                btnEditar.Click += (s, e) => EjecutarEditar((int)((Button)s).Tag);
                btnEliminar.Click += (s, e) => EjecutarEliminar((int)((Button)s).Tag);
                btnVer.Click += (s, e) => EjecutarDetalles((int)((Button)s).Tag);

                pnlBotones.Controls.Add(btnVer);
                pnlBotones.Controls.Add(btnEliminar);
                pnlBotones.Controls.Add(btnEditar);
                card.Controls.Add(pnlBotones);

                flpContenedor.Controls.Add(card);
            }
        }

        private void btnNuevaFuncion_Click(object sender, EventArgs e)
        {
            BtnGuardarGestionFunciones nuvaFunc = new BtnGuardarGestionFunciones(); // aqui utilizamos la sobrecarga del constructor

            // conformacion 
            if (nuvaFunc.ShowDialog() == DialogResult.OK)
            {
                nuvaFunc.Close();
                // cerramos y recargamos el flowpanel
                CargarDashboard();
            }
        }




        private void EjecutarEliminar(int id)
        {
            if (MessageBox.Show("guro que quieres eliminar esta función?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (new FuncionNegocio().Eliminar(id)) // usamos el meotod eliminar de la capaNegocio y noos devuelve un bool
                {
                    CargarDashboard(); //reffrescamos apra quitar la tarjeta
                }
            }
        }

        private void EjecutarEditar(int id)
        {
            // formulario modo edicion 
            
            BtnGuardarGestionFunciones formeditar = new BtnGuardarGestionFunciones(id);// inicializamos el form que despliga el guardado/actualizacoon de las funciones, en este caso para nuestro form tiene dos constructores(sobrecarga) el qeu recime el id edita, el que no crea funciones

            if (formeditar.ShowDialog() == DialogResult.OK)
            {
                CargarDashboard();
            }
        }

        private void EjecutarDetalles(int id)
        {
            FormDetalleFuncion frm = new FormDetalleFuncion(id); // usamsamos FormDetalleFuncion lo inicializamos para que meustr la informacion 
            frm.ShowDialog();



        }

        private void cmbSelectorSala_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    
     

}
