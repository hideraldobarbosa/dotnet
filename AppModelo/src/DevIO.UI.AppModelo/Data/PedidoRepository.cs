
using DevIO.UI.AppModelo.Models;

namespace DevIO.UI.AppModelo.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        public Pedido ObterPedido()
        {
            return new Pedido();
        }

    }
    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
