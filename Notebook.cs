using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Notebook : Computador
    {
        public bool TecladoNumerico { get; set; }
        public double Polegadas { get; set; }

        public Notebook(double clock)
        {
            this.CpuClock = clock;
        }
        public Notebook(double clock, string memoria):this(clock)
        {       
            this.MemoriaRam = memoria;
        }
    }
}
