using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemaGYMFITNESS.Datos;
using systemaGYMFITNESS.Presentacion;

namespace systemaGYMFITNESS.LogicaNegocio
{
    public class controladorAsistenciaClientes
    {
        private CRUDAsistenciaClientes datos_cliente;
        private frmAsisenciaCliente formulario;
        Asistencia_Clientes OBJAsisenciaCliente;
        public controladorAsistenciaClientes(frmAsisenciaCliente formulario)
        {
            this.datos_cliente = new CRUDAsistenciaClientes();
            this.formulario = formulario;
        }

        public void insert()
        {
            OBJAsisenciaCliente = getAsistenciaClientes();
            datos_cliente.insert(OBJAsisenciaCliente);
        }
        private bdDataContext db = new bdDataContext();
        public Asistencia_Clientes getAsistenciaClientes()
        {
            OBJAsisenciaCliente = new Asistencia_Clientes();
            OBJAsisenciaCliente.ID_Asistencia_Clientes = "AC-"+ db.Asistencia_Clientes.Count();
            OBJAsisenciaCliente.cedula_cliente = formulario.txtCedula.Text.Trim();
            OBJAsisenciaCliente.fecha = DateTime.Parse(formulario.dtpFechaAsistencia.Value.ToString("dd/MM/yyyy"));
            return OBJAsisenciaCliente;
        }

        public void delete(String valor)
        {
            datos_cliente.delete(valor);
        }
    }
}
