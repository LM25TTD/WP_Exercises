using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Trabalho_01.Questao05
{
    public class ContaCorrente
    {
        private long _numeroConta;
        private string _nomeCorrentista;
        private float _saldo;

        public ContaCorrente(long numeroConta, string nomeCorrentista, float saldo = 0.0f)
        {
            this._numeroConta = numeroConta;
            this._nomeCorrentista = nomeCorrentista;
            this._saldo = saldo;
        }

        public float saldo
        {
            get
            {
                return this._saldo;
            }
        }

        public string nomeCorrentista
        {
            get
            {
                return this._nomeCorrentista;
            }
        }

        public float numeroConta
        {
            get
            {
                return this._numeroConta;
            }
        }

        public void alterarNome(string nomeCorrentista)
        {
            this._nomeCorrentista = nomeCorrentista;
        }

        public void deposito(float valorDepositado)
        {
            this._saldo += valorDepositado;
        }

        public void saque(float valorRetirado)
        {
            this._saldo -= valorRetirado;
        }
    }
}
