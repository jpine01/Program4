// Grade ID: X2813
// Program 4
// CIS199 - 02
// Due: April 24, 2018
// This program has an array of package objects. Then it diplays the package information to the user.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program4
{
    class Program
    {
        // Main method
        static void Main(string[] args)
        {
            // Array of packages                              Origin / Destination / Length / Width / Height / Weight
            GroundPackage[] packageArray = { new GroundPackage(32958,    86932,       2.0,     4.0,    7.0,    20.00),
                                             new GroundPackage(00963,    40228,       8.0,     12.0,   6.0,    10.50),
                                             new GroundPackage(40218,    60345,       15.0,    6.0,    2.56,   9.38),
                                             new GroundPackage(00558,    99488,       9.98,    4.12,   3.0,    5.58),
                                             new GroundPackage(96587,    38966,       8.0,     7.0,    4.0,    18.64) };

            packageArray[2].Length = -7.89;
            packageArray[2].Width = -12;
            packageArray[2].Height = -3.69;
            packageArray[2].Weight = -1;
            packageArray[3].OriginZip = -00558;
            packageArray[4].DestinationZip = -38966;

            DisplayPackages(packageArray);
        }
        // Precondition: Must be an Array of packages
        // PostCondition: Displays the information of each package and how much it will cost to ship
        public static void DisplayPackages(GroundPackage[] array)
        {
            for (int x = 0; x < array.Length; ++x)
            {
                string dashes = "-------------------------------------";
                GroundPackage package = array[x];
                WriteLine(package.ToString());
                WriteLine($"{Environment.NewLine}Cost: {package.CalcCost():C}");
                WriteLine();
                WriteLine(dashes);
            }
        }
    }


    // Ground package class
    public class GroundPackage
    {
        private int _origZipCode; // Conatains the Origin Zipcode
        private int _destZipCode; // Contains the Destination ZipCode
        private double _lengthInInches; // Contains the Length of the package in Inches
        private double _widthInInches; // Contains the Width of the package in Inches
        private double _heightInInches; // Contains the Height of the package in Inches
        private double _weightInPounds; // Contains the Weight of the package in Pounds

        // Precondition: 0 < OriginZip < 99999
        //               0 < DestinationZip < 99999
        //               0 < Length
        //               0 < Width
        //               0 < Height
        //               0 < Weight
        // Postcondition: The Ground package object has been initialized with the specified
        //                Origin, Destination, Length, Width, Height, Weight
        public GroundPackage(int origZip, int destZip, double lengthInches, double widthInches, double heightInches, double weightPounds)
        {
            OriginZip = origZip; // Set the Origin Zipcode property
            DestinationZip = destZip; // Set the Destination Zipcode property
            Length = lengthInches; // Set the Length property
            Width = widthInches; // Set the Width property
            Height = heightInches; // Set the Height property
            Weight = weightPounds; // Set the Weight property
        }

        
        public int OriginZip
        {
            //Precondition: None
            //Postcondition: Returns the origin zipcode
            get
            {
                return _origZipCode;
            }
            //Precondition: Zip must be Between 0 - 99999
            //Postcondition: If it is a valid Zip it is assigned, if not the default gets assigned
            set
            {
                const int defaultMaxZip = 99999; //Default Max number

                if (value > 0 && value <= defaultMaxZip)
                {
                    _origZipCode = value;
                }
                else
                {
                    const int defaultOriginZip = 40202; // Default Origin Zip

                    _origZipCode = defaultOriginZip;
                }
            }
        }
        
        public int DestinationZip
        {
            // Precondition: none
            // Postcondition: Returns the destination zipcode
            get
            {
                return _destZipCode;
            }
            // Precondition: Zip must be Between 0 - 99999
            // Postcondition: If it is a valid Zip it is assigned, if not the default gets assigned
            set
            {
                const int defaultMaxZip = 99999; // Default Max number

                if (value > 0 && value <= defaultMaxZip)
                {
                    _destZipCode = value;
                }
                else
                {
                    const int defaultDestZip = 90210; // Default destination Zip

                    _destZipCode = defaultDestZip; 
                }
            }
        }
        
        public double Length
        {
            // Precondition: none
            // Postcondition: Returns the Length
            get
            {
                return _lengthInInches;
            }
            // Precondition: Must be a positive number greater than 0
            // Postcondition: If it is valid then it gets assigned, if not the default value gets assigned
            set
            {
                if(value > 0)
                {
                    _lengthInInches = value;
                }
                else
                {
                    const float defaultInches = 1.0f; // Default Length

                    _lengthInInches = defaultInches;
                }
            }
        }
        
        public double Width
        {
            // Precondition: none
            // Postcondition: Returns the Width
            get
            {
                return _widthInInches;
            }
            // Precondition: Must be a positive number greater than 0
            // Postcondition: If it is valid then it gets assigned, if not the default value gets assigned
            set
            {
                if (value > 0)
                {
                    _widthInInches = value;
                }
                else
                {
                    const float defaultInches = 1.0f; // Default Inches

                    _widthInInches = defaultInches; 
                }
            }
        }
        
        public double Height
        {
            // Precondition: none
            // Postcondition: Returns the Height
            get
            {
                return _heightInInches;
            }
            // Precondition: Must be a positive number greater than 0
            // Postcondition: If it is valid then it gets assigned, if not the default value gets assigned
            set
            {
                if (value > 0)
                {
                    _heightInInches = value;
                }
                else
                {
                    const float defaultInches = 1.0f; // Default Height

                    _heightInInches = defaultInches;
                }
            }
        }
        
        public double Weight
        {
            // Precondition: none
            // Postcondition: Returns the Weight
            get
            {
                return _weightInPounds;
            }
            // Precondition: Must be a positive number greater than 0
            // Postcondition: If it is valid then it gets assigned, if not the default value gets assigned
            set
            {
                if (value > 0)
                {
                    _weightInPounds = value;
                }
                else
                {
                    const float defaultPounds = 1.0f; // Default Weight

                    _weightInPounds = defaultPounds;
                }
            }
        }
        
        public int ZoneDistance
        {
            // Precondition: none
            // Postcondition: Returns the zone distance
            get
            {
                int denominator = 10000; // Holds the denominator by which we devide the zipcodes
                int origTemp = OriginZip; // Holds the value of the origin zipcode
                int destTemp = DestinationZip; //Holds the value of the destination zipcode

                destTemp = destTemp / denominator;
                origTemp = origTemp / denominator;

                int result = destTemp - origTemp; // Holds the result after the math is done

                return Math.Abs(result); // Turns the result to always be a positive result
            }
        }
        // Precondition: none
        // Postcondition: Returns a double that is the cost of the package
        public double CalcCost()
        {
            double sizeFactor = 0.20;
            double distanceWeightFactor = 0.5;
            double cost = sizeFactor * (Length + Width + Height) + distanceWeightFactor * (ZoneDistance + 1) * (Weight);
            return cost;
        }
        // Precondition: none
        // Postcondition: Returns a formatted string with the package information
        public override string ToString()
        {
            string content = ($"< Package Information > {Environment.NewLine}Origin ZipCode: [{OriginZip:D5}] {Environment.NewLine}Destination ZipCode: [{DestinationZip:D5}] {Environment.NewLine}Length: {Length} Inches {Environment.NewLine}Width: {Width} Inches {Environment.NewLine}Height: {Height} Inches {Environment.NewLine}Weight: {Weight} Pounds");

            return content;
        }

    }
}
