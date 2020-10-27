using System;

namespace BloodClinic
{
    public class Receiver : Member
    {
        public Receiver(string firstName, string lastName, DateTime dateOfBirth, BloodType memberBloodType, string email)
            : base(firstName, lastName, dateOfBirth, memberBloodType, email) 
        {
            LastReceivedDate = DateTime.MinValue;
        }

        public DateTime LastReceivedDate { get; set; }

        public override void SendUpdate() {
            Console.WriteLine("\nHello receiver!");
            Console.WriteLine($"Name: {FullName}");
            Console.WriteLine($"Last Received Date: {LastReceivedDate}\n");
        }
    }
}