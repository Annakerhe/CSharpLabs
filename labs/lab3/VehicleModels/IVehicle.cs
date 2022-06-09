
namespace VehicleModels
{
    public interface IVehicle
    {
        public string Type_vehicle { get; set; }

        public bool Is_overflow();
        public bool Is_overspeed();
    }
}
