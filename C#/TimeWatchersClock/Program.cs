class Program
{
    static void Main(string[] args)
    {
        CountdownClock clock = new CountdownClock(10, "Countdown finished!");

        clock.CountdownFinished += Observer1;
        clock.CountdownFinished += Observer2;
        clock.CountdownFinished += Observer3;

        clock.Start();

        // Wait for 5 seconds before pausing
        Thread.Sleep(5000);
        clock.Pause();
        Console.WriteLine("Countdown paused...");

        // Wait for 2 seconds before resuming
        Thread.Sleep(2000);
        clock.Resume();
        Console.WriteLine("Countdown resumed...");

        // Wait for the countdown to finish naturally
        Thread.Sleep(10000);
        Console.WriteLine("Countdown should have finished.");

        // Abort is only a fallback in case the countdown doesn't finish
        clock.Abort();
        Console.WriteLine("Countdown aborted (fallback).");
    }

    static void Observer1(string message)
    {
        Console.WriteLine($"Observer 1 received: {message}");
    }

    static void Observer2(string message)
    {
        Console.WriteLine($"Observer 2 received: {message}");
    }

    static void Observer3(string message)
    {
        Console.WriteLine($"Observer 3 received: {message}");
    }
}
