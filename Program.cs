using System;

namespace Aula13Uber
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Clear();

            Conta conta = new Conta();
            conta.Agencia = "256";
            conta._Conta = "452103";

            Motorista m = new Motorista();
            m.Login = "Luanna.Correia";
            m.Senha = "123456";
            m.Nome = "Luanna";
            m.Foto = "3x4";
            m.LocalizacaoAtual = "São Paulo";
            m.Carro = "Corolla";
            m.Conta=conta;

            Cartao cartao = new Cartao();
            cartao.Numero = "456 456 456 456";
            cartao.Titular = "Luanna Correia da Silva";
            cartao.Bandeira = "Visa";
            cartao.Cvv = "456";

            Passageiro p = new Passageiro();
            p.Login = "Luanna";
            p.Senha = "123456";
            p.Cartao = cartao;
            System.Console.Write("Login: ");
            string l = Console.ReadLine();
            System.Console.Write("Senha: ");
            string s = Console.ReadLine();
            p.FazerLogin(l, s);
            System.Console.WriteLine($"{p.SolicitarMotorista()}\n{m.AceitarPassageiro(p)}\n");

            Pagamento p123456789 = new Pagamento();

            System.Console.WriteLine($"\nDados do Pagamento\n{p123456789.Data}\n{p123456789.Status}");

            Corrida c24574522 = new Corrida();
            c24574522.Inicio = "São Paulo";
            c24574522.Chegada = "AV. Marginal TietÊ";
            c24574522.Motorista = m;
            c24574522.Passageiro = p;
            System.Console.WriteLine($"\nDados da Corrida: {c24574522.Inicio}\n{c24574522.Chegada}\n{c24574522.Motorista.Nome}\n{c24574522.Passageiro.Login}");
        }
    }
}