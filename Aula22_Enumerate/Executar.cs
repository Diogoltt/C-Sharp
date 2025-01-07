namespace Aula22_Enumerate.Atividade
{
    /* public enum Estado
    {
        SP,
        RJ,
        MG,
        BA,
    }

    public class ExtensaoEstado
    {
        public static string GetDescricao(Estado estado)
        {
            switch (estado)
            {
                case Estado.SP:
                    return "São Paulo";
                case Estado.RJ:
                    return "Rio de Janeiro";
                case Estado.MG:
                    return "Minas Gerais";
                case Estado.BA:
                    return "Bahia"; 
                default:
                    return "Estado não encontrado";
            }
        }
    }

    public class Regiao
    {
        public string[] Regioes = new string[]
        {
            "Sul", "Sudeste", "Centro-Oeste", "Norte", "Nordeste"
        };
        public string GetRegiao(Estado estado)
        {
            return estado switch
            {
                Estado.SP => Regioes[1],
                Estado.RJ => Regioes[1],
                Estado.MG => Regioes[1],
                Estado.BA => Regioes[4],
                _ => "Região não encontrada",
            };
        }
    } */

    public class Executar
    {
        static void Main(string[] args)
        {
            var client = new Client
            {
                Name = "Diogo",
                Email = "diogo@teste.com",
                BirthDate = new DateTime(2002, 8, 9)
            };

            var product1 = new Product { Name = "Notebook", Price = 1500.0};
            var product2 = new Product { Name = "Mouse", Price = 50.0};

            var orderItem1 = new OrderItem { Quantity = 1, Price = product1.Price};
            var orderItem2 = new OrderItem { Quantity = 2, Price = product2.Price};

            Order order = new Order
            {
                Moment = DateTime.Now,
                Status = OrderStatus.PROCESSING,
                Client = client
            };

            order.AddItem(orderItem1);
            order.AddItem(orderItem2);

            Console.WriteLine("Detalhes do pedido: ");
            Console.WriteLine($"Cliente: {order.Client.Name} ({order.Client.BirthDate:dd/MM/yyyy}) - {order.Client.Email}");
            Console.WriteLine($"Data do pedido: {order.Moment}");
            Console.WriteLine($"Status do pedido: {order.Status}");
            Console.WriteLine("Items:");
            Console.WriteLine($"1 - {product1.Name}, Quantidade: {orderItem1.Quantity}, Subtotal: ${orderItem1.SubTotal():F2}");
            Console.WriteLine($"2 - {product2.Name}, Quantidade: {orderItem2.Quantity}, Subtotal: ${orderItem2.SubTotal():F2}");
            Console.WriteLine($"Total: ${order.Total():F2}");
        }
    }
}