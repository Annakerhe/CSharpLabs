using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleReflectionModel
{
    public class Airplane : PublicTransport
    {
        public string Name { get; set; }
        public double MaxFuel { get; set; }
        public void UpMaxFuel(int count)
        {
            MaxFuel += count;
        }

        public void DownMaxFuel(int count)
        {
            MaxFuel -= count;
            if (MaxFuel < 0)
                MaxFuel = 0;
        }

        public void Rename(string name)
        {
            Name = name;
        }

        public override int GetFine()
        {
            int overspeed = CurrentSpeed - MaxSpeed;
            if (overspeed < 400) { return 5000; }
            if (overspeed >= 400 && overspeed < 600) { return 10000; }
            if (overspeed >= 600 && overspeed < 800) { return 25000; }
            return 50000;
        }
    }
}
