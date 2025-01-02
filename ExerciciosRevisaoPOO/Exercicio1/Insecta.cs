namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Insecta : Arthropoda
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nClasse Insecta";
        }
    }
}