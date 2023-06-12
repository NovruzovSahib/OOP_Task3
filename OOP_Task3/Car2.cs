using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task3
{
    internal record Car2
    {
        string carType;
        string model;
        double engine;
        string color;
        short productYear;
        bool isAutomatic;

        public string CarType { get; init; }
        public string Model { get; init; }
        public double Engine { get; init; }
        public string Color { get; init; }
        public short ProductYear { get; init; }
        public bool IsAutomatic { get; init; }



        public void CarInfo2(string CarType, string Model, string Engine, string Color, short ProductYear, bool IsAutomatic)
        {
            Console.WriteLine($"car type is {CarType}\ncar model is {Model}\ncar engine is {Engine}\ncar color is {Color}\ncar productyear is {ProductYear}\ncar isautomatic is {IsAutomatic}");
        }

    }
}
