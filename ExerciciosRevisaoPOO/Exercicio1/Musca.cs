namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Musca : Muscidae
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nGênero Musca";
        }
    }
}