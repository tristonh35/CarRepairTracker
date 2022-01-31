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

    }



}
