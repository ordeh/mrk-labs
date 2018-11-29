using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {

        static void Main(string[] args)
        {
            Car redCar = new Car("1234-TI", "Red", "Ivan Ivanov");
            Car greenCar = new Car("3214-XI", "Green", "Vasia Ivanov");

            Car yellowCar = new Car("9876-XX", "Yellow", "Gosha Ivanov");
            Car blackCar = new Car("4567-TO", "Black", "Tosha Ivanov");

            Parking parking = new Parking();
            // parking.setPlaceNumber(1);
        //    Console.Write(redCar.placeNumber);
            //parking.setCar(redCar);
           // parking.getCars().Add(redCar);
            parking.addCarToParking(yellowCar, 1);
            parking.removeCarFromParking(parking.getCarByPlaceNumber(1));


            // parking.addCarToParking(yellowCar);
            // Console.Write(parking.getCars()[0].GosNumber);
            // Console.Write(parking.getCars()[1].GosNumber);
            Console.Write(parking.getAllExistingCars());

            Console.Read();
                
            

        }
    }
}
