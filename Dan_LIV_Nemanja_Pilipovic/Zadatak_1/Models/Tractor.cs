namespace Zadatak_1.Models
{
    class Tractor : MotorVehicle
    {
        #region Properties

        public double TireSize { get; set; }
        public int WheelBase { get; set; }
        public string Drive { get; set; }

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

        #endregion
    }
}
