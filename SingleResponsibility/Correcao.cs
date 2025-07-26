namespace DesafioSolid.SingleResponsibility
{
    /*CORREÇÃO Princípio da Responsabilidade Única (Single Responsibility Principle - S):
O método CalcularClassificarIMC() foi dividido dois métodos: Calcular() e Classificar()
    Dessa forma a única razão para o método mudar é caso a lógica mude
     */
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
