using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class WeathData : ISubject
    {
        private List<IObserver> _observers;
        private float _temperature;
        private float _humidity;
        private float _pressure;

        public WeathData()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver o) => _observers.Add(o);

        public void RemoveObserver(IObserver o)
        {
            int i = _observers.IndexOf(o);
            if (i >= 0)
                _observers.RemoveAt(i);
        }
        
        public void NotifyObservers()
        {
            _observers.ForEach(o =>
            {
                o.Update(_temperature, _humidity, _pressure);
            });
        }

        public void MeasurementsChanged() => NotifyObservers();

        public void SetMeasurements(float temperature,float humidity,float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MeasurementsChanged();
        }
    }
}
