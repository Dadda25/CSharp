using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        AlarmClock alarmClock = new AlarmClock(DateTime.Now.AddSeconds(10));

        alarmClock.Tick += AlarmClock_Tick;
        alarmClock.Alarm += AlarmClock_Alarm;

        alarmClock.Start();

        Console.ReadLine();
    }

    private static void AlarmClock_Tick(object sender, EventArgs e)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] 嘀嗒...");
    }

    private static void AlarmClock_Alarm(object sender, EventArgs e)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] **闹钟响了！起床啦！**");
    }
}

public class AlarmClock
{
    public event EventHandler Tick;
    public event EventHandler Alarm;

    private DateTime alarmTime;
    private bool isRunning = false;

    public AlarmClock(DateTime alarmTime)
    {
        this.alarmTime = alarmTime;
    }

    public void Start()
    {
        isRunning = true;
        while (isRunning)
        {
            Thread.Sleep(1000);
            OnTick();

            if (DateTime.Now >= alarmTime)
            {
                OnAlarm();
                isRunning = false;
            }
        }
    }

    protected virtual void OnTick()
    {
        Tick?.Invoke(this, EventArgs.Empty);
    }

    protected virtual void OnAlarm()
    {
        Alarm?.Invoke(this, EventArgs.Empty);
    }
}
