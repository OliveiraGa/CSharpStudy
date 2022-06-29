using System;
using System.Collections.Generic;
using System.Text;

namespace byteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public int _tipo;
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
        

        public static int totalDeFuncionario { get; private set; }


        public Funcionario(string cpf, double salario)
        {
            totalDeFuncionario++;
            CPF = cpf;
            Salario = salario;
        }

        public abstract double GetBonificacao();

        public abstract void AumentarSalario();       

    }
}
