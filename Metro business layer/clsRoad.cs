using MetroDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro_business_layer
{
    public class clsRoad
    {
        public DataTable dtRoad {  get; }
        public short StationsCount {  get;  }
        public short Price {  get; }
        static private bool IsThereTransfer = false;
        private bool _IsThereTransfer;
        public string Message { get; }
        private clsRoad(DataTable dtRoad , short StationsCount ,short Price , bool IsThereTransfer )
        {
            this.dtRoad = dtRoad;
            this.StationsCount = StationsCount;
            this.Price = Price;
            this._IsThereTransfer = IsThereTransfer;
            this.Message = _GenerateMessage();
        }

        private static DataTable _GetRoadBetweenTwoStationsRoadInTheSameLine(string StationFrom, string StationTo)
        {
            float IntersectLine = _GetIntersectLine(StationFrom, StationTo);
            if (IntersectLine != -1) return clsStationDataAccessLayer.GetTheRoadBetweenTwoStationsInTheSameLine(IntersectLine, StationFrom, StationTo);
            else return null;
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
            DataTable dtStationFromLines = clsStation.GetStationLines(StationFrom);
            DataTable dtStationToLines = clsStation.GetStationLines(StationTo);
            DataTable dtTransferStations = _GetTransferStationsConnectTwoLines(dtStationFromLines, dtStationToLines);
            string TransferStation = _GetNearestTransferStation(dtTransferStations, StationFrom);
            return TransferStation;
        }


        private static DataTable _GetRoadBetweenTwoStationsInDifferentLine(string StationFrom, string StationTo)
        {
            string TransferStation = _GetNearestTransferStation(StationFrom, StationTo);
            DataTable dtStations = GetRoad(StationFrom, TransferStation).dtRoad;
            dtStations.Merge(GetRoad(TransferStation, StationTo).dtRoad);
            return dtStations;

        }

        private static float _GetIntersectLine(string StationFrom, string StationTo)
        {
            return clsStationDataAccessLayer.GetIntersectionLineBetweenTwoStations(StationFrom, StationTo);
        }


        public static clsRoad GetRoad(string StationFrom, string StationTo)
        {
            bool IsThereTransfer = false;
            DataTable dtStations = new DataTable();
            if (_GetIntersectLine(StationFrom, StationTo) != -1)
            {
                dtStations = _GetRoadBetweenTwoStationsRoadInTheSameLine(StationFrom, StationTo);
            }
            else
            {
                dtStations = _GetRoadBetweenTwoStationsInDifferentLine(StationFrom, StationTo);
                IsThereTransfer = true;
            }

            if (dtStations == null) return null;
            else
            {
                short Count = _GetRoadCount(dtStations);
                short Price = _GetRoadPrice(Count);
                
                return new clsRoad(dtStations,Count, Price, IsThereTransfer);
            }
        }

        private static short _GetRoadCount(DataTable dtStations)
        {
            return (short)(dtStations.Rows.Count - 1);
        }

        private static short _GetRoadCountBetweenTwoStationsInTheSameLine(string StationFrom, string StationTo)
        {
            float Line = _GetIntersectLine(StationFrom, StationTo);
            return clsStationDataAccessLayer.GetStationsCountBetweenTwoStationsInTheSameLine(Line, StationFrom, StationTo);
        }

        private static short _GetRoadCountBetweenTwoStationsInDifferentLine(string StationFrom, string StationTo)
        {
            string TransferStation = _GetNearestTransferStation(StationFrom, StationTo);
            short Count = _GetRoadCountBetweenTwoStationsInTheSameLine(StationFrom, TransferStation);
            Count += _GetRoadCountBetweenTwoStationsInTheSameLine(TransferStation, StationTo);
            Count -= 1;
            return Count;

        }

        public static short GetRoadCount(string StationFrom, string StationTo)
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

        private static short _GetRoadPrice(short NumberOfStations)
        {
            return clsStationDataAccessLayer.GetRoadPrice(NumberOfStations);
        }

        public static short GetRoadPrice(string StationFrom, string StationTo)
        {
            short NumberOfStations = GetRoadCount(StationFrom, StationTo);
            return _GetRoadPrice(NumberOfStations);
        }

        string _ConvertLineFloatIntoString(float LineNumber)
        {
            switch (LineNumber)
            {
                case 1:
                    return "الأول";
                case 2:
                    return "التاني";
                case 3:
                case (float)3.5:
                    return "الثالث";
                default:
                    return null;
            }
        }

        string _GetStationFrom()
        {
            return (string)dtRoad.Rows[0]["StationName"];
        }
        string _GetStationTo()
        {
            return (string)dtRoad.Rows[dtRoad.Rows.Count-1]["StationName"];
        }

        string _GetTransferStationIfExists()
        {
            if (!_IsThereTransfer) return null;
            double Line = (double)dtRoad.Rows[0]["LineNumber"];
            DataRow[] Rows = dtRoad.Select("LineNumber = " + Line);
            return (string)Rows[Rows.Length - 1]["StationName"];
        }

        private string _GenerateMessageWithTransfer()
        {

            double LineFrom = (double)dtRoad.Rows[0]["LineNumber"];
            double LineTo = (double)dtRoad.Rows[dtRoad.Rows.Count-1]["LineNumber"];
            string StationFrom = _GetStationFrom();
            string StationTo = _GetStationTo();
            string TransferStation = _GetTransferStationIfExists();
            string Direction1 = clsStation.GetDirectionName((float)LineFrom, StationFrom, TransferStation);
            string Direction2 = clsStation.GetDirectionName((float)LineTo, TransferStation, StationTo);
            string Message = $"هتركب الخط {_ConvertLineFloatIntoString((float)LineFrom)} إتجاه {Direction1} وهتحول من {TransferStation} للخط {_ConvertLineFloatIntoString((float)LineTo)} إتجاه {Direction2} ";
            return Message;
        }

        private string _GenerateWithoutTransfer()
        {
            double Line = (double)dtRoad.Rows[0]["LineNumber"];
            string StationFrom = _GetStationFrom();
            string StationTo = _GetStationTo();
            string Direction = clsStation.GetDirectionName((float)Line , StationFrom, StationTo);
            string Message = $"هتركب الخط {_ConvertLineFloatIntoString((float)Line)} إتجاه {Direction} ومفيش تحويلات";
            return Message ;
        }

        private string _GenerateMessage()
        {
            if(!_IsThereTransfer)
            {
                return _GenerateWithoutTransfer();
            }
            else
            {
                return _GenerateMessageWithTransfer();
            }
        }
    }
}
