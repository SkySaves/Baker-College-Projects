using System;
using System.Collections.Generic;

namespace Marathons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which program would you like to run? Type 1 or 2");
            Console.WriteLine("1. Program 1");
            Console.WriteLine("2. Program 2");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Program1();
            }
            else if (choice == "2")
            {
                Program2();
            }
        }
        static void Program1()
        {
            // Prompt the user for time in HH:MM:SS format
            Console.Write("Enter the time in HH:MM:SS format: ");
            string timeInput = Console.ReadLine();
            // After we get the input we will split the line by ":" to get each individual number.
            string[] timeParts = timeInput.Split(':');
            // Now that it is split and put into an array of strings, we can create variables for each number and assign accordingly.
            int hours = int.Parse(timeParts[0]);
            int minutes = int.Parse(timeParts[1]);
            int seconds = int.Parse(timeParts[2]);

            // Convert the time to total seconds
            int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            // Prompt the user for the distance
            Console.Write("Enter the distance of the race: ");
            double distance = double.Parse(Console.ReadLine());

            // Prompt the user for the unit (km or miles)
            Console.Write("Is the distance in km or miles? (Enter 'km' or 'mi'): ");
            string unit = Console.ReadLine();

            // Variables to hold distances and paces
            double distanceMiles, distanceKm;
            int pacePerMile, pacePerKm;

            // Convert distance to both miles and km
            if (unit == "mi")
            {
                distanceMiles = distance;
                distanceKm = distance * 1.60934;
            }
            else
            {
                distanceKm = distance;
                distanceMiles = distance / 1.60934;
            }

            // Calculate the pace in seconds per mile and per km
            pacePerMile = (int)(totalSeconds / distanceMiles);
            pacePerKm = (int)(totalSeconds / distanceKm);

            // Convert pace to minutes and seconds
            int paceMinutesPerMile = pacePerMile / 60;
            int paceSecondsPerMile = pacePerMile % 60;

            int paceMinutesPerKm = pacePerKm / 60;
            int paceSecondsPerKm = pacePerKm % 60;

            // Display the results
            Console.WriteLine($"Time: {timeInput}");
            Console.WriteLine($"Distance in miles: {distanceMiles:F1} Distance in km: {distanceKm:F1}");
            Console.WriteLine($"Pace in minutes per mile: {paceMinutesPerMile}:{paceSecondsPerMile:D2}");
            Console.WriteLine($"Pace in minutes per km: {paceMinutesPerKm}:{paceSecondsPerKm:D2}");
        }

        static void Program2()
        {
            // Initialize a list to store race times in seconds
            List<int> raceTimes = new List<int>();
            // Initialize variables to store the fastest and slowest times
            int fastestTime = int.MaxValue;
            int slowestTime = int.MinValue;
            // Initialize a variable to store the total time of all races
            int totalTime = 0;

            // Loop to collect up to 10 race times
            for (int i = 1; i <= 10; i++)
            {
                // Prompt the user for the time of the race
                Console.Write($"Enter the time for Race {i} in HH:MM:SS format (or -1 to stop): ");
                string input = Console.ReadLine();

                // Check if the user wants to stop entering times
                if (input == "-1")
                {
                    break;
                }

                // Split the input time into hours, minutes, and seconds
                string[] timeParts = input.Split(':');
                int hours = int.Parse(timeParts[0]);
                int minutes = int.Parse(timeParts[1]);
                int seconds = int.Parse(timeParts[2]);

                // Convert the time to total seconds
                int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

                // Add the total seconds to the list of race times
                raceTimes.Add(totalSeconds);

                // Update the fastest time if necessary
                if (totalSeconds < fastestTime)
                {
                    fastestTime = totalSeconds;
                }

                // Update the slowest time if necessary
                if (totalSeconds > slowestTime)
                {
                    slowestTime = totalSeconds;
                }

                // Add the total seconds to the total time
                totalTime += totalSeconds;
            }

            // Check if any race times were entered to avoid division by zero
            if (raceTimes.Count > 0)
            {
                // Calculate the average time
                int averageTime = totalTime / raceTimes.Count;

                // Loop through each race time to display it
                for (int i = 0; i < raceTimes.Count; i++)
                {
                    // Convert total seconds back to hours, minutes, and seconds
                    int hours = raceTimes[i] / 3600;
                    int minutes = (raceTimes[i] % 3600) / 60;
                    int seconds = raceTimes[i] % 60;

                    // Initialize a label for the fastest and slowest times
                    string label = "";

                    // Check if the current time is the fastest
                    if (raceTimes[i] == fastestTime)
                    {
                        label = "**FASTEST**";
                    }
                    // Check if the current time is the slowest
                    else if (raceTimes[i] == slowestTime)
                    {
                        label = "**SLOWEST**";
                    }

                    // Display the race time and any labels
                    Console.WriteLine($"Race {i + 1}: {hours:D2}:{minutes:D2}:{seconds:D2} {label}");
                }

                // Calculate and display the average time in HH:MM:SS format
                int avgHours = averageTime / 3600;
                int avgMinutes = (averageTime % 3600) / 60;
                int avgSeconds = averageTime % 60;
                Console.WriteLine($"Average time: {avgHours:D2}:{avgMinutes:D2}:{avgSeconds:D2}");
            }
            // If no race times were entered, display a message
            else
            {
                Console.WriteLine("No race times entered.");
            }
        }
    }
}
