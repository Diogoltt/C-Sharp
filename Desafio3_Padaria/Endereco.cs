namespace Desafio3_Padaria
{
    public class Endereco
    {
        // Utilizando propriedades auto-implementadas
        public string Rua { get; set; }
        public string Cidade { get; set; }
        public Estado Estado { get; set; }
        public int CEP { get; set; }

        // Construtor
        public Endereco(string rua, string cidade, Estado estado, int cep)
        {
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
            CEP = cep;
        }
        public Endereco()
        {
            
        }

       
    }
}