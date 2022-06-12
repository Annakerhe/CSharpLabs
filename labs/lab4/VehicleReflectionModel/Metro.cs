using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleReflectionModel
{
    public class Metro : PublicTransport
    {
        public int ProductionYear { get; set; }
        public double Condition { get; set; }

        public string GetCondition()
        {
            if (Condition > 50)
                return "Состояние нормальное.";
            else
                return "Требует ремонта.";
        }

        public void UpCost(int count)
        {
            CostTicket += count;
        }

        public void DownCost(int count)
        {
            CostTicket -= count;
            if (CostTicket < 0)
                CostTicket = 0;
        }
        public override int GetFine()
        {
            int overspeed = CurrentSpeed - MaxSpeed;
            if (overspeed < 40) { return 200; }
            if (overspeed >= 40 && overspeed < 60) { return 1030; }
            if (overspeed >= 60 && overspeed < 80) { return 2100; }
            return 4000;
        }
    }
}
