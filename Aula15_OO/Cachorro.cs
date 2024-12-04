using System;
namespace Aula15_OO
{
    public class Cachorro
    {
        public string Nome;
        public string Raca;
        public int Idade;

        public void escreveSaida()
        {
            System.Console.WriteLine("Nome: " + Nome);
            System.Console.WriteLine("Raca: " + Raca);
            System.Console.WriteLine("Idade: " + Idade);
            System.Console.WriteLine("Idade em humanos: " + getIdadeHumano());
        }

        public int getIdadeHumano()
        {
            int idadeHumano = 0;
            if (Idade <= 2)
            {
                idadeHumano = Idade * 11;
            }
            else
            {
                idadeHumano = 22 + (Idade - 2) * 5;
            }
            return idadeHumano;
        }
    }
}