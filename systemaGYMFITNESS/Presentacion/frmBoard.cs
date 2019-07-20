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
    public partial class frmBoard : Form
    {
        metodosFormularios cf = new metodosFormularios();
        public frmBoard()
        {
            InitializeComponent();
            cf.AbrirFormulario<frmProducto>(this.panelPrincipal);

        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }  

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            cf.AbrirFormulario<frmModelo>(this.panelPrincipal);

        }
    }
}
