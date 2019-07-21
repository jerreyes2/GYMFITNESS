using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using systemaGYMFITNESS.Datos;
using systemaGYMFITNESS.LogicaNegocio;

namespace systemaGYMFITNESS.Presentacion
{
    public partial class frmPrincipal : Form
    {
       private int estado; // variable para saber el estado del boton
        metodosFormularios metodosFormularios = new metodosFormularios();
        frmDashboard frmTareas;

        public frmPrincipal(frmDashboard frm)
        {
            InitializeComponent();

            // me carga el formulario de tareas con el nombre de usuario y asignacion
           
            frmTareas = frm;
            frmTareas.TopLevel = false;
            frmTareas.FormBorderStyle = FormBorderStyle.None;
            this.panelContenedor.Controls.Add(frmTareas);
            //metodosFormularios.PanelC.Controls.Add(frmTareas) ;
            metodosFormularios.Formulario = frmTareas;
            frmTareas.Show();
            frmTareas.BringToFront();
           



        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        public int Estado { get => estado; set => estado = value; }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(244, 244, 244));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        //METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            if(panelMenu.Width== 215)
            {    
                panelMenu.Width = 68;
                metodosFormularios.Formulario.WindowState = FormWindowState.Normal;
                metodosFormularios.Formulario.WindowState = FormWindowState.Maximized;
            }
            else
            {
               
                
                panelMenu.Width = 215;
                metodosFormularios.Formulario.WindowState = FormWindowState.Normal;
                metodosFormularios.Formulario.WindowState = FormWindowState.Maximized;
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            estado = 1;
        }

       
   
        private void BtnClientes_Click(object sender, EventArgs e)
        {
            metodosFormularios.AbrirFormulario<frmAsistenteCRUDClientes>(this.panelContenedor, this.btnClientes);
        }




        private void PanelTitulo_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);


        }

        private void PanelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click_1(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                this.WindowState = FormWindowState.Normal;
                metodosFormularios.Formulario.WindowState = FormWindowState.Normal;
                metodosFormularios.Formulario.WindowState = FormWindowState.Maximized;
                this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                this.btnMaximizar.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.maxmizar;
                estado = 0;
            }
            else
            {
                this.btnMaximizar.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.restaurarpngg;
                this.WindowState = FormWindowState.Maximized;
                metodosFormularios.Formulario.WindowState = FormWindowState.Normal;
                metodosFormularios.Formulario.WindowState = FormWindowState.Maximized;
                estado = 1;
            }
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
              metodosFormularios.AbrirFormulario<frmProducto>(this.panelContenedor,this.btnProductos);
           // metodosFormularios.AbrirFormulario<frmBoard>(this.panelContenedor, this.btnProductos);

            //metodosFormularios.AbrirFormulario<new frmProducto()>( this.panelContenedor);
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            frmlogin frm = new frmlogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void BtnEmpleados_Click(object sender, EventArgs e)
        {
            metodosFormularios.AbrirFormulario<FrmEmpleados>(this.panelContenedor, this.btnEmpleados);
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
          //  frmReportes frm = new frmReportes();
           // frm.Show();

        }
    }
}
