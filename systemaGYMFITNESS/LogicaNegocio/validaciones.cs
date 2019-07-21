using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace systemaGYMFITNESS.LogicaNegocio
{
    public class validaciones
    {
        //Textbox solo numeros y coma
        public static void soloNumerosYComa(KeyPressEventArgs e, bool isdecimal)
        {
            String aceptados;
            if (!isdecimal)
            {
                aceptados = "0123456789," + Convert.ToChar(8);
            }
            else
                aceptados = "0123456789," + Convert.ToChar(8);

            if (aceptados.Contains("" + e.KeyChar))
            {
                e.Handled = false;                
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros y coma (,)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Textbox solo numeros
        public static void soloNumero(KeyPressEventArgs e, bool isdecimal)
        {
            String aceptados;
            if (!isdecimal)
            {
                aceptados = "0123456789" + Convert.ToChar(8);
            }
            else
                aceptados = "0123456789" + Convert.ToChar(8);

            if (aceptados.Contains("" + e.KeyChar))
            {
                e.Handled = false;                
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //comboBox no admiten escribir
        public static void noEscribir(KeyPressEventArgs e, bool isdecimal)
        {
            String aceptados;
            if (!isdecimal)
            {
                aceptados = "" + Convert.ToChar(8);
            }
            else
                aceptados = "" + Convert.ToChar(8);

            if (aceptados.Contains("" + e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("No se admiten el ingreso de datos, unicamente escoja un valor de la lista", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void soloLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        public static Boolean fechasNoMenores(string fecha)
        {
            Boolean permitir = true;
            DateTime fechaUsuario = DateTime.Parse(fecha);
            int result = DateTime.Compare(fechaUsuario, DateTime.Today);
            string compara;
            if (result < 0)
                permitir = false;
            //if (result < 0)
            //    compara = "la fecha de nacimiento es menor que la actual";
            //else if (result == 0)
            //    compara = "las fechas coniciden";
            //else
            //    compara = "la fecha de nacimiento es superiorr a la actual";
            return permitir;
        }

        public static Boolean fechasNoMayores(string fecha)
        {
            Boolean permitir = true;
            DateTime fechaUsuario = DateTime.Parse(fecha);
            int result = DateTime.Compare(fechaUsuario, DateTime.Today);
            string compara;
            if (result > 0)
                permitir = false;
            return permitir;
        }
    }
}
