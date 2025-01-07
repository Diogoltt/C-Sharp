namespace ExerciciosEnumerate
{
     public class Empregados
    {
        private const int NUMERO_MAXIMO = 50;
        private Empregado[] empregados;
        private int NumeroEmpregados;

        public Empregados()
        {
            empregados = new Empregado[NUMERO_MAXIMO];
            NumeroEmpregados = 0;
        }

        public void Inserir(Empregado empregado)
        {
            if (NumeroEmpregados < NUMERO_MAXIMO)
            {
                empregados[NumeroEmpregados++] = empregado;
            }
        }

        public void Imprimir()
        {
            for (int i = 0; i < NumeroEmpregados; i++)
            {
                Console.WriteLine($"Nome: {empregados[i].Nome}");
                Console.WriteLine($"Tipo: {empregados[i].TipoEmpregado}");
                Console.WriteLine($"Salário: {empregados[i].CalcularSalario():C}");
                Console.WriteLine($"Status Licença: {empregados[i].StatusLicenca}");
                Console.WriteLine();
            }
        }

        public double FolhaPagamento()
        {
            double total = 0;
            for (int i = 0; i < NumeroEmpregados; i++)
            {
                total += empregados[i].CalcularSalario();
            }
            return total;
        }
    }
}