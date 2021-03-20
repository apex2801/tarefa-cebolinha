using System;

namespace tarefa_cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensagem;

            Console.WriteLine("Olá. Digite sua mensagem: ");
            mensagem = Console.ReadLine();

            mensagem = mensagem.Replace("rr", "l")
                               .Replace("RR", "L")
                               .Replace("rR", "l")
                               .Replace("Rr", "L")
                               .Replace("R", "L")
                               .Replace("r", "l");

            Console.WriteLine(mensagem);
        
        }
    }
}
