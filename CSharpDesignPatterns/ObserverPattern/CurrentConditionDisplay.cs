using System;

namespace ObserverPattern
{
    public class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private ISubject _weatherData;

        public CurrentConditionDisplay(ISubject subject)
        {
            _weatherData = subject;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            Display();
        }

        public void Display() => Console.WriteLine($"{DateTime.Now}当前温度：{_temperature} 摄氏度，湿度 {_humidity} %");
    }
}
