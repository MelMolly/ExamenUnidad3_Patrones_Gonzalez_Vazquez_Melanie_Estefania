using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Unidad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fachada gestor = new Fachada();

            Console.WriteLine("================= Gestor de Audio =================");

            string archivo = "";
            do
            {
                Console.Write("Ingrese el nombre del archivo de audio (ejemplo: cancion.mp3): ");
                archivo = Console.ReadLine().Trim();
                Console.Clear();

                if (string.IsNullOrEmpty(archivo))
                {
                    Console.WriteLine("================= Gestor de Audio =================");
                    Console.WriteLine("Ingrese un archivo...");
                }
            } while (string.IsNullOrEmpty(archivo));

            Console.WriteLine("================= Gestor de Audio =================");
            Console.Write("\n¿Desea aplicar efectos? (S/N): ");
            string respuesta = Console.ReadLine().Trim().ToUpper();

            bool aplicarEfectos = respuesta == "S";

            if (!aplicarEfectos)
            {
                IAudio audioSimple = new AudioBase(archivo);
                Console.WriteLine("\nReproduciendo sin efectos...");
                audioSimple.Reproducir();
                Console.WriteLine("\nReproducción finalizada... ¡Gracias por usar el gestor de audio!");
                Console.ReadLine();
                return;
            }
            
            Console.WriteLine("\nSeleccione los efectos que desea aplicar (S/N):");

            Console.Write("Efecto Eco: ");
            bool eco = Console.ReadLine().Trim().ToUpper() == "S";

            Console.Write("Efecto Distorsión: ");
            bool distorsion = Console.ReadLine().Trim().ToUpper() == "S";

            Console.Write("Efecto Reverberación: ");
            bool reverb = Console.ReadLine().Trim().ToUpper() == "S";

            Console.Write("Efecto Graves Intensos: ");
            bool graves = Console.ReadLine().Trim().ToUpper() == "S";

            Console.Write("Efecto Agudos Claros: ");
            bool agudos = Console.ReadLine().Trim().ToUpper() == "S";

            Console.Clear();
            Console.WriteLine("================= Gestor de Audio =================");

            Console.WriteLine("\nReproduciendo su audio...");
            gestor.AudioConEfectos(archivo, eco, distorsion, reverb, graves, agudos);

            Console.WriteLine("\nReproducción finalizada... ¡Gracias por usar el gestor de audio!");
            Console.ReadLine();
            Console.ReadKey();
        }
    }
  
}
