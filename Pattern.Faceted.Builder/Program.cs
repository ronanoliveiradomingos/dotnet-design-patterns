using System;

namespace Pattern.Faceted.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new CarBuilderFacade()
            .Info
                .WithType("BMW")
                .WithColor("Black")
                .WithNumberOfDoors(5)
            .Built
                .InCity("Porto")
                .AtAdress("Rua da Constituição, 320")
            .Build();

            Console.WriteLine(car);
        }
    }
}
