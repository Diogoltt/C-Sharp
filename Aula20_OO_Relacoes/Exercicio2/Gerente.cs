namespace Aula20_OO_Relacoes
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, DateTime nascimento, string cpf, Endereco endereco) : base(nome, nascimento, cpf, endereco)
        {
        }

        public void GetSalario()
        {
            double Salario = 3000;
            System.Console.WriteLine($"O Salário do gerente é: R${Salario + (Salario * 0.3)}");
        }
    }
}