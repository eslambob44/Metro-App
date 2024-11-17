﻿using System;
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
            if(LineNumber==3) return clsStationDataAccessLayer.ListAllStationsInLineThatHaveBranch(LineNumber);
            else return clsStationDataAccessLayer.ListAllStationsInLine(LineNumber);
        }
    }
}
