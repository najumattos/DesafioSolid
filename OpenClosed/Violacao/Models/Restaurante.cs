using DesafioSolid.OpenClosed.Violacao.Interfaces;

namespace DesafioSolid.OpenClosed.Violacao.Models
{
    //VIOLAÇÃO Princípio Aberto/Fechado (Open/Closed Principle - OCP)
    internal class Restaurante : ILanchonete
    {
        /*A violação do OCP ocorre pois houve a necessidade de MODIFICAR o método
         FazerLanche() para que essa classe seja capaz de preparar Pizza e Sobremesa
         O uso demasiado de IF/ELSE torna o código propenso a bugs*/
        public void FazerLanche(string pedido)
        {
            if(pedido == "Lanche")
            {
                //Fazer Lanche
            }
            else if(pedido == "Pizza")
            {
                //Fazer Pizza
            }
            else if(pedido == "Sobremesa")
            {
                //Fazer Sobremesa
            }            
        }
    }
}
