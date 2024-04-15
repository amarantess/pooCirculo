using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circulo c = new Circulo();

            Console.WriteLine("##CALCULA ÁREA E PERÍMETRO##");
            Console.WriteLine();

        Inicio:
            Console.Clear();

            Console.Write("Informe o raio do círculo: ");
            c.Raio = double.Parse(Console.ReadLine());
            Console.WriteLine();

            c.CalculaArea();
            c.CalculaPerimetro();

            Console.WriteLine();
            Console.WriteLine("Deseja repetir? Sim/Não");
            string opcao = Console.ReadLine();

            if (opcao == "Sim" || opcao == "sim") goto Inicio;


            Console.ReadKey();
        }
    }
}
