using System;

public class Observer
{
    private string name;

    public Observer(string name)
    {
        this.name = name;
    }

    public void OnAlarmReceived(string message)
    {
        Console.WriteLine($"{name} received the alarm: {message}");
    }
}
