using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            getPrimerValor();
            getSegundoValor();
            lblPrimerValor.Text = dgvInicio.CurrentRow.Cells[1].Value.ToString();
            lblUltimoValor.Text = dgvFin.CurrentRow.Cells[1].Value.ToString();

            lblResultado.Text = Convert.ToString(calcularFunc(Convert.ToDouble(lblPrimerValor.Text), Convert.ToDouble(lblUltimoValor.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void getPrimerValor()
        {
            N_Prueba objNegocio = new N_Prueba();
            dgvInicio.DataSource = objNegocio.VerPrimerValor(dtInicio.Value, dtFin.Value);


        }

        public void getSegundoValor()
        {
            N_Prueba objNegocio = new N_Prueba();
            dgvFin.DataSource = objNegocio.VerUltimoValor(dtInicio.Value, dtFin.Value);


        }
        public double calcularFunc(double primer_valor, double segundo_valor)
        {

            double respuesta = 0;

            if (primer_valor < segundo_valor)
            {
                respuesta = segundo_valor - primer_valor;

            }
            else if (primer_valor > segundo_valor)
            {
                respuesta = 9999 - primer_valor + segundo_valor;
            }

            return respuesta;
        }

        private void lblSegundoValor_Click(object sender, EventArgs e)
        {

        }
    }
}
