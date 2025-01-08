namespace Aula23_Sealed
{
    public class Funcionario
    {
        public string Nome { get; set; }

        public virtual void Salario(int salario)
        {
            System.Console.WriteLine("Salário base: R$ " + salario);
        }

        public virtual void Trabalhar()
        {
            System.Console.WriteLine("Trabalhando...");
        }
    }
}