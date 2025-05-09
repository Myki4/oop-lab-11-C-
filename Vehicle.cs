namespace VehicleApp.Models
{
    public abstract class Vehicle
    {
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }

        public Vehicle(double price, double speed, int year)
        {
            Price = price;
            Speed = speed;
            Year = year;
        }

        public abstract string GetInfo();

        public virtual void Accelerate(double increment)
        {
            Speed += increment;
        }
    }
}
