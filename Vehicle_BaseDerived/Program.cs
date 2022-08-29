namespace Vehicle_BaseDerived
{
    public class Program
    {
        public static void Main(String[] args)
        {
            VehicleDerived car1 = new VehicleDerived(4, "Sedan", "Honda", "Amaze");
            car1.display();

        }
    }
    public class VehicleBase
    {
        public int noOfWheels;
        public string vehicleType;
        public string company;

        public VehicleBase(int noOfWheels, string vehicleType, string company)
        {
            this.noOfWheels = noOfWheels;
            this.vehicleType = vehicleType;
            this.company = company;
        }
    }

    public class VehicleDerived : VehicleBase
    {
        private string modelName;
        public VehicleDerived(int noOfWheels, string vehicleType, string company, string modelName) : base(noOfWheels, vehicleType, company)
        {
            this.modelName = modelName;
        }

        public void display()
        {
            Console.WriteLine("No of Wheels - " + base.noOfWheels +
                                "\nVehicle Type - " + base.vehicleType +
                                "\nCompany - " + base.company +
                                "\nModel Name - " + this.modelName);
        }

    }

   
}



