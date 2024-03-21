using Library;

namespace AsyncProgram;

public static class Program
{
    public static async Task Main()
    {
        await Console.Out.WriteLineAsync("Start");
        Console.WriteLine(Test());
        Console.WriteLine("End");
    }

    private static Struct Test()
    {
        return Struct.One;
    }
}
