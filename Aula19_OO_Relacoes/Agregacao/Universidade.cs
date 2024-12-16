namespace Aula19_OO_Relacoes
{
    public class Universidade
    {
        public Professor professor;
        public Universidade(Professor professor)
        {
            this.professor = professor;
        }

        public void RealizarAula()
        {
            System.Console.WriteLine("Iniciando aula...");
            professor.Ensinar(); 
        }
    }
}