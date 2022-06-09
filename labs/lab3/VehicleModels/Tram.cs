
namespace VehicleModels
{
    public class Tram : PublicTransport
    {
        public int StopsCount { get; set; }
        public double TimeAverage { get; set; }   
            
        
        public double TotalTimeStops()
        {
            return StopsCount * TimeAverage;
        }

        public double TotalProfit()
        {
            return CurrentPassCount * CostTicket;
        }
        public override int GetFine()
        {            
                int overspeed = CurrentSpeed - MaxSpeed;
                if (overspeed < 40) { return 500; }
                if (overspeed >= 40 && overspeed < 60) {  return 1000; }
                if (overspeed >= 60 && overspeed < 80) {  return 2500; }              
                return 5000;               
            
        }
    }
}
