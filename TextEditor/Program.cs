using System;
using System.IO;
using System.Security.AccessControl;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que deseja?");
            Console.WriteLine("1. Abrir novo arquivo");
            Console.WriteLine("2. Editar novo arquivo");
            Console.WriteLine("3. Sair");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Abrir(); break;
                case 2: Editar(); break;
                default: Menu(); break;

            }
        }

        static void Abrir()
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            string pathOpen = Console.ReadLine();
            
            using(var file = new StreamReader(pathOpen))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();

        }
        static void Editar()
        {
            Console.Clear();
            Console.WriteLine("Digite seu teto abaixo (ESC para sair)");
            Console.WriteLine("----------------------");
            string text = "";
            
            do 
            {
                text += Console.ReadLine(); //Utiliza tudo que já possui texto, + o que o usuário digitou, se fosse apenas o =, ele substituiria
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);
        }

        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"O arquivo foi salvo no caminho: {path}");
            Console.ReadKey();
            Menu();
        }


    }
}