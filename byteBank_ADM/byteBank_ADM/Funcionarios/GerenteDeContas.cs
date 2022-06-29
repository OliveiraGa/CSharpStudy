using System;
using System.Collections.Generic;
using System.Text;

namespace byteBank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public GerenteDeContas(string cpf) : base(cpf, 6500)
        {

        }

        public override void AumentarSalario()
        {
            Salario += Salario * 0.5;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.18;
        }
    }
}
