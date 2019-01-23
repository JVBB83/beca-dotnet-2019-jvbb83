using System.Collections.Generic;

namespace BusinessCore
{
    public class Vehicle
    {
        private int ID;
        private VehicleType eType;
        private Chassis chassis;
        private Bodywork bodywork;
        private Engine engine;
        private List<Wheel> wheels;
        private List<Door> doors;

        public Vehicle(VehicleType v)
        {
            this.ID = 0;
            this.eType = v;
            this.chassis = new Chassis();
            this.bodywork = new Bodywork();
            this.engine = new Engine();

            if (this.eType == VehicleType.Motorcycle)
            {
                this.wheels = new List<Wheel>();
                wheels.Add(new Wheel());
                wheels.Add(new Wheel());
                this.doors = null;
            }
            else if (this.eType == VehicleType.Quad)
            {
                this.wheels = new List<Wheel>();
                this.doors = null;
            }
        }


    }







}
