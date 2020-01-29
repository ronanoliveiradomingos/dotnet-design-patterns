namespace Pattern.Faceted.Builder
{
    public class CarBuilderFacade
    {
        protected Car _car { get; set; }
        public CarBuilderFacade()
        {
            _car = new Car();
        }
        public Car Build() => _car;

        public CarInfoBuilder Info => new CarInfoBuilder(_car);
        public CarAddressBuilder Built => new CarAddressBuilder(_car);
    }
}