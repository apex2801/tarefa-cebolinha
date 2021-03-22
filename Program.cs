using System;

namespace tarefa_cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase;
            
            Console.WriteLine("---------");
            Console.WriteLine("Cebolinha");
            Console.WriteLine("---------");
            
            Console.Write("Digite uma frase: ");
            frase = Console.ReadLine();
            frase = frase.Replace("rr","l").Replace("rR","l").Replace("RR","L").Replace("Rr","L").Replace("r","l").Replace("R","L");
            Console.WriteLine(frase);        
        }
    }
}
