using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
   interface iAccessorie
    {
        void Mirror();
    }
    class Furniture
    {
        public int height;
        public int width; 

        public void printDetails(String furnitureType)
        {
            Console.WriteLine($"Printing Details for {furnitureType}");
            Console.WriteLine($"Height: {height} Width {width}");
        }
    }

    class Chair: Furniture
    {
        public void getDetails()
        {
            height = 20; width = 40;
            printDetails("Chair");
        }
    }

    class Almirah: Furniture,iAccessorie
    {
        public void Mirror()
        {
            Console.WriteLine("See yourself here...");
        }
        public void getDetails()
        {
            height = 30; width = 50;
            printDetails("Almirah");
        }
    }

    class Table: Furniture
    {
        public void getDetails()
        {
            height = 20; width = 30;
            printDetails("Table");
        }
    }
    internal class Program1
    {
        static void Main()
        {
            Chair neelkamal = new Chair();
            neelkamal.getDetails();

            Almirah almirah = new Almirah();
            almirah.getDetails();
            almirah.Mirror();

            Table table = new Table();
            table.getDetails(); 
        }
    }
}
