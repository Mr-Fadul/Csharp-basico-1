using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1
{
    class Computador
    {
        public string MemoriaRam{get; set;}
        public string CapacidadeDisco { get; set; }
        public double CpuClock { get; set; }
        public Computador()
        {

        }

        //public void overclock()
        //{
        //    this.CpuClock *= 1.05;
        //}
        public void overclock(double over)
        {
            this.CpuClock *= (1+over);
        }
        public void overclock()
        {
            //compacto - inferencia de tipo (: operador tenario)
            var incremento = this is Desktop ? 0.1 :
                this is Notebook ? 0.05 : 0;


            //tradicional 
            //double incremento = 0;
            //if (this is Notebook)
            //{
            //    incremento = 0.05;
            //}else if (this is Desktop)
            //{
            //    incremento = 0.1;
            //}


            //difícil precisa receber um objeto
            //if(pc is Desktop)
            //{
            //  Desktop desk = pc as Desktop; 
            //  desk.CpuClock += (CpuClock * 10) / 100;

            //}else if (pc is Notebook)
            //{
            //    Notebook note = pc as Notebook;
            //    note.CpuClock += (CpuClock * 5) / 100;

            //}
            this.CpuClock *= (1 + incremento);

        }






    }
}
