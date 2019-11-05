using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab8
{
    class Garage
    {
        public List<Car> garageList = new List<Car>();

        public List<Car> addCar(int index, List<Car> carList)
        {
            garageList.Add(carList[index - 1]);

            return garageList;
        }

        public List<Car> removeCar(int index)
        {
            garageList.Remove(garageList[index - 1]);

            return garageList;
        }

        public void showAllCars()
        {
            foreach (Car car in garageList)
            {
                Console.WriteLine($"{car.name} - {car.color} - {car.speed} - {car.year}");
            }
        }

        public void chooseCar(string _name, string _color, int _speed, int _year)
        {
            List<Car> searchList = new List<Car>();

            Car searchCar = new Car() { name = _name, color = _color, speed = _speed, year = _year };
            for (int i = 0; i < garageList.Count; i++)
            {
                if (garageList[i].name == searchCar.name)
                {
                    searchList.Add(garageList[i]);
                }
                else if(searchCar.name != null)
                {
                    searchList.RemoveAll(car => car.name != searchCar.name);
                }
                if (garageList[i].color == searchCar.color)
                {
                    searchList.Add(garageList[i]);
                }
                else if(searchCar.color != null)
                {
                    searchList.RemoveAll(car => car.color != searchCar.color);
                }
                if (garageList[i].speed == searchCar.speed)
                {
                    searchList.Add(garageList[i]);
                }
                else if (searchCar.speed != 0)
                {
                    searchList.RemoveAll(car => car.speed != searchCar.speed);
                }
                if (garageList[i].year == searchCar.year)
                {
                    searchList.Add(garageList[i]);
                }
                else if (searchCar.year != 0)
                {
                    searchList.RemoveAll(car => car.year != searchCar.year);
                }
            }
            IEnumerable<Car> result = searchList.Distinct();

            foreach(Car car in result)
            {
                Console.WriteLine($"Your choise{car.name} - {car.color} - {car.speed} - {car.year}");
            }
        }
    }
}
