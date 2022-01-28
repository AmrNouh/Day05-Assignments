// handling ToString() Formats
Duration D1 = new Duration(1, 10, 15);
Console.WriteLine($"new Duration(1,10,15) = {D1.ToString()}");
Duration D2 = new Duration(3600);
Console.WriteLine($"new Duration (3600) = {D2.ToString()}");
Duration D3 = new Duration(7800);
Console.WriteLine($"new Duration(7800) = {D3.ToString()}");
Duration D4 = new Duration(666);
Console.WriteLine($"new Duration(666) = {D4.ToString()}");
// Try operator overloading
Console.WriteLine($"D2 += D1 => {D2+=D1}");
Console.WriteLine($"D3 = D1 + D2 => {D3 = D1 + D2}");
Console.WriteLine($"D4 = D1 + 7800 => {D4 = D1 + 7800}");
Console.WriteLine($"D3 = 666 + D3 => {D3 = 666 + D3}");
Console.WriteLine($"D3 = D1++ => {D3 = D1++}");
Console.WriteLine($"D3 = --D2 => {D3 = --D2}");
Console.WriteLine($"D1 = -D2 => {D1 = -D2}");
Console.WriteLine($"D1 = {D1.ToString()}");
Console.WriteLine($"D2 = {D2.ToString()}");
Console.WriteLine($"D3 = {D3.ToString()}");
Console.WriteLine($"If ( D1 > D2) {D1 > D2}");
Console.WriteLine($"If ( D1 < D2) {D1 < D2}");
Console.WriteLine($"If ( D1 <= D2) {D1 <= D2}");
Console.WriteLine($"If ( D1 <= D1) {D1 <= D1}");
Console.WriteLine($"If ( D1 >= D2) {D1 >= D2}");
Console.WriteLine($"If ( D2 >= D2) {D2 >= D2}");
Console.WriteLine($"If ( D1) {D1}");
Duration D5 = new Duration();
if (D5)
{
Console.WriteLine($"D5 = {D5.ToString()}");

}
else
{
    Console.WriteLine("false");
}
Console.WriteLine($"D1 = {D2.ToString()}");
DateTime obj = (DateTime)D2;
Console.WriteLine($"datetime object = {obj.ToString()}");
