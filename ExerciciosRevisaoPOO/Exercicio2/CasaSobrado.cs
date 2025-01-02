namespace ExerciciosRevisaoPOO.Exercicio2
{
    public class CasaSobrado : Casa
    {
        public int NumAndares { get; set; }
    
        public CasaSobrado(double metragemTotal, string endereco, Engenheiro responsavel, bool condominio, int numAndares) : base(metragemTotal, endereco, responsavel, condominio)
        {
            NumAndares = numAndares;            
        }

        public override string DescricaoDoImovel()
        {
            return base.DescricaoDoImovel() + $"\nNúmero de andares: {NumAndares}";
        }
    }
}