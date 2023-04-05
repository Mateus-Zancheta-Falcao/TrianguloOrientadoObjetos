using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOrientadoObjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo();

            Console.WriteLine("Informe o valor de X");
            triangulo.X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de Y");
            triangulo.Y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o valor de Z");
            triangulo.Z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{triangulo.VerificarTipo()}");

            Console.ReadKey();
        }
    }
}
