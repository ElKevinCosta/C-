using System;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Vai buscar o argumento que passamos quando executamos o programa
            Console.WriteLine(args.GetValue(0));
        }
    }
}
