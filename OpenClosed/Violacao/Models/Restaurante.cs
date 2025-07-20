using DesafioSolid.OpenClosed.Violacao.Interfaces;

namespace DesafioSolid.OpenClosed.Violacao.Models
{
    internal class Restaurante : ILanchonete
    {
        public void FazerLanche(string pedido)
        {
            if(pedido == "Lanche")
            {
                //Fazer Lanche
            }else if(pedido == "Pizza")
            {
                //Fazer Pizza
            }else if(pedido == "Sobremesa")
            {
                //Fazer Sobremesa
            }            
        }
    }
}
