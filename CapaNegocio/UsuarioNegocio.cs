using CapaData;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class UsuarioNegocio
    {
        UsuarioDatos objDatos = new UsuarioDatos();

        public string ValidarLogin(string user, string pass)
        {
            // validamos si el usuario escrito en el textbox o en la texbox de pasword estan vacios, si es asi devolvermos strig error
            if (string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass))
            {
                return "Error";
            }
            // si no le pasamos el usuario al metodo de usuarioDatos para validar ya con la base de datoos
            return objDatos.ValidarLogin(user, pass);
        }

    }
}
