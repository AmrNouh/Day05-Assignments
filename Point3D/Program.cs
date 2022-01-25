Point3D point1, point2;
Console.WriteLine("Please Enter x1");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter y1");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter z1");
int z1 = Convert.ToInt32(Console.ReadLine());
point1 = new Point3D(x1, y1, z1);
Console.WriteLine("Please Enter x2");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter y2");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please Enter z2");
int z2 = Convert.ToInt32(Console.ReadLine());
point2 = new Point3D(x2, y2, z2);

string point = point1;
Console.WriteLine($"Point after Casting {point}");
if (point1.Equals(point2))
{
    Console.WriteLine("equals");
}
else
{
    Console.WriteLine("Not equals");
}

if (point1 == point2)
{
    Console.WriteLine("equals");
}
else
{
    Console.WriteLine("Not equals");
}

Point3D[] points = { point1, point2, new Point3D(5,6,7),new Point3D(8,9,10) };
Array.Sort(points);
Console.WriteLine("All Points After Sorting");
for (int i = 0; i < points.Length; i++)
{
    Console.WriteLine($"Point {i+1}: {points[i]}");
}



class Point3D:IComparable
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
    public Point3D(int value) : this(value, value, value) { }

    public override string ToString()
    {
        return $"Point Coordinates: ({x}, {y}, {z})";
    }

    public override bool Equals(object? obj)
    {
        Point3D p = (Point3D)obj;
        return (x == p.x && y == p.y && z == p.z);
    }

    public int CompareTo(object? obj)
    {
        Point3D point = (Point3D)obj; 
        if (x.CompareTo(point.x) == 0)
        {
            return y.CompareTo(point.y);
        }else
        {
            return x.CompareTo(point.x);
        }
    }

    public static bool operator == (Point3D point1 , Point3D point2)
    {
        return (point1.x == point2.x && point1.y == point2.y && point1.z == point2.z);
    }
    public static bool operator != (Point3D point1 , Point3D point2)
    {
        return (point1.x != point2.x || point1.y != point2.y || point1.z != point2.z);
    }

    public static implicit operator string(Point3D point)
    {
        return point.ToString();
    }
    //public static explicit operator string(Point3D point)
    //{
    //    return point.ToString();
    //}

}