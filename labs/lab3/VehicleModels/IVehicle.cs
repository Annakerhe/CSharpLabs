
namespace VehicleModels
{
    public interface IVehicle
    {
        public string TypeVehicle { get; set; }

        public bool IsOverFlow();
        public bool IsOverSpeed();
    }
}
