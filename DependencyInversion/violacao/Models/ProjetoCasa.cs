namespace DesafioSolid.DependencyInversion.violacao.Models
{
        //ProjetoCasa não deve depender de EletrecistaAna ou EletrecistaJulia mas sim de IEletrecista
    internal class ProjetoCasa : EletrecistaAna
    {
    }
}
