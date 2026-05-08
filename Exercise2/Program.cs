using System.Security.Cryptography;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aircraft[] aircraft = new Aircraft[]
{
    new PassengerPlane(100, "Airbus-A320", 150),
    new PassengerPlane(200, "Boeing-737", 120),
    new FighterJet(15000, "F-16", true),
    new FighterJet(18000, "F-35", true)
};


            foreach (var plane in aircraft)
            {
                plane.PrintStatus();
                if (plane is FighterJet jet)
                {
                    jet.FireMissile();
                }

            }




        }
    }

    class Aircraft
    {
        public int altitude { get; set; }
        public string flightNumber { get; set; }

        public Aircraft(int altitude, string flightNumber)
        {
            this.altitude = altitude;
            this.flightNumber = flightNumber;
        }

        public virtual void PrintStatus()
        {

        }


    }
}
