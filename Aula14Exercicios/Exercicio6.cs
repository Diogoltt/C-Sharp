namespace Aula14Exercicios
{
    public class Fila
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        static Node? inicio = null;
        static Node? fim = null;

        static int contador = 0;

        static void Enfileirar(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null };

            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                fim!.proximo = novoNode;
            }

            fim = novoNode;

            contador++;
        }

        static void Desenfileirar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            Console.WriteLine($"Desenfileirando {inicio.valor}");

            inicio = inicio.proximo;

            if (inicio == null)
            {
                fim = null;
            }

            contador--;
        }

        static void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }
            System.Console.WriteLine("Listando a Fila");
            Node? atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static int Tamanho()
        {
            return contador;
        }

        static void Main(string[] args)
        {
            Enfileirar(10);
            Enfileirar(20);
            Enfileirar(30);
            Listar();
            System.Console.WriteLine($"O tamanho da fila é: {Tamanho()}");
        }
    }
}