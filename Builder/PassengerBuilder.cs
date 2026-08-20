using DesignPatterns.Builder.Models;

namespace DesignPatterns.Builder.Builder
{
    internal class PassengerBuilder
    {
        private Passenger _passenger = new Passenger();

        internal PassengerBuilder IsArmedForce()
        { 
            _passenger.IsArmedForce = true;
            return this;
        }

        internal PassengerBuilder AddMandatory(string fullName, int age)
        {
            _passenger.FullName = fullName;
            _passenger.Age = age;
            return this;
        }

        internal PassengerBuilder AddDetails(string email,string phoneNumber)
        {
            _passenger.Email = email;
            _passenger.PhoneNumber = phoneNumber;
            return this;
        }

        internal PassengerBuilder IsMember()
        {
            _passenger.IsMember = true;
            return this;
        }

        internal Passenger Build()
        {
            return _passenger;
        }
    }
}
