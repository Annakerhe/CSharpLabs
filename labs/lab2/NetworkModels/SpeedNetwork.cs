
namespace NetworkModel
{
    public class SpeedNetwork : PCNetwork
     
    {
        private double P { get; set; } 
        public SpeedNetwork(string name, int stations, double dist, double speed)
            : base(name, stations, dist)
        {
            P = speed;
        }
        public override double GetQuality()
        {
            return StationsCount * P;
        }
    }
}
