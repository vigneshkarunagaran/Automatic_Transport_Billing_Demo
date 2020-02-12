using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Transport
{
    class MiniVehicle:Vehicle
    {
       public int seatingCapacity;
       public MiniVehicle(char ft , String vm, String vt, int km, int sc) :base( ft, vm,vt,km)
        {
            this.seatingCapacity = sc;
        }

        public int getSeatingCapacity()
        { return seatingCapacity; }

        public override void calculateRatePerKiloMeter()
        {
            ratePerKiloMeter = (float)(4.5 + (seatingCapacity - 4) * 1);
        }

        public override double calculateBill()
        {
            double BillAmount = (noOfKiloMeters * ratePerKiloMeter);
            return BillAmount;
        }

    }
}
