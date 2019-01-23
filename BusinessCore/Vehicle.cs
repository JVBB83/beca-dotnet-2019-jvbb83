namespace BusinessCore
{
    public class Vehicle
    {
        private int ID;
        private VehicleType eType;
        private Chassis chassis;
        private Bodywork body;
        private Engine engine;
        private Wheel[] wheels;
        private Door[] doors;

        public Vehicle(VehicleType v)
        {
            this.ID = 0;
            this.eType = v;
            

        }

                          
    }







}
