using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Lookout.Interfaces;

namespace TheLookOut.Services
{
    public class GenerateAnnouncementService : IGenerateAnnouncement
    {
        public string generateAnnouncement(string sightedObj, string Location)
        {
               
            // get the selectArticle to determine the article for the sighted object
            string getArticle = selectArticle(sightedObj);
            // generate the announcement
            string announcement = $"Ahoy,Captain, {getArticle} {sightedObj} off to {Location}!";
            return announcement;
        }

        public string getLocation()
        {
            Console.WriteLine("State the location");
            try
            {
                string Location = Console.ReadLine();
                if (Location == "")
                {
                    Console.WriteLine("Error: Location not stated");
                    return "";
                }
                return Location;
            }

            catch (Exception)
            {

                Console.WriteLine("Error: Location not stated");
                return "";
            }
        }

        public string getSightedObject()
        {
            //get inputs from a user
            Console.WriteLine("Welcome to the ship's lookout application, please enter your name:");
            string fullName = Console.ReadLine();

            // handle situation where user has not specified the name
            if (fullName == "")
                fullName = "User";

            // choose workout level
            Console.WriteLine($"Hello {fullName}, Please enter the sighted object");
            try
            {
                string sightedObj = Console.ReadLine();
                if (sightedObj == "")
                {
                    Console.WriteLine("Error:  Object name not entered");
                    return "";
                }
                return sightedObj;
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Object name not entered");
                return "";
            }
        }

        public string selectArticle(string sightedObj)
        {
            // change the first letter of the sighted object to lower get it          
            char getFirstLetter = sightedObj.Substring(0).ToLower()[0];

            // check if the first letter is a vowel
            if (getFirstLetter.Equals('a') || getFirstLetter.Equals('e') || getFirstLetter.Equals('i') || getFirstLetter.Equals('o') || getFirstLetter.Equals('u'))
                return "an";
            else
                return "a";
        }
    }
}
