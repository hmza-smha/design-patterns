# Factory (Creational)

- Create objects without exposing the creation logic to the client and refer to newly created object using a common interfate

- Allow the subclasses to choose the type of objects to create

- Define an interface or abstract class for creating object and let the subclasses decide which class to instantiate

## Used When:
1. You have a super class with multiple subclasses and based on an input, we need to return one of the subclasses. *(use abstract superclass)*
2. when you have no idea of the axact type of the objects your code will work with

## Useful In:
1. extend the code without touch the existing code