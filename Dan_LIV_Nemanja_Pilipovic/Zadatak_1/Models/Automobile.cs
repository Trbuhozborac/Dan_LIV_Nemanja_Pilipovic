using System;

namespace Zadatak_1.Models
{
    class Automobile : MotorVehicle
    {
        #region Properties

        public string RegistrationNumber { get; set; }
        public int DoorsNumber { get; set; }
        public int TankVolume { get; set; }
        public string TransmissionType { get; set; }
        public string Manufacturer { get; set; }
        public int TrafficNumber { get; set; }
        public int Fuel { get; set; }

        #endregion

        #region Constructors

        public Automobile()
        {

        }

        public Automobile(double engineDisplacement, int weight, string category, string motorType, string color,
            int numberOfMotors, string registrationNumber, int doorsNumber, int tankVolume, string transmissionType,
            string manufacturer, int trafficNumber, int fuel)
        {
            EngineDisplacement = engineDisplacement;
            Weight = weight;
            Category = category;
            MotorType = motorType;
            Color = color;
            NumberOfMotors = numberOfMotors;
            RegistrationNumber = registrationNumber;
            DoorsNumber = doorsNumber;
            TankVolume = tankVolume;
            TransmissionType = transmissionType;
            Manufacturer = manufacturer;
            TrafficNumber = trafficNumber;
            Fuel = fuel;
        }

        #endregion

        #region Functions

        public override void Go()
        {
            throw new System.NotImplementedException();
        }

        public override void Stop()
        {
            throw new System.NotImplementedException();
        }

        public void RePaint(Automobile auto, string newColor, int newTrafficNumber)
        {
            auto.Color = newColor;
            auto.TrafficNumber = newTrafficNumber;
        }

        #endregion
    }
}
