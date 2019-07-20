using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemaGYMFITNESS.Datos;
using systemaGYMFITNESS.Presentacion;

namespace systemaGYMFITNESS.LogicaNegocio
{
    public class controladorLogin
    {
        Empleado usuario;
        public DatosLogin datos;
        public frmlogin formulario;

        public controladorLogin(frmlogin frmLogin)
        {
            this.datos = new DatosLogin();
            this.formulario = frmLogin;
        }

        public Empleado Iniciar_sesion()
        {
            usuario= datos.consultaUsuario(formulario.TxtNombreUsuario.Text.Trim(), formulario.TxtContrasenia.Text.Trim());
            return usuario;
        }



    }
}
