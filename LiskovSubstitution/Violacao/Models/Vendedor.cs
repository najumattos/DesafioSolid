using DesafioSolid.LiskovSubstitution.Violacao.Interfaces;

namespace DesafioSolid.LiskovSubstitution.Violacao.Models
{
    // VIOLAÇÃO do Princípio de Substituição de Liskov (LSP)
    internal class Vendedor : IFuncionario
    {
        /*A Classe Vendedor usa a Interface IFuncionario que contem os metodos
        Gerenciar() e Vender(). Fazendo o Vendedor ter funções que não são dele, ou seja
        a classe Vendedor() NÃO é capaz de SUBSTITUIR sua classe Pai IFuncionario
        violando assim o LSP*/

        public void Vender()
        {
         //vendedor consegue vender
        }

        public void Gerenciar() {
            //vendedor deve conseguir Gereciar            
        }
    }
}
