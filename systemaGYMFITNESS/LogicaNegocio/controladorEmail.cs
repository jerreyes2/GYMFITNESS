using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using systemaGYMFITNESS.Datos;
using systemaGYMFITNESS.Presentacion;

namespace systemaGYMFITNESS.LogicaNegocio
{
   public  class controladorEmail
    {
        Empleado usuario;
        public DatosLogin datos;
        public frmRecordar formulario;
        private string correoApp { get; set; }
        public controladorEmail(frmRecordar frmrecuerda)
        {
            this.datos = new DatosLogin();
            this.formulario = frmrecuerda;
            SmtpSection smtp = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
            correoApp = smtp.From;
            //correoOrigen.Text = correoApp;
        }

        public void enviarEmail()
        {
            usuario = datos.getEmpleadoEmail(formulario.TxtEmail.Text.Trim());
            if (usuario == null)
            {
                MessageBox.Show("No está registrado con ese E-mail en el sistema, Tenga en cuenta el correo en la que se registró con anterioridad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var smtp = new SmtpClient();
                Correos emailSender = new Correos(smtp, correoApp);
                emailSender.SendEmailAsync(usuario.email, "Recuperación de clave GYMFITNESS", getMensaje());
                MessageBox.Show("Correo Enviado correctamente, revise su bandeja de entrada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
             

            }           
        }
        public String getMensaje()
        {
            return "<h1>Software GYMFITNESS</a></h1><p> Clave de acceso a la cuenta: "+usuario.password+ "</p><p>!Que tenga Un Buen Día! </p>";
        }


    }
}
