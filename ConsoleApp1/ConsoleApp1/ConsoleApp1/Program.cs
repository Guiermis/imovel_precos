using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_de_Preco
{
    class Program
    {
        static void Main(string[] args)
        {
            Usado usad = new Usado();
            Novo nov = new Novo();

            Console.WriteLine("voce deseja ele novo ou usado?");
            string info = Console.ReadLine();

            if (info == "novo")
            {
                Console.WriteLine("Digite o nome:");
                nov.nome = Console.ReadLine();
                Console.WriteLine("Digite o endereço:");
                nov.endereco = Console.ReadLine();
                Console.WriteLine("Digite o preço:");
                nov.preco = double.Parse(Console.ReadLine());

                nov.aument = 50000.00;

                double total1 = nov.preco + nov.aument;

                Console.WriteLine(" Nome: {0} \n Endereco: {1} \n Preco: {2} \n Total: {3}", nov.nome, nov.endereco, nov.preco, total1);

            } else if (info == "usado")
            {
                Console.WriteLine("Digite o nome:");
                usad.nome = Console.ReadLine();
                Console.WriteLine("Digite o endereço:");
                usad.endereco = Console.ReadLine();
                Console.WriteLine("Digite o preço:");
                usad.preco = double.Parse(Console.ReadLine());

                usad.desconto = 50000.00;

                double total2 = usad.preco + usad.desconto;

                Console.WriteLine(" Nome: {0} \n Endereco: {1} \n Preco: {2} \n Total: {3}", usad.nome, usad.endereco, usad.preco, total2);

            }
            else
            {
                Console.WriteLine("selecione apenas 'usado' ou 'novo'");
            }
        }
    }
}
