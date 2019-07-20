using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using systemaGYMFITNESS.LogicaNegocio;

namespace systemaGYMFITNESS.Presentacion
{
    public partial class frmCrearCuenta : Form
    {
        controladorEmpleadoUsuario controlador;
        frmlogin formularioLogin;
        public frmCrearCuenta(frmlogin formulario)
        {
            InitializeComponent();
            formularioLogin = formulario;

            //controlador = new controladorEmpleadoUsuario(this);
        }

        private void FrmCrearCuenta_Load(object sender, EventArgs e)
        {
           
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;


            // Por default ADMINISTRADOR
            int index = comboAcceso.FindString("ADMINISTRADOR");
            comboAcceso.SelectedIndex = index;
           
        }

   
        int seleccion = 1;
        private void LblVisible_Click_1(object sender, EventArgs e)
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

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            if (estaVacio() == false)
            {
                controlador.insert();
               
            }
        }

        public Boolean  estado=false;

        public Boolean estaVacio()
        {
            estado = false;
            foreach (Control ctrl in this.Controls)
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


        private void LblInisiar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formularioLogin.BringToFront();
            this.Close();
        }
    }
}
