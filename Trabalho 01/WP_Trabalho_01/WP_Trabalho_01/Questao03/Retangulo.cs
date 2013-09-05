using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Trabalho_01.Questao03
{
    public class Retangulo
    {
        private float _base=0.0f;
        private float _altura=0.0f;

        public Retangulo() { }

        public Retangulo (float base_inicial, float altura_inicial)
        {
            this._base = base_inicial;
            this._altura = altura_inicial;
        }

        public void mudarBase(float nova_base)
        {
            this._base = nova_base;
        }

        public void mudarAltura(float nova_altura)
        {
            this._altura = nova_altura;
        }

        public float retornaBase()
        {
            return this._base;
        }

        public float retornaAltura()
        {
            return this._altura;
        }

        public float calculaArea()
        {
            return (this._base * this._altura);
        }

        public float calculaPerimetro()
        {
            return (2*this._base + 2*this._altura);
        }
    }
}
