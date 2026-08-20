using DesignPatterns.Builder.Builder;

namespace DesignPatterns.Builder
{
    internal class DemoBuilder
    {
        internal static void Process()
        {
            Console.WriteLine("************************");
            Console.WriteLine("Default Passenger");

            var builder = new PassengerBuilder().AddMandatory("Tejal", 20);
            var passenger = builder.Build();

            passenger.Display();
            Console.WriteLine();

            Console.WriteLine("************************");
            Console.WriteLine("Add Contact");

            passenger = builder
                .AddDetails("t@t.com", "9876543210")
                .Build();

            passenger.Display();
            Console.WriteLine();

            Console.WriteLine("************************");
            Console.WriteLine("Adding Armed Force and Membership");
            passenger = builder
                .IsArmedForce()
                .IsMember()
                .Build();

            passenger.Display();
        }
    }
}
