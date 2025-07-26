using DesafioSolid.InterfaceSegregation.Correcao.Interfaces;

namespace DesafioSolid.InterfaceSegregation.Correcao.Models
{
    //aqui o estoquista recebe apenas os métodos referentes a sua função
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

