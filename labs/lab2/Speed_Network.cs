
namespace NetworkModel
{
    public class Speed_Network : PC_Network
     
    {
        private double P { get; set; } 
        public Speed_Network(string name, int stations, double dist, double speed)
            : base(name, stations, dist)
        {
            P = speed;
        }
        public override double Get_quality()
        {
            return Stations_count * P;
        }
    }
}
