namespace TheVariableShop;

class Program
{
    static void Main(string[] args)
    {
        byte myByte = 45;
        sbyte mySByte = 25;

        short myShort = -30_000;
        ushort myUShort = 300;

        int myInt = 100_000_000;
        uint myUInt = 4_000_000_000;

        long myLong = 90_000_000_000_000;
        ulong myULong = 200_200_000_000_000_000;

        float myFloat = -200.01f;
        double myDouble = -3.903;
        decimal myDecimal = -2220.46m;
        bool isBored = false;
        char myChar = 'X';
        string myString = "Soooo many numbers.";


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
