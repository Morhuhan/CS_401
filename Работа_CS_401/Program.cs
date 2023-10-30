using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using carlib;

namespace Работа_CS_401
{

    internal class Program
    {

        static void Main(string[] args)
        {
            SportCar Viper = new SportCar("Viper", 240, 20);
            Viper.TurboBoost();
            MiniVan mv = new MiniVan();
            mv.TurboBoost();

            VWmininVan vmv = new VWmininVan();
            vmv.TurboBoost();
            vmv.IsVersion();

        }
    }
}
