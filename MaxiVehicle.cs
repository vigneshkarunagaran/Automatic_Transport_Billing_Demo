using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Transport
{
    class MaxiVehicle : Vehicle
    {
        public float loadInKG;
        public float ratePerKG;
        public MaxiVehicle(char ft, String vm, String vt, int km, float lKG) : base (ft,vm,vt,km)
        {
            this.loadInKG = lKG;
        }

        public float getLoadInKG()
        { return loadInKG; }
        public float getRatePerKG()
        { return ratePerKG; }
        public bool validateLoadInKG()
        {
            if (loadInKG >= 100 && loadInKG <= 5000)
            { return true; }
            else
            { return false; }
        }
        public void calculateRatePerKG()
        {
            vehicleMake = vehicleMake.ToLower();
            if (vehicleMake == "ashok leyland")
                ratePerKG = (float)1.5;
            else if (vehicleMake == "mahindra")
                ratePerKG = (float)1.0;
            else
                ratePerKG = (float)0.5; 

        }
        public override void calculateRatePerKiloMeter()
        {
            if (fuelType == 'P')
                ratePerKiloMeter = 6;
            else
                ratePerKiloMeter = 5;
        }
        public override double calculateBill()
        {
            double amount;
            if (validateLoadInKG())
            {
                amount = (noOfKiloMeters * ratePerKiloMeter) + (loadInKG * ratePerKG);
                return amount;
            }
            else
            {

                Console.WriteLine("Unable to calculate the bill as the entered" + loadInKG + "is incorrect");
                return amount = 0.0;
            }

        }


    }
}
