using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Numeros_aleatorios
{
    public partial class Ejercicio1 : Form
    {
        //DataTable dataTable;
        ArrayList aleatorios;
        int CANT_ITERACIONES = 20;
        int x0;
        int k;
        int g;
        int c;
        int a;
        long m;
        int indice;

        public Ejercicio1()
        {
            InitializeComponent();
            aleatorios = new ArrayList();
            modulo.Text = CANT_ITERACIONES + "";
            enteroG.Text = Math.Truncate(Math.Log2(CANT_ITERACIONES)) + "";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            grdResultados.Rows.Clear();
            indice = -1;
            x0 = int.Parse(semilla.Text);
            k = int.Parse(enteroK.Text);
            g = int.Parse(enteroG.Text);
            c = int.Parse(constanteAditiva.Text);
            a = int.Parse(constanteMultiplicativa.Text);
            m = long.Parse(modulo.Text);

            MessageBox.Show( " " + x0 + k + g + c + a + m);
            if (rbLineal.Checked) { congruencialLineal(); }
            else { congruencialMultiplicativo(); }

        }


        private void congruencialLineal()
        {
            long entradaAnterior = x0;
            long entradaActual;
            double aleatorioActual;

            for (int i = 0; i < CANT_ITERACIONES; i++)
            {
                entradaActual = ((a * entradaAnterior) + c) % (m);
                aleatorioActual = (double)entradaActual / (m); // (m-1) para incluir el 1 
                var aleatorioActualTruncado = truncarDecimales(aleatorioActual); // Truncate() remueve los decimales
                aleatorios.Add(aleatorioActualTruncado);
                entradaAnterior = entradaActual;
            }
        }

        private float truncarDecimales(double numero)
        {
            int factor = 10000;
            return (float) Math.Truncate(factor * numero) / factor;
        }

        private void congruencialMultiplicativo()
        {
            //falta

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (indice + 1 >= CANT_ITERACIONES) { return; }
            grdResultados.Rows.Add();
            ++indice;
            grdResultados.Rows[indice].Cells[0].Value = indice + 1;
            grdResultados.Rows[indice].Cells[1].Value = aleatorios[indice];
            grdResultados.CurrentCell = grdResultados.Rows[indice].Cells[0];
        }


        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }

        private void enteroK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarK();
                actualizarA();
            }
        }

        private void constanteMultiplicativa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarA();
                actualizarK();
            }
        }

        private void modulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarG();
                actualizarM();
            }
        }

        private void enteroG_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                actualizarM();
                actualizarG();
            }
        }

        private void actualizarG()
        {
            m = long.Parse(modulo.Text);
            g = (int)Math.Log2(m);
            enteroG.Text = g + "";
        }

        private void actualizarM()
        {
            g = int.Parse(enteroG.Text);
            m = (long)Math.Pow(2, g);

            modulo.Text = m + "";
        }

        private void actualizarK()
        {
            k = int.Parse(enteroK.Text);
            a = 1 + 4 * k;

            constanteMultiplicativa.Text = a + "";
        }

        private void actualizarA()
        {
            a = int.Parse(constanteMultiplicativa.Text);
            k = (a - 1) / 4;

            enteroK.Text = k + "";
        }


       
    }
}