using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSolid
{
    internal class OCP
    {
        //Princípio Aberto/Fechado(Open/Closed Principle - O)

        //Esse exemplo teve uma empresa real como inspiração
        /*
        

        **************modo errado******************
        
        Funcionario{
        Vender() Organizar(), Pacote(), RedesSociais(), ControlarEstoque()

        if funcionario freelancer nao pode ControlarEstoque()
        }            

        gerente : funcionario(){
            contratar(), pagarConta(), receber()

        if funcionario for caixa nao pode contratar
        }


        ****************modo certo*************
         
        funcionario(){
        vender() organizar(), pacote(), redesSociais()
}
        caixa : funcioanrio(){
            pagarContas(), receber()
        } 

        gerente : caixa(){
            contratar()
        }
       
                */
    }
}
