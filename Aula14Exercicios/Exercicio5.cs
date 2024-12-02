using System;

namespace Aula14Exercicios
{
    public class FilaEncadeada
    {
        class Node
        {
            public int valor;
            public Node? proximo;
        }

        private Node? inicio = null;
        private Node? fim = null;

        private int contador = 0;

        public void Enfileirar(int valor)
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

        public void Desenfileirar()
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

        public void JuntarFilas(FilaEncadeada outraFila)
        {
            if (outraFila.inicio == null)
            {
                return;
            }

            if (inicio == null)
            {
                inicio = outraFila.inicio;
                fim = outraFila.fim;
            }
            else
            {
                fim!.proximo = outraFila.inicio;
                fim = outraFila.fim;
            }

            contador += outraFila.contador;
        }

        public void Listar()
        {
            if (inicio == null)
            {
                Console.WriteLine("Fila vazia!");
                return;
            }

            Console.WriteLine("Listando a Fila");
            Node? atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void teste(string[] args)
        {
            FilaEncadeada fila1 = new FilaEncadeada();
            FilaEncadeada fila2 = new FilaEncadeada();

            fila1.Enfileirar(10);
            fila1.Enfileirar(20);
            fila1.Enfileirar(30);
            Console.WriteLine("Fila 1:");
            fila1.Listar();

            fila2.Enfileirar(40);
            fila2.Enfileirar(50);
            Console.WriteLine("Fila 2:");
            fila2.Listar();

            fila1.JuntarFilas(fila2);
            Console.WriteLine("Fila 1 após juntar com Fila 2:");
            fila1.Listar();
        }
    }
}
