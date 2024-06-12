﻿using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;
using System.Collections.Generic;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: </remarks>
    /// <remarks>Date: </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            
            Console.WriteLine("Enter the item number of an appliance: ");
            
            long itemNumber;
            
            string input = Console.ReadLine();
            itemNumber = long.Parse(input);
            
            Appliance foundAppliance = null;
            
            foreach (var appliances in Appliances)
            {
                if (appliances.ItemNumber == itemNumber)
                {
                    foundAppliance = appliances;
                    break;
                }
            }
            
            if (foundAppliance == null)
            {
                Console.WriteLine("No appliances found with that item number.");
            }
            else
            {
                if (foundAppliance.IsAvailable)
                {
                    foundAppliance.Checkout();
                    Console.WriteLine($"Appliance \"{itemNumber}\" has been checked out.");
                }
                else
                {
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
        }
            // Write "Enter the item number of an appliance: "
            // Create long variable to hold item number

            // Get user input as string and assign to variable.
            // Convert user input from string to long and store as item number variable.

            // Create 'foundAppliance' variable to hold appliance with item number
            // Assign null to foundAppliance (foundAppliance may need to be set as nullable)

            // Loop through Appliances
            // Test appliance item number equals entered item number
            // Assign appliance in list to foundAppliance variable
            // Break out of loop (since we found what need to)

            // Test appliance was not found (foundAppliance is null)
            // Write "No appliances found with that item number."
            // Otherwise (appliance was found)
            // Test found appliance is available
            // Checkout found appliance

            // Write "Appliance has been checked out."
            // Otherwise (appliance isn't available)
            // Write "The appliance is not available to be checked out."

        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            Console.WriteLine("Enter brand to search for:");
            string brandToSearch = Console.ReadLine();
            List<Appliance> found = new List<Appliance>();

            foreach (var appliance in Appliances)
            {
                if (appliance.Brand.ToLower() == brandToSearch.ToLower())
                {
                    found.Add(appliance);
                }
            }
            DisplayAppliancesFromList(found, 0);
            // Write "Enter brand to search for:"

            // Create string variable to hold entered brand
            // Get user input as string and assign to variable.

            // Create list to hold found Appliance objects

            // Iterate through loaded appliances
            // Test current appliance brand matches what user entered
            // Add current appliance in list to found list


            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            Console.WriteLine("Possible options: ");
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");
            Console.WriteLine("Enter number of doors: ");

            string numberEntered = Console.ReadLine();
            int numberOfDoors = Convert.ToInt32(numberEntered);

            List<Appliance> found = new List<Appliance>();
            foreach (var appliance in Appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator refrigerator = (Refrigerator)appliance;
                    if (numberOfDoors == 0 || refrigerator.Doors == numberOfDoors)
                    {
                        found.Add(appliance);
                    }
                }
            }
            DisplayAppliancesFromList(found, 0);
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "2 - Double doors"
            // Write "3 - Three doors"
            // Write "4 - Four doors"

            // Write "Enter number of doors: "

            // Create variable to hold entered number of doors

            // Get user input as string and assign to variable

            // Convert user input from string to int and store as number of doors variable.

            // Create list to hold found Appliance objects

            // Iterate/loop through Appliances
            // Test that current appliance is a refrigerator
            // Down cast Appliance to Refrigerator
            // Refrigerator refrigerator = (Refrigerator) appliance;

            // Test user entered 0 or refrigerator doors equals what user entered.
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            Console.WriteLine("Possible options: ");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Residential");
            Console.WriteLine("2 - Commercial");
            Console.WriteLine("Enter grade: ");
          
            string gradeEntered = Console.ReadLine();
            string grade;
            if (gradeEntered == "0")
            {
                grade = "Any";
            }
            else if (gradeEntered == "1")
            {
                grade = "Residential";
            }
            else if (gradeEntered == "2")
            {
                grade = "Commercial";
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"

            // Write "Enter grade:"

            // Get user input as string and assign to variable

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)

            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."

            // Return to calling (previous) method
            // return;


            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");
            Console.Write("Enter voltage: ");
            string input = Console.ReadLine();

            int voltage;

            if (input == "0")
            {
                voltage = 0;
            }
            else if (input == "1")
            {
                voltage = 18;
            }
            else if (input == "2")
            {
                voltage = 24;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)appliance;
                    if (grade == "Any" || (grade == vacuum.Grade && (voltage == 0 || voltage == vacuum.BatteryVoltage)))
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"

            // Write "Enter voltage:"

            // Get user input as string
            // Create variable to hold voltage

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            // Create found variable to hold list of found appliances.

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Kitchen");
            Console.WriteLine("2 - Work site");
            Console.Write("Enter room type: ");

            string input = Console.ReadLine();
            double roomType;

            if (input == "0")
            {
                roomType = 'A';
            }
            else if (input == "1")
            {
                roomType = 'K';
            }
            else if (input == "2")
            {
                roomType = 'W';
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Microwave)
                {
                    Microwave microwave = (Microwave)appliance;
                    if (roomType == 'A' || roomType == microwave.RoomType)
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"

            // Write "Enter room type:"

            // Get user input as string and assign to variable

            // Create character variable that holds room type

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;

            // Create variable that holds list of 'found' appliances

            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");
            Console.Write("Enter sound rating: ");
            string input = Console.ReadLine();

            string soundRating;

            if (input == "0")
            {
                soundRating = "Any";
            }
            else if (input == "1")
            {
                soundRating = "Qt";
            }
            else if (input == "2")
            {
                soundRating = "Qr";
            }
            else if (input == "3")
            {
                soundRating = "Qu";
            }
            else if (input == "4")
            {
                soundRating = "M";
            }
            else
            {
                Console.WriteLine("Invalid option.");
                return;
            }

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (soundRating == "Any" || soundRating == dishwasher.SoundRating)
                    {
                        found.Add(appliance);
                    }
                }
            }

            DisplayAppliancesFromList(found, 0);

            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"

            // Write "Enter sound rating:"

            // Get user input as string and assign to variable

            // Create variable that holds sound rating

            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method

            // Create variable that holds list of found appliances

            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            Console.WriteLine("Appliance Types");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 – Refrigerators");
            Console.WriteLine("2 – Vacuums");
            Console.WriteLine("3 – Microwaves");
            Console.WriteLine("4 – Dishwashers");
            Console.Write("Enter type of appliance: ");
            string applianceType = Console.ReadLine();

            Console.Write("Enter number of appliances: ");
            string numInput = Console.ReadLine();
            int num = Convert.ToInt32(numInput);

            List<Appliance> found = new List<Appliance>();

            foreach (Appliance appliance in Appliances)
            {
                if (applianceType == "0")
                {
                    found.Add(appliance);
                }
                else if (applianceType == "1" && appliance is Refrigerator)
                {
                    found.Add(appliance);
                }
                else if (applianceType == "2" && appliance is Vacuum)
                {
                    found.Add(appliance);
                }
                else if (applianceType == "3" && appliance is Microwave)
                {
                    found.Add(appliance);
                }
                else if (applianceType == "4" && appliance is Dishwasher)
                {
                    found.Add(appliance);
                }
            }

            found.Sort(new RandomComparer());

            DisplayAppliancesFromList(found, num);
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"

            // Write "Enter type of appliance:"

            // Get user input as string and assign to appliance type variable

            // Write "Enter number of appliances: "

            // Get user input as string and assign to variable

            // Convert user input from string to int

            // Create variable to hold list of found appliances

            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
        }
    }
}
