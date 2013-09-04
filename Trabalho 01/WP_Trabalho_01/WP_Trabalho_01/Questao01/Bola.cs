using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Trabalho_01.Questao01
{
    public class Bola
    {
        private string _cor;
        private float _circunferencia;
        private string _material;

        public string mostraCor()
        {
            return this._cor;
        }

        public void trocaCor(string cor)
        {
          this._cor=cor;
        }

        public float circunferencia
        {
            get
            {
                return this._circunferencia;
            }
            set
            {
                this._circunferencia = circunferencia;
            }
        }

        public string material
        {
            get
            {
                return this._material;
            }
            set
            {
                this._material = material;
            }
        }

    }
}
