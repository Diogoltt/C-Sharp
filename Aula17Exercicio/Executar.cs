namespace Aula17Exercicio
{
    public class Executar
    {
        static void Main(string[] args)
        {
            Assalariado assalariado1 = new("NomeAssalariado1", "SobreNomeAssalariado1", "0987654321", 1420);
            assalariado1.ExibirDados();

            Comissionado comissionado1 = new("NomeComissionado1", "SobreNomeComissionado1", "987654321", 2000, 0.40);
            comissionado1.ExibirDados();

            Horista horista = new("NomeHorista1", "SobreNomeHorista1", "123456789", 7, 160);
            horista.ExibirDados();
        }
    }
}