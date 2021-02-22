using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Prueba
    {
        private int _IdPrueba;
        private decimal _Valor;
        private DateTime _Tiempo;

        public int IdPrueba { get => _IdPrueba; set => _IdPrueba = value; }
        public decimal Valor { get => _Valor; set => _Valor = value; }
        public DateTime Tiempo { get => _Tiempo; set => _Tiempo = value; }
    }
}