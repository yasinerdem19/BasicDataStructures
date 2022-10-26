// See https://aka.ms/new-console-template for more information
/*
 * 
1 Byte = 8 Bit
------------
Int16 = 2 Byte
Int32 = 4 Byte
Int64 = 8 Byte
SByte = 1 Byte
Byte = 1 Byte

*/
string str = new string('-', 42);
Console.WriteLine(nameof(SByte));
Console.WriteLine($"Min Value:          : {SByte.MinValue,20:#,##0}");
Console.WriteLine($"Max Value:          : {SByte.MaxValue,20:#,##0}");
Console.WriteLine($"Size:               : {sizeof(SByte),20:#,##0}");
Console.WriteLine(str);
Console.ReadLine();

Console.WriteLine(nameof(Byte));
Console.WriteLine($"Min Value:          : {Byte.MinValue,20:#,##0}");
Console.WriteLine($"Max Value:          : {Byte.MaxValue,20:#,##0}");
Console.WriteLine($"Size:               : {sizeof(Byte),20:#,##0}");
Console.WriteLine(str);
Console.ReadLine();

Console.WriteLine(nameof(Int16));
Console.WriteLine($"Min Value:          : {Int16.MinValue,20:#,##0}");
Console.WriteLine($"Max Value:          : {Int16.MaxValue,20:#,##0}");
Console.WriteLine($"Size:               : {sizeof(Int16),20:#,##0}");
Console.WriteLine(str);
Console.ReadLine();

Console.WriteLine(nameof(UInt16));
Console.WriteLine($"Min Value:          : {UInt16.MinValue,20:#,##0}");
Console.WriteLine($"Max Value:          : {UInt16.MaxValue,20:#,##0}");
Console.WriteLine($"Size:               : {sizeof(UInt16),20:#,##0}");
Console.WriteLine(str);
Console.ReadLine();

Console.WriteLine(nameof(Int32));
Console.WriteLine($"Min Value:          : {Int32.MinValue,20:#,##0}");
Console.WriteLine($"Max Value:          : {Int32.MaxValue,20:#,##0}");
Console.WriteLine($"Size:               : {sizeof(Int32),20:#,##0}");
Console.WriteLine(str);
Console.ReadLine();

Console.WriteLine(nameof(UInt32));
Console.WriteLine($"Min Value:          : {UInt32.MinValue,20:#,##0}");
Console.WriteLine($"Max Value:          : {UInt32.MaxValue,20:#,##0}");
Console.WriteLine($"Size:               : {sizeof(UInt32),20:#,##0}");
Console.WriteLine(str);
Console.ReadLine();

Console.WriteLine(nameof(Double));
Console.WriteLine($"Min Value:          : {Double.MinValue,20}");
Console.WriteLine($"Max Value:          : {Double.MaxValue,20}");
Console.WriteLine($"Size:               : {sizeof(Double),20}");
Console.WriteLine(str);
Console.ReadLine();


