using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemaGYMFITNESS.Datos
{
    class CRUDAsistenciaClientes
    {
        private bdDataContext db = new bdDataContext();

        public Asistencia_Clientes asistencia_ClientesCRUD;
        public clientes clientesCRUD;
        public void insert(Asistencia_Clientes cliente)
        {
            Boolean aumentarCeros = false;
            int cantidadCeros=0;
            String ceros = "";
            do
            {
                try
                {
                    bool bandera = false;
                    clientesCRUD = getClientes(cliente.cedula_cliente); // este me daba error

                    if (clientesCRUD != null)
                        bandera = true;

                    if (bandera == true)
                    {
                        if (aumentarCeros == true)
                        {
                            for (int i = 0; i<= cantidadCeros; i++)
                            {
                                ceros = ceros + 0;
                            }
                            Match m = Regex.Match(cliente.ID_Asistencia_Clientes, "(\\d+)");
                            string num = string.Empty;
                            if (m.Success)
                            {
                                num = m.Value;
                            }
                            cliente.ID_Asistencia_Clientes = "AC-"+ ceros + num;
                        }
                        db.Asistencia_Clientes.InsertOnSubmit(cliente);
                        db.SubmitChanges();
                        MessageBox.Show("Asistencia guardada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aumentarCeros = false;
                    }
                    else
                    {
                        MessageBox.Show("La cedula del cliente no existe, por favor revise los datos ingresados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Violation of PRIMARY KEY") | ex.Message.Contains("DuplicateKeyException"))
                    {
                        aumentarCeros = true;
                        cantidadCeros++;
                    }
                    else
                    {
                        MessageBox.Show("Error Inesperado al guardar, Contacte con el administrador del Sistema :\n" + ex, "Error insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } while (aumentarCeros == true);            
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

        public void delete(string id)
        {
            asistencia_ClientesCRUD = getIDAsistencia(id);

            DialogResult resul = MessageBox.Show("Esta seguro que quiere eliminar a : \n" + asistencia_ClientesCRUD.ID_Asistencia_Clientes+ " "+ asistencia_ClientesCRUD.cedula_cliente + " " + asistencia_ClientesCRUD.fecha, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resul == DialogResult.Yes)
            {
                if (asistencia_ClientesCRUD != null)
                {
                    try
                    {
                        db.Asistencia_Clientes.DeleteOnSubmit(asistencia_ClientesCRUD);
                        db.SubmitChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Inesperado al eliminar datos, Contacte con el administrador del Sistema : \n" + ex, "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public Asistencia_Clientes getIDAsistencia(String id)
        {
            try
            {
                asistencia_ClientesCRUD = db.Asistencia_Clientes.Single(x => x.ID_Asistencia_Clientes == id);
            }
            catch (System.InvalidOperationException)
            {
                asistencia_ClientesCRUD = null;
            }
            return asistencia_ClientesCRUD;
        }
    }
}
