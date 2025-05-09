namespace VehicleApp.Models
{
    public class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string Port { get; set; }

        public Ship(double price, double speed, int year, int passengers, string port)
            : base(price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }

        public override string GetInfo()
        {
            return $"Корабель: Ціна = {Price}, Швидкість = {Speed}, Рік = {Year}, Пасажири = {Passengers}, Порт приписки = {Port}";
        }
    }
}
