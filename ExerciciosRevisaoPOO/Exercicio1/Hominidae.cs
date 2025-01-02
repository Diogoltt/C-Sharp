namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Hominidae : Primata
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nFamília Hominidae";
        }
    }
}