using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemaGYMFITNESS.LogicaNegocio
{
    public class metodosFormularios
    {
        private Panel panelC;
        private Form formulario;
        Button btnc;

        public Form Formulario { get => formulario; set => formulario = value; }
        public Panel PanelC { get => panelC; set => panelC = value; }

        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        public void AbrirFormulario<MiForm>(Panel panelContenedor, Button btn) where MiForm : Form, new() 
        {
            panelC = panelContenedor;
            btnc = btn;
            formulario = panelC.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                pintarBotonON(btnc);
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.WindowState = FormWindowState.Maximized;
                panelC.Controls.Add(formulario);
                panelC.Tag = formulario;
                panelContenedor = panelC;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CloseForms);

            }
            //si el formulario/instancia existe
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Maximized;
            }
        }
        private void CloseForms(object sender, FormClosedEventArgs e )
        {
            if (Application.OpenForms["frmCliente"] == null)
                pintarBotonOFF(btnc);
            if (Application.OpenForms["frmProducto"] == null)
                pintarBotonOFF(btnc);
            if (Application.OpenForms["Form3"] == null)
                pintarBotonOFF(btnc);
            

        }

        public void pintarBotonON(Button btn)
        {
            btn.BackColor = Color.FromArgb(4, 41, 68);
        }
        public void pintarBotonOFF(Button btn)
        {
            btn.BackColor = Color.FromArgb(0, 0, 128);
        }
        //METODO PARA ABRIR FORMULARIOS DENTRO DEL PANEL
        public void AbrirFormulario<MiForm>(Panel panelContenedor) where MiForm : Form, new()
        {
            panelC = panelContenedor;
           
            formulario = panelC.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                //pintarBotonON(btnc);
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.WindowState = FormWindowState.Maximized;
                panelC.Controls.Add(formulario);
                panelC.Tag = formulario;
                panelContenedor = panelC;
                formulario.Show();
                formulario.BringToFront();
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);

            }
            //si el formulario/instancia existe
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
            }
        }
    }  
}
