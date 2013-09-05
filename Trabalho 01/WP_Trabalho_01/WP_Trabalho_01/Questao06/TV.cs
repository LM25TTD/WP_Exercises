using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WP_Trabalho_01.Questao06
{
    public class TV
    {
        private int _canal=1;
        private int _volume=0;

        public int canal
        {
            get
            {
                return this._canal;
            }
            set
            {
                this._canal = value;
                if (value < 1)
                    this._canal = 1;
                if (value > 1000)
                    this._canal = 1000;                
            }
        }

        public int volume
        {
            get
            {
                return this._volume;
            }
            set
            {
                this._volume = value;
                if (value < 1)
                    this._volume = 0;
                if (value > 100)
                    this._volume = 100;                
            }
        }
    }
}
