using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather(DateTime.Today, 16, 25, 25, 0, 87, 5.2, 96, Dictionary.Precipitation.Нет_осадков);
            

            Console.WriteLine(weather);

        }
    }
}
