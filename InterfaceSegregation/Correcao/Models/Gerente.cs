using DesafioSolid.InterfaceSegregation.Correcao.Interfaces;

namespace DesafioSolid.InterfaceSegregation.Correcao.Models
{
    /*Nesse caso o Gerente tem mais de uma função porém é importante evitar que uma mesma
     classe implemente varias funções pois isso viola o Princípio da Responsabilidade Única
    */
    internal class Gerente : IReceberPagamento, IEstoque, IVender
    {
        public void ControlarEstoque()
        {
           //Gerente pode exercer a função de estoquista, porém o estoquista não pode exercer a função de Gerente
        }

        public void ReceberPagamento()
        {
           //função somente do gerente porem eu posso criar uma classe Caixa que pode herdar tambem da interface IReceberPagamentos, sem quebrar o código
        }

        public void Vender()
        {
            //Gerente pode exercer a função de vender, porém a vendedora não pode exercer a função de Gerente
        }
    }
}
