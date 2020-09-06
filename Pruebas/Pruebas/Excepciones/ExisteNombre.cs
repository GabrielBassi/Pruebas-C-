using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Excepciones
{
    class ExisteNombre : Exception
    {
        public ExisteNombre(string message) : base(message)
        {

        }

    }
}
