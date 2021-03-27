using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_basic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductList productList = new ProductList();

            Console.WriteLine("code to insert");
            int insert = int.Parse(Console.ReadLine());

            Console.WriteLine("after i code");
            int after = int.Parse(Console.ReadLine());

            Product bicycle = new Product();
            bicycle.Name = "Bicycle";
            bicycle.price = 350;
            bicycle.Code = 101;
            bicycle.color = "blue";
            productList.Add(bicycle,insert,after);

            Product car = new Product();
            car.Name = "Car";
            car.price = 1250;
            car.Code = 102;
            car.color = "red";
            productList.Add(car, insert, after);

            Product motorcycle = new Product();
            motorcycle.Name = "Motorcycle";
            motorcycle.price = 780;
            motorcycle.Code = 103;
            motorcycle.color = "black";
            productList.Add(motorcycle, insert, after);


            Product skateboard = new Product();
            skateboard.Name = "Skateboard";
            skateboard.price = 238;
            skateboard.Code = 104;
            skateboard.color = "white";
            productList.Add(skateboard, insert, after);


            Product skates = new Product();
            skates.Name = "Skates";
            skates.price = 180;
            skates.Code = 105;
            skates.color = "green";
            productList.Add(skates, insert, after);


            Product pickupTruck = new Product();
            pickupTruck.Name = "pickupTruck";
            pickupTruck.price = 56700;
            pickupTruck.Code = 106;
            pickupTruck.color = "gray";
            productList.Add(pickupTruck, insert, after);

            productList.Print();

        }
        
    }
}
