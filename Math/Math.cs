// calling using object name

// calling using class name
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
        if (y != 0)
        {
            return x / y;
        }
        else
        {
            Console.WriteLine("Please Enter A Positive Number Greater Than Zero");
            return -1;
        }
    }

}