namespace TheVariableShop;

class Program
{
    static void Main(string[] args)
    {
        byte myByte = 234;
        sbyte mySByte = -115;

        short myShort = -30_000;
        ushort myUShort = 60_000;

        int myInt = -2_000_000;
        uint myUInt = 3_000_000_000;

        long myLong = -90_000_000_000_000;
        ulong myULong = 200_000_000_000_000;

        float myFloat = 0.01f;
        double myDouble = 3.14159;
        decimal myDecimal = 20.46m;
        bool isBored = true;
        char myChar = 'T';
        string myString = "Lots of numbers here.";


        Console.WriteLine(myString);
        Console.WriteLine(myByte);
        Console.WriteLine(mySByte);
        Console.WriteLine(myShort);
        Console.WriteLine(myUShort);
        Console.WriteLine(myInt);
        Console.WriteLine(myUInt);
        Console.WriteLine(myLong);
        Console.WriteLine(myULong);
        Console.WriteLine(myFloat);
        Console.WriteLine(myDouble);
        Console.WriteLine(myDecimal);
        Console.WriteLine(myChar);
        Console.WriteLine(isBored);

    }
}
