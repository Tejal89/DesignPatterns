using DesignPatterns.Models;

namespace DesignPatterns
{
    internal class PassengerBuilder
    {
        private Passenger _passenger = new Passenger();

        public PassengerBuilder IsArmedForce()
        { 
            _passenger.IsArmedForce = true;
            return this;
        }

        public PassengerBuilder AddMandatory(string fullName, int age)
        {
            _passenger.FullName = fullName;
            _passenger.Age = age;
            return this;
        }

        public PassengerBuilder AddDetails(string email,string phoneNumber)
        {
            _passenger.Email = email;
            _passenger.PhoneNumber = phoneNumber;
            return this;
        }

        public PassengerBuilder IsMember()
        {
            _passenger.IsMember = true;
            return this;
        }

        public Passenger Build()
        {
            return _passenger;
        }
    }
}
