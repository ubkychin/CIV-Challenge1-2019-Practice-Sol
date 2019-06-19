using System;
using System.Collections.Generic;
using System.Net.Configuration;

namespace Inheritence {
    internal class Program {
        public static void Main(string[] args) {
            List<Transport> transports = new List<Transport>();

            AeroPlane plane = new AeroPlane();
            plane.Make = "Boeing";
            plane.Model = "747";
            plane.Colour = "White";
            plane.PassengerLimit = 300;
            plane.WingSpan = 60;
            plane.Fly();
            plane.AddPassengers(200);
            transports.Add(plane);
            
            Ute ute = new Ute();
            ute.Make = "Holden";
            ute.Model = "Commodore";
            ute.Colour = "Pink";
            ute.CarryLimit = 10;
            ute.Load = 0;
            ute.AddLoad(8);
            transports.Add(ute);
            
            Sedan sedan = new Sedan();
            sedan.Make = "Ford";
            sedan.Model = "Falcon";
            sedan.Colour = "Purple";
            sedan.Doors = 4;
            sedan.PassengerLimit = 5;
            sedan.Passengers = 0;
            sedan.AddPassenger();
            sedan.AddPassenger();
            sedan.Drive();
            transports.Add(sedan);

            foreach(Transport t in transports) {
                Console.WriteLine($"{t.Make} \t {t.Model}");
            }

        }
    }

    public class Transport {
        public string Make;
        public string Model;
        public string Colour;
    }

    public class AeroPlane : Transport{
        public int WingSpan;
        public int PassengerLimit;
        public int Passengers;

        public void Fly() {
            Console.WriteLine("Whooosh!");
        }

        public bool AddPassengers(int p) {
            if (Passengers + p <= PassengerLimit) {
                Passengers += p;
                return true;
            }

            return false;
        }
        
    }

    public class Car : Transport {
        public int Wheels;
        public string Rego;

        public void Drive() {
            Console.WriteLine("Broooom Brooooom");
        }
    }

    public class Ute : Car {
        public int CarryLimit;
        public int Load;

        public bool AddLoad(int l) {
            if (CarryLimit + l <= Load) {
                CarryLimit += l;
                return true;
            }

            return false;
        }
    }

    public class Sedan : Car {
        public int Doors;
        public int PassengerLimit;
        public int Passengers;

        public bool AddPassenger() {
            if (Passengers + 1 <= PassengerLimit) {
                Passengers++;
                return true;
            }

            return false;
        }
    }
}