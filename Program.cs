using System;
using System.Collections.Generic;

namespace DIO_Bank
{
    class Program
    {
        static List<Conta> listContas=new List<Conta>();
        static void Main(string[] args)
        {
        Conta minhaConta=new Conta(TipoConta.PessoaFisica,0,0,"Luis");
        string opcaoUsuario=ObterOpcaoUsuario();
        while (opcaoUsuario.ToUpper()!= "X")
        {
            switch (opcaoUsuario)
            {
                case "1":
                    ListarContas();
                    break;
                case "2":
                    InserirConta();
                    break;
                case "3":
                    Transferir();
                    break;
                case "4":
                    SacarConta();
                    break;
                case "5":
                    DepositarConta();
                    break;
                case "C" :
                    Console.Clear();
                    break;
                default:    
                    throw new ArgumentOutOfRangeException();

            }
            opcaoUsuario=ObterOpcaoUsuario();
        }

            
        }
        private static void InserirConta() 
        {
            Console.WriteLine("Inserir nova conta");

            Console.WriteLine("Digite 1 para conta PF ou 2 para PJ");
            int entradaTipoConta=int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do Cliente");
            string EntradaNome=Console.ReadLine();

            Console.WriteLine("Saldo inicial");
            double entradaSaldo=double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o crédito");
            double entradaCredito=double.Parse(Console.ReadLine());

            Conta novaConta=new Conta(tipoConta:(TipoConta)entradaTipoConta,
                                        saldo: entradaSaldo,
                                        credito: entradaCredito,
                                        nome: EntradaNome);
            
            listContas.Add(novaConta);
        }                
        private static void ListarContas() 
        {
            System.Console.WriteLine("Listar Contas");
            if (listContas.Count==0) 
            {
                System.Console.WriteLine("Nenhuma conta cadastrada.");
                return;
            }
            for (int i=0;i<listContas.Count;i++)
            {
                Conta conta=listContas[i];
                Console.Write("#{0} - ",i);
                Console.WriteLine(conta);
            }
        }
        private static void SacarConta()
        {
            System.Console.WriteLine("Digite o número da Conta");
            int indiceConta=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor a ser Sacado:");
            double valorDeposito=double.Parse(Console.ReadLine());

            listContas[indiceConta].Sacar(valorDeposito);
        }
        private static void DepositarConta()
        {
            System.Console.WriteLine("Digite o número da Conta");
            int indiceConta=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor a ser Depositado:");
            double valorDeposito=double.Parse(Console.ReadLine());

            listContas[indiceConta].Depositar(valorDeposito);
        }

        private static void Transferir() 
        {
            System.Console.WriteLine("Digite o número da conta de origem:");
            int indiceContaOrigem=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o número da conta de destino:");
            int indiceContaDestino=int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite o valor a ser transferido:");
            double valorTransferencia=double.Parse(Console.ReadLine());

            listContas[indiceContaOrigem].Transferir(valorTransferencia,listContas[indiceContaDestino]);
        }


        private static string ObterOpcaoUsuario() 
        {
            System.Console.WriteLine();
            System.Console.WriteLine("DIO Bank a seu dispor");
            System.Console.WriteLine("Informe as opção desejada");

            System.Console.WriteLine("1- Listar Conta");
            System.Console.WriteLine("2- Inserir nova conta");
            System.Console.WriteLine("3- Transferir");
            System.Console.WriteLine("4- Sacar");
            System.Console.WriteLine("5- Depositar");
            System.Console.WriteLine("C- Limpar tela");
            System.Console.WriteLine("X- Sair ");
            System.Console.WriteLine("");

            string opcaoUsuario=Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }                    
        
    }
}
