# Obverver Pattern
The observer pattern defines a one-to-many dependency between objects so that when one object changes state,
all its dependents are notified and updated.

## OO Principles
- Strive for loosely coupled designs between objects that interact.

<br/>

```mermaid
classDiagram
    Subject <|.. WeatherData
    Observer *--  Subject : Observer
    WeatherData *-- CurrentConditionsDisplay : Subject
    Observer <|.. CurrentConditionsDisplay
    Observer <|.. StatisticsDisplay
    Observer <|.. ThirdPartyDisplay
    Observer <|.. ForecastDisplay
    DisplayElement <|.. CurrentConditionsDisplay
class Subject {
  <<interface>>
  RegisterObserver()
  RemoveObserver()
  NotifyObservers()
}
class WeatherData {
  RegisterObserver()
  RemoveObserver()
  NotifyObservers()
  
  GetTemperature()
  GetHumidity()
  GetPressure()
  MeasurementsChanged()
}
class Observer {
  <<interface>>
  Update()
}
class DisplayElement {
  <<interface>>
  Display()
}
class CurrentConditionsDisplay {
  Update()
  Display()
}
class StatisticsDisplay {
  Update()
  Display()
}
class ThirdPartyDisplay {
  Update()
  Display()
}
class ForecastDisplay {
  Update()
  Display()
}
```

Note*  Similar to the book, all displays should have a pointer to the class 'WeatherData' & the interface 'DisplayElement'
