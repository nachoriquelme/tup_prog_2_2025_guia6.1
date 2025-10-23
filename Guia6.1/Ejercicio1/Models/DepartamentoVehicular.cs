using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ejercicio1.Models
{
    public class DepartamentoVehicular
    {
        List<RegistroVehiculo> registros = new List<RegistroVehiculo>();

        public int CantidadRegistros 
        {
            get 
            { 
                return registros.Count; 
            }
        }

        int serie;

        public RegistroVehiculo RegistrarVehiculo(Persona propietario, string patente)
        {
            RegistroVehiculo nuevo = new RegistroVehiculo(patente, ++serie, propietario);
            registros.Add(nuevo);
            return nuevo;
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx >=0 && idx < registros.Count)
            {
                return registros[idx];
            } 
            return null;
        }

        public void OrdenarRegistros()
        {
            registros.Sort();
        }
    }
}
