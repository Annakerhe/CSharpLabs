
namespace VehicleModels
{
    public class Tram : Public_transport
    {
        public int Stops_count { get; set; }
        public double Time_average { get; set; }   
            
        
        public double Total_time_stops()
        {
            return Stops_count * Time_average;
        }

        public double Total_profit()
        {
            return Current_pass_count * Cost_ticket;
        }
    }
}
