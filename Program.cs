using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador cpu1 = new Computador();
            cpu1.CpuClock = 4.0;
            cpu1.overclock(0.20);
            Console.WriteLine("Cpu1 clock com overclock : "+cpu1.CpuClock);

            Notebook note1 = new Notebook(3.2, "8 GB");
            Desktop desk1 = new Desktop();
            desk1.Altura = 30.0;
            desk1.CapacidadeDisco = "1 TB";
            desk1.CpuClock = 3.2;
            desk1.overclock();
            note1.overclock();
            note1.CapacidadeDisco = "2 TB";
            note1.Polegadas = 20;
            Console.WriteLine("Desk1 clock com overclock : " + desk1.CpuClock);

            Console.WriteLine("Note1 clock com overclock : " + note1.CpuClock + " Polegadas : " + note1.Polegadas); ;


        }
    }
}
