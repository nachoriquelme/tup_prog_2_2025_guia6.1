using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class RegistroVehiculo : IComparable
    {
        public string Patente {  get; private set; }
        public int Serie { get; private set; }
        public Persona Propietario { get; set; }

        public RegistroVehiculo(string Patente, int Serie, Persona propietario)
        {
            this.Patente = Patente;
            this.Serie = Serie;
            Propietario = propietario;

            Match m = Regex.Match(Patente.Trim(), @"^[A-Z]{3}\s*[0-9]{3}$", RegexOptions.IgnoreCase);
            if (m.Success == false)
            {
                throw new FormatException();
            }
        }

        public int CompareTo (object obj)
        {
            RegistroVehiculo otro = obj as RegistroVehiculo;
            if (otro == null)
            {
                return this.Patente.CompareTo(otro.Patente);
            }
            return 1;
        }

        public override string ToString()
        {
            return $"{Patente} - {Propietario.Nombre} - {Propietario.DNI}";
        }
    }
}
