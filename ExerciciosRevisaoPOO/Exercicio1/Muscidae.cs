namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Muscidae : Diptera
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nFamília Muscidae";
        }
    }
}