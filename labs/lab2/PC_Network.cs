namespace NetworkModel
{
   public class PC_Network
    {
        private string Name { get; set; }
        public int Stations_count { get; set; }
        private double Distance_average { get; set; }
        public PC_Network()
        {
            Name = "";
            Stations_count = 0;
            Distance_average = 0;
        }

        public PC_Network(string name, int stations, double dist)
        {
            Name = name;
            Stations_count = stations;
            Distance_average = dist;
        }
        
        public virtual double Get_quality()=> Stations_count * Distance_average;
    }
}