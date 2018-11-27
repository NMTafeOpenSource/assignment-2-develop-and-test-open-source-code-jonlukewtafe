using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_car_rental_system
{
    class Vehicle
    {
        public String Manufacturer { get; set; }
        public String Model { get; set; }
        public int MakeYear { get; set; }
        public string RegistrationNumber { get; set; }
        public double OdometerReading { get; set; }
        public int TankCapacity { get; set; }

        public FuelPurchase FuelPurchase { get; set; }
        public Journey Journey { get; set; }

        /**
         * Class constructor specifying name of make (manufacturer), model and year
         * of make.
         *
         * @param manufacturer
         * @param model
         * @param makeYear
         * @param registrationNumber
         * @param odometerReading
         * @param tankCapacity
         */
        public Vehicle(String Manufacturer, String Model, int MakeYear, String RegistrationNumber, double OdometerReading, int TankCapacity)
        {
            this.Manufacturer = Manufacturer;
            this.Model = Model;
            this.MakeYear = MakeYear;
            this.RegistrationNumber = RegistrationNumber;
            this.OdometerReading = OdometerReading;
            this.TankCapacity = TankCapacity;
            FuelPurchase = new FuelPurchase();
            Journey = new Journey();
        }

        /**
         * Prints details for {@link Vehicle}
         */
        public void printDetails()
        {
          // TODO Display additional information about this vehicle
        }

        // Adds the distance travelled to the pre-existing odometer reading
        public void addKilometers(double KilometersTravelled)
        {
            Journey.addKilometers(KilometersTravelled);
            OdometerReading += KilometersTravelled;
        }


        // adds fuel to the car
        public void addFuel(double litres, double price)
        {
            FuelPurchase.purchaseFuel(litres, price);
        }
        
    }
}
