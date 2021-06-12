using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

static class Constante
{
    public const double discount = 5;
}
namespace ContaBancaria
{
    class Conta
    {
        public string name { get; set; }
        public int NumberAccount { get; private set; }
        private double depositAmout;
        private double accountBalance;
        private double discount;

        public Conta(int number_accout, string name_user, double init_value)
        {
            name = name_user;
            NumberAccount = number_accout;
            accountBalance = init_value;
        }
        public Conta(int number_accout, string name_user)
        {
            name = name_user;
            NumberAccount = number_accout;
        }
        public Conta()
        {
        }

        public double DepositAmout
        {
            get { return  depositAmout; }
            set {  depositAmout = value; }
        }


        //metodo para deposito
        public void Deposit (double deposit)
        {
            Console.WriteLine("O deposito foi no valor de " + deposit);
            accountBalance += deposit;
            Console.WriteLine("O saldo da conta e de " + accountBalance);
        }

        //metodo para saque 
        public void withdraw (double valueWithdraw)
        {
            accountBalance = accountBalance - (discount + valueWithdraw);
           
        }

        public override string ToString()
        {
       
            return "o numero da conta"
                + NumberAccount + "\n"
                + "Nome do titular"
                + name + "\n"
                + "Saldo:"
                + accountBalance;

        }

    }
}
