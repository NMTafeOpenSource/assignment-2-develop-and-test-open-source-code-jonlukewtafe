/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

import java.util.Random;
/**
 *
 * @author 20001833
 */
public class VehicleRental {

    /** Main entry point to the program
     * @param args the command line arguments
     */
    public static void main(String[] args) {        
            Vehicle v = new Vehicle("Ford", "T812", 2014, 1000000000, 25000, 120);
          //  Vehicle v = new Vehicle("Ford", "T812", 2014, 8746210831, 25000, 120);
		
            // Vehicle sample distance
            v.addFuel(new Random().nextDouble()*10, 1.3);

            v.printDetails();
            System.out.println("\n\n");
    }
    
}
