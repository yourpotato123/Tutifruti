using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca
{
    internal class PaqueteCompra:Paquete
    {
        public PaqueteCompra(string H, string T, string C):base(H,T,C)
        {
          
        }
        public override bool RealizarEx(string TE)
        {
            throw new System.NotImplementedException();
        }
    }
}
