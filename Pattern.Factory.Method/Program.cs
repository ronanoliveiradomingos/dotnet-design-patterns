namespace Pattern.Factory.Method
{
    class Program
    {
        static void Main(string[] args)
        {
            AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Actions.Warming, 22.5)
                .Operate();

            AirConditioner
                .InitializeFactories()
                .ExecuteCreation(Actions.Cooling, 5.0)
                .Operate();
        }
    }
}
