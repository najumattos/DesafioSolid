using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSolid
{
    internal class LSP
    {
        //Princípio da Substituição de Liskov(Liskov Substitution Principle - L) :

        /*
         ********ERRADO***************
         *um único método para todos os tipos de Abastecimentos, além de violar o SRP por ter mais de uma função,
         dessa maneira gera a necessidade de tratar os tipos de carros o que aumenta as chances de erros
         class Carro{
        Abastecer(tipoDeCarro)

        metodo Abastecer(tipoDeCarro){
            if tipoDeCarro for combustao
                abastecer combustivel
            else if tipoDeCarro for eletrico
                throw new Exception("Carro eletrico nao pode ser abastecido")
        }

        ********CERTO***************
        Em metodos separados o LSP é respeitado pois como cada método é responsavel por tratar
        apenas um tipo´não há a necessidade de tratar possiveis erros de tipos.
        class Carro{
        AbastecerCarroEletrico()
        AbastecerCarroCombustao()
        }
         */

    }
}
