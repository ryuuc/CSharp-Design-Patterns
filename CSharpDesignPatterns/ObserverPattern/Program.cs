using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WeathData weathData = new WeathData();

            CurrentConditionDisplay currentConditionDisplay = new CurrentConditionDisplay(weathData);

            weathData.SetMeasurements(30, 42, 30.2f);
            weathData.SetMeasurements(36, 20, 34.5f);
            weathData.SetMeasurements(40, 55, 38.8f);

            Console.Read();
        }
    }
}
