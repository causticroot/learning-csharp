using System;
namespace Enums
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime Momento { get; set; }
        public PedidoStatus Status { get; set; }

        public override string ToString()
        {
            return Id
            + ", "
            + Momento
            + ", "
            + Status;
        }    
    }
}