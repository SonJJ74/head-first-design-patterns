# Singleton Pattern
The singleton pattern ensures a class has only one instance, 
and provides a global point of access to it.

```mermaid
classDiagram
class Singleton {
  static UniqueInstance
  static GetInstance()
}
