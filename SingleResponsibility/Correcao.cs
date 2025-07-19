using System;

namespace DesafioSolid.SingleResponsibility
{
    /*CORREÇÃO Princípio da Responsabilidade Única (Single Responsibility Principle - S):
O método CalcularClassificarIMC() foi dividido dois métodos: Calcular() e Classificar()*/
    internal class Correcao
    {
        private double Peso;
        private double Altura;
        private double Imc;
        private readonly string[] Classificacao = new string[]
        {
        "Abaixo do Peso",
        "Peso Ideal",
        "Sobrepeso",
        "Obesidade I",
        "Obesidade II",
        "Obesidade III"
        };
        public void CalcularIMC()
        {
            Imc = Peso / (Altura * Altura);
        }

        public void ClassificarIMC()
        {
            if (Imc < 18.5)
            {
                Console.WriteLine($"Seu IMC é {Imc:F2} - {Classificacao[0]}"); //Abaixo do Peso
            }
            else if ((Imc >= 18.5) && (Imc < 25))
            {
                Console.WriteLine($"Seu IMC é {Imc:F2} - {Classificacao[1]}"); //Peso Ideal
            }
            else if ((Imc >= 25) && (Imc < 30))
            {
                Console.WriteLine($"Seu IMC é {Imc:F2} - {Classificacao[1]}"); //Sobrepeso

            }
            else if ((Imc >= 30) && (Imc < 35))
            {
                Console.WriteLine($"Seu IMC é {Imc:F2} - {Classificacao[2]}"); //Obesidade I
            }
            else if ((Imc >= 35) && (Imc < 40))
            {
                Console.WriteLine($"Seu IMC é {Imc:F2} - {Classificacao[3]}"); //Obesidade II
            }
            else
            {
                Console.WriteLine($"Seu IMC é {Imc:F2} - {Classificacao[4]}"); //Obesidade III
            }
        }
    }
}
