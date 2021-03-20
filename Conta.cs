namespace DIO_Bank
{
    public class Conta
    {
        private TipoConta TipoConta {get;set;}
        private double Saldo {get;set;}      
        private double Credito {get;set;}
        private string Nome {get;set;}
        public Conta(TipoConta tipoConta, double saldo, double credito, string nome) 
        {
            this.TipoConta = tipoConta;
                this.Saldo = saldo;
                this.Credito = credito;
                this.Nome = nome;      
        }

          public bool Sacar(double valorSaque) {
             if(this.Saldo-valorSaque< (this.Credito*-1)) {
                 System.Console.WriteLine("saldo insuficiente");
                 return false;
             }
            this.Saldo-=valorSaque;
            return true;
             
         }
        public void Depositar(double valorDeposito)
         {
            this.Saldo+=valorDeposito;
         }

        public void Transferir(double valorTransferencia,Conta contaDestino) {
            if (this.Sacar(valorTransferencia)) {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString() 
        {
            string retorno ="" ;
            retorno+="TipoConta "+this.TipoConta + "|" ;
            retorno+="Nome "+this.Nome + "|" ;
            retorno+="Saldo  "+this.Saldo + "|" ;
            retorno+="Credito "+this.Credito ;

            return retorno;
        }


    }

}

