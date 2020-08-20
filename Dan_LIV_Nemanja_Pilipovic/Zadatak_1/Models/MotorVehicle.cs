namespace Zadatak_1.Models
{
    public abstract class MotorVehicle
    {
        #region Properties

        public double EngineDisplacement { get; set; }
        public int Weight { get; set; }
        public string Category { get; set; }
        public string MotorType { get; set; }
        public string Color { get; set; }
        public int NumberOfMotors { get; set; }

        #endregion

        #region Functions

        public abstract void Go();
        public abstract void Stop();

        #endregion
    }
}
