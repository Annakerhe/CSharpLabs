namespace VehicleModels
{
    public abstract class Public_transport : IVehicle
    {
        public string Type_vehicle { get; set; } = string.Empty;
        public int Current_speed { get; set; }
        public int Max_speed {  get; set; }
        public int Max_pass_count { get; set; }
        public int Current_pass_count { get; set; }
        public int Cost_ticket { get; set; }

            
        public bool Is_overflow()
        {
            return Current_pass_count > Max_pass_count;
        }
      
        public bool Is_overspeed()
        {
            return Current_speed > Max_speed;
        }
    }

}