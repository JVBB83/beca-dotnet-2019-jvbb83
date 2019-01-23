namespace BusinessCore
{
    public class Vehicle
    {
        private int ID;
        private VehicleType eType;
        private Chassis chassis;
        private Bodywork bodywork;
        private Engine engine;
        private Wheel[] wheels;
        private Door[] doors;

        public Vehicle(VehicleType v)
        {
            this.ID = 0;
            this.eType = v;
            this.chassis = new Chassis();
            this.bodywork = new Bodywork();
            this.engine = new Engine();

            if (this.eType == VehicleType.Motorcycle)
            {
                this.wheels = new Wheel[]
                {
                    new Wheel(),
                    new Wheel(),
                };
                this.doors = null;
            }
            else if (this.eType == VehicleType.Quad)
            {
                this.wheels = new Wheel[]
                {
                    new Wheel(),
                    new Wheel(),
                    new Wheel(),
                    new Wheel(),
                };
                this.doors = null;
            }
        }


    }







}
