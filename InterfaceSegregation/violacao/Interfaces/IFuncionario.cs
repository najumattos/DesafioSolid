using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSolid.InterfaceSegregation.violacao.Interfaces
{
    internal interface IFuncionario
    {
        
        void ControlarEstoque();
        void ReceberPagamento();
        void Vender();
    }
}
