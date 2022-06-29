using System;
using System.Collections.Generic;
using System.Text;

namespace byteBank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf) : base(cpf, 1500)
        {

        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.1;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.1;
        }
    }
}
