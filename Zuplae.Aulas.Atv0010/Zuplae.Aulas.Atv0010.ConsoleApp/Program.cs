using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zuplae.Aulas.Atv0010.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================== ATV-0010 ==========================");
            Console.WriteLine("Digite o nome da cidade: ");
            string cidade = Console.ReadLine();
            Console.WriteLine("Digite o nome do estado: ");
            string estado = Console.ReadLine();
            Console.WriteLine("Digite o nome do país: ");
            string pais = Console.ReadLine();
            Console.WriteLine("Digite a população: ");
            int populacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a PIB: ");
            double pib = double.Parse(Console.ReadLine());

            Console.WriteLine($"Os dados digitados foram: Cidade: {cidade}, Estado: {estado}, País: {pais}, População: {populacao} e o PIB: {pib}");
        }
    }
}
