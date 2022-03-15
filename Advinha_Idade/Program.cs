using System;

namespace Advinha_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com um numero de 1 a 9: ");
            int x = int.Parse(Console.ReadLine());
            x = ((x * 2) + 5 ) * 50;
            Console.WriteLine("Ja fez aniversario este ano? (s/n)");
            char resp = char.Parse(Console.ReadLine());
            int val;
            if(resp == 's')
            {
                val = 1772;
                x += val;
            }
            else
            {

                val = 1771;
                x += val;
            }
            Console.Write("Entre com o ano do seu nascimento: ");
            int n = int.Parse(Console.ReadLine());
            int resultado = x - n;
            Console.WriteLine("O resultado a seguir é o numero que voce escolheu seguido da sua idade atual.");
            Console.WriteLine($"O resultado é {resultado}");
            Console.ReadLine();
        }
    }
}
