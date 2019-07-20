using System.Windows.Forms;

namespace systemaGYMFITNESS.Presentacion
{
    partial class frmRecordar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblInisiarSesión = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(30, 52);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(352, 30);
            this.txtEmail.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(74, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Ingrese E-mail:";
            // 
            // lblInisiarSesión
            // 
            this.lblInisiarSesión.AutoSize = true;
            this.lblInisiarSesión.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInisiarSesión.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(203)))));
            this.lblInisiarSesión.Location = new System.Drawing.Point(27, 134);
            this.lblInisiarSesión.Name = "lblInisiarSesión";
            this.lblInisiarSesión.Size = new System.Drawing.Size(340, 17);
            this.lblInisiarSesión.TabIndex = 37;
            this.lblInisiarSesión.Text = "Se le enviará a su correo su contraseña que registró";
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(98)))), ((int)(((byte)(203)))));
            this.btnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.ForeColor = System.Drawing.Color.White;
            this.btnEnviar.Location = new System.Drawing.Point(30, 88);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(115, 34);
            this.btnEnviar.TabIndex = 36;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.email;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(30, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // frmRecordar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 168);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInisiarSesión);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Name = "frmRecordar";
            this.Text = "Recordar Contraseña";
            this.Load += new System.EventHandler(this.FrmRecordar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblInisiarSesión;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox pictureBox1;

        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public Label LblInisiarSesión { get => lblInisiarSesión; set => lblInisiarSesión = value; }
        public Button BtnEnviar { get => btnEnviar; set => btnEnviar = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
     
    }
}