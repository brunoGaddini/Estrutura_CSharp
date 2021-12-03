using Estrutura_CSharp;
using System; 

namespace Estrutura_CSharp
{
    class Program
    {
        static void Main()
        {
            var s = new Pilhas();
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
        }
    }
}



