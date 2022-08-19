using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForPowerLine
{
    public abstract class Car
    {
        /// <summary>
        /// Тип автомобиля
        /// </summary>
        public TypeCar typeCar;
        /// <summary>
        /// Average Fuel Consumption - средний расход топлива
        /// </summary>
        public double AFC;
        /// <summary>
        /// Fuel Tank Capacity - текущий объем топливного бака
        /// </summary>
        public double FTC;
        /// <summary>
        /// Текущая скорость автомобиля
        /// </summary>
        public double speed;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="typeCar">Тип автомобиля</param>
        /// <param name="AFC">Average Fuel Consumption - средний расход топлива</param>
        /// <param name="FTC">Fuel Tank Capacity - текущий объем топливного бака</param>
        /// <param name="speed">Текущая скорость автомобиля</param>
        public Car(TypeCar typeCar, double AFC, double FTC, double speed)
        {
            this.typeCar = typeCar;
            this.AFC = AFC;
            this.FTC = FTC;
            this.speed = speed;
        }

        /// <summary>
        /// Вычисляет запас хода на полном/остаточном объёме бака без учёта загрузки
        /// </summary>
        /// <param name="FTC">Полный/остаточный объём топливного бака</param>
        /// <returns></returns>
        public double GetDistanceWithoutLoad(double FTC = 0)
        {
            //проверяем если FTC меньше нуля
            if (FTC <= 0) 
            {
                FTC = this.FTC;
            }

            double FuncResult = Math.Round(AFC / FTC * 100);
            return FuncResult;
        }

        /// <summary>
        /// Вычисляет за сколько автомобиль преодолеет расстояние, ч
        /// </summary>
        /// <param name="distance">Расстояние</param>
        /// <param name="FTC">Количество топлива</param>
        /// <returns></returns>
        public TimeSpan GetTravelTime(double distance, double FTC = 0)
        {
            //проверяем если FTC меньше нуля
            if (FTC <= 0)
            {
                FTC = this.FTC;
            }

            DateTime lastRunDate = DateTime.Now;
            DateTime currentDate = lastRunDate.AddHours(distance / speed);

            TimeSpan funcResult = (currentDate - lastRunDate).Duration();

            return funcResult;
        }

        /// <summary>
        /// Вычисляет запас хода в зависимости от нагрузки (пассажиров/груза)
        /// </summary>
        /// <returns></returns>
        abstract public double GetPathDistanceWithLoad();

    }
}
