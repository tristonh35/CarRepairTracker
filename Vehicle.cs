using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRepairTracker
{
    public class Vehicle
    {   
        /// <summary>
        /// No arg constructor for the vehicle class
        /// </summary>
        public Vehicle() { }
        /// <summary>
        /// Represents the make of the vehicle
        /// </summary>
        public string Make { get; set; }
        /// <summary>
        /// Represents the model of the vehicle
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Represents the year of the vehicle
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Represents the VIN of the vehicle
        /// </summary>
        public string VIN { get; set; }

        /// <summary>
        /// Constructor with parameters for the Vehicle class.
        /// </summary>
        /// <param name="make"></param>
        /// <param name="model"></param>
        /// <param name="year"></param>
        /// <param name="vin"></param>
        public Vehicle(string make, string model, int year, string vin)
        {
            Make = make;
            Model = model;
            Year = year;
            VIN = vin;
            
            
        }
        /// <summary>
        /// Method that gets the make of a vehicle
        /// </summary>
        /// <returns>@Make</returns>
        public string getMake()
        {
            return Make;
        }
        /// <summary>
        /// Method that gets the model of the vehicle
        /// </summary>
        /// <returns>@Model</returns>
        public string getModel()
        {
            return Model;
        }
        /// <summary>
        /// Method that gets the year of the vehicle
        /// </summary>
        /// <returns>@Year</returns>
        public int getYear()
        {
            return Year;
        }

        /// <summary>
        /// Method that gets the vin of a vehicle
        /// </summary>
        /// <returns>@VIN</returns>
        public string getVin()
        {
            return VIN;
        }
    }
}
