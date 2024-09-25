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
