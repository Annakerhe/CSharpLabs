namespace NetworkModel
{
    public class PCNetwork
    {
        private string Name { get; set; }
        public int StationsCount { get; set; }
        private double DistanceAverage { get; set; }
        public PCNetwork()
        {
            Name = "";
            StationsCount = 0;
            DistanceAverage = 0;
        }

        public PCNetwork(string name, int stations, double dist)
        {
            Name = name;
            StationsCount = stations;
            DistanceAverage = dist;
        }

        public virtual double GetQuality() => StationsCount * DistanceAverage;
    }
}