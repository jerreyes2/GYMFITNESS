using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemaGYMFITNESS.Datos
{
    class CRUDClientes
    {
        private bdDataContext db = new bdDataContext();

        public clientes clientesCRUD;

        public void insert(clientes cliente)
        {
            try
            {
                bool bandera = false;

                clientesCRUD = getClientes(cliente.cedula); // este me daba error

                if (clientesCRUD != null)
                    bandera = true;

                if (bandera != true)
                {
                    db.clientes.InsertOnSubmit(cliente);
                    db.SubmitChanges();
                    MessageBox.Show(" Cliente creado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Cliente existente, no puede ser ingresado nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inesperado al ingresar, Contacte con el administrador del Sistema :\n" + ex, "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public clientes getClientes(String cedula)
        {
            try
            {
                clientesCRUD = db.clientes.Single(x => x.cedula == cedula);
            }
            catch (System.InvalidOperationException)
            {
                clientesCRUD = null;

            }
            return clientesCRUD;
        }
    }
}
