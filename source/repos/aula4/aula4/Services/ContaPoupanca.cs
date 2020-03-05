using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4.Services
{
    class ContaPoupanca
    {

        Pessoa pessoa = new Pessoa("00000", "Joao", "jcartapati@mgmail.com");

        public void depositar(double valor)
        {
            Console.WriteLine("Digite um valor a ser depositado");
            valor = double.Parse(Console.ReadLine());

            valor = valor + pessoa.Saldo;
        }

        public void sacar(double valor, double saldoPessoa)
        {
            Console.WriteLine("Digite um valor a ser sacado");
            saldoPessoa = pessoa.Saldo;
            valor = double.Parse(Console.ReadLine());
            if (saldoPessoa < valor)
            {
                Console.WriteLine("Saldo insuficiente");
            } else
            {
                saldoPessoa = saldoPessoa - valor;
            }
        }

        public void getSaldo(double saldo)
        {
            Console.WriteLine($"Seu saldo é {pessoa.Saldo}");
        }
    }
}
