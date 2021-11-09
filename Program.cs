using System;

namespace AppExerciciospropostos_Logica05
{
    /// <summary>
    /// Exercicios propostos 05
    /// Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
    /// código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
    /// </summary>
    class Program
    {
        public static void zerarVariaveis(int cPeças,int nPecas, double vUniPeca) 
        {
            cPeças = 0;
            nPecas = 0;
            vUniPeca = 0;

        }

        public static double calcularValorTotal(int nPecas, double vUniPeca) 
        {
            double resultado = nPecas * vUniPeca;
            return resultado;
        }

        static void Main(string[] args)
        {
            int cPeças;
            int nPecas;
            double vUniPeca;
            double vValorTotal;

            Console.WriteLine("Entre com as seguintes informações: Codigo de peça, número de peças e valor unitário: ");
            string[] vet = Console.ReadLine().Split(" ");
            string[] vet2 = Console.ReadLine().Split(" ");
            
            cPeças = int.Parse(vet[0]);
            nPecas = int.Parse(vet[1]);
            vUniPeca = double.Parse(vet[2]);

            vValorTotal = calcularValorTotal(nPecas, vUniPeca);
            zerarVariaveis(cPeças, nPecas, vUniPeca);
            
            cPeças = int.Parse(vet2[0]);
            nPecas = int.Parse(vet2[1]);
            vUniPeca = double.Parse(vet2[2]);
            vValorTotal = vValorTotal+calcularValorTotal(nPecas, vUniPeca);

            Console.WriteLine("O valor total a ser pago é: {0}", vValorTotal.ToString("F2")+" R$");
            Console.ReadLine();
        }
    }
}
