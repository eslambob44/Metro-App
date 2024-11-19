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

        private static DataTable _GetTwoStationsRoadInTheSameLine(string StationFrom, string StationTo)
        {
            float IntersectLine = _GetIntersectLine(StationFrom, StationTo);
            if (IntersectLine != -1) return clsStationDataAccessLayer.GetTheRoadBetweenTwoStationsInTheSameLine(IntersectLine, StationFrom, StationTo);
            else return null;
        }

        private static DataTable _GetStationLines(string StationName)
        {
            return clsStationDataAccessLayer.GetStationLines(StationName);
        }

        private static DataTable _GetTransferStationsConnectTwoLines(DataTable dtStationFromLines, DataTable dtStationToLines)
        {
            DataTable dtStations = new DataTable();
            dtStations.Columns.Add("StationID", typeof(short));
            dtStations.Columns.Add("StationName", typeof(string));
            dtStations.Columns.Add("StationOrder", typeof(byte));
            dtStations.Columns.Add("LineNumber", typeof(double));
            foreach (DataRow Row1 in dtStationFromLines.Rows)
            {

                float Line1 = Convert.ToSingle(Row1["LineNumber"]);
                foreach (DataRow Row2 in dtStationToLines.Rows)
                {
                    float Line2 = Convert.ToSingle(Row2["LineNumber"]);
                    DataTable Temp = clsStationDataAccessLayer.ListTransferStationsThatConnectTwoLines(Line1, Line2);
                    if (Temp.Columns.Count > 0) dtStations.Merge(Temp);
                }
            }
            return dtStations;
        }

        static private int _GetDifferencesBetweenTwoStationsInSameLine(string StationFrom, string StationTo, float Line)
        {
            int StationFromOrder = clsStationDataAccessLayer.GetStationOrderInLine(StationFrom, Line);
            int StationToOrder = clsStationDataAccessLayer.GetStationOrderInLine(StationTo, Line);
            int Difference = StationToOrder - StationFromOrder;
            Difference *= (Difference < 0) ? -1 : 1;
            return Difference;
        }

        private static string _GetNearestTransferStation(DataTable dtTransferStations, string StationFrom)
        {
            if (dtTransferStations.Rows.Count == 1)
            {
                return (string)dtTransferStations.Rows[0]["StationName"];
            }
            int Index = 0, Min = 100;

            for (int i = 0; i < dtTransferStations.Rows.Count; i++)
            {
                float Line = Convert.ToSingle(dtTransferStations.Rows[i]["LineNumber"]);


                int Difference = _GetDifferencesBetweenTwoStationsInSameLine(StationFrom, (string)dtTransferStations.Rows[i]["StationName"], Line);
                if (Difference < Min)
                {
                    Index = i;
                    Min = Difference;
                }
            }
            return (string)dtTransferStations.Rows[Index]["StationName"];
        }

        private static string _GetNearestTransferStation(string StationFrom, string StationTo)
        {
            DataTable dtStationFromLines = _GetStationLines(StationFrom);
            DataTable dtStationToLines = _GetStationLines(StationTo);
            DataTable dtTransferStations = _GetTransferStationsConnectTwoLines(dtStationFromLines, dtStationToLines);
            string TransferStation = _GetNearestTransferStation(dtTransferStations, StationFrom);
            return TransferStation;
        }

        private static DataTable _GetTwoStationsInDifferentLine(string StationFrom, string StationTo)
        {
            string TransferStation = _GetNearestTransferStation(StationFrom, StationTo);
            DataTable dtStations = GetRoad(StationFrom, TransferStation);
            dtStations.Merge(GetRoad(TransferStation, StationTo));
            return dtStations;

        }

        private static float _GetIntersectLine(string StationFrom, string StationTo)
        {
            return clsStationDataAccessLayer.GetIntersectionLineBetweenTwoStations(StationFrom, StationTo);
        }


        public static DataTable GetRoad(string StationFrom, string StationTo)
        {

            if (_GetIntersectLine(StationFrom, StationTo) != -1)
            {
                return _GetTwoStationsRoadInTheSameLine(StationFrom, StationTo);
            }
            else
            {
                return _GetTwoStationsInDifferentLine(StationFrom, StationTo);
            }
        }

        public static short GetRoadCount(DataTable dtStations)
        {
            return (short)(dtStations.Rows.Count - 1);
        }

        private static short _GetRoadCountBetweenTwoStationsInTheSameLine(string StationFrom , string StationTo)
        {
            float Line = _GetIntersectLine(StationFrom , StationTo);
            return clsStationDataAccessLayer.GetStationsCountBetweenTwoStationsInTheSameLine(Line , StationFrom , StationTo);
        }

        private static short _GetRoadCountBetweenTwoStationsInDifferentLine(string StationFrom , string StationTo)
        {
            string TransferStation = _GetNearestTransferStation(StationFrom, StationTo);
            short Count = _GetRoadCountBetweenTwoStationsInTheSameLine(StationFrom,TransferStation);
            Count += _GetRoadCountBetweenTwoStationsInTheSameLine(TransferStation, StationTo);
            Count -= 1;
            return Count;

        }

        public static short GetRoadCount(string StationFrom , string StationTo)
        {
            if (_GetIntersectLine(StationFrom, StationTo) != -1)
            {
                return _GetRoadCountBetweenTwoStationsInTheSameLine(StationFrom, StationTo);
            }
            else
            {
                return _GetRoadCountBetweenTwoStationsInDifferentLine(StationFrom, StationTo);
            }
        }

        public static short GetRoadPrice(short NumberOfStations)
        {
            return clsStationDataAccessLayer.GetRoadPrice(NumberOfStations);
        }
    }
}
