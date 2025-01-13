namespace Aula26_FileManipulate.Banco
{
    public class Customer
    {
        public Customer(string nome) 
        {
            Nome = nome;
        }
        
        public string Nome { get; private set; }
    }
}