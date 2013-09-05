using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Trabalho_01.Questao02
{
    public class Quadrado
    {
        private float _lado=0;

        public void mudarValorLado(float lado)
        {
            this._lado = lado;
        }

        public float retornaValorLado()
        {
            return this._lado;
        }

        public float calculaArea()
        {
            return (this._lado * this._lado);
        }
    }
}
