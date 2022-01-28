// calling using object name

// calling using class name
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
