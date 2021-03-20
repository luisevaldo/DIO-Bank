using System;

namespace DIO_Bank
{
    class Program
    {
        static void Main(string[] args)
        {
        Conta minhaConta=new Conta(TipoConta.PessoaFisica,0,0,"Luis");
        System.Console.WriteLine(   minhaConta.ToString());
        
            
        }
    }
}
