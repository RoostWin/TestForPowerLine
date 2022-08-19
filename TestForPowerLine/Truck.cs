using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForPowerLine
{
    internal class Truck:Car
    {
        /// <summary>
        /// Вес груза
        /// </summary>
        private double Payload;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="AFC">Average Fuel Consumption - средний расход топлива</param>
        /// <param name="FTC">Fuel Tank Capacity - текущий объем топливного бака</param>
        /// <param name="speed">Текущая скорость автомобиля</param>
        /// <param name="Payload">Вес груза, кг</param>
        /// <exception cref="Exception"></exception>
        public Truck(double AFC, double FTC, double speed, double Payload) : base(TypeCar.Truck, AFC, FTC, speed)
        {
            //если вес груза больше 100% / 4% * 200 кг
            if (Payload > 100 / 4 * 200)
            {
                throw new Exception("Превышена допустимая нагрузка");
            }
            this.Payload = Payload;
        }    

        override public double GetPathDistanceWithLoad()
        {
            double FuncResult = GetDistanceWithoutLoad();

            //считаем влияние груза на запас хода
            FuncResult -= FuncResult / 100 * Payload / 100 * 2;

            return FuncResult;
        }
    }
}
