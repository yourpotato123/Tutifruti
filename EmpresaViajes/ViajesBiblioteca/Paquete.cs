using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca
{
    public abstract class Paquete
    {
        public Viaje viaje;
        public string Hospedaje { get; protected set; }
        public string Transporte { get; protected set; }
        public string Comida { get; protected set; }
        
        List<Cliente> clientes = new List<Cliente>();

        public int CantidadClientes
        {
            get { return clientes.Count; }
        }

        public Paquete(string H, string T, string C, string D, string Dur)
        {
            Hospedaje = H;
            Transporte = T;
            Comida = C;
            Viaje viaje = null;
            viaje.AgregarDestino(D);
            viaje.AgregarDestino(Dur);
        }
        //public abstract bool RealizarEx(string TE);

        
        public void AgregarCliente(Cliente cliente) //chequea que no sobrepase el limite de 70 personas
        {
            if (CantidadClientes < 70)
            {
                clientes.Add(cliente);
            }
        }
        /*public override string ToString()
        {
            return 
        }*/



    }
}
