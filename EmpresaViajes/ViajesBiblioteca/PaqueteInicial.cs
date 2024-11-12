using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca
{
    public class PaqueteInicial:Paquete
    {
        public bool SalidasOpcional = false;
        private string[] TipoExcursiones = new string[20];
        private int cont = 0;
        public PaqueteInicial(string H, string T, string C, string D, int Dur) : base(H,T,C,D,Dur)
         {
             Hospedaje = H;
             Transporte = T;
             Comida = C;
            Destino = D;
            Duracion = Dur;
         }
        //En la implementacion, no tiene sentido tener un paquete inicial
        public string VerExcursiones()              //devuelve las excursiones
        {
            string excursiones = null;
            foreach (string T in TipoExcursiones)
            {
                excursiones += T + "-";
            }
            return "";
        }
        public void AgregarExcursiones(string exc)  //chequea que no sobrepase el maximo de excursiones
        {
            if ((exc != null) && (TipoExcursiones.Length < 20))
            {
                TipoExcursiones[cont] = exc;
                cont++;
            }
        }
        
    }
}
