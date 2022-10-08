# Strategy Pattern
The strategy pattern defines a family of algorithms, encapsulates each one and makes them interchangeable.  
Strategy lets the algorithm vary independently from clients that use it.

## OO Basics
- Encapsulates what varies.
- Favour composition over inheritances.
- Program to an interfaces, not implementations

## OO Principles
- Encapsulates what varies.
- Favour composition over inheritances.
- Program to an interfaces, not implementations

```mermaid
classDiagram
  Duck <|-- MallardDuck
  Duck <|-- RedheadDuck
  Duck <|-- RubberDuck
  Duck <|-- DecoyDuck
  FlyBehaviour <|.. FlyWithWings
  FlyBehaviour <|.. FlyNoWay
  QuackBehaviour <|.. Quack
  QuackBehaviour <|.. Squeak
  QuackBehaviour <|.. MuteQuack
  FlyBehaviour *-- Duck
  QuackBehaviour *-- Duck
class Duck {
  FlyBehaviour flyBehaviour
  QuackBehaviour quackBehaviour
  Swim()
  Display()
  PerformQuack()
  PerformFly()
  SetFlyBehaviour()
  SetQuackBehaviour()
}
class MallardDuck {
  Display()
}
class RedheadDuck {
  Display()
}
class RubberDuck {
  Display()
}
class DecoyDuck {
  Display()
}
class FlyBehaviour {
  <<interface>>
  Fly()
}
class FlyWithWings {
  Fly()
}
class FlyNoWay {
  Fly()
}
class QuackBehaviour {
  <<interface>>
  Quack()
}
class Quack {
  Quack()
}
class Squeak {
  Quack()
}
class MuteQuack {
  Quack()
}
