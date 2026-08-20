using System.Text.Json;

namespace DesignPatterns.Builder.Models
{
    public class Passenger
    {
        public string FullName { get; internal set; }
        public int Age { get; internal set; }
        public string Email { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public bool IsArmedForce { get; internal set; }
        public bool IsMember { get; internal set; }

        public void Display()
        {
            Console.WriteLine(JsonSerializer.Serialize(this));
        }
    }
}
