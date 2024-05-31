using Demo.BuilderLibrary;
using Demo.Interfaces;

namespace Demo.BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            // Builder1 (Product)
            Builder1 builder = new Builder1();
            director.Builder = builder;

            Console.WriteLine("Standard basic product:");
            director.BuildSimpleProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildComplexProduct();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder.BuildPartA();
            builder.BuildPartC();
            Console.WriteLine(builder.GetProduct().ListParts());

            Console.ReadLine();

            // Builder2 (Handbook)
            Builder2 builder2 = new Builder2();
            director.Builder =builder2;

            Console.WriteLine("Documentation for Standard basic product:");
            director.BuildSimpleProduct();
            Console.WriteLine(builder2.GetHandbook());

            Console.WriteLine("Documentation for Standard full featured product:");
            director.BuildComplexProduct();
            Console.WriteLine(builder2.GetHandbook());

            Console.WriteLine("Documentation for Custom product:");
            builder2.BuildPartA();
            builder2.BuildPartC();
            Console.WriteLine(builder2.GetHandbook());

            Console.ReadLine();
        }
    }
}
