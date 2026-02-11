using System;

namespace PublishingHouse
{
    class PrintEdition
    {
        // Закриті поля
        private string name;
        private string type; // "газета" або "журнал"
        private double price;
        private int pages;

        // Конструктор без параметрів
        public PrintEdition()
        {
            Name = "Невідоме видання";
            Type = "газета";
            Price = 0.0;
            Pages = 0;
        }

        // Властивості (get/set)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public int Pages
        {
            get { return pages; }
            set { pages = value; }
        }

        // Метод 1: вивід назви і типу
        public void ShowInfo()
        {
            Console.WriteLine($"Назва: {Name}, Тип: {Type}");
        }

        // Метод 2: аналіз ціни і типу
        public void Analyze()
        {
            if (Price > 10 && Type.ToLower() == "газета")
            {
                Console.WriteLine($"Це занадто дорога газета ({Price} грн.)");
            }
            else if (Price < 10 && Type.ToLower() == "журнал")
            {
                Console.WriteLine($"Це дешевий журнал ({Price} грн.)");
            }
            else
            {
                Console.WriteLine($"Це видання: {Type}. Його ціна: {Price} грн.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкта
            PrintEdition edition1 = new PrintEdition();
            edition1.Name = "Дніпровські новини";
            edition1.Type = "газета";
            edition1.Price = 12.5;
            edition1.Pages = 24;

            edition1.ShowInfo();
            edition1.Analyze();

            Console.WriteLine();

            PrintEdition edition2 = new PrintEdition();
            edition2.Name = "Наука і життя";
            edition2.Type = "журнал";
            edition2.Price = 8.0;
            edition2.Pages = 56;

            edition2.ShowInfo();
            edition2.Analyze();
        }
    }
}

