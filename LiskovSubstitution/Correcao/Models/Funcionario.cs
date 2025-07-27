using DesafioSolid.LiskovSubstitution.Correcao.Interfaces;

namespace DesafioSolid.LiskovSubstitution.Correcao.Models
{
    //CORREÇÃO Liskov Substitution Principle - LSP
    internal class Funcionario : IVender, IEstoque
    {
        /*Aqui o funcionario recebe apenas suas responsabilidades,
         podendo substituir IVender ou IEstoque, respeitando tambem
         o Princípio da Segregação de Interfaces (ISP).
        */
        public void ControlarMercadoria()
        {
            //Método herdado do IEstoque
        }
        public void Vender()
        {
            //Método herdado do IVender
        }
    }

    
}
