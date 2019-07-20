using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace systemaGYMFITNESS.LogicaNegocio
{
    public class Correos : IEmailSender
    {
        private SmtpClient _smtpClient { get; set; }
        private string _emailFrom { get; set; }

        public Correos(SmtpClient smtpClient, string emailFrom)
        {
            _smtpClient = smtpClient;
            _emailFrom = emailFrom;
        }

        public Task SendEmailAsync(string emailTo, string subject, string message)
        {
            var correo = new MailMessage(from: _emailFrom, to: emailTo, subject: subject, body: message);
            correo.IsBodyHtml = true;
            return _smtpClient.SendMailAsync(correo);
        }

        /*
        public void enviar()
        {
            string usuario, contraseña, destinatario, asunto, mensaje;
            usuario = "juanerreyes@hotmail.com";
            contraseña = "12demayode1997";
            destinatario = "juanitoreyeselconsentido@hotmail.com";
            asunto = "Recuperar Clave sistema Gym Fitness";
            mensaje = "contraseña: 1234";

            MailMessage correo = new MailMessage(usuario, destinatario, asunto, mensaje);

            SmtpClient servidor = new SmtpClient("smtp.hotmail.com",587);
            NetworkCredential credenciales = new NetworkCredential(usuario, contraseña);
            servidor.Credentials = credenciales;
            servidor.EnableSsl = true;
            try
            {
                servidor.Send(correo);
                Console.WriteLine("\t\tCorreo enviado de manera exitosa");
                correo.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/
    }
    public interface IEmailSender
    {
        Task SendEmailAsync(string emailTo, string subject, string message);
    }
}
