using System;
// Enhancements to exceed requirements:
// - Added VisualizationActivity for mental imagery and relaxation.
// - Breathing animation uses dynamic text blocks to simulate breath.
// - Ensured prompts/questions are not repeated until all are used.
// - Used inheritance and encapsulation with a clean class hierarchy.
// - Spinner and countdown animations implemented with Thread.Sleep and console overwrite.


class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Activity activity = choice switch
            {
                "1" => new BreathingActivity(),
                "2" => new ReflectionActivity(),
                "3" => new ListingActivity(),
                "4" => new VisualizationActivity(),
                "5" => null,
                _ => null
            };

            if (activity == null)
            {
                if (choice == "5") break;
                Console.WriteLine("Invalid choice. Try again.");
                Thread.Sleep(1000);
            }
            else
            {
                activity.Start();
            }
        }

        Console.WriteLine("Goodbye! Stay mindful.");
    }
}
