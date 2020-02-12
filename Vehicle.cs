using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Transport
{
    abstract class Vehicle
    {
        public int billID;
        public char fuelType;
        public string vehicleMake;
        public string vehicleType;
        public int noOfKiloMeters;
        public float ratePerKiloMeter;
        public static int counter = 0;

        public Vehicle(char ft, String vm, String vt, int km)
        {
            this.fuelType = ft;
            this.vehicleMake = vm;
            this.vehicleType = vt;
            this.noOfKiloMeters = km;
        }

        public int getBillID()
        {
            int a = 1001 + counter;
            counter++;
            billID = a;
            return billID;
        }
        public char getFuelType()
        { return fuelType;}

        public string getVehicleMake()
        { return vehicleMake; }

        public string getVehicleType()
        { return vehicleType; }

        public int getNoOfKiloMeters()
        { return noOfKiloMeters; }

        public float getRatePerKiloMeter()
        { return ratePerKiloMeter; }

        public void validateFuelType()
        {
            if ((fuelType != 'P') && (fuelType != 'D'))
            {
                fuelType = 'D';
                Console.WriteLine("Invalid fuel type, set the value to D");
            }
        }

        public abstract void calculateRatePerKiloMeter();
        public abstract double calculateBill();
       


    }
}
