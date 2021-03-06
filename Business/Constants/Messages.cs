﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Added Car";
        public static string CarNameInvalid = "Car name is invalid";
        public static string MaintenanceTime = "The system is under maintenance";
        public static string CarsListed = "Cars listed";
        public static string CarDeleted = "Deleted Car";
        public static string CarUpdated = "Updated Car";
        public static string RentalCar = "Car Rented";
        public static string RentalDeleted = "Deleted Rental";
        public static string RentalUpdated = "Updated Rental";
        public static string RentalsListed = "Rentals listed";
        public static string NotCarRented = "The car was not rented";
        internal static string CarImageCountOfCarError = "The number of pictures of the car cannot be more than five.";
        public static string AuthorizationDenied = "You are not authorized";
    }
}
