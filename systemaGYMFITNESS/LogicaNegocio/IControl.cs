using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace systemaGYMFITNESS.LogicaNegocio
{
    interface IControl
    {
        void insert();
        void update();
        void delete();
        void buscar();
        void presentarTabla();
    }
}
