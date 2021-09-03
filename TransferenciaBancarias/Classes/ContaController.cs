using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferenciaBancarias
{
    class ContaController
    {
        public static List<Conta> listarConta = new List<Conta>();
        public static void ListarConta()
        {
            Console.WriteLine("Listar contas");

            if(listarConta.Count == 0)
            {
                Console.WriteLine("nenhuma conta cadastrada");
                return;
            }

            for(int i= 0; i < listarConta.Count; i++) {
                Conta conta = listarConta[i];
                Console.Write("#{0} - ",i);
                Console.WriteLine(conta);
            }
        }
        public static void CadastrarConta()
        {

            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para conta física ou 2 para juridica: ");
            int tipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o saldo inicial: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito da conta: ");
            double credito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta((TipoConta)tipoConta, nome, saldo, credito);

            listarConta.Add(novaConta);
        }

        public static void Sacar() {

            Console.WriteLine("Digite o numero da conta: ");
            int idConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do saque: ");
            double valorSaque = double.Parse(Console.ReadLine());

            listarConta[idConta].Sacar(valorSaque);
        }

        public static void Depositar()
        {

            Console.WriteLine("Digite o numero da conta: ");
            int idConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor do deposito: ");
            double deposito = double.Parse(Console.ReadLine());

            listarConta[idConta].Depositar(deposito);
        }
        public static void Transferir()
        {

            Console.WriteLine("Digite o numero da conta de origem: ");
            int idConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o numero da conta destino: ");
            int idDestino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da tranferencia: ");
            double transf = double.Parse(Console.ReadLine());

            listarConta[idConta].Transferir(transf, listarConta[idDestino]);
        }



        public static void Transferir(Conta conta1, Conta conta2)
        {

        }

    }
}
