namespace DesafioSolid.DependencyInversion.Correcao.Interfaces
{
    /*ventilador acoplado a casa = ruim.
      Solucao: instalar uma entrada no ventilador e uma na casa

      IEletrecista pode ser implementado em qualquer Eletrecista(ex.EletrecistaAna ou EletrecistaJulia)
        contrato de eletrecita

        ProjetoCasa é o contrato entre eletrecista e a casa
        onde eu defino o projeto e o eletrecista.
        
    
        O aparelho pode ser usado em qualquer tomada

    

        
     */
    internal interface IEletrecista
    {
        void InstalarLampada();
    }
}
