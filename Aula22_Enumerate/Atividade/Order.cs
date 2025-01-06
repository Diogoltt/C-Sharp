namespace Aula22_Enumerate.Atividade
{
    public class Order
    {
        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public void AddItem(OrderItem item)
        {
            
        }

    }
}