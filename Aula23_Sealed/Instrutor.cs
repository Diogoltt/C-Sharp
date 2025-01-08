namespace Aula23_Sealed
{
    public class Instrutor : Coordenador
    {
        public override void Salario(int salario)
        {
            System.Console.WriteLine($"Salário Base: R$ " + salario * 1.3);;
        }
    }
}