using System;
using System.IO;

namespace ExercicioMatrizCSV
{
    public static class MatrizCSV
    {
        public static void EscreverResultadosCSV(string caminhoArquivo, int[] resultados, string tipoOperacao)
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                writer.WriteLine(tipoOperacao);
                for (int i = 0; i < resultados.Length; i++)
                {
                    writer.WriteLine($"{tipoOperacao} {i + 1},{resultados[i]}");
                }
            }
        }

        public static void EscreverMatrizTranspostaCSV(string caminhoArquivo, int[,] matrizTransposta)
        {
            using (StreamWriter writer = new StreamWriter(caminhoArquivo))
            {
                int linhas = matrizTransposta.GetLength(0);
                int colunas = matrizTransposta.GetLength(1);

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        writer.Write(matrizTransposta[i, j]);
                        if (j < colunas - 1)
                        {
                            writer.Write(",");
                        }
                    }
                    writer.WriteLine();
                }
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o tamanho de linhas para a matriz: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o tamanho de colunas para a matriz: ");
            int M = Convert.ToInt32(Console.ReadLine());
            int[,] matriz = new int[N, M];

            var random = new Random();
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(1, 100);
                }
            }

            Console.WriteLine("\nMatriz Original:");
            ImprimirMatriz(matriz);

            Console.WriteLine("\n1. Soma das Linhas");
            Console.WriteLine("2. Soma das Colunas");
            Console.WriteLine("3. Transpor a Matriz");
            Console.WriteLine("Escolha um tipo de Operação: ");
            int op = Convert.ToInt32(Console.ReadLine());

            string caminhoArquivo = "resultado.csv";

            switch (op)
            {
                case 1:
                    int[] somaLinhas = SomarLinhas(matriz);
                    Console.WriteLine("\nSoma das Linhas:");
                    for (int i = 0; i < somaLinhas.Length; i++)
                    {
                        Console.WriteLine($"Linha {i + 1}: {somaLinhas[i]}");
                    }
                    MatrizCSV.EscreverResultadosCSV(caminhoArquivo, somaLinhas, "Linha");
                    Console.WriteLine($"Resultados salvos em '{caminhoArquivo}'");
                    break;

                case 2:
                    int[] somaColunas = SomarColunas(matriz);
                    Console.WriteLine("\nSoma das Colunas:");
                    for (int j = 0; j < somaColunas.Length; j++)
                    {
                        Console.WriteLine($"Coluna {j + 1}: {somaColunas[j]}");
                    }
                    MatrizCSV.EscreverResultadosCSV(caminhoArquivo, somaColunas, "Coluna");
                    Console.WriteLine($"Resultados salvos em '{caminhoArquivo}'");
                    break;

                case 3:
                    int[,] matrizTransposta = TransporMatriz(matriz);
                    Console.WriteLine("\nMatriz Transposta:");
                    ImprimirMatriz(matrizTransposta);
                    MatrizCSV.EscreverMatrizTranspostaCSV(caminhoArquivo, matrizTransposta);
                    Console.WriteLine($"Resultados salvos em '{caminhoArquivo}'");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        static int[] SomarLinhas(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[] somasLinhas = new int[linhas];

            for (int i = 0; i < linhas; i++)
            {
                int somaLinha = 0;
                for (int j = 0; j < colunas; j++)
                {
                    somaLinha += matriz[i, j];
                }
                somasLinhas[i] = somaLinha;
            }

            return somasLinhas;
        }

        static int[] SomarColunas(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[] somasColunas = new int[colunas];

            for (int j = 0; j < colunas; j++)
            {
                int somaColuna = 0;
                for (int i = 0; i < linhas; i++)
                {
                    somaColuna += matriz[i, j];
                }
                somasColunas[j] = somaColuna;
            }
            return somasColunas;
        }

        static int[,] TransporMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);
            int[,] matrizTransposta = new int[colunas, linhas];

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    matrizTransposta[j, i] = matriz[i, j];
                }
            }

            return matrizTransposta;
        }

        static void ImprimirMatriz(int[,] matriz)
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write($"{matriz[i,j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
