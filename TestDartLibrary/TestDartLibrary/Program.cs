using System;
using DartLibrary;

namespace TestDartLibrary
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            DartLibrary.Class1 dartClass = new DartLibrary.Class1();

            List<string> argumentos = new List<string>
            {
                "85",
                "10",
            };

            var aux = await dartClass.ExecutarExeDart(argumentos);

            Console.WriteLine(aux.ToString());
            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}