using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Trabalho_01.Questao04
{
    public class Pessoa
    {
        private string nome { get; set; }
        private int _idade;
        private float _peso;
        private float _altura;

        public int idade
        {
            get
            {
                return this._idade;
            }
        }

        public float peso
        {
            get
            {
                return this._peso;
            }
        }

        public float altura
        {
            get
            {
                return this._altura;
            }
        }
        
        public Pessoa(string nome, int idade, float peso, float altura)
        {
            this.nome = nome;
            this._idade = idade;
            this._peso = peso;
            this._altura = altura;
        }

        public void envelhecer()
        {
            if (this._idade < 21)
                this.crescer(0.5f);
            this._idade++;
        }

        public void engordar(float peso_ganho)
        {
            this._peso += peso_ganho;
        }

        public void emagrecer(float peso_perdido)
        {
            this._peso -= peso_perdido;
        }

        public void crescer(float tamanho_ganho)
        {
            this._altura += tamanho_ganho;
        }
    }
}
