using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unidad 1: Estructuras de control II
            //Unidad 2: Funciones II
            //Sesion 12: Instruccion while

            // sintaxis: while

            // inicializacion;
            // while(expresion)
            //{
            //   bloque de instrucciones
            //   iterador;
            //}

            // iterar: repetir.

            // Ejemplo 1: ciclo ascendente (rango: 1-3)

            // m: variable de control
            int m=1; //Inicializacion
            while(m <= 3)
            {
                //Bloque de instrucciones.
                Console.WriteLine($"m: {m}");
                m += 1; // iterador
            }
            //Ejercitacion: definir un ciclo para imprimir tu nombre 5 veces
            //nota: usar el operador menor que
            int n=1;
            while(n < 6)
            {
                Console.WriteLine("abril");
                n += 1;
            }

            //b. ciclo descendente
            int d=3;
            while(d>=1)
            {
                Console.WriteLine($"d: {d}");
                d-=1;
            }

            //c. incrementos (ciclo ascendente)
            // secuencia: 3, 6, 9, 12, 15, 18.
            int i=3;
            while(i<=18)
            {
                Console.WriteLine($"i: {i}");
                i+=3;
            }

            //ejercitacion: definir un ciclo para imprimir 331 8 veces
            // define un ciclo descendente con decrementos de dos unidades
            int s= 16;
            while(s>0)
            {
                Console.WriteLine("331");
                s-=2;
            }
        } 
    } 
} 
