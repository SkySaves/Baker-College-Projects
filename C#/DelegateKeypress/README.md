# DelegateKeypress: A Console Movement Application
Welcome to the DelegateKeypress repository! This C# console application demonstrates the use of delegates to handle keyboard inputs for moving a character within the console window. It's a simple yet effective showcase of how delegates can be utilized in a .NET application for input management.
## Features
* Movement Controls: Use the W, A, S, D keys to move the character (@) up, left, down, and right within the console window.
* Boundary Checking: The character's movement is constrained within the console window's dimensions, preventing it from moving outside the visible area.
* Exit Functionality: You can exit the application at any time by pressing the Escape key.
* Delegate-Based Input Handling: The application uses a dictionary of delegates to associate specific keys with their corresponding actions, demonstrating a clean and scalable way to handle user inputs.
## How It Works
The application defines a delegate type called ActionDelegate, which represents methods that handle specific actions like moving up, down, left, or right. A dictionary named myControls maps ConsoleKey values to these delegates. When a key is pressed, the application checks if it's associated with an action in the dictionary and, if so, invokes the corresponding delegate.
## Running the Application
To run DelegateKeypress, you'll need:
* A C# development environment like Visual Studio or Visual Studio Code.
* .NET Framework or .NET Core installed on your machine.
Clone the repository, open the solution in your development environment, build the project, and run it. You'll see a console window with a character (@) that you can move around using the specified keys.
## Contributions
Contributions to DelegateKeypress are welcome! Whether it's enhancing the functionality, refactoring the code, or improving documentation, feel free to fork the repository and submit a pull reques
## License
This project is open-sourced under the MIT License. Feel free to use it as you see fit in your personal or professional projects.
