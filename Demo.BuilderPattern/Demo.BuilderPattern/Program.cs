using Demo.BuilderLibrary;
using Demo.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Demo.BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            //builder.Services.AddSingleton<IDirector, Director>();
            //builder.Services.AddKeyedSingleton<IBuilder, Builder1>("Product");
            //builder.Services.AddKeyedSingleton<IBuilder, Builder2>("Manual");

            var director = new Director();

            // Builder1 (Product)
            Builder1 builder1 = new Builder1();
            director.Builder = builder1;

            Console.WriteLine("Standard basic product:");
            director.BuildSimpleProduct();
            Console.WriteLine(builder1.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildComplexProduct();
            Console.WriteLine(builder1.GetProduct().ListParts());

            Console.WriteLine("Custom product:");
            builder1.BuildPartA();
            builder1.BuildPartC();
            Console.WriteLine(builder1.GetProduct().ListParts());

            Console.ReadLine();

            // Builder2 (Manual)
            Builder2 builder2 = new Builder2();
            director.Builder = builder2;

            Console.WriteLine("Documentation for Standard basic product:");
            director.BuildSimpleProduct();
            Console.WriteLine(builder2.GetManual());

            Console.WriteLine("Documentation for Standard full featured product:");
            director.BuildComplexProduct();
            Console.WriteLine(builder2.GetManual());

            Console.WriteLine("Documentation for Custom product:");
            builder2.BuildPartA();
            builder2.BuildPartC();
            Console.WriteLine(builder2.GetManual());

            Console.ReadLine();
        }
    }
}
