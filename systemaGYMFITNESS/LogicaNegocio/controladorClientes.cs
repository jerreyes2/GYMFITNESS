using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using systemaGYMFITNESS.Datos;
using systemaGYMFITNESS.Presentacion;

namespace systemaGYMFITNESS.LogicaNegocio
{
     public  class controladorClientes
    {
        private CRUDClientes datos_cliente;
        private frmClientes formulario;
        clientes OBJcliente;

        public controladorClientes(frmClientes formulario)
        {
            this.datos_cliente = new CRUDClientes();
            this.formulario = formulario;
        }

        public void insert()
        {
            OBJcliente = getDatosEmpleado();
            datos_cliente.insert(OBJcliente);
        }

        public clientes getDatosEmpleado()
        {
            OBJcliente = new clientes();
            OBJcliente.cedula = formulario.txtCedula.Text.Trim();
            OBJcliente.nombres = formulario.txtNombres.Text;
            OBJcliente.apellidos = formulario.txtApellidos.Text;
            OBJcliente.direccion = formulario.txtDireccion.Text;
            OBJcliente.fecha_nacimiento = DateTime.Parse(formulario.dtpFecha_Nacimiento.Value.ToString("yyyy/MM/dd"));
            OBJcliente.telefono = formulario.txtTelefono.Text.Trim();
            OBJcliente.celular = formulario.txtCelular.Text.Trim();
            OBJcliente.peso = decimal.Parse(formulario.txtPeso.Text);
            if (formulario.txtCadera.TextLength > 0)
            {
                OBJcliente.cadera = decimal.Parse(formulario.txtCadera.Text);
            }
            else
            {
                OBJcliente.cadera = 0;
            }
            if (formulario.rbMasculino.Checked)
            {
                OBJcliente.sexo = "Masculino";
            }
            else
            {
                OBJcliente.sexo = "Femenino";
            }
            OBJcliente.altura = decimal.Parse(formulario.txtAltura.Text);
            OBJcliente.cuello = decimal.Parse(formulario.txtCuello.Text);
            OBJcliente.cintura = decimal.Parse(formulario.txtCintura.Text);
            OBJcliente.indiceCintura_Altura = decimal.Parse(formulario.txtIndici_cintura_altura.Text);
            OBJcliente.masaCorporalMagra = decimal.Parse(formulario.txtMasa_Corporal_magra.Text);
            OBJcliente.sobrepeso = decimal.Parse(formulario.txt_Sobrepeso.Text);
            return OBJcliente;
        }

    }
}
