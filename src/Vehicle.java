
public class Vehicle {

    private String manufacturer;
    private String model;
    private int makeYear;
    private long registrationNumber;
    private int odometerReading = 0;
    private int tankCapacity;

    private FuelPurchase fuelPurchase;

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
    public Vehicle(String manufacturer, String model, int makeYear, long registrationNumber, int odometerReading, int tankCapacity)
    {
        this.manufacturer = manufacturer;
        this.model = model;
        this.makeYear = makeYear;
        this.registrationNumber = registrationNumber;
        this.odometerReading = odometerReading;
        this.tankCapacity = tankCapacity;
        fuelPurchase = new FuelPurchase();
    }

    /**
     * Prints details for {@link Vehicle}
     */
    public void printDetails() {
        System.out.println("Vehicle: " + makeYear + " " + manufacturer + " " + model + " " + registrationNumber + " " + odometerReading + " " + tankCapacity);
        // TODO Display additional information about this vehicle
    }

    public void addKilometers() 
    {
        // TODO Create an addKilometers method which takes a parameter for distance travelled 
        // and adds it to the odometer reading.
    }
     
    
    // adds fuel to the car
    public void addFuel(double litres, double price) {
        fuelPurchase.purchaseFuel(litres, price);
    }

}
