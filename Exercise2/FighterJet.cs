using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class FighterJet : Aircraft
    {
        public bool missilesLoaded { get; set; }

        public FighterJet(int altitude, string flightNumber, bool missilesLoaded) : base(altitude, flightNumber)

        {
            this.missilesLoaded = missilesLoaded;
        }

        public override void PrintStatus()
        {
            Console.WriteLine($"Fighter Jet: the flight number is {flightNumber}, Altitude: {altitude}, Armed: {missilesLoaded}");
        }
        public void FireMissile()
        {
            if (missilesLoaded == true)
            {
                Console.WriteLine("Missile fired!");
                missilesLoaded = false;
            }
        }

    }
}



