using System;
using System.Globalization;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.WriteLine("Digite o numero da conta:");
            int numberAccout = int.Parse(Console.ReadLine());
            Console.WriteLine("Quem será responsavel pela conta:");
            string name = Console.ReadLine();
            Console.WriteLine("Deseja fazer um deposito inicial?(S/N)");
            char Resposta = char.Parse(Console.ReadLine());
            if (Resposta == 'S'|| Resposta == 's')
            {
                Console.WriteLine("Qual e o valor que deseja depositar");
                double depositInti = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numberAccout, name, depositInti);
            }
            else
            {
                conta = new Conta(numberAccout, name);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Faça um deposito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposit(valor);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Faça um saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.withdraw(valor);
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);
        }
    }
}
