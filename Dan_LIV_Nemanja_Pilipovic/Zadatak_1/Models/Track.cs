namespace Zadatak_1.Models
{
    class Track : MotorVehicle
    {
        #region Properties

        public double LoadCapacity { get; set; }
        public double Heigth { get; set; }
        public int SeatsNumber { get; set; }

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

        public void Load()
        {

        }

        public void Unload()
        {

        }

        #endregion
    }
}
