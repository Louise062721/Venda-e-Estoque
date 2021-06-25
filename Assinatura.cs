﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda_e_estoque_2
{
    public class Assinatura : Licensa
    {
        private int _duracao;

        public double Duracao
        {
            get { return this._duracao; }
        }

        public Assinatura(string nome, double mensalidade, int duracao, string chaveAtivacao) : base(nome, mensalidade, chaveAtivacao)
        {
            this._duracao = duracao;
        }

        public override double CalculaValorTotal()
        {
            return this._preco * this._duracao;
        }

        public override void Imprimir()
        {
            Console.WriteLine("Software:\t{0}", this.Nome);
            Console.WriteLine("Mensalidade:\tR$ {0:0.00}", this._preco);
            Console.WriteLine("Duração:\t{0}", this._duracao);
            Console.WriteLine("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
        }
    }
}
