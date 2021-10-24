using System;

namespace gdc.task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            myCat a = new myCat("Andy", 3, 12);
            myCat b = new myCat("Tommy");
            a.changeName("Johnny");
            Console.WriteLine(a.getName());
        }
    }
}

class myCat
{
    private string name;
    public int legs;
    public int speed;

    public myCat(string Name, int Legs, int Speed)
    {
        name = Name;
        legs = Legs;
        speed = Speed;
        Console.WriteLine("Это мой полный конструктор!");
    }

    public myCat(string Name)
    {
        name = Name;
        legs = 4;
        Console.WriteLine("Это мой именной конструктор!");
    }
    public void changeName(string newName)
    {
        name = newName;
        Console.WriteLine("Кот переименован!");
    }
    public string getName()
    {
        return(name);
    }
}