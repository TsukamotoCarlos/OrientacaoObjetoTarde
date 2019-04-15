namespace Ex1 {
    public class ContaCorrente {
        public string titular;

        public int agencia;

        public int numeroConta;

        private double saldo {get; set;}

        public void Depositar(double valor){
            saldo += valor;
        }
        public bool Sacar (double valor) {
            if(valor > saldo){
                return false;
            }else{
                saldo -= valor;
                return true;
            }
        } //fim sacar
        public double ExibirSaldo(){
            return saldo;   
        }

        public bool Trasferir(double valor, ContaCorrente contaDestino){
            if(valor > saldo){
                return false;
            }else{
                saldo -= valor;
                contaDestino.saldo += valor;
                return true;
            }
        }
    }
}