using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysMultidimencionales_Udemy_
{
    class Program
    {
        static void Main(string[] args)
        {
            //=========Array Bidimencional============//
            //[,] esto indica que tendremos columnas y filas
            //[5,2] tama;o de columnas = 2 y filas = 2
            //{6,3.0} columna 1 = 6 y columna 2 = 3.0
            double[,] doble = new double[2, 2] { {6,3.1},{ 6.3,5.6} };
            //[1,0] fila numero 1, columna numero 0 esto sera igual a = 6.3
            Console.WriteLine("Resultado " + doble [1,0]);
            Console.ReadLine();

            //========Array Tridimencional============//
            double[,,] doble2 = new double[2,2,3] { { {3.0,6.9,8.9},{3.6,3.5,4.5} },{ { 6.5,8.2,9.0},{ 7.5,8.2,9.5} }, };
            // fila 0 = { {3.0,6.9,8.9},{3.6,3.5,4.5} }
            // columna 1 = {3.6,3.5,4.5}
            // dato 2 = 4.5
            Console.WriteLine("Resultado " + doble2 [0,1,2]);
            Console.ReadLine();


        }
    }
}
