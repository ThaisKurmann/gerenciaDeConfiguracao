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


            Pessoa pessoa = new Pessoa(altura, peso);

            Console.WriteLine(pessoa.ResultIMC());

        }
    }
}
