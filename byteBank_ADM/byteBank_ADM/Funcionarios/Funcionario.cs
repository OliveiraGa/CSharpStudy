using System;
using System.Collections.Generic;
using System.Text;

namespace byteBank_ADM.Funcionarios
{
    public class Funcionario
    {
        public int _tipo;
        public string Nome { get; set; }
        public string CPF { get; set; }
        public double Salario { get; set; }
        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }


        public Funcionario()
        {
           
        }



    }
}
