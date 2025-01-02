namespace ExerciciosRevisaoPOO.Exercicio1
{
    public class HomoSapiens : Homo
    {
        public override string ObterDescricao()
        {
            return base.ObterDescricao() + "\nEspécie Homo sapiens";
        }
    }
}