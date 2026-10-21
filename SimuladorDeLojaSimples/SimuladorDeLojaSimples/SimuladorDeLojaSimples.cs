using System;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace SimuladorDeLojaSimples
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int QuantidadeEmEstoque;

        public static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.Nome = "mouse";
            p1.Preco = 10.20f;
            p1.QuantidadeEmEstoque = 24;

            Produto p2 = new Produto();
            p2.Nome = "teclado";
            p2.Preco = 22.50f;
            p2.QuantidadeEmEstoque = 42;

            Produto p3 = new Produto();
            p3.Nome = "monitor";
            p3.Preco = 600.00f;
            p3.QuantidadeEmEstoque = 22;

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("--- SIMULADOR DE LOJA ---");
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1. Exibir detalhes do produto");
                Console.WriteLine("2. Sair do programa");

                
                string opcao = Console.ReadLine();
                

                if (opcao == "1")
                {
                    Console.WriteLine("Qual Produto deseja olhar?");
                    Console.WriteLine("1. mouse");
                    Console.WriteLine("2. teclado");
                    Console.WriteLine("3. monitor");

                    string opicao = Console.ReadLine();

                    if (opicao == "1")
                    {
                        p1.ExibirDetalhes();
                    }
                    else if (opicao == "2")
                    {
                        p2.ExibirDetalhes();
                    }
                    else if (opicao == "3")
                    {
                        p3.ExibirDetalhes();
                    }
                }
                else if (opcao == "2") { continuar = false; }
                
               
            } 
        }
        public void ExibirDetalhes()
        {

            Console.WriteLine($"{Nome}, custa R${Preco:00.00} e tem exatas {QuantidadeEmEstoque} unidades disponiveis.");


            
            
            
        } 
        

    }

}