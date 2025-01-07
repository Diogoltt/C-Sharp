namespace Aula22_Enumerate.Atividade
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}