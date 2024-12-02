using System;

namespace Aula14Exercicio
{
    public class PilhaEncadeadaInvertida
    {
        public class Node
        {
            public int valor;
            public Node? proximo;
        }

        static Node? topo = null;

        static void Empilhar(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = topo };
            topo = novoNode;
        }

        static int? Desempilhar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia");
                return null;
            }

            int valor = topo.valor;
            topo = topo.proximo;
            return valor;
        }

        static void Listar()
        {
            if (topo == null)
            {
                Console.WriteLine("Pilha vazia");
                return;
            }

            Node? atual = topo;
            Console.WriteLine("Elementos na pilha:");

            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        static void Inverter()
        {
            Node? pilhaAuxiliar = null;

            while (topo != null)
            {
                int? valor = Desempilhar();
                if (valor != null)
                {
                    Node novoNode = new Node {valor = valor.Value, proximo = pilhaAuxiliar};
                    pilhaAuxiliar = novoNode;
                }
            }

            topo = pilhaAuxiliar;
        }

        static void teste()
        {
            Empilhar(10);
            Empilhar(20);
            Empilhar(30);

            System.Console.WriteLine("Pilha Original: ");
            Listar();

            Console.WriteLine("Pilha invertida:");
            Inverter();
            Listar();
        }
    }
}
