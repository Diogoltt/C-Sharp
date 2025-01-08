namespace Aula24_Exceptions.ExercicioContaBancaria
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Entre com os dados da conta");
                Console.Write("Número da conta: ");
                var number = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome do titular: ");
                var holder = Console.ReadLine();
                Console.Write("Balanço inicial: ");
                var balance = Convert.ToDouble(Console.ReadLine());
                Console.Write("Limite de saque: ");
                var withdrawLimit = Convert.ToDouble(Console.ReadLine());

                var account = new Account(number, holder, balance, withdrawLimit);

                Console.Write("\nEntre com o valor para saque: ");
                var withdrawAmount = Convert.ToDouble(Console.ReadLine());
                
                account.Withdraw(withdrawAmount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro de formato: Digite um valor numérico válido");
            }
            catch (DomainException e)
            {
                Console.WriteLine($"Erro na operação: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro inesperado: {e.Message}");
            }
        }
    }
}
