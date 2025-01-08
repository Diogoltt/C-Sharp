namespace Aula23_Sealed
{
    public sealed class Gerente : Funcionario
    // Sealed impede que a classe seja herdada por outras classes
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salário base: R$ " + salario * 1.5);
        }

        public override void Trabalhar()
        {
            System.Console.WriteLine("Gerenciando...");;
        }
    }
}