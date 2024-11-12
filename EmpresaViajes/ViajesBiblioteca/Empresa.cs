using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca
{
    public class Empresa
    {
        List<Cliente> ListaCliente = new List<Cliente>();
        List<Paquete> ListaPaquete = new List<Paquete>();

        public Cliente this[int dni]
        {
            get
            {
                ListaCliente.Sort();
                int a = ListaCliente.BinarySearch(new Cliente(0, dni, null));
                if (a >= 0)
                {
                    return ListaCliente[a];
                }
                return null;
            }
        }
        public Cliente AgregarCliente (Cliente cliente)
        {
            ListaCliente.Add(cliente);
        }
        public void QuitarCliente(Cliente cliente)
        {
            ListaCliente.Remove(cliente);
        }
        public List<Cliente> HistorialClientes()
        {
            List<Cliente> listilla= null;
            if (ListaCliente.Count > 0)
            {
                listilla = ListaCliente;
            }
            return listilla;
        }
        
        public void CrearViaje(Cliente cliente)     //??
        {

        }
        




    }
}
