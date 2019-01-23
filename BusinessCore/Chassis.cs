namespace BusinessCore
{
    class Chassis
    {
        private int ID;
        private string ChassisType;

        public Chassis()
        {
            this.ID = 0;
            this.ChassisType = "";

        }
        public void SetID(int i)
        {
            ID = i;
        }

        public int GetID()
        {
            return ID;
        }

    }







}
