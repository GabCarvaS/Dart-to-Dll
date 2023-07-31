using System;
using DartLibrary;

namespace TestDartLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DartLibrary.Class1 dartClass = new DartLibrary.Class1();
            dartClass.ExecutarExeDart();

            Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}