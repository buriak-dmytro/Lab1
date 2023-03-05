using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Car
    {
        private string manufacturer;
        private string color;
        private string numberPlate;
        private bool isWashed;

        public Car()
        {
            manufacturer = string.Empty;
            color = string.Empty;
            numberPlate = string.Empty;
            isWashed = false;
        }

        public Car(string manufacturer, string color, string numberPlate, bool isWashed)
        {
            this.manufacturer = manufacturer;
            this.color = color;
            this.numberPlate = numberPlate;
            this.isWashed = isWashed;
        }

        public bool IsWashed
        {
            get { return isWashed; }
            set { isWashed = value; }
        }

        public override string ToString()
        {
            return $"{manufacturer} {color} {numberPlate} " + (isWashed ? "clean" : "dirty");
        }
    }
}
