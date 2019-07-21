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
using systemaGYMFITNESS.LogicaNegocio;
using systemaGYMFITNESS.Datos;

namespace systemaGYMFITNESS.Presentacion
{
    public partial class frmAsisenciaCliente : Form
    {
        int estado;
        public frmAsisenciaCliente()
        {
            InitializeComponent();
            estado = 1;
            controlador = new controladorAsistenciaClientes(this);
            ActualizardgvRegistrasAsistencia();
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            txtCedula.Text = "";
            dtpFechaAsistencia.Value = DateTime.Now;
        }

        private void FrmAsisenciaCliente_Load(object sender, EventArgs e)
        {

        }
        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

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
            this.panel1.Region = region;
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

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            if (estado == 1)
            {
                this.WindowState = FormWindowState.Normal;
                //this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
                //this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
                this.btnMaximizar.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.maxmizar;
                estado = 0;
            }
            else
            {
                this.btnMaximizar.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.restaurarpngg;
                this.WindowState = FormWindowState.Maximized;
                estado = 1;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }
        controladorAsistenciaClientes controlador;
        bdDataContext dataBase = new bdDataContext();
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            controlador.insert();
            ActualizardgvRegistrasAsistencia();
        }
        public void ActualizardgvRegistrasAsistencia()
        {           
            var results = from asisteciaCliente in dataBase.Asistencia_Clientes
                          select new
                          {
                              id = asisteciaCliente.ID_Asistencia_Clientes,
                              cedula = asisteciaCliente.cedula_cliente,
                              fecha = asisteciaCliente.fecha
                          };
            dgvRegistrasAsistencia.DataSource = results;
        }
        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumero(e, false);
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumero(e, false);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            actualizardgvBuscarAsistencia();
        }
        public void actualizardgvBuscarAsistencia()
        {
            var results = from asisteciaCliente in dataBase.Asistencia_Clientes
                          where asisteciaCliente.cedula_cliente.Equals(txtBuscar.Text) & asisteciaCliente.fecha >= dtpFechaDesde.Value & asisteciaCliente.fecha <= dtpFechaHasta.Value
                          select new
                          {
                              id = asisteciaCliente.ID_Asistencia_Clientes,
                              cedula = asisteciaCliente.cedula_cliente,
                              fecha = asisteciaCliente.fecha
                          };
            dgvBuscarAsistencia.DataSource = results;
        }
        private void DgvBuscarAsistencia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                string valor = dgvBuscarAsistencia.Rows[e.RowIndex].Cells[0].Value.ToString();
                DialogResult result = MessageBox.Show("¿Seguro que dese Eliminar el registro "+ valor + " ?", "Eliminar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    controlador.delete(valor);
                    actualizardgvBuscarAsistencia();
                    ActualizardgvRegistrasAsistencia();
                }
            }
        }

        private void DtpFechaAsistencia_ValueChanged(object sender, EventArgs e)
        {            
            if (!validaciones.fechasNoMenores(dtpFechaAsistencia.Value.ToString())) {
                MessageBox.Show("No puede Elegir fecha anteriores a la actual");
                dtpFechaAsistencia.Value = DateTime.Now;
            }
        }

        private void DtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            if (!validaciones.fechasNoMayores(dtpFechaAsistencia.Value.ToString()))
            {
                MessageBox.Show("No puede Elegir fecha posteriores a la actual");
                dtpFechaAsistencia.Value = DateTime.Now;
            }
        }

        private void DtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (!validaciones.fechasNoMenores(dtpFechaAsistencia.Value.ToString()))
            {
                MessageBox.Show("No puede Elegir fecha anteriores a la actual");
                dtpFechaAsistencia.Value = DateTime.Now;
            }
        }
    }
}
