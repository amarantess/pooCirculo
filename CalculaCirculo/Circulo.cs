using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculaCirculo
{
    public class Circulo
    {
        // Propriedade
        private double raio;

        public double Raio
        {
            get { return raio; }
            set { raio = value; }
        }

        // Métodos
        public void CalculaArea()
        {
            double calculo = 3.14 * (this.Raio * this.Raio);
            Console.WriteLine($"A área do círculo é: {calculo}");
        }

        public void CalculaPerimetro()
        {
            double calculoP = 2 * 3.14 * this.Raio;
            Console.WriteLine($"O Perímetro do círculo é: {calculoP}");
        }
    }
}
