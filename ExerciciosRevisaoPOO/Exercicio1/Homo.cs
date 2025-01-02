namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Homo : Hominidae
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nGênero Homo";
        }
    }
}