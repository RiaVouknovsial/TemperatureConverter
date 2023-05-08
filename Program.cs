//Создайте пространство имен "TemperatureConversion", в котором определите статический класс "TemperatureConverter" 
//для конвертации температуры между шкалами Цельсия, Фаренгейта и Кельвина.
//В классе "TemperatureConverter" определите следующие статические методы:
//CelsiusToFahrenheit - метод, принимающий значение температуры в градусах Цельсия и
//                                                                   возвращающий его эквивалент в градусах Фаренгейта
//FahrenheitToCelsius" - метод, принимающий значение температуры в градусах Фаренгейта и
//                                                                      возвращающий его эквивалент в градусах Цельсия
//CelsiusToKelvin" - метод, принимающий значение температуры в градусах Цельсия и
//                                                                    возвращающий его эквивалент в Кельвинах
//"KelvinToCelsius" - метод, принимающий значение температуры в Кельвинах и
//                                                                       возвращающий его эквивалент в градусах Цельсия
//"FahrenheitToKelvin" - метод, принимающий значение температуры в градусах Фаренгейта и
//                                                                              возвращающий его эквивалент в Кельвинах
//"KelvinToFahrenheit" - метод, принимающий значение температуры в Кельвинах и
//                                                                    возвращающий его эквивалент в градусах Фаренгейта
using System;

TemperatureConversion.TemperatureConverter converter = new TemperatureConversion.TemperatureConverter();

Console.WriteLine($"Перевод {converter.CelsiusToFahrenheit = 25} градусов Цельсия в градусы Фаренгейта");
double fahrenheitTemperature = converter.CelsiusToFahrenheit;
Console.WriteLine(fahrenheitTemperature);
Console.WriteLine();

Console.WriteLine($"Перевод {converter.FahrenheitToCelsius = 92} градусов Фаренгейта в градусы Цельсия");
double celsiusTemperature = converter.FahrenheitToCelsius;
Console.WriteLine(celsiusTemperature);
Console.WriteLine();

Console.WriteLine($"Перевод {converter.CelsiusToKelvin = 35} градусов Цельсия в градусы Кельвина");
double kelvinTemperature = converter.CelsiusToKelvin;
Console.WriteLine(kelvinTemperature);
Console.WriteLine();

Console.WriteLine($"Перевод {converter.KelvinToCelsius = 270} градусов Кельвина в градусы Цельсия");
double celsiusTemperature2 = converter.KelvinToCelsius;
Console.WriteLine(celsiusTemperature2);
Console.WriteLine();

Console.WriteLine($"Перевод {converter.FahrenheitToKelvin = 45} градусов Фаренгейта в градусы Кельвина");
double kelvinTemperature2 = converter.FahrenheitToKelvin;
Console.WriteLine(kelvinTemperature2);
Console.WriteLine();

Console.WriteLine($"Перевод {converter.KelvinToFahrenheit = 230} градусов Кельвина в градусы Фаренгейта");
double fahrenheitTemperature2 = converter.KelvinToFahrenheit;
Console.WriteLine(fahrenheitTemperature2);
Console.WriteLine();

namespace TemperatureConversion
{
    class TemperatureConverter
    {

        private double celsius;

        private double kelvin;

        private double fahrenheit;
        public TemperatureConverter() { }
        public double CelsiusToFahrenheit
        {
            get
            {
                return (celsius * 9 / 5 + 32);
            }

            set
            {
                celsius = value;
            }

        }
        public double FahrenheitToCelsius
        {
            get
            {
                return ((fahrenheit - 32) * 5 / 9);
            }

            set
            {
                fahrenheit = value;
            }
        }
        public double CelsiusToKelvin
        {
            get
            {
                return (celsius + 273.15);
            }

            set
            {
                celsius = value;
            }
        }
        public double KelvinToCelsius
        {
            get
            {
                return (kelvin - 273.15);
            }

            set
            {
                kelvin = value;
            }
        }
        public double FahrenheitToKelvin
        {
            get
            {
                return (((fahrenheit - 32) * 5 / 9) + 273.15);
            }

            set
            {
                fahrenheit = value;
            }
        }
        public double KelvinToFahrenheit
        {
            get
            {
                return (((kelvin - 273.15) * 9 / 5) + 32);
            }

            set
            {
                kelvin = value;
            }

        }
    }
}

