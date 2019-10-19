using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Dictionary
    {
        public enum Clouds
        {
            Ясно,
            Малооблачно,
            Облачно,
            Тучи
        }

        public enum Precipitation
        {
            Нет_осадков,
            Дождь,
            Снег,
            Туман
        }

        public enum Direction
        {
            N,
            NE,
            E,
            SE,
            S,
            SW,
            W,
            NW,
            No_wind
        }
    }
}
