﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViajesBiblioteca
{
    public class Pagos
    {
        public int Cuotas {  get; private set; }
        public double Precio {  get; private set; }

        public Pagos(int cuotas, double precio)
        {
            Cuotas = cuotas;
            Precio = precio;
        }

        public override string ToString()
        {
            return $"{Cuotas}-{Precio}";
        }
    }
}
