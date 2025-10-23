using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RangoDniIncorrectoException:ApplicationException
    {
        public RangoDniIncorrectoException() : base("Dni incorrecto") { }
        public RangoDniIncorrectoException(string message) : base(message) { }
        public RangoDniIncorrectoException(string message, Exception inner) : base(message, inner) { }
    }
}
