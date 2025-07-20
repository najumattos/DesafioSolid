using DesafioSolid.InterfaceSegregation.violacao.Interfaces;

namespace DesafioSolid.InterfaceSegregation.violacao.Models
{
    internal class Vendedora : IFuncionario
    {
        //a classe Vendedora é obrigada a ter metodos que não sao dela como ControlarEstoque() e ReceberPagamento()
        public void ControlarEstoque()
        {
            //metodo inutilizável
        }

        public void ReceberPagamento()
        {
            //metodo inutilizável
        }

        public void Vender()
        {
           //vender
        }
    }
}
