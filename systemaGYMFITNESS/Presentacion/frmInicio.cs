using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemaGYMFITNESS.Presentacion
{
    public partial class frmInicio : Form
    {
        readonly Thread t;
        public frmInicio()
        {
            /*t = new Thread(new ThreadStart(Splash));
            start();
            string str = string.Empty;
            for (int i = 0; i < 100000; i++)
            {
                str += i.ToString();
            }
            finish();*/
            InitializeComponent();
 
        }
        public void start()
        {
            t.Start();
        }
        public void finish()
        {
            t.Abort();
        }
        void Splash()
        {
            SplashScreen.SplashForm frm = new SplashScreen.SplashForm();
            frm.AppName = "Iniciando";
            Application.Run(frm);
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
         
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }

        private void BtnEmpezar_Click(object sender, EventArgs e)
        {
           
            frmlogin frm = new frmlogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
