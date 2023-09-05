using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Conversores
    {
        public String[][] etiquetas = new String[][]{
            new String[]{"", ""},
            new String[]{"Dolar","Euro","Quetzalez","Lempiras","Colon SV","Cordoba","Pesos CR","Yen","Libras esterlina","Rupia India" },
            new String[]{ "Metro", "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Tareas", "Manzanas", "Hectareas"}
        };
        public double[][] valores = new double[][] {
            new double[]{},
            new double[]{1, 0.92, 7.86, 24.62, 8.75, 36.56, 535.14, 145.52, 0.79, 83.32},
            new double[]{1, 10.7639, 1.431, 1.19598888894151, 0.002285714285, 0.000143082804, 0.0001}
        };
        public double convertir(int tipo, int de, int a, double cantidad)
        {
            return valores[tipo][a] / valores[tipo][de] * cantidad;
        }
    }
}
