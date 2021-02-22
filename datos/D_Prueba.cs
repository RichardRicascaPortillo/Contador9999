using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class D_Prueba
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Prueba> PrimerValor(DateTime inicio, DateTime fin)
        {
            SqlDataReader PrimerValor;
            SqlCommand cmd = new SqlCommand("SP_PRIMERVALOR", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@INICIO", inicio);
            cmd.Parameters.AddWithValue("@FIN", fin);

            PrimerValor = cmd.ExecuteReader();
            List<E_Prueba> Listar = new List<E_Prueba>();

            while (PrimerValor.Read())
            {
                Listar.Add(new E_Prueba
                {
                    Valor = PrimerValor.GetDecimal(0)
                });
            }
            conexion.Close();
            PrimerValor.Close();
            return Listar;

        }

        public List<E_Prueba> UltimoValor(DateTime inicio, DateTime fin)
        {
            SqlDataReader PrimerValor;
            SqlCommand cmd = new SqlCommand("SP_ULTIMOVALOR", conexion);

            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            cmd.Parameters.AddWithValue("@INICIO", inicio);
            cmd.Parameters.AddWithValue("@FIN", fin);

            PrimerValor = cmd.ExecuteReader();
            List<E_Prueba> Listar = new List<E_Prueba>();

            while (PrimerValor.Read())
            {
                Listar.Add(new E_Prueba
                {
                    Valor = PrimerValor.GetDecimal(0)
                });
            }
            conexion.Close();
            PrimerValor.Close();
            return Listar;

        }
    }
}
