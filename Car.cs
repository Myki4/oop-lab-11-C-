namespace VehicleApp.Models
{
    public class Car : Vehicle
    {
        public Car(double price, double speed, int year)
            : base(price, speed, year) { }

        public override string GetInfo()
        {
            return $"Авто: Ціна = {Price}, Швидкість = {Speed}, Рік = {Year}";
        }
    }
}
