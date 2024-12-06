namespace Aula16_ExercicioAnimal
{
    public class Javali : Animal
    {
        public bool Selvagem;

        public Javali(bool vivo, bool selvagem) : base(vivo)
        {
            this.Selvagem = selvagem;
        }

        public int GetVelocidadeMax()
        {
            int Velocidade = 100;
            return Velocidade;
        }

        public void SetSelvagem()
        {
            this.Selvagem = true;
        }
    }
}