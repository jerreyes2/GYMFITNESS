using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * 
 * */
namespace systemaGYMFITNESS.Datos
{
    public class CRUDCrearEmpleadoUsuario
    {

        private bdDataContext db = new bdDataContext();

        public Empleado empleadoCRUD, usuario;

        public bdDataContext Db { get => db; set => db = value; }

        // metodo que me consulta  a un usuario
        public Empleado getUsuario(String cedula)
        {
            try
            {
                empleadoCRUD = db.Empleados.Single(x => x.cedula_Empleado == cedula);
            }
            catch (System.InvalidOperationException)
            {
                empleadoCRUD = null;

            }
            return empleadoCRUD;

        }


        /*
         Metodo que inserta un usuario
         */

        public void insert(Empleado empleado)
        {
            try
            {
                bool bandera = false;

                empleadoCRUD = getUsuario(empleado.cedula_Empleado); // este me daba error
                
               if (empleadoCRUD!=null)
                    bandera = true;

                if (bandera != true)
                {
                    db.Empleados.InsertOnSubmit(empleado);
                    db.SubmitChanges();
                    MessageBox.Show(" Cuenta de usuario creada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Usuario existente, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inesperado al ingresar, Contacte con el administrador del Sistema :\n" + ex, "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /*
         Metodo que actualiza un usuario
         */
        public void update(String cedula, Empleado empleado)
        {
            try
            {
                empleadoCRUD = getUsuario(empleado.cedula_Empleado);

                if (empleadoCRUD != null)
                {
                    empleadoCRUD.cedula_Empleado = empleado.cedula_Empleado;
                    empleadoCRUD.nombre = empleado.nombre;
                    empleadoCRUD.apellido = empleado.apellido;
                    empleadoCRUD.direccion = empleado.direccion;
                    empleadoCRUD.telefono = empleado.telefono;
                    empleadoCRUD.login = empleado.login;
                    empleadoCRUD.password = empleado.password;
                    empleadoCRUD.tipo_acceso = empleado.tipo_acceso;
                    empleadoCRUD.email = empleado.email;

                    db.SubmitChanges();
                    MessageBox.Show("Usuario/Empleado modificado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inesperado al actualizar datos, Contacte con el administrador del Sistema : \n" + ex, "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /*
         Metodo que elimina un usuario
         */
        public void delete(string cedula)
        {
            empleadoCRUD = getUsuario(cedula);

            DialogResult resul = MessageBox.Show("Esta seguro que quiere eliminar a : \n" + empleadoCRUD.nombre, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resul == DialogResult.Yes)
            {
                if (empleadoCRUD != null)
                {
                    try
                    {
                        db.Empleados.DeleteOnSubmit(empleadoCRUD);
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Inesperado al eliminar datos, Contacte con el administrador del Sistema : \n" + ex, "Error update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }


        }
    }


}
