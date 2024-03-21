using System.Collections.Immutable;

namespace Library;

public readonly struct Struct
{
    private readonly int Value;

    private Struct(int value)
    {
        Value = value;
    }

    public static Struct One { get; }

    public static ImmutableArray<Struct> AllValues { get; }

    static Struct()
    {
        One = new(1);
        AllValues = [One];
    }
}
