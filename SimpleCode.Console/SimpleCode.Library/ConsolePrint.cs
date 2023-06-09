namespace SimpleCode.Library;

public static class ConsolePrint
{
    private static void PrivatePrint(string message)
    {
        Console.WriteLine($"{message}");
    }
    public static void Print(string message)
    {
        PrivatePrint(message);
    }
}