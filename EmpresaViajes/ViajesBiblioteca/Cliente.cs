using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca 
{
    public class Cliente : IComparable
    {
        public Pagos cuota {  get; set; }
        public int Edad { get; private set; }
        public int DNI { get; private set; }
        public string Nombre { get; private set; }
        public Cliente(int e, int d, string n)
        {
            Edad = e;
            DNI = d;
            Nombre = n;
        }
        public override string ToString()
        {
            return $"{DNI} - {Nombre} - {Edad}";
        }
        public int CompareTo(Object obj)
        {
            Cliente c = obj as Cliente;
            if (c != null)
            {
                return DNI.CompareTo(c.DNI);
            }
            return 1;
        }

    }
}
