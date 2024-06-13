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
            //builder.Services.AddKeyedSingleton<IBuilder, ProductBuilder>("Product");
            //builder.Services.AddKeyedSingleton<IBuilder, ManualBuilder>("Manual");

            var director = new Director();

            // 1. Builder (with and without Director)
            ProductBuilder productBuilder = new ProductBuilder();
            director.Builder = productBuilder;

            Console.WriteLine("Standard basic product:");
            director.BuildSimpleProduct();
            Console.WriteLine(productBuilder.BuildProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director.BuildComplexProduct();
            Console.WriteLine(productBuilder.BuildProduct().ListParts());

            Console.WriteLine("Custom product:");
            productBuilder.AddPartA();
            productBuilder.AddPartC();
            Console.WriteLine(productBuilder.BuildProduct().ListParts());

            Console.ReadLine();

            // 2. Builder (with and without Director)
            ManualBuilder manualBuilder = new ManualBuilder();
            director.Builder = manualBuilder;

            Console.WriteLine("Documentation for Standard basic product:");
            director.BuildSimpleProduct();
            Console.WriteLine(manualBuilder.BuildManual());

            Console.WriteLine("Documentation for Standard full featured product:");
            director.BuildComplexProduct();
            Console.WriteLine(manualBuilder.BuildManual());

            Console.WriteLine("Documentation for Custom product:");
            manualBuilder.AddPartA();
            manualBuilder.AddPartC();
            Console.WriteLine(manualBuilder.BuildManual());

            Console.ReadLine();
        }
    }
}
