class Point3D : IComparable,ICloneable
{
    public int x { get; set; }
    public int y { get; set; }
    public int z { get; set; }

    public Point3D()
    {
        x = y = z = 0;
    }
    public Point3D(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public Point3D(int value) : this(value, value, value) { } // Constructor Chaining

    public override string ToString()
    {
        return $"Point Coordinates: ({x}, {y}, {z})";
    }
    public override bool Equals(object? obj)
    {
        if (obj is Point3D)
        {
            Point3D p = (Point3D)obj;
            return (x == p.x && y == p.y && z == p.z);
        }
        else
        {
            return false;
        }
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    // Implementation of CompareTo() Method From IComparable Interface
    public int CompareTo(object? obj)
    {
        if (obj is Point3D)
        {
            Point3D point = (Point3D)obj;
            if (x.CompareTo(point.x) == 0)
            {
                return y.CompareTo(point.y);
            }
            else
            {
                return x.CompareTo(point.x);
            }
        }
        else
        {
            throw new ArgumentException("The Two Object is not The Same Type");
        }
    }

    // Operater OverLoading of == and != Opertator
    public static bool operator ==(Point3D point1, Point3D point2)
    {
        return (point1.x == point2.x && point1.y == point2.y && point1.z == point2.z);
    }
    public static bool operator !=(Point3D point1, Point3D point2)
    {
        return (point1.x != point2.x || point1.y != point2.y || point1.z != point2.z);
    }

    // Implicit and Explicit Casting of Point3D
    public static implicit operator string(Point3D point)
    {
        return point.ToString();
    }
    //public static explicit operator string(Point3D point)
    //{
    //    return point.ToString();
    //}

    // Read From User
    public static Point3D ReadFromUser()
    {
        int x , y ,z;
        do
        {
            Console.Clear();
            Console.WriteLine("Please Enter Value of X:");
        } while (!int.TryParse(Console.ReadLine(), out x));
        do
        {
            Console.Clear();
            Console.WriteLine("Please Enter Value of Y:");
        } while (!int.TryParse(Console.ReadLine(), out y));
        do
        {
            Console.Clear();
            Console.WriteLine("Please Enter Value of Z:");
        } while (!int.TryParse(Console.ReadLine(), out z));

        return new Point3D(x, y, z);
    }

    public object Clone()
    {
        return new Point3D(x, y,z);
    }
}