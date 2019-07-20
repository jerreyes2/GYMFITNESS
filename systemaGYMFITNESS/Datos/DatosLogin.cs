using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemaGYMFITNESS.Datos
{
    public class DatosLogin
    {

        private bdDataContext db = new bdDataContext();

        public Empleados empleadoCRUD, cli;   // en el usuario es el mismo usuario q ingresa al sistema

        public bdDataContext Db { get => db; set => db = value; }

        // metodo que me consulta  a un usuario / usuario
        public Empleados getCLiente(String cedula)
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
        // metodo que me permite consultar usuario para logeo esta ya sea con la celula o el nombre de usuario
        public Empleados consultaUsuario(String usuario,String contrasenia)
        {
        
            try
            {
                  empleadoCRUD = db.Empleados.Single(x => (x.cedula_Empleado == usuario && x.password==contrasenia) || (x.login == usuario && x.password == contrasenia));
               
            }
            catch (System.InvalidOperationException)
            {
                empleadoCRUD = null;

            }
            return empleadoCRUD;

        }

        // metodo que me consulta  el email de un usuario / usuario
        public Empleados getEmpleadoEmail(String email)
        {
            try
            {
                empleadoCRUD = db.Empleados.Single(x => x.email == email);
            }
            catch (System.InvalidOperationException)
            {
                empleadoCRUD = null;

            }
            return empleadoCRUD;

        }

    }
}
