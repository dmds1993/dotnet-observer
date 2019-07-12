using ConsoleApp1.Revista;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Editora editora = new Editora();

            AssinanteConcreto assinanteConcreto = new AssinanteConcreto(editora);

            AssinanteConcreto assinanteConcreto1 = new AssinanteConcreto(editora);

            AssinanteConcreto assinanteConcreto2 = new AssinanteConcreto(editora);

            editora.AlterarEdicao();

            editora.RemoverObservador(assinanteConcreto2);

            Console.WriteLine("==============================");

            editora.AlterarEdicao();

            Console.ReadKey();
        }
    }
}
