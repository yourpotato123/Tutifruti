using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca 
{
    public class Cliente : IComparable<Cliente>
    {
        public int Edad { get; private set; }
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public string [] Viajes { get; set; }
        public Cliente(int e, int d, string n)
        {
            Edad = e;
            DNI = d;
            Nombre = n;
        }

        public void AgregarViaje(string viaje)
        {

        }
        public override string ToString()
        {
            return $"{DNI} - {Nombre} - {Edad}";
        }
        public int CompareTo(Cliente obj)
        {
            if (obj != null)
            {
                return DNI.CompareTo(obj.DNI);
            }
            return 1;
        }

    }
}
