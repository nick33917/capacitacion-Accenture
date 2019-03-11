using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("bienvenidos al primer curso!");
            Console.ReadKey();
            

            //Variables
            string Nombre;
            string Apellido;

            Console.Write("Cual es tu nombre: ");
            Nombre = Console.ReadLine();

            Console.Write("Cual es tu apellido: ");
            Apellido = Console.ReadLine();

            //Console.WriteLine("El nombre ingresado es: " + Nombre);

            //{0} es el parametro.
            Console.WriteLine("El nombre es: {0} y el apellido es: {1}",Nombre,Apellido);
            Console.ReadKey();

            

            //constantes
            const int DiasSemana = 7;
            const int HorasPorDia = 24;
            Console.WriteLine("La cantidad de horas de una semana es {0}", DiasSemana * HorasPorDia);
            Console.ReadKey();
            
            

            //Variables Char
            char char1 = 'Z'; //un caracter
            char char2 = (char)88;// valor tabla ASCII convertido a CHAR
            Console.WriteLine(char1 + " " + char2);
            Console.ReadKey();

           

            //Variables Boolean se puede definir (bool x,y,z;)
            bool z;
            z = true;
            Console.WriteLine(z);
            z = false;
            Console.WriteLine(z);
            Console.ReadKey();

            
        

            //VARIABLES float
            float fl = 0;
            Console.WriteLine(fl);
            fl = 95.60f; //asigna el literal 95.60 con sufijo f o F , si lo pongo sin sufijo es DOUBLE
            Console.WriteLine(fl);

            //VARIABLES Double
            double dl = 0;
            Console.WriteLine(dl);
            dl = 95.60d; //asigna el literal 95.60 con sufijo d o D
            Console.WriteLine(dl);

            Console.ReadKey();

            


            //Operaciones Logicas

            bool A = true;
            bool B = false;
            bool resultado = A && B; //AND
            Console.WriteLine("{0} and {1} da {2}", A, B, resultado);

            resultado = A || B; // OR
            Console.WriteLine("{0} or {1} da {2}", A, B, resultado);

            resultado = !A; //NOT
            Console.WriteLine("not {0} da {1}", A, resultado);

            Console.ReadKey();

        
            */

            //Operaciones Relacionales

            int A = 10;
            int B = 5;
            Console.WriteLine("{0} es mayor a {1} ? {2}", A, B, A>B);
            Console.WriteLine("{0} es menor a {1} ? {2}", A, B, A<B);
            Console.ReadKey();


        }
    }
}
