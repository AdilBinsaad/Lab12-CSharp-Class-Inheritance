DerivedClass dc = new DerivedClass();
class BaseClass1
{
    public BaseClass1()
    {
        System.Console.WriteLine("This is BaseClass1");
    }
}

class BaseClass2
{
    public BaseClass2()
    {
        System.Console.WriteLine("This is BaseClass2");
    }
}

class DerivedClass
{
    private BaseClass1 base1;
    private BaseClass2 base2;

    public DerivedClass()
    {
        base1 = new BaseClass1();
        base2 = new BaseClass2();
        System.Console.WriteLine("This is DerivedClass");
    }
}