# 1. Creational Patterns
These deal with object creation mechanisms, trying to create objects in a manner suitable to the situation.

## ✅ Most Common:
### Singleton
Ensures a class has only one instance and provides a global point of access to it.
### Factory Method
Defines an interface for creating an object but lets subclasses alter the type of objects that will be created.
### Abstract Factory
Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
### Builder
Separates the construction of a complex object from its representation so that the same construction process can create different representations.


 # 2. Structural Patterns
These deal with object and class composition. They help ensure that when parts of a system change, the entire structure doesn’t need to do so.

## ✅ Most Common:
### Adapter
Allows incompatible interfaces to work together.
### Decorator
Adds behavior to objects dynamically without affecting the behavior of other objects of the same class.
### Proxy
Controls access to another object, often used for lazy loading, permissions, or adding functionality before/after requests.
### Composite
Composes objects into tree structures to represent part-whole hierarchies.
### Facade
Provides a simplified interface to a set of interfaces in a subsystem.


# Behavioral Patterns
These are concerned with algorithms and the assignment of responsibilities between objects.

## ✅ Most Common:
### Observer
Defines a dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
### Strategy
Enables selecting an algorithm at runtime — defines a family of algorithms, encapsulates each one, and makes them interchangeable.
### Command
Encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
### Template Method
Defines the skeleton of an algorithm in a method, deferring some steps to subclasses.
### Chain of Responsibility
Passes a request along a chain of handlers; each handler either processes the request or passes it to the next handler.

# Bonus: Other Notable Patterns
While not always in the top tier, these are also widely used:

### Dependency Injection (DI) – Not a formal GoF pattern but essential in modern frameworks like Spring, Angular, etc.
### Repository Pattern – Used to separate data access logic from business logic.
### Service Locator – Offers a way to get services without tight coupling.
### Flyweight – Minimizes memory usage by sharing as much data as possible with similar objects.
