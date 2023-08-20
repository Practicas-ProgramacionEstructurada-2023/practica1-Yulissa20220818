using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
           //Declaracion de variable 
           string nombre;
           int edad;
           string direccion;
           int telefono;
           string Universidad;
           string carrera;
           string facultad;
           int ciclo;

           Console.WriteLine("\n******************Practica 1 - Programacion Estructurada********************\n");
           Console.WriteLine("Ingresar tu nombre completo:"); //Obtener Datos
           nombre = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("Ingresa tu edad:"); //Obtener Datos 
           edad = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("Ingresa tu direccion: ");//Obtener Datos 
           direccion = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("Ingresa tu telefono");//Obtener Datos
           telefono = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("Ingresa a la Universidad que vas:");//Obtener Datos
           Universidad = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("Ingresa tu carrera:");//Obtener Datos
           carrera = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("Ingresa tu facultad:"); //Obtener Datos 
           facultad = Convert.ToString(Console.ReadLine());
           Console.WriteLine("\n");  

           Console.WriteLine("Ingresa tu ciclo:"); //Obtener Datos
           ciclo = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("\n");

           Console.WriteLine("Su noombre es: "+ nombre);
           Console.WriteLine("Su edad es: "+ edad);
           Console.WriteLine("su direccion es: "+ direccion);
           Console.WriteLine("Su telefono es: "+ telefono);
           Console.WriteLine("Universidad que estudia: "+ Universidad);
           Console.WriteLine("Su carrera  es: "+ carrera);
           Console.WriteLine("Su facultad es: "+ facultad);
           Console.WriteLine("Su ciclo es: "+ ciclo);
        }
    }
}
