﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseLib;

namespace Homework_Warehouse_
{
    class Program
    {
        static void Main(string[] args)
        {
            String nameProduct, continueProg;
            int menuNumber, priceProduct, baseProduct;

            continueProg = "yes";
            while (continueProg == "yes")
            {
                Console.WriteLine("=========Warehouse=========");
                Console.WriteLine("Menu");
                Console.WriteLine("1 Add Product\n2 Wiev All Product\n3 Exit\n");
                Console.Write("Select number: ");
                menuNumber = CheckInt();

                switch (menuNumber)
                {
                    case 1:
                        Console.WriteLine("Please fill the data of your product");
                        Console.Write("Enter the Name: ");
                        nameProduct = Console.ReadLine();

                        Console.Write("Enter the Price: ");
                        priceProduct = CheckInt();

                        Console.Write("Enter the Base(shelf life): ");
                        baseProduct = CheckInt();

                        string guid = System.Guid.NewGuid().ToString();


                        prodData DataAboutProduct = new prodData(newID: guid, nameProd: nameProduct, priceProd: priceProduct, baseProd: baseProduct);

                        productCollection.Add(DataAboutProduct);
                        Console.WriteLine("==============================");
                        Console.WriteLine("Product has been enterd!");
                        Console.WriteLine("Do you want continue?");
                        Console.Write("Write answer(yes/no): ");
                        continueProg = Console.ReadLine();
                        Console.Clear();
                        break;


                    case 2:
                        break;


                    case 3:
                        break;
                }

            }
            Console.WriteLine("THE END");
            Console.ReadKey();
        }

        static int CheckInt()
        {
            int checkResultInt;

            while (!int.TryParse(Console.ReadLine(), out checkResultInt))
            {
                Console.Write("Error, please write number: ");
            }

            return checkResultInt;
        }
    }
}
