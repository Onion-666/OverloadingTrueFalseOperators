using System;

class MyClass
{
    public int code;
    public MyClass(int n)
    {
        code = n;
    }
    public static bool operator true(MyClass obj)
    {
        if (obj.code >= 5)
            return true;
        else
            return false;
    }
    public static bool operator false(MyClass obj)
    {
        if (obj)
            return false;
        else
            return true;
    }
}
class Programm
{
    static void Main()
    {
        MyClass obj = new MyClass(10);
        while(obj)
        {
            Console.Write(obj.code + " ");
            obj.code--;
        }
        Console.WriteLine();
    }
}