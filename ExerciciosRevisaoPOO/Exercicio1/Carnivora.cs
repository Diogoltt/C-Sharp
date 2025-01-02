namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class Carnivora : Mammalia
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nOrdem Carnívora";
        }
    }
}