using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Parking
    {
       
     //   private int placeNumber;
        
     //   private bool isExists;
       
        private List<Car> cars;

      //  private Dictionary<int, Car> carPlace; 

        public Parking()
        {
            Cars = new List<Car>();
         //   CarPlace = new Dictionary<int, Car>();
        }

        public void addCarToParking(Car car, int placeNumber)
        {
            car.isExists = true;
            car.placeNumber = placeNumber;
            Cars.Add(car);
           // Console.Write(CarPlace.Last());       
        }

        public void removeCarFromParking(Car car)
        {
            car.isExists = false;
        }

        public Car getCarByPlaceNumber(int number)
        {
            Car resultCar = null;
            for (int i = 0; i < Cars.Count; i++)
            {
               Car targetCar = Cars[i];
                if(targetCar.placeNumber == number)
                {
                    resultCar = targetCar;
                }
                
            }
            return resultCar;
        }

        public List<Car> getAllExistingCars()
        {
            List<Car> resultCar = new List<Car>();
            for (int i = 0; i < Cars.Count; i++)
            {
                Car targetCar = Cars[i];
                if (targetCar.isExists == true)
                {
                    resultCar.Add(targetCar);
                }

            }
            return resultCar;
        }

        public List<Car> getAllNonExistingCars()
        {
            List<Car> resultCar = new List<Car>();
            for (int i = 0; i < Cars.Count; i++)
            {
                Car targetCar = Cars[i];
                if (targetCar.isExists == false)
                {
                    resultCar.Add(targetCar);
                }

            }
            return resultCar;
        }


        // public int PlaceNumber { get => placeNumber; set => placeNumber = value; }
        // public bool IsExists { get => isExists; set => isExists = value; }
        internal List<Car> Cars { get => cars; set => cars = value; }
       // internal Dictionary<int, Car> CarPlace { get => carPlace; set => carPlace = value; }

    }
}
