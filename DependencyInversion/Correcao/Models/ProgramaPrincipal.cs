using DesafioSolid.DependencyInversion.Correcao.Interfaces;
namespace DesafioSolid.DependencyInversion.Correcao.Models
{
    internal class ProgramaPrincipal
    {
        public static void Main()
        {
            IEletrecista eletrecistaEscolhida = new EletrecistaAna();
            IEncanador encanadorEscolhido = new Encanador();

            ProjetoCasa aptoMickey = new ProjetoCasa(eletrecistaEscolhida, encanadorEscolhido);
            aptoMickey.ConstruirEletrica();
            aptoMickey.ConstruirHidraulica();
        }
    }
}
