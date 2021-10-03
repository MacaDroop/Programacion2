using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable1 = "Hola mundo";

            //variable1
            int numero1 = 18;
            double densidad = 23456.12142; 
            string nombre = "jamil";
            bool estatus = true;

            //datos
            string alumna = "mariana";
            string edad = "25";
            string carrera = "tics";

            Console.WriteLine(variable1);
            var S = string.Format("alumna {0} tiene {1} años estudiar la carrera {2} ", alumna, edad, carrera);
            Console.WriteLine(S);
            Console.ReadLine();

        }
    }
}
