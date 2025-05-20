using System;

namespace Module6_Homework
{
    // ===== Задание 1 =====
    /*
    // Базовый класс Money
    public class Money
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public void SetAmount(int dollars, int cents)
        {
            Dollars = dollars;
            Cents = cents;
            Normalize();
        }

        public void DisplayAmount()
        {
            Console.WriteLine($"Сумма: {Dollars}.{Cents:D2}");
        }

        private void Normalize()
        {
            if (Cents >= 100)
            {
                Dollars += Cents / 100;
                Cents %= 100;
            }
        }
    }

    // Производный класс Product
    public class Product : Money
    {
        public string Name { get; set; }

        public void ReducePrice(int dollars, int cents)
        {
            int totalCents = Dollars * 100 + Cents;
            int reduceCents = dollars * 100 + cents;
            totalCents -= reduceCents;

            if (totalCents < 0) totalCents = 0;

            Dollars = totalCents / 100;
            Cents = totalCents % 100;
        }

        public void PrintProductInfo()
        {
            Console.WriteLine($"Продукт: {Name}");
            DisplayAmount();
        }
    }
    */

    // ===== Задание 2 =====
    /*
    // Базовый класс Device
    public class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук устройства");
        }

        public void Show()
        {
            Console.WriteLine($"Устройство: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Описание: {Description}");
        }
    }

    // Производные классы
    public class Kettle : Device
    {
        public Kettle(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Чайник свистит: Шшшш!");
        }
    }

    public class Microwave : Device
    {
        public Microwave(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Микроволновка гудит: Вжжж!");
        }
    }

    public class Car : Device
    {
        public Car(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Автомобиль сигналит: Бип-бип!");
        }
    }

    public class Steamship : Device
    {
        public Steamship(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Пароход гудит: Ууууу!");
        }
    }
    */

    // ===== Задание 3 =====
    /*
    // Базовый класс MusicalInstrument
    public class MusicalInstrument
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public MusicalInstrument(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Звук музыкального инструмента");
        }

        public void Show()
        {
            Console.WriteLine($"Инструмент: {Name}");
        }

        public void Desc()
        {
            Console.WriteLine($"Описание: {Description}");
        }

        public virtual void History()
        {
            Console.WriteLine("История создания неизвестна");
        }
    }

    // Производные классы
    public class Violin : MusicalInstrument
    {
        public Violin(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Скрипка играет: Ля-ля-ля!");
        }

        public override void History()
        {
            Console.WriteLine("Скрипка появилась в XVI веке в Италии.");
        }
    }

    public class Trombone : MusicalInstrument
    {
        public Trombone(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Тромбон звучит: Ту-ту-ту!");
        }

        public override void History()
        {
            Console.WriteLine("Тромбон известен с XV века.");
        }
    }

    public class Ukulele : MusicalInstrument
    {
        public Ukulele(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Укулеле играет: Пинь-пинь!");
        }

        public override void History()
        {
            Console.WriteLine("Укулеле появилось на Гавайях в XIX веке.");
        }
    }

    public class Cello : MusicalInstrument
    {
        public Cello(string name, string description) : base(name, description) { }

        public override void Sound()
        {
            Console.WriteLine("Виолончель звучит: Доооо!");
        }

        public override void History()
        {
            Console.WriteLine("Виолончель развилась в XVI веке.");
        }
    }
    */

    // ===== Задание 4 =====
    // Абстрактный базовый класс Worker
    public abstract class Worker
    {
        public abstract void Print();
    }

    // Производные классы
    public class President : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Президент: Управляет компанией.");
        }
    }

    public class Security : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Охранник: Обеспечивает безопасность.");
        }
    }

    public class Manager : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Менеджер: Координирует работу команды.");
        }
    }

    public class Engineer : Worker
    {
        public override void Print()
        {
            Console.WriteLine("Инженер: Разрабатывает технические решения.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 4
            Worker[] workers = new Worker[]
            {
                new President(),
                new Security(),
                new Manager(),
                new Engineer()
            };

            foreach (var worker in workers)
            {
                worker.Print();
            }

            /*
            // 1
         
            Product apple = new Product { Name = "Яблоко" };
            apple.SetAmount(5, 99);
            apple.PrintProductInfo();
            apple.ReducePrice(2, 50);
            Console.WriteLine("После уменьшения цены:");
            apple.PrintProductInfo();

            //2
            Device[] devices = new Device[]
            {
                new Kettle("Чайник Bosch", "Электрический чайник с подогревом"),
                new Microwave("Микроволновка Samsung", "С грилем и конвекцией"),
                new Car("Toyota Camry", "Седан с бензиновым двигателем"),
                new Steamship("Титаник", "Легендарный пароход")
            };

            foreach (var device in devices)
            {
                device.Show();
                device.Sound();
                device.Desc();
                Console.WriteLine();
            }

            //3
            MusicalInstrument[] instruments = new MusicalInstrument[]
            {
                new Violin("Скрипка Stradivarius", "Деревянный смычковый инструмент"),
                new Trombone("Тромбон Bach", "Медный духовой инструмент"),
                new Ukulele("Укулеле Kala", "Гавайская четырёхструнная гитара"),
                new Cello("Виолончель Yamaha", "Смычковый инструмент басового регистра")
            };

            foreach (var instrument in instruments)
            {
                instrument.Show();
                instrument.Sound();
                instrument.Desc();
                instrument.History();
                Console.WriteLine();
            }
            */
        }
    }
}