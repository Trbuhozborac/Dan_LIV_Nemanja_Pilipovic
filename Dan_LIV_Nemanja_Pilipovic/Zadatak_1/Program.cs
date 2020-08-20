using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Zadatak_1.Models;

namespace Zadatak_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Track> tracks = CreateTracks();
            List<Tractor> tractors = CreateTractors();
            List<Automobile> automobiles = CreateAutomobiles();

            Race();
        }

        #region Functions

        private static List<Track> CreateTracks()
        {
            List<Track> tracks = new List<Track>();
            Track track1 = new Track();
            Track track2 = new Track();
            tracks.Add(track1);
            tracks.Add(track2);
            return tracks;
        }

        private static List<Tractor> CreateTractors()
        {
            List<Tractor> tractors = new List<Tractor>();
            Tractor tractors1 = new Tractor();
            Tractor tractors2 = new Tractor();
            tractors.Add(tractors1);
            tractors.Add(tractors2);
            return tractors;
        }

        private static List<Automobile> CreateAutomobiles()
        {
            List<Automobile> automobiles = new List<Automobile>();
            Automobile automobile1 = new Automobile();
            Automobile automobile2 = new Automobile();
            automobiles.Add(automobile1);
            automobiles.Add(automobile2);
            return automobiles;
        }

        private static void Race()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Thread.Sleep(5000);
            sw.Stop();
            List<Automobile> automobilsForRace = CreateAutomobilsForRace();
            //TODO odavde krece trka
        }

        private static List<Automobile> CreateAutomobilsForRace()
        {
            List<Automobile> automobiles = new List<Automobile>();
            Automobile auto1 = new Automobile(2000, 1000, "Hatchback", "Diesel", "Black", 2, "NS111AA", 3, 50, "Manual", "Mazda", 1001);
            Automobile auto2 = new Automobile(1500, 800, "Limousine", "Gasoline", "White", 3, "NS112AA", 5, 45, "Automatic", "Opel", 1002);
            Automobile auto3 = new Automobile(1700, 1200, "Hatchback", "Diesel", "Red", 1, "NS113AA", 5, 60, "Manual", "BMW", 1003);
            Automobile auto4 = new Automobile(2500, 1500, "Hatchback", "Gasoline", "Purple", 2, "NS114AA", 3, 50, "Automatic", "Audi", 1004);
            Automobile auto5 = new Automobile(1400, 850, "Limousine", "Diesel", "Red", 1, "NS115AA", 5, 35, "Manual", "Mazda", 1005);
            Automobile golf = new Automobile(2200, 1100, "Hatchback", "Diesel", "Orange", 2, "NS116AA", 3, 55, "Manual", "Vw - Golf", 1006);

            automobiles.Add(auto1);
            automobiles.Add(auto2);
            automobiles.Add(auto3);
            automobiles.Add(auto4);
            automobiles.Add(auto5);
            automobiles.Add(golf);

            return automobiles;
        }
        #endregion
    }
}
