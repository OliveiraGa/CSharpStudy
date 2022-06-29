using byteBank_ADM.Funcionarios;
using byteBank_ADM.Utilitarios;
using System;

namespace byteBank_ADM
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularBonificacao();


            //Console.WriteLine("Boa vindas, ao ByteBank ADM");
            //Funcionario joao = new Funcionario("12345678910", 2000);
            //joao.Nome = "João";                       

            //Console.WriteLine($"Total de Funcionarios: {Funcionario.totalDeFuncionario}");


            //Diretor paula = new Diretor("12345678910");
            //paula.Nome = "Paula";           

            //Console.WriteLine($"Bonificação: {joao.GetBonificacao()}");
            //Console.WriteLine($"Bonificação: {paula.GetBonificacao()}");

            //gerenciadorDeBonificacoes.Registrar(joao);
            //gerenciadorDeBonificacoes.Registrar(paula);

            //Console.WriteLine($"Total de bonificacoes: {gerenciadorDeBonificacoes.GetBonificacao()}");

            //joao.AumentarSalario();
            //paula.AumentarSalario();

            //Console.WriteLine($"Salario {joao.Nome}: {joao.Salario} ");
            //Console.WriteLine($"Salario {paula.Nome}: {paula.Salario} ");

        }

        public static void CalcularBonificacao()
        {
            GerenciadorDeBonificacoes gerenciadorDeBonificacoes = new GerenciadorDeBonificacoes();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor paula = new Diretor("159.753.398-04");
            paula.Nome = "Paula";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igor";

            GerenteDeContas camila = new GerenteDeContas("326.985.628-89");
            camila.Nome = "Camila";

            gerenciadorDeBonificacoes.Registrar(pedro);
            gerenciadorDeBonificacoes.Registrar(paula);
            gerenciadorDeBonificacoes.Registrar(igor);
            gerenciadorDeBonificacoes.Registrar(camila);


            pedro.AumentarSalario();

            Console.WriteLine($"Total de Bonificação: {gerenciadorDeBonificacoes.GetBonificacao()}" );

        }
    }
}
