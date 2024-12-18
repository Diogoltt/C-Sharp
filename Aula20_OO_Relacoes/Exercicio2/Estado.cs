namespace Aula20_OO_Relacoes
{
    public class Estado
    {
        public string? Nome { get; set; }
        public string? Sigla { get; set; }

        public Estado(string nome, string sigla)
        {
            Nome = nome;
            Sigla = sigla;
        }
    }
}