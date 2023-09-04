using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Lookout.Interfaces;
using TheLookOut.Services;

namespace TheLookOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // register dependencies            
            var serviceProvider = new ServiceCollection().AddSingleton<IGenerateAnnouncement, GenerateAnnouncementService>().BuildServiceProvider();
            
            // Resolve dependencies
            var announcementService = serviceProvider.GetRequiredService<IGenerateAnnouncement>();
            // get Object sighted
            var sightedObj = announcementService.getSightedObject();
            // get location sighted
            var location = announcementService.getLocation();
            // handle exceptions
            try
            {
                // generate announcement
                var announcement = announcementService.generateAnnouncement(sightedObj, location);
                Console.WriteLine(announcement);
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Make sure location and sighted object are specified");
                return;
            }
               


        }
    }
}
