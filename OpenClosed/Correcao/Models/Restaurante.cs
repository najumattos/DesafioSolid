using DesafioSolid.OpenClosed.Correcao.Interfaces;

namespace DesafioSolid.OpenClosed.Correcao.Models
{
    //CORREÇÃO Princípio Aberto/Fechado (Open/Closed Principle - OCP)
    internal class Restaurante
    {
        public void FazerPedido(IPedido pedido)
        {
            /*Desse modo, a classe Lanche recebe o pedido independente de qual seja e
          separando Restaurante em classes menores(Lanche, Pizza, Sobremesa),
          ela se torna apta para extensões sem comprometer o código existente,
          além de respeitar assim o Principio da Responsabilidade Única*/
            pedido.Preparar();
        }
    }
}
