using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using System.IO;

namespace assignment_2_car_rental_system
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Vehicle> vehicles;


        public MainWindow()
        {
            InitializeComponent();

            // Add vehicles to a new list of Vehicles
            vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle("Ford", "T812", 2014, "THA-HEL", 25000, 250));
            vehicles.Add(new Vehicle("Tesla", "M4", 2019, "WTF-HEL", 34986, 367));

            // Bind the list to the listview
            listView_vehicles.ItemsSource = vehicles;

        }

        private void listView_vehicles_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Vehicle ve = (Vehicle)listView_vehicles.SelectedItem;
            if (ve != null)
            {
                txtBlock_VehicleManufacturer.Text = ve.Manufacturer.ToString();
                txtBlock_VehicleModel.Text = ve.Model.ToString();
                txtBlock_ManufactureYear.Text = ve.MakeYear.ToString();
                txtBlock_FuelCapacity.Text = ve.TankCapacity.ToString();
                txtBlock_OdometerReading.Text = ve.OdometerReading.ToString();
                txtBlock_RegistrationNumber.Text = ve.RegistrationNumber.ToString();                
            }                        
        }

        private void btn_AddJourney_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)listView_vehicles.SelectedItem;
            
            if (ve != null && txtBox_AddKilometers.Text != null)
            {
                ve.addKilometers(Int32.Parse(txtBox_AddKilometers.Text));
                // TODO: Auto update ListView to show updated OdometerReading 
                txtBlock_OdometerReading.Text = ve.OdometerReading.ToString();


                
            }
        }

        private void btn_AddFuel_Click(object sender, RoutedEventArgs e)
        {
            Vehicle ve = (Vehicle)listView_vehicles.SelectedItem;
            
            if (ve != null && txtBox_AddKilometers.Text != null)
            {
                ve.FuelPurchase.purchaseFuel(Int32.Parse(txtBox_FuelLitres.Text), Int32.Parse(txtBox_Cost.Text)); 
            }
        }
    }
}
