using System;

namespace Pattern.Faceted.Builder
{
    public class CarInfoBuilder : CarBuilderFacade
    {
        public CarInfoBuilder(Car car)
        {
            _car = car;
        }

        public CarInfoBuilder WithType(string type)
        {
            _car.Type = type;
            return this;
        }

        public CarInfoBuilder WithColor(string color)
        {
            _car.Color = color;
            return this;
        }

        public CarInfoBuilder WithNumberOfDoors(int number)
        {
            _car.NumberOfDoors = number;
            return this;
        }
    }
}