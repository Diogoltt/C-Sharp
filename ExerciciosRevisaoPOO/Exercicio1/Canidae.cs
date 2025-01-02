namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Canidae : Carnivora
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nFamília Canidae";
        }
    }
}