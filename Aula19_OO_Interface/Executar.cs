namespace Aula19_OO_Interface
{
    public class Executar
    {
        static void Main(string[] args)
        {
            CartaoCredito cartao = new("12345", DateTime.Now, 100);
            cartao.RealizarPagamento(500);
            cartao.ExibirComprovante();


        }
    }
}