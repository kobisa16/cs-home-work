using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class PassengerPlane : Aircraft
    {
        public int passengersCount { get; set; }
        public PassengerPlane(int altitude, string flightNumber, int passengersCount) : base(altitude, flightNumber)
        {
            this.passengersCount = passengersCount;
        }

        public override void PrintStatus()
        {
            Console.WriteLine($" Passenger Plane: The altitude is {altitude} and the flight number is {flightNumber} and the amount of passengers is {passengersCount}");
        }
    }
}
