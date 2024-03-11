using System;

public abstract class Worker
{
    protected string name;
    protected double rate;

    public Worker(string name, double rate)
    {
        this.name = name;
        this.rate = rate;
    }

    public abstract double ComputePay();
}

public class FullTimeWorker : Worker
{
    public FullTimeWorker(string name) : base(name, 10) { }

    public override double ComputePay()
    {
        return Math.Min(240, 240) * rate;
    }
}

public class HourlyWorker : Worker
{
    private int hoursWorked;

    public HourlyWorker(string name) : base(name, 5)
    {
        hoursWorked = 0;
    }

    public void AddHours(int hours)
    {
        hoursWorked += hours;
    }

    public override double ComputePay()
    {
        return Math.Min(hoursWorked, 60) * rate;
    }
}

class Program
{
    static void Main()
    {
        FullTimeWorker fullTimeWorker = new FullTimeWorker("John");
        Console.WriteLine("Full-time worker's pay: " + fullTimeWorker.ComputePay());

        HourlyWorker hourlyWorker = new HourlyWorker("Alice");
        hourlyWorker.AddHours(50);
        Console.WriteLine("Hourly worker's pay: " + hourlyWorker.ComputePay());
    }
}
