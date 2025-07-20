namespace DesafioSolid.SingleResponsibility
{
    /*CORREÇÃO Princípio da Responsabilidade Única (Single Responsibility Principle - S):
O método CalcularClassificarIMC() foi dividido dois métodos: Calcular() e Classificar()*/
    internal class Correcao
    {

        public void CalcularIMC()
        {
            //Calcular IMC
        }

        public void ClassificarIMC()
        {
           //Classificar IMC
        }
    }
}
