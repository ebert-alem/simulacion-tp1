using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_aleatorios.Negocio
{
    class Ji_Cuadrada
    {
        int K { get; set; }
        int M { get; set; }
        int V { get; set; }

        int[] Fo;
        int Fe;
        float[] Serie;



        public Ji_Cuadrada(int k, int m)
        {
            M = m;
            K = k;

            Serie = new float[m];
            Fo = new int[k];
            Fe = M / K;
        }

        public void generarSerie()
        {
            Random random = new Random();
            for (int i = 0; i < M; i++)
            {
                Serie[i] = random.Next(0, 9999) / 1000;
            }
        }

        public float[] generarIntervalos()
        {
            float rango = 0;
            float[] intervalos = new float[K];
            for (int i = 0; i < K; i++)
            {
                intervalos[i] = rango + (1 / K);
            }
            return intervalos;
        }

        public int[] calcularFo()
        {
            float[] intervalos = generarIntervalos();
            for (int i = 0; i < K; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (Serie[j] < intervalos[i])
                    {
                        Fo[i] += 1;
                    }
                }
            }
            return Fo;
        }

    }
}