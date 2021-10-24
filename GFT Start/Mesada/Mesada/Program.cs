//Crie uma classe representando a mesada que um pai paga para seu filho, com
//métodos para pagar uma quantia, para o filho sacar uma quantia e para o filho saber
//o saldo. Como este filho apronta muito, cada saque que o filho faz ele devolve 0,5%
//do valor recebido para o pai. Depois crie uma subclasse desta classe anterior para
//representar um filho que não apronta...Filho que não apronta devolve apenas 0,1% do
//valor recebido para o pai. Mostre o resultado das duas classes



using System;
using Mesada;
using Mesada.Entities;

namespace Mesada
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            int menu = 0;
            int filho = 0;
            double mesada = 0;

            while (loop == true)
            {
                Console.WriteLine("1 - Para pagar  2 - Para sacar 3 - Ver Saldo");
                menu = Convert.ToInt32(Console.ReadLine());
                if (menu == 1)
                {
                    Console.WriteLine("Escolha filho 1 ou filho 2");
                    filho = Convert.ToInt32(Console.ReadLine());
                    if (filho == 1)
                    {
                        Console.WriteLine("Digite o valor da mesada do filho 1");
                        mesada = Convert.ToDouble(Console.ReadLine());
                    } else
                    {
                        Console.WriteLine("Digite o valor da mesada do filho 2");
                        mesada = Convert.ToDouble(Console.ReadLine());
                    }

                }
                
            }
        }

    }
}
