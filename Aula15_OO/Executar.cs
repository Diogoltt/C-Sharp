using System;
namespace Aula15_OO
{
    public class Executar
    {
        static void teste(string[] args)
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Cachorro 1";
            cachorro1.Raca = "Poodle";
            cachorro1.Idade = 6;

            cachorro1.escreveSaida();
        }
    }
}