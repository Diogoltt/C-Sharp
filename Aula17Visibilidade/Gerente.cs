namespace Aula17Visibilidade
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, double salario) : base(nome, salario, "Gerente")
        {

        }

        public void Imprimir()
        {
            ExibirInformacoes();
        }

        public void AtualizarCargoGerente(string novoCargo)
        {
            AtualizarCargo(novoCargo);
        }

        private void CalcularImpostoGerente()
        {
    
        }
    }
}