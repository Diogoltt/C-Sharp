namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Canis : Canidae
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nGênero Canis";
        }
    }
}