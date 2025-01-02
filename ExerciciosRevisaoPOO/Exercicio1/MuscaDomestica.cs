namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class MuscaDomestica : Musca
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nEspécie Musca domestica";
        }
    }
}