using DesafioSolid.LiskovSubstitution.Correcao.Interfaces;

namespace DesafioSolid.LiskovSubstitution.Correcao.Models
{
    internal class Funcionario
    {
        public void Vender()
        {
            //Qualquer Funcionario pode vender
        }
    }

    internal class Gerente : Funcionario, IGerenciar
    {
        /*Além de Gerenciar, o Gerente é capaz de executar a função de qualquer funcionario,
        logo,o gerente pode subtituir qualquer funcionario*/
        public void Gerenciar()
        {
            //Gerenciar
        }
    }
}
