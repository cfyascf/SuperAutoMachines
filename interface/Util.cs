public static class Util
{
    public static void Sleep(double seconds)
    {
        int milliseconds = (int)(seconds * 1000);
        var startTime = DateTime.Now;
        var endTime = startTime.AddMilliseconds(milliseconds);

        while (DateTime.Now < endTime) { }
    }

    public static void Print(string text)
    {
        foreach(var c in text)
        {
            Console.Write(c);
            Sleep(0.05);
        }
    }
}