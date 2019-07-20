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
    public partial class frmlogin : Form
    {
        controladorLogin controlador ;
        Empleado usuario;

        public frmlogin()
        {
            InitializeComponent();
            controlador = new controladorLogin(this);
            this.lblError.Visible=false;
        }

        private void Frmlogin_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (TxtNombreUsuario.Text.Equals("") || TxtContrasenia.Text.Equals(""))
            {
                this.lblError.Visible = true;
            }
            else
            {
                usuario = controlador.Iniciar_sesion();
              
                if (usuario != null)
                {
                    frmDashboard frmTareas = new frmDashboard();
                    frmTareas.LblUsuario.Text = usuario.login;
                    frmTareas.LblAsignacion.Text = " Eres " + usuario.tipo_acceso + " en este momento.";

                    frmPrincipal frm = new frmPrincipal(frmTareas);
                    this.Hide();
                    frm.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
            }   
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

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
                seleccion=0;
            }
            else
            {
                txtContrasenia.UseSystemPasswordChar = true;
                txtContrasenia.Text = text;
                this.lblVisible.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.novisible;
                seleccion = 1;
            }
        }

        private void LblContrasenia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRecordar frm = new frmRecordar();
          //  this.Hide();
            frm.ShowDialog();
           
        }

        private void LblCrearCuentaUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCrearCuenta frm = new frmCrearCuenta(this);
            //this.Hide();
            frm.ShowDialog();
            
        }
    }
}
