
// Read Value of Two Point From User => Bad And Redundant Code Here (old Version)
//Point3D point1, point2;
//Console.WriteLine("Please Enter x1");
//int x1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please Enter y1");
//int y1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please Enter z1");
//int z1 = Convert.ToInt32(Console.ReadLine());
//point1 = new Point3D(x1, y1, z1);
//Console.WriteLine("Please Enter x2");
//int x2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please Enter y2");
//int y2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Please Enter z2");
//int z2 = Convert.ToInt32(Console.ReadLine());
//point2 = new Point3D(x2, y2, z2);

// Read Value of Two Point From User (Enhanced Version)
Point3D point1 = Point3D.ReadFromUser(), point2 = Point3D.ReadFromUser();
Console.Clear();

// Casting Point3D To string
string point = point1;
Console.WriteLine($"Point after Casting {point}");

// Try of using == Operator on Point3D
if (point1 == point2)
{
    Console.WriteLine("Two Points are equal");
}
else
{
    Console.WriteLine("Two Points are Not equal");
}

// Try of using Equals Function (From base Object)
if (point1.Equals(point2))
{
    Console.WriteLine("Two Points are equal");
}
else
{
    Console.WriteLine("Two Points are not equal");
}


// Making array of Points and Sort this Array Base on x and y
Point3D[] points = { point1, point2, new Point3D(5, 6, 7), new Point3D(8, 9, 10) };

// Sorting Array
Array.Sort(points);

// Printing Array After Sorting
Console.WriteLine("\nAll Points After Sorting\n");
for (int i = 0; i < points.Length; i++)
{
    Console.WriteLine($"Point {i + 1}: {points[i]}");
}

// cloning of exist object
Point3D point3 = point1.Clone() as Point3D ?? new Point3D();
Console.WriteLine($"Value of Point1 is {point1}, Cloning Point3 from Point1 Value of Point3 is {point3}");
