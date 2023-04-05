using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloOrientadoObjetos
{
    internal class Triangulo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public string resposta { get; set; }

        public string VerificarTipo() 
        {
            if (X == 0 || Y == 0 || Z == 0)
            {
                resposta = "Não pode conter valores do tipo zero!";
            }
            else
            {
                if (X < Y + Z || Y < X + Z || Z < Y + X)
                {
                    Console.WriteLine("\nForma um triângulo\n");
                }
                if (X == Y && Y == Z && X == Z)
                {
                    resposta = "Triângulo Equilátero";
                }
                else if (X == Y || Y == Z || X == Z)
                {
                    resposta = "Triângulo Isósceles";
                }
                else
                {
                    resposta = "Triângulo Escaleno";
                }
            }
                return resposta;
        }
    }
}
