using System;
using System.Collections.Generic;
using System.Text;

namespace byteBank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }

    }
}
