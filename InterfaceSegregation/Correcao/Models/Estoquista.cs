using DesafioSolid.InterfaceSegregation.Correcao.Interfaces;

namespace DesafioSolid.InterfaceSegregation.Correcao.Models
{
    /*Nesse caso o Estoquista tem mais de uma função porém é importante evitar que uma mesma
     classe implemente varias funções pois isso viola o Princípio da Responsabilidade Única
    */
    internal class Estoquista : IEstoque, IVender
    {

        public void ControlarEstoque()
        {
            //o estoquista controla o estoque
        }

        public void Vender()
        {
            //o estoquista pode adquirir a função de Vender herdado da IVender
        }
    }
}

