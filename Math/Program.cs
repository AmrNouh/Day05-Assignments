// calling using object name
Math1 math = new Math1();
Console.WriteLine(math.Add(1,2));
Console.WriteLine(math.Multiply(5,5));

// calling using class name
Console.WriteLine(Math.Add(1,2));
Console.WriteLine(Math.Multiply(6,6));



class Math1
{
    public int Add(int x, int y)
    {
        return x + y;
    }
    public int Subtract(int x, int y)
    {
        return x - y;
    }
    public int Multiply(int x, int y)
    {
        return x * y;
    }

    public int Divide(int x, int y)
    {
        return x / y;
    }

}

class Math
{
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static int Divide(int x, int y)
    {
        return x / y;
    }

}