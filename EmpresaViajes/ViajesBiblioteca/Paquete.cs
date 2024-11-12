using System.Collections.Generic;

namespace ViajesBiblioteca
{
    public abstract class Paquete
    {
        public string TE {  get; protected set; }
        public string Hospedaje { get; private set; }
        public string Transporte { get; private set; }
        public string Comida { get; private set; }
        Cliente[] clientes = new Cliente[70];
        int cont = 0;
        List<Viaje> viajes = new List<Viaje>();
        List<Pagos> pagos = new List<Pagos>();
     
        public Paquete(string H, string T, string C)
        {
            Hospedaje = H;
            Transporte = T;
            Comida = C;
           
        }
        public Viaje this[string destino]
        {
            get
            {
                viajes.Sort();
                Viaje v = new Viaje(destino, 0);
                int idx = viajes.BinarySearch(v);
                return viajes[idx];
            }
        }
        public abstract bool RealizarEx(string TE);
        public double PagoUnitario(int cuota,double total)
        {
            Pagos p = new Pagos(cuota,total);
            pagos.Add(p);
            return p.CalcularCuota();
        }
        public void AgregarCliente(Cliente c)
        {
            if (cont < 70)
            {
                clientes[cont++] = c;
                c.cuota = pagos[cont];
            }
          
        }
        public void CrearViaje(string D, int Dur) //chequea que no sobrepase el limite de 70 personas
        {
            Viaje v = new Viaje(D, Dur);
            viajes.Add(v);
        }
        /*public override string ToString()
        {
            return 
        }*/



    }
}
