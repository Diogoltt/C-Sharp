using System;
namespace Exercicios {
    class Exercicio3 {
        static void teste() {
            System.Console.WriteLine("Digite um DDD: ");
            int DDD = int.Parse(Console.ReadLine());
            string estado = "";

            switch(DDD) {
                case 41 or 42 or 43 or 44 or 45 or 46:
                    estado = "Paraná";
                    break;
                case 51 or 53 or 54 or 55:
                    estado = "Rio Grande do Sul";
                    break;
                case 61:
                    estado = "Brasília";
                    break;
                case 62 or 64:
                    estado = "Goiás";
                    break;
                case 65 or 66:
                    estado = "Mato Grosso";
                    break;
                case 67:
                    estado = "Mato Grosso do Sul";
                    break;
                default:
                    estado = "Estado não registrado";
                    break;
            }
            System.Console.WriteLine($"O DDD digitado corresponde ao estado de: {estado}");
        }
    }
}