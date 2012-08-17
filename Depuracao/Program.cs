using System;
using System.Collections.Generic;
using System.Text;

namespace Depuracao
{
    class Program
    {
        static int Mudar(int n)
        {
            n = n + 1;
            return n;
        }

        static float Dividir(int n, int d)
        {
            return n / d;
        }

        static void Main(string[] args)
        {
            int numero = 0;
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("O numero escolhido é: {0}", numero);
            numero = Mudar(numero);
            Console.WriteLine("O numero modificado é: {0}", numero);

            int dominador = 0;
            dominador = int.Parse(Console.ReadLine());
            if (dominador == 0)
                Console.WriteLine("Não é possivel dividir {0} por zero", numero);
            else
                Console.WriteLine("O quociente entre {0} e {1} é {2}", numero, dominador, Dividir(numero, dominador));
            Console.Read();
        }
    }
}
