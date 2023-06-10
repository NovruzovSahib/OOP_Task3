using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Task3
{
    internal class Car1
    {
        string carType;
        string model;
        double engine;
        string color;
        short productYear;
        bool isAutomatic;

        public string CarType { get { return carType; } set { carType = value;  } }
        public string Model { get { return model; } set { model = value; } }
        public double Engine { get { return engine; } set { engine = value; } }
        public string Color { get { return color; } set { color = value; } }
        public short ProductYear { get { return productYear; } set { productYear = value; } }
        public bool IsAutomatic { get { return isAutomatic; } set { isAutomatic = value; } }


        public Car1(string _carType, string _model, double _engine, string _color, short _productYear, bool isAutomatic)
        {
            CarType = _carType;
            Model = _model;
            Engine = _engine;
            Color = _color;
            ProductYear = _productYear;
            IsAutomatic = isAutomatic;
        }

        public void CarInfo()
        {
            Console.WriteLine($"car cartype is {CarType = "Hachbak"}\ncar model is {Model = "Toyota"}\ncar engine is {Engine = 1.6}\ncar color is {Color ="Gray"}\ncar productyear is {ProductYear=2008}\ncar isautomatic is {IsAutomatic = true}");
        }

    }
}
