# Head First Design Patterns

## OO Basics
- Encapsulates what varies.
- Favour composition over inheritances.
- Program to an interfaces, not implementations

## OO Principles
- Encapsulates what varies.
- Favour composition over inheritances.
- Program to an interfaces, not implementations
- Strive for loosely coupled designs between objects that interact.
- Classes should be open for extension, but closed for modification.
- Depend on abstractions.  Do not depend on concrete classes.

<br/>

# Design Patterns

## Strategy Pattern
The strategy patterns defines a family of algorithms, encapsulates each one and makes them interchangeable.  
Strategy lets the algorithm vary independently from clients that use it.

## Obverver Pattern
The observer pattern defines a one-to-many dependency between objects so taht when one object change state,
all its dependents are notified and updated.

## Decorator Pattern
The decorator pattern attaches additional responsibilities to an object dynamically.
Decorators provide a flexible alternative to subclassing for extending functionality.

## Factory Patterns

### Factory Method Pattern
The factory method pattern defines an inteface for creating an object, but let subclasses decide which class to instantiate.
Factory method lets a class defer instantiation to the subclasses.

### Abstract Factory Pattern
The abstract factory pattern provides an interface for creating families of related or dependent objects 
without specifiying their concrete classes.

## Singleton Pattern
The singleton pattern ensures a class only has one instance and provide a global point of access to it.
