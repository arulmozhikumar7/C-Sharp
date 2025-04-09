using System;


public delegate void ThresholdReachedEventHandler(object sender, ThresholdReachedEventArgs e);

public class ThresholdReachedEventArgs : EventArgs
{
    public int Threshold { get; set; }
    public DateTime TimeReached { get; set; }
}


public class Counter
{
    private int _threshold;
    private int _count;

    public event ThresholdReachedEventHandler? ThresholdReached;

    public Counter(int threshold)
    {
        _threshold = threshold;
        _count = 0;
    }

    public void Add(int value)
    {
        _count += value;
        Console.WriteLine($"Counter: {_count}");

        if (_count >= _threshold)
        {
            ThresholdReachedEventArgs args = new ThresholdReachedEventArgs()
            {
                Threshold = _threshold,
                TimeReached = DateTime.Now
            };

            OnThresholdReached(args);
        }
    }

    protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
    {
        ThresholdReached?.Invoke(this, e);
    }
}

class Handlers
{
    public static void LogThresholdReached(object sender, ThresholdReachedEventArgs e)
    {
        Console.WriteLine($"[LOG] Threshold {e.Threshold} reached at {e.TimeReached}");
    }

    public static void AlertThresholdReached(object sender, ThresholdReachedEventArgs e)
    {
        Console.WriteLine($"[ALERT] Threshold has been hit! Value: {e.Threshold}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Counter counter = new Counter(5);

        counter.ThresholdReached += Handlers.LogThresholdReached;
        counter.ThresholdReached += Handlers.AlertThresholdReached;

        Console.WriteLine("Press 'i' to increment the counter or 'q' to quit.");

        while (true)
        {
            var input = Console.ReadKey(true);
            if (input.KeyChar == 'i')
            {
                counter.Add(1);
            }
            else if (input.KeyChar == 'q')
            {
                break;
            }
        }

        Console.WriteLine("Program Ended.");
    }
}
