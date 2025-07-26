namespace DesafioSolid.SingleResponsibility
{
        /*VIOLAÇÃO Princípio da Responsabilidade Única (Single Responsibility Principle - S):
        O método CalcularClassificarIMC() tem duas funções: Calcular e Classificar o IMC*/

    internal class Violacao
    {
        public void CalcularClassificarIMC()
        {
            //Calcula o valor do IMC
          
            //Além de Calcular o IMC, o método também classifica  IMC
        }
    }
}
