using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Garage : ICollection<Car>
    {
        private List<Car> cars;

        public Garage() => cars = new List<Car>();

        public Garage(List<Car> cars) => this.cars = cars;

        public Garage(Car[] cars) => this.cars = new List<Car>(cars);

        public int Count => cars.Count;

        public bool IsReadOnly => false;

        public void Add(Car carItem) => cars.Add(carItem);

        public void Clear() => cars.Clear();

        public bool Contains(Car carItem) => cars.Contains(carItem);

        public void CopyTo(Car[] carsArray, int arrayIndex) => cars.CopyTo(carsArray, arrayIndex);

        public IEnumerator<Car> GetEnumerator() => cars.GetEnumerator();

        public bool Remove(Car carItem) => cars.Remove(carItem);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public override string ToString()
        {
            string toReturn = "";

            toReturn += "Garage:\n";
            for (int i = 0; i < cars.Count - 1; i++)
            {
                toReturn += cars[i].ToString() + "\n";
            }
            toReturn += cars[cars.Count - 1].ToString();

            return toReturn;
        }
    }
}
