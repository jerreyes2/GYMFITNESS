using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using systemaGYMFITNESS.LogicaNegocio;

namespace systemaGYMFITNESS.Presentacion
{
    public partial class frmRecordar : Form
    {


        controladorEmail controlaEmail;
        public frmRecordar()
        {
            InitializeComponent();

            controlaEmail = new controladorEmail(this);

        }

        private void FrmRecordar_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            controlaEmail.enviarEmail();
        }
        
    }
}
