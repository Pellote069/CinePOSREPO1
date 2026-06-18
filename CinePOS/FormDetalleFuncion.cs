using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaData;
using CapaEntidad;
using CapaNegocio;
using System.IO;
namespace CinePOS
{
    public partial class FormDetalleFuncion : Form
    {
        public FormDetalleFuncion(int idFunc)
        {
            InitializeComponent();

            this.Text = "Detalle de la funcion";
            this.Size = new Size(650, 450);

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            this.MaximizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;

            this.BackColor = Color.FromArgb(28, 28, 28);
            CargarDetalles(idFunc);

        }

        private void CargarDetalles(int id)
        {
            var f = new FuncionNegocio().ObtenerDetalle(id);

            if (f == null)
            {
                MessageBox.Show("No se encontro información de la funcion.");
                this.Close();
                return;
            }

            //caja para la imagen(poster)


            PictureBox pbPoster = new PictureBox();
            pbPoster.Size = new Size(240, 340);
            pbPoster.Location = new Point(20, 20);
            pbPoster.SizeMode = PictureBoxSizeMode.Zoom;
            pbPoster.BackColor = Color.Black;

            if (!string.IsNullOrEmpty(f.RutaPoster) && File.Exists(f.RutaPoster))
            {
                pbPoster.Image = Image.FromFile(f.RutaPoster);
            }
            else
            {
                pbPoster.BackColor = Color.Gray;
            }
            this.Controls.Add(pbPoster);

            //titulo
            Label lblTitulo = new Label();
            lblTitulo.AutoSize = true;
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitulo.Location = new Point(280, 20);

            lblTitulo.Text = $"PELÍCULA: {f.NombrePelicula.ToUpper()}";
            this.Controls.Add(lblTitulo);

            // clasifiacion
            Label lblClasificacion = new Label();
            lblClasificacion.AutoSize = true;
            lblClasificacion.ForeColor = Color.Yellow;
            lblClasificacion.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lblClasificacion.Location = new Point(280, 50);
            lblClasificacion.Text = $"CLASIFICACIÓN: {f.Clasificacion}";
            this.Controls.Add(lblClasificacion);

            //informacion tecnica
            Label lblInfo = new Label();
            lblInfo.AutoSize = true;
            lblInfo.ForeColor = Color.White;
            lblInfo.Font = new Font("Segoe UI", 11);
            lblInfo.Location = new Point(280, 80);
            lblInfo.Text = $"SALA: {f.NombreSala}\n" +
                           $"ASIENTOS DISPONIBLES: {f.Capacidad}\n\n" +
                           $"FECHA: {f.FechaHora:dd/MM/yyyy}\n" +
                           $"HORA: {f.FechaHora:HH:mm} hrs\n" +
                           $"DURACIÓN: {f.Duracion} min";
            this.Controls.Add(lblInfo);

            //label para la sinopsis
            Label lblSinopsis = new Label();
            lblSinopsis.Text = $"SINOPSIS:\n{f.Sinopsis}";
            lblSinopsis.ForeColor = Color.LightGray;
            lblSinopsis.Font = new Font("Segoe UI", 10);
            lblSinopsis.Location = new Point(280, 210);

            lblSinopsis.Size = new Size(340, 150);
            lblSinopsis.AutoSize = false;
            this.Controls.Add(lblSinopsis);

            // noton cerrar
            Button btnCerrar = new Button();
            btnCerrar.Text = "Cerrar";
            btnCerrar.ForeColor = Color.White;

            btnCerrar.Size = new Size(100, 35);

            btnCerrar.Location = new Point(500, 360);
            btnCerrar.Click += (s, e) => this.Close();
            this.Controls.Add(btnCerrar);
        }
    }
}
