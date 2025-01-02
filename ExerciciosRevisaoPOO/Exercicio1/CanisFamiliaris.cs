namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class CanisFamiliaris : Canis
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nEspécie Canis familiaris";
        }
    }
}