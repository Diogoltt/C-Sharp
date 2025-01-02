namespace ExerciciosRevisaoPOO.Exercicio2
{
    public class Engenheiro : Pessoa
    {
        public int Crea { get; set; }

        public Engenheiro(string nome, string cpf, int crea) : base(nome, cpf)
        {
            Crea = crea;
        }
    }
}