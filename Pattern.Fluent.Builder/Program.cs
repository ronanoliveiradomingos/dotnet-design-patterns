using System;

namespace Pattern.Fluent.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = EmployeeBuilderDirector
                        .NewEmployee
                        .SetName("Ronan Oliveira Domingos")
                        .AtPosition("Software Developer")
                        .WithSalary(3500)
                        .Build();

            var empQA = EmployeeBuilderDirector
                        .NewEmployee
                        .SetName("Alberto Alves Silva")
                        .AtPosition("QA")
                        .WithSalary(2500)
                        .Build();

            Console.WriteLine(emp);
            Console.WriteLine(empQA);        }
    }
}
