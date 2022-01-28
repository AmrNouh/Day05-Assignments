using FTPClientProjeect;

NIC obj = NIC.CreateInstance();
obj.manufacture = "Intel(R) Ethernet Connection I217";
obj.physicalAddress = "70-5A-0F-BA-5D-00";
obj.cardType = CardType.Ethernet;

Console.WriteLine(obj);

NIC obj2 = NIC.CreateInstance();
Console.WriteLine(obj2);