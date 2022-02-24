using Projeto_teste.Entities;
using System;

namespace Projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker work = new Worker();
            work.Departments.Name = "Luiz";
            Console.WriteLine(work.Departments.Name);
         
        }
    }
}
