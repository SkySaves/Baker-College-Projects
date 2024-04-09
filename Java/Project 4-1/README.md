# Java Project 4-1: Geometric Shape Calculator

## Description

This project comprises a series of classes that together form a geometric shape calculator. It utilizes Java's object-oriented programming features, such as inheritance and polymorphism, to calculate and display the surface area and volume of various shapes: cones, cylinders, and spheres. The `Shape` class serves as an abstract base, with `Cone`, `Cylinder`, and `Sphere` extending it to implement specific calculations.

## Project Structure

- **Shape (Abstract Class)**: Defines the structure that all geometric shapes will follow, requiring them to implement methods for calculating surface area and volume.
- **Cone**: Represents a cone shape, with methods to calculate its surface area and volume.
- **Cylinder**: Represents a cylinder shape, with methods to calculate its surface area and volume.
- **Sphere**: Represents a sphere shape, with methods to calculate its surface area and volume.
- **ShapeArray**: Contains the `main` method that demonstrates the use of polymorphism by storing different shapes in an array and displaying their properties.

## Features

- Calculates the surface area and volume for cones, cylinders, and spheres.
- Demonstrates the use of abstract classes and method overriding.
- Uses an array to hold different types of objects, showcasing polymorphism.
- Prints detailed information about each shape, including calculated properties.

## Conclusion

Project 4-1 exemplifies the power of object-oriented design and programming in Java through the lens of geometric calculations. It not only demonstrates the application of abstract classes and polymorphism but also provides a solid foundation for further exploration into more complex shapes and calculations. The modular design allows for easy addition of more shapes without altering the existing structure, promoting code reusability and scalability.
