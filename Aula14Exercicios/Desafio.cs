/*
Exercício Avançado de Lista Duplamente Encadeada
Exercício: Remover Todos os Elementos de um Valor Específico
Crie uma função que remova todas as ocorrências de um valor específico de uma lista duplamente encadeada.

Requisitos:

A função deve percorrer a lista inteira.
Todas as ocorrências do valor especificado devem ser removidas.
A lista deve permanecer íntegra após a remoção (ou seja, os ponteiros Proximo e Anterior devem ser ajustados adequadamente).

Exemplo de Uso:

Lista: 10 <-> 20 <-> 30 <-> 20 <-> 40
Remover(20)
Resultado: 10 <-> 30 <-> 40
*/
using System;
namespace Aula14Exercicios
{
    public class ListaDuplamenteEncadeada
    {
        public class Node
        {
            public int valor;
            public Node? proximo;
            public Node? anterior;
        }

        static Node? inicio = null;

        public void Inserir(int valor)
        {
            Node novoNode = new Node { valor = valor, proximo = null, anterior = null };
            if (inicio == null)
            {
                inicio = novoNode;
            }
            else
            {
                Node atual = inicio;
                while (atual.proximo != null)
                {
                    atual = atual.proximo;
                }
                atual.proximo = novoNode;
                novoNode.anterior = atual;
            }
        }

        public void Excluir(int valor)
        {
            if (inicio == null)
            {
                Console.WriteLine("Lista vazia");
                return;
            }

            if (inicio.valor == valor)
            {
                if (inicio.proximo != null)
                {
                    inicio.proximo.anterior = null;
                }
                inicio = inicio.proximo;
                return;
            }

            Node atual = inicio;
            while (atual != null && atual.valor != valor)
            {
                atual = atual.proximo;
            }

            if (atual != null)
            {
                if (atual.anterior != null)
                {
                    atual.anterior.proximo = atual.proximo;
                }

                if (atual.proximo != null)
                {
                    atual.proximo.anterior = atual.anterior;
                }
            }
        }

        public void RemoverRecorrenciaTodos(int valor)
        {
            Node? atual = inicio;

            while (atual != null)
            {
                if (atual.valor == valor)
                {
                    // Caso o nó seja o início da lista
                    if (atual == inicio)
                    {
                        inicio = inicio.proximo;
                        if (inicio != null)
                        {
                            inicio.anterior = null;
                        }
                    }
                    else
                    {
                        if (atual.anterior != null)
                        {
                            atual.anterior.proximo = atual.proximo;
                        }

                        if (atual.proximo != null)
                        {
                            atual.proximo.anterior = atual.anterior;
                        }
                    }
                }

                atual = atual.proximo;
            }
        }

        public static void Listar()
        {
            Node? atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.valor);
                atual = atual.proximo;
            }
        }

        public static void Main(string[] args)
        {
            ListaDuplamenteEncadeada lista = new ListaDuplamenteEncadeada();
            lista.Inserir(10);
            lista.Inserir(20);
            lista.Inserir(30);
            lista.Inserir(20);
            lista.Inserir(40);
            Console.WriteLine("Lista após inserção:");
            Listar();

            lista.RemoverRecorrenciaTodos(20);
            Console.WriteLine("Lista após remover todas as ocorrências de 20:");
            Listar();
        }
    }
}

