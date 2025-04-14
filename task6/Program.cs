using System;

public delegate void delegate1(string s);

class Counter
{
    public event delegate1? event_alert_and_log;
    int total=0;
    int threshold;

    public Counter(int number)
    {
        threshold = number;
    }

    public bool Add(int num, string s)
    {
        total = total + num;

        if(total>threshold)
        {

            Console.WriteLine("Current total is: "+total);
            invoke_event(s);
            return true;
        }
        return false;
    }
    private void invoke_event(string s)
    {
        event_alert_and_log?.Invoke(s);
    }
}
class Handler
{
    public void alert(string s)
    {
        Console.WriteLine("Alert alarmed by "+s);
    }
    public void log(string s)
    {
        Console.WriteLine("Logs shown to "+s);
    }
}
class Program
{
    public static void Main()
    {
        Counter counter = new Counter(10);
        Handler handler = new Handler();

        counter.event_alert_and_log += handler.alert;
        counter.event_alert_and_log += handler.log;

        for(int i=0;i<10; i++)
        {
            bool state = counter.Add(i,"Kaushik");
            if(state)
            {
                return ;
            }
        }
        
    }
}