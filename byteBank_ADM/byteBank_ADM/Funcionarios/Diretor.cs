using System;
using System.Collections.Generic;
using System.Text;

namespace byteBank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {

        public Diretor(string cpf) : base(cpf, 5000)
        {

        }       

        public override void AumentarSalario()
        {
            Salario += Salario * 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario + 0.5;
        }
    }
}
