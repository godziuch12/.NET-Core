namespace Apps.Core.Domain
{
    public class Vehicle
    {
        public string Name {get; protected set;}
        public int Seats {get; protected set;}
        public string Brand {get; protected set;}

        public Vehicle(string brand, string name, int seat)
        {
            Name = name;
            Brand = brand;
            Seats = seat;
        }
    }
}