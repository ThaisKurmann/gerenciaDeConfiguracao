using System;
using System.Globalization;

namespace Atividade7
{
    class Pessoa
    {

         public double peso;
         public double altura;



        public Pessoa(double altura, double peso)
        {
            this.peso = peso;
            this.altura = altura;

        }

        public double IMC()
        {
            return peso / (altura * altura);
        }




        public string ResultIMC()
        {

            if (IMC() < 18.5)
            {
                //MAGREZA
                return "Atencao! Estado de magreza. IMC = " + IMC().ToString("F0", CultureInfo.InvariantCulture);

            }
            else if (IMC() > 18.5 && IMC() < 24.9)
            {
                //NORMAL
                return "Estado normal. IMC = " + IMC().ToString("F0", CultureInfo.InvariantCulture);
            }
            else if (IMC() > 24.9 && IMC() < 30)
            {
                //SOBREPESO
                return "Cuidado. Estado de sobrepeso. IMC = " + IMC().ToString("F0", CultureInfo.InvariantCulture);
            }
            else
            {
                //OBESIDADE
                return "Atencao! Estado de Obesidade. IMC = " + IMC().ToString("F0", CultureInfo.InvariantCulture);
            }

        }
    }
}
