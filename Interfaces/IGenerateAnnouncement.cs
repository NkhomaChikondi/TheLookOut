using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Lookout.Interfaces
{
    public interface IGenerateAnnouncement
    {
        string generateAnnouncement(string sightedObj, string Location);
        string selectArticle (string sightedObj);
        string getLocation();
        string getSightedObject();
    }
}
