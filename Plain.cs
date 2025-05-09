namespace VehicleApp.Models
{
    public class Plain : Vehicle
    {
        public double Height { get; set; }
        public int Passengers { get; set; }

        public Plain(double price, double speed, int year, double height, int passengers)
            : base(price, speed, year)
        {
            Height = height;
            Passengers = passengers;
        }

        public override string GetInfo()
        {
            return $"Літак: Ціна = {Price}, Швидкість = {Speed}, Рік = {Year}, Висота = {Height}, Пасажири = {Passengers}";
        }
    }
}
