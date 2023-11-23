using System;
using System.Threading;

public class CountdownClock
{
    public delegate void CountdownFinishedHandler(string message);
    public event CountdownFinishedHandler CountdownFinished;

    private int countdownTime;
    private string message;
    private bool isRunning;
    private bool isPaused;
    private int remainingTime;

    public CountdownClock(int timeInSeconds, string message)
    {
        this.countdownTime = timeInSeconds;
        this.message = message;
        this.isRunning = false;
        this.isPaused = false;
        this.remainingTime = timeInSeconds;
    }

    public void Start()
    {
        if (!isRunning)
        {
            isRunning = true;
            isPaused = false;
            Thread countdownThread = new Thread(new ThreadStart(RunCountdown));
            countdownThread.Start();
        }
    }

    public void Pause()
    {
        if (isRunning && !isPaused)
        {
            isPaused = true;
        }
    }

    public void Resume()
    {
        if (isRunning && isPaused)
        {
            isPaused = false;
        }
    }

    public void Abort()
    {
        if (isRunning)
        {
            isRunning = false;
        }
    }

    private void RunCountdown()
    {
        while (remainingTime > 0 && isRunning)
        {
            if (!isPaused)
            {
                Console.WriteLine($"Countdown: {remainingTime} seconds remaining");
                Thread.Sleep(1000); // Sleep for 1 second
                remainingTime--;
            }
        }

        if (remainingTime == 0 && isRunning)
        {
            CountdownFinished?.Invoke(message);
        }

        // Reset the state
        isRunning = false;
        isPaused = false;
        remainingTime = countdownTime;
    }
}
