using DesafioSolid.InterfaceSegregation.violacao.Interfaces;
using System;

namespace DesafioSolid.InterfaceSegregation.violacao.Models
{
    internal class Vendedora : IFuncionario
    {
        //a classe Vendedora é obrigada a ter metodos que não sao dela como ControlarEstoque() e ReceberPagamento()
        public void ControlarEstoque()
        {
            throw new NotImplementedException();
        }

        public void ReceberPagamento()
        {
            throw new NotImplementedException();
        }

        public void Vender()
        {
           //vender
        }
    }
}
