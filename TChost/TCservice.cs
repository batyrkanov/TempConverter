using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TChost
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "TCservice" в коде и файле конфигурации.
    public class TCservice : ITCservice
    {
        public double CelsiumToKelvin(double celsium)
        {
            double calvin = celsium + 273.15;
            return calvin;
        }

        public double CelsiumToFahrenheit(double celsium)
        {
            double fahrenheit = (celsium * 1.8) + 32;
            return fahrenheit;
        }

        public double FahrenheitToCelsium(double fahrenheit)
        {
            double celsium = (fahrenheit - 32) / 1.8;
            return celsium;
        }

        public double FahrenheitToKelvin(double fahrenheit)
        {
            double kelvin = ((fahrenheit - 32) / 1.8) + 273.15;
            return kelvin;
        }

        public double KelvinToCelsium(double kelvin)
        {
            double celsium = kelvin - 273.15;
            return celsium;
        }

        public double KelvinToFahrenheit(double kelvin)
        {
            double fahrenheit = (1.8 * (kelvin - 273.15)) + 32;
            return fahrenheit;
        }
    }
}
