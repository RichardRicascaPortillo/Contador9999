using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Datos;
using Entidades;

namespace Negocio
{
    public class N_Prueba
    {
        D_Prueba objDatos = new D_Prueba();

        public List<E_Prueba> VerPrimerValor(DateTime inicio, DateTime fin)
        {
            return objDatos.PrimerValor(inicio, fin);
        }
        public List<E_Prueba> VerUltimoValor(DateTime inicio, DateTime fin)
        {
            return objDatos.UltimoValor(inicio, fin);
        }
    }
}
