using System;

namespace MyApp.Models
{
    /// <summary>
    /// Базовый класс автомобиля
    /// Поля make и model private - доступны только внутри класса
    /// Свойство Year public - доступно из любого места
    /// </summary>
    public class Car
    {
        private string make; // private - только для внутреннего использования в классе
        private string model; // private - только для внутреннего использования в классе
        public int Year { get; set; } // public - доступно из любого места

        /// <summary>
        /// Internal метод - доступен только в пределах текущей сборки
        /// </summary>
        internal void SetMakeAndModel(string make, string model)
        {
            this.make = make;
            this.model = model;
        }

        /// <summary>
        /// Protected метод - доступен только внутри класса и производных классов
        /// </summary>
        protected virtual void DisplayInfo()
        {
            Console.WriteLine($"Car Info: {make} {model}, Year: {Year}");
        }
    }

    /// <summary>
    /// Класс электромобиля, наследуется от Car
    /// </summary>
    public class ElectricCar : Car
    {
        private double batteryCapacity; // private - только для внутреннего использования

        /// <summary>
        /// Public метод - доступен из любого места
        /// </summary>
        public void SetBatteryCapacity(double capacity)
        {
            batteryCapacity = capacity;
        }

        /// <summary>
        /// Переопределенный protected метод - доступен только внутри класса и производных классов
        /// </summary>
        protected override void DisplayInfo()
        {
            base.DisplayInfo(); // Вызываем базовую версию метода
            Console.WriteLine($"Battery Capacity: {batteryCapacity} kWh");
        }

        /// <summary>
        /// Public метод для вывода информации (так как DisplayInfo protected)
        /// </summary>
        public void ShowInfo()
        {
            DisplayInfo();
        }
    }
}

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр обычного автомобиля
            var car = new MyApp.Models.Car();

            // Попытка установить make и model напрямую - не скомпилируется, так как поля private
            // car.make = "Toyota"; // Ошибка компиляции
            // car.model = "Camry"; // Ошибка компиляции

            // Устанавливаем значения через internal метод (доступно, так как в одной сборке)
            car.SetMakeAndModel("Toyota", "Camry");
            car.Year = 2020; // Public свойство - доступно

            // car.DisplayInfo(); // Нельзя вызвать напрямую, так как метод protected

            // Создаем экземпляр электромобиля
            var electricCar = new MyApp.Models.ElectricCar();
            electricCar.SetMakeAndModel("Tesla", "Model S");
            electricCar.Year = 2022;
            electricCar.SetBatteryCapacity(100.0); // Public метод

            // Выводим информацию
            Console.WriteLine("Car Information:");
            // Для Car нет public метода для вывода информации, поэтому нужно либо:
            // 1. Создать public метод-обертку, как в ElectricCar
            // 2. Изменить модификатор доступа DisplayInfo
            // В данном примере мы не можем вывести информацию для Car

            Console.WriteLine("\nElectric Car Information:");
            electricCar.ShowInfo(); // Вызываем public метод, который использует protected DisplayInfo

            Console.ReadKey();
        }
    }
}