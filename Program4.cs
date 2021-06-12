using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread musica = new System.Threading.Thread(new System.Threading.ThreadStart(Musica));
            System.Threading.Thread opera = new System.Threading.Thread(new System.Threading.ThreadStart(Opera));
            System.Threading.Thread word = new System.Threading.Thread(new System.Threading.ThreadStart(Word));
            musica.Start();
            opera.Start();
            word.Start();
        }
        static void Musica()
        {
            int i = 0;
            while (i == 0) { 
            Console.WriteLine("Escuchando Spotify");
            }
        }
        static void Opera()
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Procesando Opera");
            }
        }
        static void Word()
        {
            int i = 0;
            while (i == 0)
            {
                Console.WriteLine("Procesando Procesador de Texto");
            }
        }
    }
}
