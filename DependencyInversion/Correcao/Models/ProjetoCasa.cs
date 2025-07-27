using DesafioSolid.DependencyInversion.Correcao.Interfaces;

namespace DesafioSolid.DependencyInversion.Correcao.Models
{
    /*IEletrecista pode ser implementado em qualquer Eletrecista(ex.EletrecistaAna ou EletrecistaJulia)
      IEletrecista é o contrato de eletrecista

      ProjetoCasa é o contrato entre eletrecista e a casa onde eu defino o projeto e o eletrecista.

     *** Módulos de alto nível não devem depender de módulos de baixo nível, e sim de abstrações
         ProjetoCasa não deve depender de EletrecistaAna ou EletrecistaJulia mas sim de IEletrecista

     *** Ambas as partes, alto e baixo nível, devem depender de abstrações.
         ProjetoCasa, EletrecistaAna e EletrecistaJulia dependem de IEletrecista.

     *** Abstrações não devem depender de detalhes
         IEletrecista não depende de EletrecistaAna ou EletrecistaJulia

     *** Detalhes devem depender de abstrações
         EletrecistaAna e EletrecistaJulia dependem de IEletrecista

     */
    internal class ProjetoCasa
    {
        private readonly IEletrecista _eletrecista;
        private readonly IEncanador _encanador;

        public ProjetoCasa(IEletrecista eletrecista, IEncanador encanador)
        {
            _eletrecista = eletrecista;
            _encanador = encanador;
        }

        public void ConstruirEletrica()
        {
            _eletrecista.InstalarLampada();
        }       
        public void ConstruirHidraulica()
        {
            _encanador.Desentupir();
        }

    }
}
