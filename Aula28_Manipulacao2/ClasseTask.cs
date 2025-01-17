/* namespace Aula28_Manipulacao2
{
    public class ClasseTask
    {
        // O async é quando a função é assíncrona,
        // Ela é executada de forma que não trava o programa
        // Enquanto espera retorno 
        static async Task Main(string[] args)
        {
            System.Console.WriteLine("Inicio do programa");
            int resultado = await Soma(10, 20);
            System.Console.WriteLine("Resultado: " + resultado);
        }

        static Task<int> Soma(int a, int b)
        {
            return Task.Run(() =>
            {
                Task.Delay(2000).Wait();
                return a + b;
            });
        }
    }
} */