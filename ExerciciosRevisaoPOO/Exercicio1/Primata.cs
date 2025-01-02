namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Primata : Mammalia
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nOrdem Primata";
        }
    }
}