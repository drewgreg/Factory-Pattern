namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfWheels;
            bool input = false;

            do
            {
                Console.WriteLine("Enter the amount of wheels for vehicle you would like to create.");

                input = int.TryParse(Console.ReadLine(), out numberOfWheels);

            } while (input == false);

            var vehicle = VehicleFactory.GetVehicle(numberOfWheels);

            vehicle.Drive();
        }
    }
}
