using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroDataAccessLayer;
using System.Data;
namespace Metro_business_layer
{
    static public class clsStation
    {
        public static DataTable ListStations(float LineNumber)
        {
            if (LineNumber == 3) return clsStationDataAccessLayer.ListAllStationsInLineThatHaveBranch(LineNumber);
            else return clsStationDataAccessLayer.ListAllStationsInLine(LineNumber);
        }

        

        public static DataTable GetStationLines(string StationName)
        {
            return clsStationDataAccessLayer.GetStationLines(StationName);
        }

        public static DataTable ListStationsByLikeName(string StationName)
        {
            return clsStationDataAccessLayer.GetStationsByLikeName(StationName);
        }

        public static string GetDirectionName (float LineNumber , string StationFrom , string StationTo)
        {
            return clsStationDataAccessLayer.GetDirectionOfLine(LineNumber , StationFrom , StationTo);  
        }

        

        

        

        
    }
}
