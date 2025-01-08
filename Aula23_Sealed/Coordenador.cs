namespace Aula23_Sealed
{
    public class Coordenador : Funcionario
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine("Salário base: R$ " + salario * 1.2);   
        }

        public sealed override void Trabalhar()
        {
            System.Console.WriteLine("Coordenando...");   
        }
    }
}