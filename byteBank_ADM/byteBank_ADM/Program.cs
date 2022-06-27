using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitarios;
using System;

namespace byteBank_ADM
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorDeBonificacoes gerenciadorDeBonificacoes = new GerenciadorDeBonificacoes();


            Console.WriteLine("Boa vindas, ao ByteBank ADM");
            Funcionario joao = new Funcionario();
            joao.Nome = "João";
            joao.CPF = "12345678910";
            joao.Salario = 2000;

            Diretor paula = new Diretor();
            paula.Nome = "Paula";
            paula.CPF = "12345678910";
            paula.Salario = 5000;


            Console.WriteLine($"Bonificação: {joao.GetBonificacao()}");
            Console.WriteLine($"Bonificação: {paula.GetBonificacao()}");

            gerenciadorDeBonificacoes.Registrar(joao);
            gerenciadorDeBonificacoes.Registrar(paula);

            Console.WriteLine($"Total de bonificacoes: {gerenciadorDeBonificacoes.GetBonificacao()}");

        }
    }
}
