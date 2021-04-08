using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido = new Pedido
            {
                Id = 10232,
                Momento = DateTime.Now,
                Status = PedidoStatus.PagamentoPendente
            };

            System.Console.WriteLine(pedido);

            //Convertendo valor da enumeração para string
            string texto = PedidoStatus.PagamentoPendente.ToString();
            Console.WriteLine(texto);
            
            //Convertendo de string para enumerado
            PedidoStatus estado = Enum.Parse<PedidoStatus>(texto);
            Console.WriteLine(estado);
            
        }
    }
}
