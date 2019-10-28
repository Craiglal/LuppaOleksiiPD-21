using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();
            int count;
            bool a;

            List<Car> carList = new List<Car>()
            { 
                new Car(){name = "BMW M2", color = "Red", speed=250, year=2019},
                new Car(){name = "BMW M5", color = "Black", speed=300, year=2019},
                new Car(){name = "BMW X6", color = "Black", speed=320, year=2019},
                new Car(){name = "Audi A4", color = "Red", speed=220, year=2016},
                new Car(){name = "Audi A7", color = "Silver", speed=250, year=2018},
                new Car(){name = "Audi Q7", color = "Black", speed=290, year=2018},
                new Car(){name = "Audi S4", color = "Red", speed=200, year=2013},
                new Car(){name = "Nissan GT-R R35", color = "White", speed=320, year=2017}
            };
            

            do
            {
                Console.WriteLine("1) Show all the cars in the garage");
                Console.WriteLine("2) Add car to the garage");
                Console.WriteLine("3) Delete car from the garage");
                Console.WriteLine("4) Choose your car from the garage");
                Console.WriteLine("0) Exit");
                do
                {
                    Console.Write("Enter your choise: ");
                    a = int.TryParse(Console.ReadLine(), out count);
                    if (!a || count >= 5)
                        Console.WriteLine("Wrong number!");
                } while (!a || count >= 5);
                switch (count)
                {
                    case 1:
                        if(garage.garageList == null)
                            Console.WriteLine("Garage is empty");
                        else
                            garage.showAllCars();

                        break;
                    case 2:
                        for(int i = 0; i < carList.Count; i++)
                        {
                            Console.WriteLine($"{carList[i].name} - {carList[i].color} - {carList[i].speed} - {carList[i].year}; Index = {i + 1}" );
                        }
                        do
                        {
                            Console.Write("Enter the index to buy the car: ");
                            a = int.TryParse(Console.ReadLine(), out count);
                            if (!a || count > carList.Count)
                                Console.WriteLine("Wrong index!");
                        } while (!a || count > carList.Count);
                        garage.addCar(count, carList);

                        break;
                    case 3:
                        if(garage.garageList == null)
                        {
                            Console.WriteLine("Garage is empty");
                        }
                        else
                        {
                            for (int i = 0; i < garage.garageList.Count; i++)
                            {
                                Console.WriteLine($"{garage.garageList[i].name} - {garage.garageList[i].color} - {garage.garageList[i].speed} - {garage.garageList[i].year}; Index = {i + 1}");
                            }
                            do
                            {
                                Console.Write("Enter the index to remove the car: ");
                                a = int.TryParse(Console.ReadLine(), out count);
                                if (!a || count > garage.garageList.Count)
                                    Console.WriteLine("Wrong index!");
                            } while (!a || count > garage.garageList.Count);
                            garage.removeCar(count);
                        }

                        break;
                    case 4:
                        string carName = null, carColor = null;
                        int carSpeed = 0, carYear = 0;
                        if (garage.garageList == null)
                        {
                            Console.WriteLine("Garage is empty");
                        }
                        else
                        {
                            for (int i = 0; i < garage.garageList.Count; i++)
                            {
                                Console.WriteLine($"{garage.garageList[i].name} - {garage.garageList[i].color} - {garage.garageList[i].speed} - {garage.garageList[i].year}; Index = {i + 1}");
                            }
                            do
                            {
                                Console.WriteLine($"1) Car name {(carName == null ? "#" : carName)}");
                                Console.WriteLine($"2) Car color {(carColor == null ? "#" : carColor)}");
                                Console.WriteLine($"3) Car speed {(carSpeed == 0 ? 0 : carSpeed)}");
                                Console.WriteLine($"4) Car year {(carYear == 0 ? 0 : carYear)}");
                                Console.WriteLine("0) Exit");
                                Console.WriteLine("0 or # - any value");
                                do
                                {
                                    Console.Write("Enter your choise: ");
                                    a = int.TryParse(Console.ReadLine(), out count);
                                    if (!a || count >= 5)
                                        Console.WriteLine("Wrong number!");
                                } while (!a || count >= 5);
                                Console.WriteLine();
                                switch (count)
                                {
                                    case 1:
                                        for (int i = 0; i < garage.garageList.Count; i++)
                                        {
                                            Console.WriteLine($"Year - {garage.garageList[i].name}");
                                        }
                                        carName = Console.ReadLine();

                                        break;
                                    case 2:
                                        for (int i = 0; i < garage.garageList.Count; i++)
                                        {
                                            Console.WriteLine($"Year - {garage.garageList[i].color}");
                                        }
                                        carColor = Console.ReadLine();

                                        break;
                                    case 3:
                                        for (int i = 0; i < garage.garageList.Count; i++)
                                        {
                                            Console.WriteLine($"Year - {garage.garageList[i].speed}");
                                        }
                                        do
                                        {
                                            Console.Write("Enter your choise: ");
                                            a = int.TryParse(Console.ReadLine(), out carSpeed);
                                            if (!a)
                                                Console.WriteLine("Wrong number!");
                                        } while (!a);

                                        break;
                                    case 4:
                                        for (int i = 0; i < garage.garageList.Count; i++)
                                        {
                                            Console.WriteLine($"Year - {garage.garageList[i].year}");
                                        }
                                        do
                                        {
                                            Console.Write("Enter your choise: ");
                                            a = int.TryParse(Console.ReadLine(), out carYear);
                                            if (!a)
                                                Console.WriteLine("Wrong number!");
                                        } while (!a);
                                        break;
                                    default:
                                        break;
                                }
                                Console.WriteLine();
                                garage.chooseCar(carName, carColor, carSpeed, carYear);
                                Console.WriteLine();
                            } while (count != 0);
                        }
                        
                        break;
                    default:
                        break;
                }

            } while (count != 0);
        }
    }
}
