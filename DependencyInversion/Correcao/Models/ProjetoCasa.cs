using DesafioSolid.DependencyInversion.Correcao.Interfaces;

namespace DesafioSolid.DependencyInversion.Correcao.Models
{
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
