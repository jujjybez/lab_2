# Лабораторная работа 1
# Цели работы
1. Научиться синтаксису и основным принципам наследования в C#.

# Задание 1
Создайте класс, представляющий учебный класс ClassRoom. Создайте класс ученик - Pupil. В теле класса создайте методы void Study(), void Read(), void Write(), void Relax(). Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика (реализация может быть произвольной, например простой вывод на консоль разных строк). Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать.
Примечание: при реализации возможности создания экземпляра класса ClassRoom с произвольным количеством учеников воспользуйтесь ключевым словом params.

Код задания 1:
```
using System;

public class ClassRoom
{
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)//неограниченное количество элементов
    {
        this.pupils = pupils;
    }

    public void PrintPupilInfo()
    {
        Console.WriteLine("Pupil info:");
        for (int i = 0; i < pupils.Length; i++)
        {
            Console.WriteLine($"Pupil {i + 1}:");//интерполяция
            pupils[i].Study();
            pupils[i].Read();
            pupils[i].Write();
            pupils[i].Relax();
            Console.WriteLine();
        }
    }
}
public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil is studying.");
    }

    public virtual void Read()
    {
        Console.WriteLine("Pupil is reading.");
    }

    public virtual void Write()
    {
        Console.WriteLine("Pupil is writing.");
    }

    public virtual void Relax()
    {
        Console.WriteLine("Pupil is relaxing.");
    }
}
class ExcellentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Pupil is studying well.");
    }

    public override void Read()
    {
        Console.WriteLine("Pupil is reading a lot.");
    }

    public override void Write()
    {
        Console.WriteLine("Pupil is writing perfectly.");
    }

    public override void Relax()
    {
        Console.WriteLine("Pupil is resting a little.");
    }
}

class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Pupil is studying good.");
    }

    public override void Read()
    {
        Console.WriteLine("Pupil is reading a few books.");
    }

    public override void Write()
    {
        Console.WriteLine("Pupil is writing nicely.");
    }

    public override void Relax()
    {
        Console.WriteLine("Pupil is relaxing sometimes.");
    }
}

class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Pupil is not studying enough.");
    }

    public override void Read()
    {
        Console.WriteLine("Pupil is not reading.");
    }

    public override void Write()
    {
        Console.WriteLine("Pupil doesn't write.");
    }

    public override void Relax()
    {
        Console.WriteLine("Pupil is relaxing all the time.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Pupil p1 = new ExcellentPupil();
        Pupil p2 = new GoodPupil();
        Pupil p3 = new BadPupil();
        Pupil p4 = new Pupil();

        ClassRoom classRoom = new ClassRoom(p1, p2, p3, p4);
        classRoom.PrintPupilInfo();
    }
}
```

Вывод консоли:
![image](https://github.com/user-attachments/assets/bcdebbe2-004a-4f3b-9f62-fa8986447223)


# Задание 2
Создайте класс vehicle. В теле класса создайте поля: координаты и параметры средств передвижения (цена, скорость, год выпуска). Создайте 3 производных класса Plane, Саг и Ship. Для класса Plane должна быть определена высота и количество пассажиров. Для класса Ship — количество пассажиров и порт приписки. Написать программу, которая выводит на экран информацию о каждом средстве передвижения. Примечание: избегайте дублирования кода, используйте ключевое слово base после объявления конструкторов в классах наследниках для вызова и передачи параметров в конструктор базового класса.

Код задания 2:
```
using System;

class Vehicle
{
    private double x;
    private double y;
    private double price;
    private double speed;
    private int year;

    public Vehicle(double x, double y, double price, double speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Vehicle information:");
        Console.WriteLine($"Coordinates: ({x}, {y})");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine($"Speed: {speed}");
        Console.WriteLine($"Year: {year}");
    }
}

class Plane : Vehicle
{
    private double height;
    private int passengers;

    public Plane(double x, double y, double price, double speed, int year, double height, int passengers)
        : base(x, y, price, speed, year)
    {
        this.height = height;
        this.passengers = passengers;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Passengers: {passengers}");
    }
}

class Car : Vehicle
{
    public Car(double x, double y, double price, double speed, int year)
        : base(x, y, price, speed, year)
    {
    }

    public void ShowInfo()
    {
        base.ShowInfo();
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double x, double y, double price, double speed, int year, int passengers, string port)
        : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Passengers: {passengers}");
        Console.WriteLine($"Port: {port}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Plane plane = new Plane(100, 200, 100000, 500, 2010, 10000, 200);
        plane.ShowInfo();

        Console.WriteLine();

        Car car = new Car(50, 100, 50000, 200, 2015);
        car.ShowInfo();

        Console.WriteLine();

        Ship ship = new Ship(300, 400, 2000000, 100, 2020, 1000, "New York");
        ship.ShowInfo();
    }
}
```

Вывод консоли:
![image](https://github.com/user-attachments/assets/7443f82e-5bd5-4eeb-aff9-cff6546285fe)


# Задание 3
Создайте класс DocumentWorker. В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument(). В тело каждого из методов добавьте вывод на экран соответствующих строк: &quot;Документ открыт&quot;, &quot;Редактирование документа доступно в версии Pro&quot;, &quot;Сохранение документа доступно в версии Pro&quot;. Создайте производный класс ProDocumentWorker. Переопределите соответствующие методы, при переопределении методов выводите следующие строки: &quot;Документ отредактирован&quot;, &quot;Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Expert&quot;. Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран &quot;Документ сохранен в новом формате&quot;. В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp. Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса), если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.

Код задания 3:
```
using System;

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document is open.");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Editing the document is available in the Pro version.");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Saving the document is available in the Pro version.");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Document is edited.");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Document is saved in the old format, saving in other formats is available in the Expert version.");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Document is saved in the new format.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter user access key: ");
        string userAccessKey = Console.ReadLine();

        DocumentWorker documentWorker;

        switch (userAccessKey)
        {
            case "pro":
                documentWorker = new ProDocumentWorker();
                break;
            case "exp":
                documentWorker = new ExpertDocumentWorker();
                break;
            default:
                documentWorker = new DocumentWorker();
                break;
        }

        documentWorker.OpenDocument();
        documentWorker.EditDocument();
        documentWorker.SaveDocument();
    }
}
```

Вывод консоли:
![image](https://github.com/user-attachments/assets/ab54da4b-9608-497f-a4c5-7331a93cefdf)

# Вывод
В ходе выполнения лабораторной работы получилось научиться синтаксису и основным принципам наследования в C#.
