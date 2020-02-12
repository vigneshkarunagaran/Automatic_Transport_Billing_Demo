using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC_Transport
{
    class Demo
    {
        public
        static void Main(string[] args)
        {
            Demo ABT = new Demo();
            ABT.getInitializeObjMini("Car");
            ABT.getInitializeObjMaxi("Bus");
        }

        public MiniVehicle getInitializeObjMini(string type) 
        {
            MiniVehicle Min = new MiniVehicle('P',"Mazda",type,40,7);
            Min.validateFuelType();
            Min.calculateRatePerKiloMeter();

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Vehicle Type : {0}", Min.getVehicleType());
            Console.WriteLine("BillID  : {0}", Min.getBillID());
            Console.WriteLine("Rate per Kilo Meter : {0}", Min.getRatePerKiloMeter());
            Console.WriteLine("Fuel type : {0}", Min.getFuelType());
            Console.WriteLine("Seating Capacity : {0}", Min.getSeatingCapacity());
            Console.WriteLine("---------------------------------------------------------");

            Min.calculateBill();
            return Min;

        }

        public MaxiVehicle getInitializeObjMaxi(string type)  
        {
            MaxiVehicle Max = new MaxiVehicle('D', "Tata", type, 200, 1500);
            Max.validateFuelType();
            Max.calculateRatePerKiloMeter();
            Max.calculateRatePerKG();

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Vehicle Type : {0}", Max.getVehicleType());
            Console.WriteLine("BillID  : {0}", Max.getBillID());
            Console.WriteLine("Rate per Kilo Meter : {0}", Max.getRatePerKiloMeter());
            Console.WriteLine("Fuel type : {0}", Max.getFuelType());
            Console.WriteLine("Load In KG : {0}", Max.getLoadInKG());
            Console.WriteLine("Rate per KG  : {0}", Max.getRatePerKG());
            Console.WriteLine("---------------------------------------------------------");
            Console.ReadLine();

            Max.calculateBill();
            return Max;


        }

    }
}
