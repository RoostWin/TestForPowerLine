using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForPowerLine
{
    /// <summary>
    /// Пассажирский автомобиль
    /// </summary>
    internal class PassengerCar:Car
    {
        /// <summary>
        /// Кол-во пассажиров
        /// </summary>
        private byte passengers;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="AFC">Average Fuel Consumption - средний расход топлива</param>
        /// <param name="FTC">Fuel Tank Capacity - текущий объем топливного бака</param>
        /// <param name="speed">Текущая скорость автомобиля</param>
        /// <param name="passengers">Количество пассажиров, чел</param>
        /// <exception cref="Exception"></exception>
        public PassengerCar(double AFC, double FTC, double speed, byte passengers) : base(TypeCar.PassengerCar, AFC, FTC, speed)
        {
            if (passengers > 100 / 6)
            {
                throw new Exception("Превышена допустимая нагрузка");
            }
            this.passengers = passengers;
        }

        public override double GetPathDistanceWithLoad()
        {
            double FuncResult = GetDistanceWithoutLoad();

            //считаем влияние пассажиров на запас хода
            FuncResult -= FuncResult / 100 * passengers * 6;

            return FuncResult;
        }
    }
}
