using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using systemaGYMFITNESS.Datos;
using systemaGYMFITNESS.LogicaNegocio;


namespace systemaGYMFITNESS.Presentacion
{
    public partial class FrmEmpleados : Form 
    {
        int seleccion = 1;
        controladorEmpleadoUsuario controlador;

   
        public FrmEmpleados()
        {
            
            InitializeComponent();
            
            controlador = new controladorEmpleadoUsuario(this);

            presentarTabla();

            // Por default ADMINISTRADOR
            int index = comboAcceso.FindString("ADMINISTRADOR");
            comboAcceso.SelectedIndex = index;  

        }

        
       

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void presentarTabla()
        {
            controlador.presentarTabla();

        }

        private void LblVisible_Click(object sender, EventArgs e)
        {

            string text = txtContrasenia.Text;
            if (seleccion == 1)
            {
                txtContrasenia.UseSystemPasswordChar = false;
                txtContrasenia.Text = text;
                this.lblVisible.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.visible;
                seleccion--;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
                txtContrasenia.Text = text;
                this.lblVisible.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.novisible;
                seleccion = 1;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (estaVacio() == false)
            {
                 controlador.insert();
                controlador.presentarTabla();

            }
        }

        public Boolean estado = false;

        public Boolean estaVacio()
        {
            estado = false;
            foreach (Control ctrl in this.panelDatos.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.Text.Equals(""))
                    {
                        estado = true;
                        ctrl.BackColor = Color.Pink;
                    }
                    else
                    {
                        ctrl.BackColor = Color.White;
                    }

                }
            }
            if (estado)
            {
                estado = true;
                MessageBox.Show("No deje información en blanco", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                estado = false;
            }

            return estado;

        }

        public void limpiar()
        {
            // this.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = ""); // ESTA TAMBIEN VALE
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            panelDatos.Show();

        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (estaVacio() == false)
            {
                controlador.update();
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (estaVacio() == false)
            {
                controlador.delete();
            }


        }
       
        
        private void TxtFiltrar_TextChanged(object sender, EventArgs e)
        {
            controlador.buscar();
           
        }

        private void BtnEditar2_Click(object sender, EventArgs e)
        {

        }
    }

   
}
 