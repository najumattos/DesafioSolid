using DesafioSolid.LiskovSubstitution.Violacao.Interfaces;

namespace DesafioSolid.LiskovSubstitution.Violacao.Models
{
    internal class Vendedor : IFuncionario
    {        

        public void Vender()
        {
         //vendedor consegue vender
        }

        public void Gerenciar() {
            //vendedor não consegue Gereciar
            throw new System.NotImplementedException();
        }
    }
}
