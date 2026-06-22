using CapaEntidad;
using CapaNegocio;
using System;
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
    public partial class FormAdminLogin : Form
    {
        UsuarioNegocio objNegocio = new UsuarioNegocio();// con este metodo tenemos aacceso a los metodos de validacion

        public string usuariologueado { get; private set; }
        public FormAdminLogin()
        {
            InitializeComponent();
        }



        private void FormAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsuario.Text)|| string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("rellenar campos");
                return;
            }

            string rol = objNegocio.ValidarLogin(txtUsuario.Text, txtPassword.Text); // nuestro metodo nos devuelve un string osea el tipo de usuario y lo validamos con if

            if(rol == "Admin")
            {
                usuariologueado = txtUsuario.Text;
                this.DialogResult = DialogResult.OK;

                
            }

            else
            {
                MessageBox.Show("valores incorrectos", "acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

            
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();


        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChecCaracteres_CheckedChanged(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            
        }
    }
}
