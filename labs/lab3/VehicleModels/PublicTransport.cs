namespace VehicleModels
{
    public abstract class PublicTransport : IVehicle
    {
        public string TypeVehicle { get; set; } = string.Empty;
        public int CurrentSpeed { get; set; }
        public int MaxSpeed {  get; set; }
        public int MaxPassCount { get; set; }
        public int CurrentPassCount { get; set; }
        public int CostTicket { get; set; }

        public abstract int GetFine();
            
        public bool IsOverFlow()
        {
            return CurrentPassCount > MaxPassCount;
        }
      
        public bool IsOverSpeed()
        {
            return CurrentSpeed > MaxSpeed + 20; // + нештрафуемый порог
        }
    }

}