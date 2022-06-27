using byteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace byteBank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacoes
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }

        //public void Registrar(Diretor funcionario)
        //{
        //    this.totalBonificacao += funcionario.GetBonificacao();
        //}

        public double GetBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}
