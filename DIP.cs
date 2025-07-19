using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioSolid
{
    internal class DIP
    {
        //Princípio da Inversão de Dependência (Dependency Inversion Principle - D):

    }
    #region ViolacaoDIP 
    public class Pedido
    {
        public string Cliente { get; set; }
        public int ValorTotal { get; set; }
    }

    class PedidoService
    {
        public string RealizarPedido(Pedido pedido)
        {
            if (pedido.Cliente is null) {
                return "Favor informar um cliente";

            }
            var pedidoRepositorio = new PedidoRepositorio();
            pedidoRepositorio.Gravar(pedido);

            return string.Empty;
        }
    }

    //implementação = baixoNivel???
    public class PedidoRepositorio
    {
        private string _nome;
        //construtor
        public PedidoRepositorio(string nome)
        {
            _nome = nome; 
        }
        public void Gravar(Pedido pedido)
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region CorrecaoDIP


    #endregion
}
