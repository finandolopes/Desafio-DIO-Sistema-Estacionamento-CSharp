using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sistema_para_um_Estacionamento_com_CSharp.Controller;

namespace Sistema_para_um_Estacionamento_com_CSharp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja Bem-Vindo ao estacionamento!\n");

            Console.WriteLine("Digite o Preço Inicial: ");
            decimal precoInicial = Decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Preço por Hora: ");
            decimal precoHora = Decimal.Parse(Console.ReadLine());

            Estacionamento estacionamento = new Estacionamento(precoInicial, precoHora);

            string opcao = string.Empty;
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.Clear();
                Console.WriteLine("Digite a sua Opção: ");
                Console.WriteLine("1 - Cadastrar Veículo");
                Console.WriteLine("2 - Remover Veículo");
                Console.WriteLine("3 - Listar Veículos");
                Console.WriteLine("4 - Encerrar");

                switch (Console.ReadLine())
                {
                    case "1":
                        estacionamento.AdicionarVeiculo();
                        break;

                    case "2":
                        estacionamento.RemoverVeiculo();
                        break;

                    case "3":
                        estacionamento.ListarVeiculos();
                        break;

                    case "4":
                        exibirMenu = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

                Console.WriteLine("Pressione uma tecla para continuar");
                Console.ReadLine();
            }

            Console.WriteLine("O programa se encerrou");
        }
    }
}