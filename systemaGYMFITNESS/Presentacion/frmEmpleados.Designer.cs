using System.Windows.Forms;

namespace systemaGYMFITNESS.Presentacion
{
    partial class FrmEmpleados
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.tablaControl = new System.Windows.Forms.TabControl();
            this.panelTabla = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFiltrar = new System.Windows.Forms.TextBox();
            this.panelDatos = new System.Windows.Forms.TabPage();
            this.btnEditar2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblVisible = new System.Windows.Forms.PictureBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtContrasenia = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboAcceso = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tablaControl.SuspendLayout();
            this.panelTabla.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisible)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 620);
            this.panel1.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnNuevo.Location = new System.Drawing.Point(1, 24);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(159, 44);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEliminar.Location = new System.Drawing.Point(-2, 178);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(162, 44);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "     Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditar.Location = new System.Drawing.Point(0, 126);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 44);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGuardar.Location = new System.Drawing.Point(1, 76);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(159, 44);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "   Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.btnMinimizar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(160, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 25);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Empleado";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.cerrar;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Location = new System.Drawing.Point(880, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(24, 19);
            this.btnCerrar.TabIndex = 21;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.minimizar;
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Location = new System.Drawing.Point(843, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(31, 25);
            this.btnMinimizar.TabIndex = 20;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // tablaControl
            // 
            this.tablaControl.Controls.Add(this.panelTabla);
            this.tablaControl.Controls.Add(this.panelDatos);
            this.tablaControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tablaControl.Location = new System.Drawing.Point(160, 25);
            this.tablaControl.Name = "tablaControl";
            this.tablaControl.SelectedIndex = 0;
            this.tablaControl.Size = new System.Drawing.Size(909, 595);
            this.tablaControl.TabIndex = 13;
            // 
            // panelTabla
            // 
            this.panelTabla.Controls.Add(this.tableLayoutPanel2);
            this.panelTabla.Location = new System.Drawing.Point(4, 25);
            this.panelTabla.Name = "panelTabla";
            this.panelTabla.Padding = new System.Windows.Forms.Padding(3);
            this.panelTabla.Size = new System.Drawing.Size(901, 566);
            this.panelTabla.TabIndex = 0;
            this.panelTabla.Text = "Tabla";
            this.panelTabla.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tabla, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.433628F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.56637F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(895, 560);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tabla
            // 
            this.tabla.BackgroundColor = System.Drawing.Color.White;
            this.tabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabla.Location = new System.Drawing.Point(3, 42);
            this.tabla.Name = "tabla";
            this.tabla.Size = new System.Drawing.Size(889, 486);
            this.tabla.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.txtFiltrar, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(878, 31);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.Location = new System.Drawing.Point(3, 3);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(440, 21);
            this.txtFiltrar.TabIndex = 0;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.TxtFiltrar_TextChanged);
            // 
            // panelDatos
            // 
            this.panelDatos.AutoScroll = true;
            this.panelDatos.Controls.Add(this.btnEditar2);
            this.panelDatos.Controls.Add(this.pictureBox3);
            this.panelDatos.Controls.Add(this.btnLimpiar);
            this.panelDatos.Controls.Add(this.label12);
            this.panelDatos.Controls.Add(this.label11);
            this.panelDatos.Controls.Add(this.lblVisible);
            this.panelDatos.Controls.Add(this.txtNombreUsuario);
            this.panelDatos.Controls.Add(this.txtEmail);
            this.panelDatos.Controls.Add(this.txtDireccion);
            this.panelDatos.Controls.Add(this.txtCedula);
            this.panelDatos.Controls.Add(this.txtTelefono);
            this.panelDatos.Controls.Add(this.txtContrasenia);
            this.panelDatos.Controls.Add(this.txtApellidos);
            this.panelDatos.Controls.Add(this.txtNombres);
            this.panelDatos.Controls.Add(this.label10);
            this.panelDatos.Controls.Add(this.pictureBox2);
            this.panelDatos.Controls.Add(this.pictureBox1);
            this.panelDatos.Controls.Add(this.label9);
            this.panelDatos.Controls.Add(this.comboAcceso);
            this.panelDatos.Controls.Add(this.label8);
            this.panelDatos.Controls.Add(this.label7);
            this.panelDatos.Controls.Add(this.label6);
            this.panelDatos.Controls.Add(this.label5);
            this.panelDatos.Controls.Add(this.label2);
            this.panelDatos.Controls.Add(this.label4);
            this.panelDatos.Controls.Add(this.label3);
            this.panelDatos.Location = new System.Drawing.Point(4, 25);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Padding = new System.Windows.Forms.Padding(3);
            this.panelDatos.Size = new System.Drawing.Size(901, 566);
            this.panelDatos.TabIndex = 1;
            this.panelDatos.Text = "Datos";
            this.panelDatos.UseVisualStyleBackColor = true;
            // 
            // btnEditar2
            // 
            this.btnEditar2.FlatAppearance.BorderSize = 0;
            this.btnEditar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditar2.Image = global::systemaGYMFITNESS.Properties.Resources.Editar;
            this.btnEditar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar2.Location = new System.Drawing.Point(170, 516);
            this.btnEditar2.Name = "btnEditar2";
            this.btnEditar2.Size = new System.Drawing.Size(181, 44);
            this.btnEditar2.TabIndex = 62;
            this.btnEditar2.Text = "Guardar edición";
            this.btnEditar2.UseVisualStyleBackColor = true;
            this.btnEditar2.Click += new System.EventHandler(this.BtnEditar2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.gymhombre;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(452, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(441, 437);
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnLimpiar.Image = global::systemaGYMFITNESS.Properties.Resources.actions_edit_clear_15784__1_;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(37, 516);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 44);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(449, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(378, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Creacion de cuenta de Empleado servirá tambien para el inicio de sesión";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(448, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 20);
            this.label11.TabIndex = 58;
            this.label11.Text = "Empleado";
            // 
            // lblVisible
            // 
            this.lblVisible.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.visible;
            this.lblVisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lblVisible.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVisible.Location = new System.Drawing.Point(350, 423);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.Size = new System.Drawing.Size(27, 23);
            this.lblVisible.TabIndex = 57;
            this.lblVisible.TabStop = false;
            this.lblVisible.Click += new System.EventHandler(this.LblVisible_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(34, 353);
            this.txtNombreUsuario.Multiline = true;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(342, 30);
            this.txtNombreUsuario.TabIndex = 56;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(35, 279);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 30);
            this.txtEmail.TabIndex = 55;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(34, 181);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(342, 30);
            this.txtDireccion.TabIndex = 54;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(34, 132);
            this.txtCedula.Multiline = true;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(342, 30);
            this.txtCedula.TabIndex = 53;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(34, 230);
            this.txtTelefono.Multiline = true;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(342, 30);
            this.txtTelefono.TabIndex = 52;
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasenia.Location = new System.Drawing.Point(35, 419);
            this.txtContrasenia.Multiline = true;
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.PasswordChar = '*';
            this.txtContrasenia.Size = new System.Drawing.Size(345, 30);
            this.txtContrasenia.TabIndex = 46;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(34, 83);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(342, 30);
            this.txtApellidos.TabIndex = 38;
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(34, 36);
            this.txtNombres.Multiline = true;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(342, 28);
            this.txtNombres.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(34, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 16);
            this.label10.TabIndex = 51;
            this.label10.Text = "E-mail:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.Contrasenia;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(35, 386);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 28);
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::systemaGYMFITNESS.Properties.Resources.usuario;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(34, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 32);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 16);
            this.label9.TabIndex = 48;
            this.label9.Text = "Tipo Acceso";
            // 
            // comboAcceso
            // 
            this.comboAcceso.FormattingEnabled = true;
            this.comboAcceso.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "CAJERO",
            "BODEGUERO",
            "CONTROL DE EMPLEADOS",
            "VENDEDOR",
            "PERSONAL VENTAS"});
            this.comboAcceso.Location = new System.Drawing.Point(37, 478);
            this.comboAcceso.Name = "comboAcceso";
            this.comboAcceso.Size = new System.Drawing.Size(342, 24);
            this.comboAcceso.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(78, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(78, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nombre de Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Teléfono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Dirección:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = " Cedula / Dni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(31, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 40;
            this.label4.Text = "Apellidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(31, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nombres:";
            // 
            // FrmEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 620);
            this.Controls.Add(this.tablaControl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmpleados";
            this.Text = "frmEmpleados";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tablaControl.ResumeLayout(false);
            this.panelTabla.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVisible)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.TabControl tablaControl;
        private System.Windows.Forms.TabPage panelTabla;
        private System.Windows.Forms.TabPage panelDatos;
        private System.Windows.Forms.PictureBox lblVisible;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtContrasenia;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboAcceso;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView tabla;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox txtFiltrar;
        private Button btnEditar2;

        public Panel Panel1 { get => panel1; set => panel1 = value; }
        public Button BtnNuevo { get => btnNuevo; set => btnNuevo = value; }
        public Button BtnEliminar { get => btnEliminar; set => btnEliminar = value; }
        public Button BtnEditar { get => btnEditar; set => btnEditar = value; }
        public Button BtnGuardar { get => btnGuardar; set => btnGuardar = value; }
        public Panel Panel3 { get => panel3; set => panel3 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
        public Button BtnCerrar { get => btnCerrar; set => btnCerrar = value; }
        public Button BtnMinimizar { get => btnMinimizar; set => btnMinimizar = value; }
        public TabControl TablaControl { get => tablaControl; set => tablaControl = value; }
        public TabPage TabPage1 { get => panelTabla; set => panelTabla = value; }
        public TabPage TabPage2 { get => panelDatos; set => panelDatos = value; }
        public PictureBox LblVisible { get => lblVisible; set => lblVisible = value; }
        public TextBox TxtNombreUsuario { get => txtNombreUsuario; set => txtNombreUsuario = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtDireccion { get => txtDireccion; set => txtDireccion = value; }
        public TextBox TxtCedula { get => txtCedula; set => txtCedula = value; }
        public TextBox TxtTelefono { get => txtTelefono; set => txtTelefono = value; }
        public TextBox TxtContrasenia { get => txtContrasenia; set => txtContrasenia = value; }
        public TextBox TxtApellidos { get => txtApellidos; set => txtApellidos = value; }
        public TextBox TxtNombres { get => txtNombres; set => txtNombres = value; }
        public Label Label10 { get => label10; set => label10 = value; }
        public PictureBox PictureBox2 { get => pictureBox2; set => pictureBox2 = value; }
        public PictureBox PictureBox1 { get => pictureBox1; set => pictureBox1 = value; }
        public Label Label9 { get => label9; set => label9 = value; }
        public ComboBox ComboAcceso { get => comboAcceso; set => comboAcceso = value; }
        public Label Label8 { get => label8; set => label8 = value; }
        public Label Label7 { get => label7; set => label7 = value; }
        public Label Label6 { get => label6; set => label6 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label12 { get => label12; set => label12 = value; }
        public Label Label11 { get => label11; set => label11 = value; }
        public Button BtnLimpiar { get => btnLimpiar; set => btnLimpiar = value; }
        public TableLayoutPanel TableLayoutPanel2 { get => tableLayoutPanel2; set => tableLayoutPanel2 = value; }
        public DataGridView Tabla { get => tabla; set => tabla = value; }
     
        public TableLayoutPanel TableLayoutPanel4 { get => tableLayoutPanel4; set => tableLayoutPanel4 = value; }
        public TextBox TxtFiltrar { get => txtFiltrar; set => txtFiltrar = value; }
    }
}