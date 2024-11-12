using System.Collections.Generic;
using System.ComponentModel;

namespace ViajesBiblioteca
{
    public class Empresa
    {
        List<Cliente> ListaCliente = new List<Cliente>();
        List<Paquete> ListaPaquete = new List<Paquete>();

        public Paquete CrearPaquete(string H, string T, string C, bool SO)
        {
            Paquete p;
            if (SO == true)
            {
                p = new PaqueteInicial(H, T, C, SO);
            }
            else
            {
                p = new PaqueteCompra(H, T, C);
            }
            if (p != null)
            {
                ListaPaquete.Add(p);
            }
            return p;
        }
        public Cliente AgregarCliente(Cliente c)
        {
            ListaCliente.Add(c);
            return c;
        }
        public Cliente QuitarCliente(int dni)
        {
            Cliente c = BusqCliente(dni);
            ListaCliente.Remove(c);
            return c;
        }
        public Cliente BusqCliente(int dni)
        {
            Cliente c = null;
            Cliente busq = new Cliente(0, dni, "");
            ListaCliente.Sort();
            int idx = ListaCliente.BinarySearch(busq);
            c = ListaCliente[idx];
            return c;
        }
      
    }
}
