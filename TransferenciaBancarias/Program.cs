using System;

namespace TransferenciaBancarias
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = ""; 
            while(opcao.ToUpper() != "X")
            {
                opcao = OpcaoMenu();
                switch (opcao)
                {
                    case "1":ContaController.ListarConta();
                        break;
                    case "2": ContaController.CadastrarConta();
                        break; 
                    case "3":ContaController.Transferir();
                        break;
                    case "4":ContaController.Sacar();
                        break;
                    case "5":ContaController.Depositar();
                        break;
                    case "X": Console.WriteLine("Obrigado por utalizar nossos serviços.");
                        break;
                    default: Console.WriteLine("Opção Invalida");
                        break;
                }
            }
        }

        public static string OpcaoMenu()
        {
            Console.WriteLine("Escolha uma das opções:");
            Console.WriteLine("1 - Listar Contas");
            Console.WriteLine("2 - Inserir Conta");
            Console.WriteLine("3 - Transferir ");
            Console.WriteLine("4 - Sacar");
            Console.WriteLine("5 - Depositar");
            Console.WriteLine("X - Sair");

            string retorno = Console.ReadLine();

            return retorno;
        }
    }
}
