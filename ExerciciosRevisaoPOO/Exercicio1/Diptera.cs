namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Diptera : Insecta
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nOrdem Díptera";
        }
    }
}