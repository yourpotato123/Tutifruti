using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca
{
    internal class PaqueteCompra:Paquete
    {
        public PaqueteCompra(string H, string T, string D, string Dur):base(H,T,D,Dur)
        {
            Hospedaje = H;
            Transporte = T;
            Comida = null;
            Viaje viaje = null;
            viaje.AgregarDestino(D);
            viaje.AgregarDestino(Dur);
        }

    }
}
