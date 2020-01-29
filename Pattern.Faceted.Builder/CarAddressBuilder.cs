namespace Pattern.Faceted.Builder
{
    public class CarAddressBuilder: CarBuilderFacade
    {
        public CarAddressBuilder(Car car)
        {
            _car = car;
        }

        public CarAddressBuilder InCity(string city)
        {
            _car.City = city;
            return this;
        }

        public CarAddressBuilder AtAdress(string address)
        {
            _car.Address = address;
            return this;
        }
    }
}