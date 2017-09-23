using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TChost
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "ITCservice" в коде и файле конфигурации.
    [ServiceContract]
    public interface ITCservice
    {
        [OperationContract]
        double CelsiumToFahrenheit(double celsium);
        [OperationContract]
        double CelsiumToKelvin(double celsium);
        [OperationContract]
        double FahrenheitToCelsium(double fahrenheit);
        [OperationContract]
        double FahrenheitToKelvin(double fahrenheit);
        [OperationContract]
        double KelvinToCelsium(double kelvin);
        [OperationContract]
        double KelvinToFahrenheit(double kelvin);
    }
}
