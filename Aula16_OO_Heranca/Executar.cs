namespace Aula16_OO_Heranca
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Gerente gerente = new Gerente("João", "123-456-789-00", 5000, "SETOR 1");
            System.Console.WriteLine("Mostrar o salário do gerente: " + gerente.Salario);
            System.Console.WriteLine("Mostrar a bonificação do gerente: " + gerente.GetBonificacao());
            System.Console.WriteLine("Mostrar o setor do gerente: " + gerente.Setor);
            gerente.GerenciarEquipe();
            gerente.ImprimirDados();
        }
    }
}