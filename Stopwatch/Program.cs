using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }



        static void Menu(){
            Console.Clear();
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            if (data == "0")
                Environment.Exit(0);            

            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

    
            int multiplier = 1;
            if (type == 'm')
                multiplier = 60;

            
            PreStart(time * multiplier);
        }

        static void PreStart(int time){
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go!");
            Thread.Sleep(1000);

            Start(time);
        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
                {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
                }
            Console.Clear();
            Console.WriteLine("O tempo passou!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}