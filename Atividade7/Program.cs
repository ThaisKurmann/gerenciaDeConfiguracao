using System;
using System.Globalization;

namespace Atividade7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Formula: IMC = peso / (altura * altura)
            Console.WriteLine("Calculo de IMC");
            Console.WriteLine("Entre com seu peso : ");
            double peso;
            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com sua altura em metros: ");
            double altura;
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double IMC = (peso/(altura * altura));
            
            
            if (IMC < 18.5) {
                //MAGREZA
                Console.WriteLine("Atencao! Estado de magreza. IMC = " + IMC.ToString("F0", CultureInfo.InvariantCulture));
                
            }else if ( IMC > 18.5 && IMC < 24.9)
            {
                //NORMAL
                Console.WriteLine("Estado normal. IMC = " + IMC.ToString("F0", CultureInfo.InvariantCulture));      
            }else if (IMC > 24.9 && IMC < 30)
            {
                //SOBREPESO
                Console.WriteLine("Cuidado. Estado de sobrepeso. IMC = " + IMC.ToString("F0", CultureInfo.InvariantCulture));
            }
            else
            {
                //OBESIDADE
                Console.WriteLine("Atencao! Estado de Obesidade. IMC = " + IMC.ToString("F0", CultureInfo.InvariantCulture));
            }

            



        }
    }
}
