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

namespace systemaGYMFITNESS.Presentacion
{
    public partial class frmClientes : Form
    {
        controladorClientes controlador;

        int estado;
        metodosFormularios cf = new metodosFormularios();

        public frmClientes()
        {
            InitializeComponent();
            estado = 1;
            controlador = new controladorClientes(this);
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
            this.panel.Region = region;
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

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

                
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            
        }

        private void PanelTitulo_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnMaximizar_Click_1(object sender, EventArgs e)
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSiguienteCrearCuenta_Click(object sender, EventArgs e)
        {
            if (estaVacio() == false)
            {
                tabControl1.SelectedIndex = 1;
            }
        }

        private void PanelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnSiguienteDatoMembresia_Click(object sender, EventArgs e)
        {
            if (CambiosDatoMembresia == true)
                MessageBox.Show("Debe de calcular el costo antes de continuar");
            else
            {
                if (estaVacio() == false)
                {
                    tabControl1.SelectedIndex = 2;
                }
            }
        }

        private void BtnAnteriorDatoMembresia_Click(object sender, EventArgs e)
        {
             tabControl1.SelectedIndex = 0;
        }

        private void BtnAnteriorFicha_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        public Boolean cambioFicha;
        private void BtnSiguienteFicha_Click(object sender, EventArgs e)
        {
            if (estaVacio() == false)
            {
                if (cambioFicha)
                {
                    tabControl1.SelectedIndex = 3;
                }
                else
                {
                    MessageBox.Show("Se han realizado cambios vuelva a calcular la ficha del cliente");
                }                
            }
        }

        private void BtnAnteriorDatosFinales_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;            
        }

        private void BtnBorrarCrearCuenta_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void BtnBorrarDatoMembresia_Click(object sender, EventArgs e)
        {
            borrar();
        }

        public void borrar()
        {
            foreach (Control ctrl in tabControl1.SelectedTab.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }

        private void BtnBorrarFicha_Click(object sender, EventArgs e)
        {
            borrar();
        }

        private void TabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
            {
                lblCedula.Text = txtCedula.Text;
                labelNombres.Text = txtNombres.Text;
                lblApellidos.Text = txtApellidos.Text;
                lblDireccion.Text = txtDireccion.Text;
                lblFechaNacimiento.Text = dtpFecha_Nacimiento.Value.ToString("yyyy/MM/dd");
                lblTelefono.Text = txtTelefono.Text;
                lblCelular.Text = txtCelular.Text;
                if (rbMasculino.Checked == true)
                {
                    lblSexo.Text = "Masculino";
                }
                if (rbFemenino.Checked == true)
                {
                    lblSexo.Text = "Femenino";
                }
                lblIndiceCinturaAltura.Text = txtIndici_cintura_altura.Text;
                lblMasaCorporalMagra.Text = txtMasa_Corporal_magra.Text;
                lblSobrepeso.Text = txt_Sobrepeso.Text;
                lblNivel.Text = cbbNivel.SelectedItem.ToString();
                lblRutina.Text = cbbRutina.SelectedItem.ToString();
                lblFechaPago.Text = dtpFechaPago.Value.ToString("yyyy/MM/dd");
                lblFechaProximoPago.Text = dtpFechaProximoPago.Value.ToString("yyyy/MM/dd");
                lblCosto.Text = txtCosto.Text;
                lblTotal.Text = txtTotal.Text;
            }
        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            txtID_membresia.Text = "IDM" + txtCedula.Text;
        }

        public Boolean estaVacio()
        {
            Boolean estado = false;
            estado = false;
            foreach (Control ctrl in tabControl1.SelectedTab.Controls)
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

        private void TabDatosMembresia_Click(object sender, EventArgs e)
        {

        }
        Boolean CambiosDatoMembresia = false;
        private void TbDias_TextChanged(object sender, EventArgs e)
        {            
            if (tbDias.Text.Length > 0) {
                dtpFechaProximoPago.Value = dtpFechaPago.Value.AddDays(int.Parse(tbDias.Text));
            }
            CambiosDatoMembresia = true;
        }

        private void DtpFechaPago_ValueChanged(object sender, EventArgs e)
        {
            if (tbDias.Text.Length > 0)
            {
                dtpFechaProximoPago.Value = dtpFechaPago.Value.AddDays(int.Parse(tbDias.Text));
            }
        }
        public double costoNivel = 0;
        public double costoRutina = 0;
        private void CbbNivel_TextChanged(object sender, EventArgs e)
        {
            if (cbbNivel.SelectedIndex == 0)
            {
                costoNivel = +1.20;
            }
            if (cbbNivel.SelectedIndex == 1)
            {
                costoNivel = 1.25;
            }
            if (cbbNivel.SelectedIndex == 2)
            {
                costoNivel = 1.30;
            }
            CambiosDatoMembresia = true;
        }

        private void CbbRutina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbNivel.SelectedIndex == 0)
            {
                costoRutina = 0.50;
            }
            if (cbbNivel.SelectedIndex == 1)
            {
                costoRutina = 0.25;
            }
            if (cbbNivel.SelectedIndex == 2)
            {
                costoRutina = 0.30;
            }
            CambiosDatoMembresia = true;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            txtCosto.Text = ((costoNivel + costoRutina) * int.Parse(tbDias.Text))+"";
            txtTotal.Text = ""+(double.Parse(txtCosto.Text)*0.12 + double.Parse(txtCosto.Text));
            CambiosDatoMembresia = false;
        }

        private void BtnSiguienteDatoMembresia_MouseClick(object sender, MouseEventArgs e)
        {            
        }

        private void BtnSiguienteDatoMembresia_MouseEnter(object sender, EventArgs e)
        {            
        }

        private void BtnCalcularDatosCorporales_Click(object sender, EventArgs e)
        {
            double grasa = 0;
            if (txtPeso.TextLength>0 & txtCuello.TextLength>0 & txtCintura.TextLength>0 & txtAltura.TextLength > 0)
            {
                //calcula indice cintura/altura
                double peso = Double.Parse(txtPeso.Text);
                double altura = Double.Parse(txtAltura.Text);
                txtIndici_cintura_altura.Text = "" + (Math.Truncate((peso / (altura* altura)) * 100) / 100);
                //calcula masa corporal magra
                if (rbMasculino.Checked == true | rbFemenino.Checked == true)
                {
                    if (rbMasculino.Checked == true)
                    {
                        //grasa = 495 / (1.0324 - 0.19077 * (Math.Log(Double.Parse(txtCintura.Text) - Double.Parse(txtCuello.Text))) + 0.15456 * (Math.Log(Double.Parse(txtAltura.Text)))) - 450;
                        DateTime nacimiento = new DateTime(dtpFecha_Nacimiento.Value.Year, dtpFecha_Nacimiento.Value.Month, dtpFecha_Nacimiento.Value.Day); //Fecha de nacimiento
                        int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                        grasa = 1.2 * double.Parse(txtIndici_cintura_altura.Text) + 0.23 * edad - 10.8 - 5.4;
                    }
                    else
                    {
                        if (txtCadera.TextLength > 0)
                        {
                            //grasa = 495 / (1.29579 - 0.35004 * (Math.Log(Double.Parse(txtCintura.Text)) + Double.Parse(txtCadera.Text)) - Double.Parse(txtCuello.Text)) + 0.22100 * (Math.Log(Double.Parse(txtAltura.Text))) - 450;
                            DateTime nacimiento = new DateTime(dtpFecha_Nacimiento.Value.Year, dtpFecha_Nacimiento.Value.Month, dtpFecha_Nacimiento.Value.Day); //Fecha de nacimiento
                            int edad = DateTime.Today.AddTicks(-nacimiento.Ticks).Year - 1;
                            grasa = 1.2 * double.Parse(txtIndici_cintura_altura.Text) + 0.23 * edad - 5.4;
                        }
                        else
                        {
                            MessageBox.Show("Rellene el campos cadera (solo para mujeres)");
                        }
                    }
                    //txtMasa_Corporal_magra.Text = "" + (Double.Parse(txtPeso.Text) * (100 - grasa));
                    txtMasa_Corporal_magra.Text = "" + (Math.Truncate(grasa * 100) / 100);
                }
                else
                {
                    MessageBox.Show("Seleccione el campo sexo");
                }
                //calculamos el sobrepeso en base al indice cintura/altura
                txt_Sobrepeso.Text = calculoSobrepeso()+"";
                //habilitamos boton siguiente
                cambioFicha = true;
            }
            else
            {
                MessageBox.Show("Rellene todos los campos solicitados");
            }           
        }
        public int calculoSobrepeso()
        {
            //18,5 - 24,9   Normopeso
            //25 - 26,9 Sobrepeso grado I
            //27 - 29,9 Sobrepeso grado II(preobesidad)
            //30 - 34,9 Obesidad de tipo I
            //35 - 39,9 Obesidad de tipo II
            //40 - 49,9 Obesidad de tipo III(mórbida)
            //> 50 Obesidad de tipo IV(extrema)
            int tipoSobrepeso = 0;
            double indiceC_A = double.Parse(txtIndici_cintura_altura.Text);
            if (indiceC_A>=18.5 & indiceC_A <= 24.9)
            {
                tipoSobrepeso = 0;
            }
            else
            {
                if (indiceC_A >= 25 & indiceC_A <= 26.9)
                {
                    tipoSobrepeso = 1;
                }
                else
                {
                    if (indiceC_A >= 27 & indiceC_A <= 29.9)
                    {
                        tipoSobrepeso = 2;
                    }
                    else
                    {
                        if (indiceC_A >= 30 & indiceC_A <= 34.9)
                        {
                            tipoSobrepeso = 3;
                        }
                        else
                        {
                            if (indiceC_A >= 35 & indiceC_A <= 39.9)
                            {
                                tipoSobrepeso = 4;
                            }
                            else
                            {
                                if (indiceC_A >= 40)
                                {
                                    tipoSobrepeso = 5;
                                }
                            }
                        }
                    }
                }
            }
            return tipoSobrepeso;
        }
        private void BtnGuardarDatosFinales_Click(object sender, EventArgs e)
        {
            controlador.insert();
        }

        private void RbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            cambioRadioButtonMasculinoFemenino();
        }

        public void cambioRadioButtonMasculinoFemenino()
        {
            cambioFicha = false;
            if (rbMasculino.Checked == true)
            {
                txtCadera.Text = "0";
                txtCadera.Enabled = false;
            }
            else
            {
                if (rbFemenino.Checked == true)
                {
                    txtCadera.Text = "";
                    txtCadera.Enabled = true;
            }
            }
        }

        private void RbFemenino_CheckedChanged(object sender, EventArgs e)
        {
            cambioRadioButtonMasculinoFemenino();
        }

        validaciones validator = new validaciones();

        private void TxtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumerosYComa(e, false);
            cambioFicha = false;
        }

        private void TxtCuello_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumerosYComa(e, false);
            cambioFicha = false;
        }

        private void TxtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumerosYComa(e, false);
            cambioFicha = false;
        }

        private void TxtCintura_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumerosYComa(e, false);
            cambioFicha = false;
        }

        private void TxtCadera_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumerosYComa(e, false);
            cambioFicha = false;
        }

        private void DtpFecha_Nacimiento_ValueChanged(object sender, EventArgs e)
        {

            cambioFicha = false;

        }

        private void TbDias_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumero(e, false);
        }

        private void CbbNivel_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.noEscribir(e,false);
        }

        private void CbbRutina_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.noEscribir(e, false);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumero(e, false);
        }

        private void TxtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumero(e, false);
        }

        private void TxtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void TxtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloLetras(e);
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.soloNumero(e, false);
        }
    }
}
