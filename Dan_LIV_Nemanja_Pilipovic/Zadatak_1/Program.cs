using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using Zadatak_1.Models;

namespace Zadatak_1
{
    static class Program
    {       
        static void Main(string[] args)
        {
            Queue<Track> tracks = CreateTracks();
            Stack<Tractor> tractors = CreateTractors();
            List<Automobile> automobiles = CreateAutomobiles();

            Race();
            
            Console.ReadLine();
        }

        #region Functions

        private static Queue<Track> CreateTracks()
        {
            Queue<Track> tracks = new Queue<Track>();
            Track track1 = new Track();
            Track track2 = new Track();
            tracks.Enqueue(track1);
            tracks.Enqueue(track2);
            return tracks;
        }

        private static Stack<Tractor> CreateTractors()
        {
            Stack<Tractor> tractors = new Stack<Tractor>();
            Tractor tractors1 = new Tractor();
            Tractor tractors2 = new Tractor();
            tractors.Push(tractors1);
            tractors.Push(tractors2);
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
            Console.WriteLine("Waiting Automobils to prepare for the Race");
            Console.WriteLine("Race starts is:");
            sw.Start();
            Thread.Sleep(1000);
            Console.WriteLine("5");
            Thread.Sleep(1000);
            Console.WriteLine("4");
            Thread.Sleep(1000);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            sw.Stop();
            List<Automobile> automobilsForRace = CreateAutomobilsForRace();

            Console.WriteLine("All Automobils are ready to start a rece!");
            Console.WriteLine("Race Started!");
            s.Start();
            foreach (Automobile automobile in automobilsForRace)
            {
                Thread thread = new Thread(() => StartRace(automobile));
                thread.Name = string.Format("Color: {0} Licence: {1}", automobile.Color, automobile.RegistrationNumber);
                thread.Start();
            }

            c.Wait();

           
        }

        private static void StartRace(Automobile auto)
        {
            int FuelSpend = r.Next(1, 3);
            int FuelVolume = r.Next(1, 50);

            while (s.ElapsedMilliseconds <= 10000)
            {
                if (s.ElapsedMilliseconds % 1000 == 0) { FuelVolume -= FuelSpend; Thread.Sleep(1); }

                if (FuelVolume <= 0)
                {
                    Console.WriteLine("{0} has run out of fuel.", Thread.CurrentThread.Name);
                    c.Signal();
                    Thread.CurrentThread.Abort();
                }
            }

            lock (TheLock)
            {
                if (!semaphore)
                {
                    Thread.Sleep(1);
                    Console.WriteLine("Automobiles have reached semaphore!");
                    semaphore = true;
                }
            }

            while (s.ElapsedMilliseconds <= 12000)
            {
                if (s.ElapsedMilliseconds % 1000 == 0) { FuelVolume -= FuelSpend; Thread.Sleep(1); }

                if (FuelVolume <= 0)
                {
                    Console.WriteLine("{0} has run out of fuel.", Thread.CurrentThread.Name);
                    c.Signal();
                    Thread.CurrentThread.Abort();
                }
            }

            while (s.ElapsedMilliseconds <= 13000)
            {
                if (s.ElapsedMilliseconds % 1000 == 0) { FuelVolume -= FuelSpend; Thread.Sleep(1); }

                if (FuelVolume <= 0)
                {
                    Console.WriteLine("{0} has run out of fuel.", Thread.CurrentThread.Name);
                    c.Signal();
                    Thread.CurrentThread.Abort();
                }
            }

            if (FuelVolume < 15)
            {
                lock (TheLock)
                {
                    Thread.Sleep(1);
                    Console.WriteLine("{0} is refuling", Thread.CurrentThread.Name);
                    FuelVolume = 50;
                }
            }

            while (s.ElapsedMilliseconds <= 20000)
            {
                if (s.ElapsedMilliseconds % 1000 == 0) { FuelVolume -= FuelSpend; Thread.Sleep(1); }

                if (FuelVolume <= 0)
                {
                    Console.WriteLine("{0} has run out of fuel.", Thread.CurrentThread.Name);
                    c.Signal();
                    Thread.CurrentThread.Abort();
                }
            }


            Console.WriteLine("{0} has finished the race!", Thread.CurrentThread.Name);

            if (Thread.CurrentThread.Name.Contains("Red"))
            {
                finish.Add(Thread.CurrentThread.Name);
            }

          
            c.Signal();

            if (finish.Count != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Fastest red automobile was: {0}", finish[0]);
               
            }
        }

        private static List<Automobile> CreateAutomobilsForRace()
        {
            List<Automobile> automobiles = new List<Automobile>();
            Automobile auto1 = new Automobile(2000, 1000, "Hatchback", "Diesel", "Red", 2, "NS111AA", 3, 50, "Manual", "Mazda", 1001,40);
            Automobile auto2 = new Automobile(1500, 800, "Limousine", "Gasoline", "White", 3, "NS112AA", 5, 45, "Automatic", "Opel", 1002,45);
            Automobile auto3 = new Automobile(1700, 1200, "Hatchback", "Diesel", "Red", 1, "NS113AA", 5, 60, "Manual", "BMW", 1003, 50);
            Automobile auto4 = new Automobile(2500, 1500, "Hatchback", "Gasoline", "Purple", 2, "NS114AA", 3, 50, "Automatic", "Audi", 1004, 50);
            Automobile auto5 = new Automobile(1400, 850, "Limousine", "Diesel", "Red", 1, "NS115AA", 5, 35, "Manual", "Mazda", 1005, 30);
            Automobile golf = new Automobile(2200, 1100, "Hatchback", "Diesel", "Orange Golf", 2, "NS116AA", 3, 55, "Manual", "Vw - Golf", 1006, 40);

            automobiles.Add(auto1);
            automobiles.Add(auto2);
            automobiles.Add(auto3);
            automobiles.Add(auto4);
            automobiles.Add(auto5);
            automobiles.Add(golf);

            return automobiles;
        }

        #endregion

        #region Static Fields and Objects

        static Stopwatch sw = new Stopwatch();
        public static object TheLock = new object();
        public static Stopwatch s = new Stopwatch();
        public static Random r = new Random();
        public static CountdownEvent c = new CountdownEvent(7);
        public static bool semaphore = false;
        public static ArrayList finish = new ArrayList();

        #endregion
    }
}
