using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Excepciones
{
    class ExcepcionControlFechas: Exception
    {
        public ExcepcionControlFechas(string message) : base(message)
        {

        }
    }
}
