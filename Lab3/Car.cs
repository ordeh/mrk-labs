using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Car
    {

        private string gosNumber;

        private string color;

        private string lastName;

        public int placeNumber;

        public bool isExists;

        public Car(string gosNumber, string color, string lastName)
        {
            this.gosNumber = gosNumber;
            this.color = color;
            this.lastName = lastName;
            this.isExists = false;


        }

        public string GosNumber { get => gosNumber; set => gosNumber = value; }
        public string Color { get => color; set => color = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}
