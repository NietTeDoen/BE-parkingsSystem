namespace WebApplication1.models
{
    public class ParkingPlace
    {
        public int Id { get; set; }
        public string ParkeerPlaats { get; set; }
        public double Price { get; set; }
        public int MaxCarSize { get; set; }
        public bool Available { get; set; }
        public bool Disability { get; set; }
        public string Location { get; set; }
    }
}
