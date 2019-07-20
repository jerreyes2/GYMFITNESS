using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using systemaGYMFITNESS.Datos;
using systemaGYMFITNESS.Presentacion;


namespace systemaGYMFITNESS.LogicaNegocio
{


    public class controladorEmpleadoUsuario : IControl
    {

        private CRUDCrearEmpleadoUsuario datos_empleado;
        private FrmEmpleados formulario;
        Empleado empleado;
     
        public controladorEmpleadoUsuario(FrmEmpleados formulario)
        {
            this.datos_empleado = new CRUDCrearEmpleadoUsuario();
            this.formulario = formulario; 
        }

        public void insert()
        {
            empleado = getDatosEmpleado();
            datos_empleado.insert(empleado);
            presentarTabla();
            
        }


        public void update()
        {

           datos_empleado.update(formulario.TxtCedula.Text.Trim(), getDatosEmpleado());
           presentarTabla();

        }

        public void delete()
        {
            datos_empleado.delete(formulario.TxtCedula.Text.Trim());
            presentarTabla();

        }
        public void presentarTabla()
        {
            datos_empleado.Db = new bdDataContext();
            formulario.Tabla.DataSource = datos_empleado.Db.Empleados;
        }

        public object getDBEmpleado()
        {
            return datos_empleado.Db.Empleados;
        }
        bdDataContext db;
        public void buscar()
        {
            if (formulario.TxtFiltrar.Text.Trim() != "")
            {
                var filtro = from Empleado c in datos_empleado.Db.Empleados where c.cedula_Empleado.ToUpper().Contains(formulario.TxtFiltrar.Text.Trim().ToUpper()) select c;
                foreach (Empleado c in filtro)
                {
                    formulario.Tabla.DataSource  = filtro;
                }
            }

        }

        public Empleado getDatosEmpleado()
        {
            empleado = new Empleado();

            empleado.cedula_Empleado = formulario.TxtCedula.Text.Trim();
            empleado.nombre = formulario.TxtNombres.Text.Trim();
            empleado.apellido = formulario.TxtApellidos.Text.Trim();
            empleado.direccion = formulario.TxtDireccion.Text.Trim();
            empleado.telefono = formulario.TxtTelefono.Text.Trim();
            empleado.login = formulario.TxtNombreUsuario.Text.Trim();
            empleado.password = formulario.TxtContrasenia.Text.Trim();
            empleado.tipo_acceso = formulario.ComboAcceso.SelectedItem.ToString();
            empleado.email = formulario.TxtEmail.Text.Trim();
           
            return empleado;
        }

    }
}




/*
            bandera = false;
            if (formulario.ComboAcceso.SelectedItem.Equals("ADMINISTRADOR"))
            {

                string entrada = Microsoft.VisualBasic.Interaction.InputBox("Ingrese contraseña de ADMINISTRADOR otorgada por el fabricante, sin ella no tiene permisos de crear usuarios administrativos");
                if (entrada.Equals("ADMIN1234"))
                {
                    empleado.cedula_Empleado = formulario.TxtCedula.Text.Trim();
                    empleado.nombre = formulario.TxtNombres.Text.Trim();
                    empleado.apellido = formulario.TxtApellidos.Text.Trim();
                    empleado.direccion = formulario.TxtDireccion.Text.Trim();
                    empleado.telefono = formulario.TxtTelefono.Text.Trim();
                    empleado.login = formulario.TxtNombreUsuario.Text.Trim();
                    empleado.password = formulario.TxtContrasenia.Text.Trim();
                    empleado.tipo_acceso = formulario.ComboAcceso.SelectedItem.ToString();
                    empleado.email = formulario.TxtEmail.Text.Trim();
                    bandera = true;
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta, pongase en contacto con el fabricante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                bandera = true;
                empleado.cedula_Empleado = formulario.TxtCedula.Text.Trim();
                empleado.nombre = formulario.TxtNombres.Text.Trim();
                empleado.apellido = formulario.TxtApellidos.Text.Trim();
                empleado.direccion = formulario.TxtDireccion.Text.Trim();
                empleado.telefono = formulario.TxtTelefono.Text.Trim();
                empleado.login = formulario.TxtNombreUsuario.Text.Trim();
                empleado.password = formulario.TxtContrasenia.Text.Trim();
                empleado.tipo_acceso = formulario.ComboAcceso.SelectedItem.ToString();
                empleado.email = formulario.TxtEmail.Text.Trim();

            }*/
