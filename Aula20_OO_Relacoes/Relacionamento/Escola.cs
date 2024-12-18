namespace Aula20_OO_Relacoes
{
    public class Escola
    {
        private Aluno estudante;
        private Professor professor;

        // Construtor da escola
        // Mostra a relação de composição

        public Escola(string nomeEstudante)
        {
            // Aqui há a mudança, pois a escola vai ter um aluno como parte
            // dela, sendo assim uma relação de Composição
            estudante = new Aluno(nomeEstudante);
        }

        // Metodo para agregação (que recebe de forma externa o professor)
        public void ContratarProfessor(Professor professor)
        {
            this.professor = professor;
        }

        public void MostrarInfo()
        {
            System.Console.WriteLine($"Nome do Aluno: {estudante.Nome}");
            System.Console.WriteLine($"Nome do Professor: {professor.Nome}");
            professor.Ensinar();
        }
    }
}