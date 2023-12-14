# Countdown Clock with Observer Pattern
Welcome to the Countdown Clock with Observer Pattern repository! This C# console application demonstrates the use of the Observer design pattern in a simple countdown clock scenario. The application creates a countdown timer that notifies multiple observers when the countdown finishes.
## Features
* Countdown Timer: A customizable timer that counts down from a specified number of seconds.
* Event-Driven Notifications: Utilizes delegates and events to notify observers when the countdown finishes.
* Pause and Resume Functionality: Ability to pause and resume the countdown.
* Abort Option: Safely aborts the countdown if needed.
* Multiple Observers: Demonstrates how multiple observers can subscribe to and receive notifications from the countdown clock.
## Components
* CountdownClock.cs: Contains the CountdownClock class, which manages the countdown timer and triggers events upon completion.
* Observer.cs: Defines the Observer class, which represents an observer that can subscribe to the countdown clock's notifications.
* Program.cs: The main entry point of the application, demonstrating the creation of a countdown clock, adding observers, and controlling the countdown.
## How It Works
* The CountdownClock class manages the countdown process in a separate thread, allowing for pause, resume, and abort functionalities.
* Observers are added to the countdown clock using event subscriptions.
* When the countdown finishes or is aborted, all subscribed observers are notified with a custom message.
