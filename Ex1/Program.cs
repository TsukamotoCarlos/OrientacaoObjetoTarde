using System;

namespace Ex1 {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Bem vindo - Sportore Bank");
          

            ContaCorrente conta1 = new ContaCorrente ();
            conta1.titular = "Cesar";
            conta1.agencia = 132;
            conta1.numeroConta = 999;
            conta1.Depositar (10000); //aqui

            ContaCorrente conta2 = new ContaCorrente();
            conta2.titular = "Tsukamoto";
            conta2.agencia = 132;
            conta2.numeroConta = 1;
            conta2.Depositar(5000);

            Console.WriteLine ($"----Primeira conta----");
            Console.WriteLine ($"Titular: {conta1.titular}");
            Console.WriteLine ($"Agência: {conta1.agencia}");
            Console.WriteLine ($"Numero da conta: {conta1.numeroConta}");
            Console.WriteLine ($"Saldo: {conta1.ExibirSaldo()}");
            Console.WriteLine ($"-----------------------");

            Console.WriteLine ($"----Segunda conta----");
            Console.WriteLine ($"Titular: {conta2.titular}");
            Console.WriteLine ($"Agência: {conta2.agencia}");
            Console.WriteLine ($"Numero da conta: {conta2.numeroConta}");
            Console.WriteLine ($"Saldo: {conta2.ExibirSaldo()}");
            Console.WriteLine ($"-----------------------");
            


            // bool valorRetornado = conta1.Sacar(3500);
            // if(valorRetornado){
            // Console.WriteLine("Parabéns você conseguiu!");
            // }else{
            // Console.WriteLine("Você não tem dinheiro na conta");
            // }
            // Console.WriteLine ($"Saldo depois do saque: {conta1.ExibirSaldo()}");

            conta2.Trasferir(1000, conta1);

            Console.WriteLine ($"Saldo conta 1: {conta1.ExibirSaldo()}");
            Console.WriteLine ($"Saldo conta 2: {conta2.ExibirSaldo()}");



        }
    }
}