namespace Aula22_Enumerate.Atividade
{
    public class OrderItem
    {
        public OrderItem(Product product, int quantity, double price)
        {
            Product = product;
            Quantity = quantity;
            Price = price;      
        }

        public Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double SubTotal(int quantity, double price)
        {
            return quantity * price;
        }
    }
}