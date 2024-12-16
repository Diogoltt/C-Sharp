namespace Aula19_OO_Relacoes
{
    public class Computador
    {
        private Processador processador;

        public Computador()
        {
            processador = new Processador();
        }

        void Iniciar()
        {
            System.Console.WriteLine("Iniciando... ");
            processador.Processar();
        }
    }
}

// A composição é quando a classe principal contém partes
// essenciais que não podem existir sem ela