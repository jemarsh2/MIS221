using System;

class Program
{
    static void Main(string[] args)
    {
        string day;
        bool keepGoing = true;

        while (keepGoing)
        {
            day = GetDayOfWeek();

            // If the user typed "exit", break the loop
            if (day.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                keepGoing = false;
            }
            else
            {
                EventDecision(day);
            }
        }

        Console.WriteLine("Goodbye!");
    }

    // Prompts the user for the day of the week
    static string GetDayOfWeek()
    {
        Console.WriteLine("\nEnter a day of the week (or type 'exit' to quit):");
        return Console.ReadLine();
    }

    // Associates the day with the event and calls DisplayEventMessage
    static void EventDecision(string day)
    {
        string eventName = "";

        switch (day.ToLower())
        {
            case "monday":
                eventName = "class";
                break;
            case "tuesday":
                eventName = "basketball practice";
                break;
            case "wednesday":
                eventName = "study group";
                break;
            case "thursday":
                eventName = "club meeting";
                break;
            case "friday":
                eventName = "movie night";
                break;
            case "saturday":
                eventName = "party";
                break;
            case "sunday":
                eventName = "family dinner";
                break;
            default:
                Console.WriteLine("That’s not a valid day. Try again!");
                return;
        }

        DisplayEventMessage(day, eventName);
    }

    // Displays the message for the correct event
    static void DisplayEventMessage(string day, string myEvent)
    {
        Console.WriteLine($"Today is {day}, so I have {myEvent}!");
    }
}
