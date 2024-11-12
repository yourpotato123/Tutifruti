using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca
{
    public class Viaje : IComparable<Viaje>
    {
        public string Destino { get; private set; }
        public int Duracion {  get; private set; }
        public Viaje (string destino, int duracion)
        {
            this.Destino = destino;
            if (duracion<10 && duracion > 3)
            {
                this.Duracion = duracion;
            }
            else
            {
                throw new Exception("Duracion entre 3 y 5 dias"); 
            }
        }
        public void AgregarDestino(string des)
        {
            Destino = des;
        }
        public void AgregarDuracion(int dur)
        {
            Duracion = dur;
        }


        public override string ToString()
        {
            return $"{Destino} - {Duracion}";
        }

        public int CompareTo(Viaje other)
        {
            if (other != null)
            {
                return Destino.CompareTo(other.Destino);
            }
            return 1;
        }




    }
}
