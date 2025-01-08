namespace Aula23_Sealed
{
    public class Program
    {
        static void Main(string[] args)
        {
            var funcionario = new Funcionario();
            funcionario.Salario(1000);
            funcionario.Trabalhar();

            var coordenador = new Coordenador();
            coordenador.Salario(1000);
            coordenador.Trabalhar();
            
            var gerente = new Gerente();
            gerente.Salario(1000);
            gerente.Trabalhar();

            var Instrutor = new Instrutor();
            Instrutor.Trabalhar();
            Instrutor.Salario(1000);
        }
    }
}