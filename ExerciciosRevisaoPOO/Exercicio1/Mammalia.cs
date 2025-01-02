namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Mammalia : Chordata
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nClasse Mammalia";
        }
    }
}