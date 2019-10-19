using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    class Weather
    {
        DateTime date;
        int minTemperature;
        int maxTemperature;
        int clouds;
        Dictionary.Clouds cloudsTitle;
        Dictionary.Precipitation precipitation;
        int precipitationValue;
        int humidity;
        double windPower;
        double windDirection;
        Dictionary.Direction direction;

        public DateTime Date { get => date; set => date = value; }
        public int MinTemperature { get => minTemperature; set => minTemperature = (value < -273) ? throw new Exception("Incorrect temperature") : value; }
        public int MaxTemperature { get => maxTemperature; set => maxTemperature = (value < minTemperature || value > 80) ? throw new Exception("Incorrect temperature") : value; }
        public int Clouds { get => clouds; set => clouds = (value < 0 || value > 100) ? throw new Exception("Incorrect value") : value; }
        public int PrecipitationValue { get => precipitationValue; set => precipitationValue = (value >= 0) ? value : throw new Exception("Incorrect value"); }
        public int Humidity { get => humidity; set => humidity = (value < 0 || value > 100) ? throw new Exception("Incorrect value") : value; }
        public double WindPower { get => windPower; set => windPower = (value >= 0) ? value : throw new Exception("Incorrect value"); }
        public double WindDirection { get => windDirection; set => windDirection = (value < 0 || value > 360) ? throw new Exception("Incorrect value") : value; }
        internal Dictionary.Clouds CloudsTitle { get => cloudsTitle; set => cloudsTitle = value; }
        internal Dictionary.Precipitation Precipitation { get => precipitation; set => precipitation = value; }
        internal Dictionary.Direction Direction { get => direction; set => direction = value; }

        public Weather()
        {
        }

        public Weather(
            DateTime date, 
            int minTemperature, 
            int maxTemperature,
            int clouds,
            int precipitationValue,
            int humidity,
            double windPower,
            double windDirection,
            Dictionary.Precipitation precipitation)
        {
            Date = date;
            MinTemperature = minTemperature;
            MaxTemperature = maxTemperature;
            Clouds = clouds;
            PrecipitationValue = precipitationValue;
            Humidity = humidity;
            WindPower = windPower;
            WindDirection = windDirection;
            Precipitation = precipitation;

            if (clouds >= 0 && clouds < 20)
            {
                CloudsTitle = Dictionary.Clouds.Ясно;
            }
            else if(clouds >= 20 && clouds < 50)
            {
                CloudsTitle = Dictionary.Clouds.Малооблачно;
            }
            else if (clouds >= 50 && clouds < 70)
            {
                CloudsTitle = Dictionary.Clouds.Облачно;
            }
            else if (clouds >= 70)
            {
                CloudsTitle = Dictionary.Clouds.Тучи;
            }

            if ((windDirection >= 0 && windDirection < 22.5) || ( windDirection >= 337.5))
            {
                Direction = Dictionary.Direction.N;
            }
            else if (windDirection >= 22.5 && windDirection < 67.5)
            {
                Direction = Dictionary.Direction.NE;
            }
            else if (windDirection >= 67.5 && windDirection < 115.5)
            {
                Direction = Dictionary.Direction.E;
            }
            else if (windDirection >= 115.5 && windDirection < 157.5)
            {
                Direction = Dictionary.Direction.SE;
            }

            if (windPower == 0)
            {
                Direction = Dictionary.Direction.No_wind;
            }
        }

        public override string ToString()
        {
            return $"Date: {date}\nTemperature: {minTemperature} - {maxTemperature}\nClouds: {cloudsTitle}\nPrecipitation: {precipitation}\nWind: {direction} {windPower} kn.";
        }
    }
}
