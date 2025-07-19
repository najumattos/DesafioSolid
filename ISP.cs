using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSolid
{
    internal interface ISP
    {
        //Princípio da Segregação de Interfaces (Interface Segregation Principle - I):

        /*
         impressas imprimem e escaneiam
chega uma terceira que faz fax
como ficam as duas primeiras?

******errado
interface impressora{
	imprime
	escaneia
	fax
}

*******certo
interface imprimir
interface escaneia
interface fax
         */
    }
}
