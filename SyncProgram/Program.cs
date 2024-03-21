using Library;

namespace SyncProgram;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Start");
        Console.WriteLine(Test());
        Console.WriteLine("End");
    }

    private static Struct Test()
    {
        return Struct.One;
    }
}
