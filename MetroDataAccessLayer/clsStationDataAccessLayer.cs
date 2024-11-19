using System;
using System.Data;
using System.Data.SqlClient;

namespace MetroDataAccessLayer
{
    static public class clsStationDataAccessLayer
    {
        static public DataTable GetStationsByLikeName(string StationName)
        {
            DataTable dt = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select StationName From Stations
                        Where StationName Like N'%'+@StationName+'%'";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StationName", StationName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows) dt.Load(Reader);

                Reader.Close();
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return dt;
        }

        static public int GetStationIDByName(string StationName)
        {
            int StationID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select StationID From Stations Where StationName = @StationName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StationName", StationName);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int Test))
                {
                    StationID = Test;
                }

            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return StationID;
        }

        static public bool SaveStationLineAndOrder(int StationID, float Line, short Order)
        {

            bool IsInserted = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);

            string Query = @"Insert Into [Line'sStations] (StationID , StationOrder , LineNumber )
                            Values (@StationID , @Order , @Line)";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StationID", StationID);
            Command.Parameters.AddWithValue("@Line", Line);
            Command.Parameters.AddWithValue("@Order", Order);
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                IsInserted = (RowsAffected > 0);
            }
            catch
            {

            }
            finally
            {
                Connection.Close();
            }
            return IsInserted;
        }

        static public DataTable ListAllStationsInLine(float LineNumber)
        {
            DataTable dtStations = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select StationName From FullStationInfo
                            Where LineNumber = @LineNumber
                            Order By LineNumber , StationOrder;";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LineNumber", LineNumber);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dtStations.Load(Reader);
                }
                Reader.Close();
            }
            catch { }
            finally
            {
                Connection.Close();
            }
            return dtStations;
        }

        static public DataTable ListAllStationsInLineThatHaveBranch(float LineNumber)
        {
            DataTable dtStations = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @" Select C.StationName From 
                                (Select * From FullStationInfo
                                Where LineNumber = @LineNumber
                                union

                                Select B.* From
                                (
                                    Select * From FullStationInfo
                                    Where LineNumber = @LineNumber)A
                                    full join
                                    (Select * From FullStationInfo
                                    Where LineNumber = @BranchLineNumber
                                )B
                                on A.StationID = B.StationID
                                Where A.StationID is null)C


                                Order By LineNumber , StationOrder";


            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LineNumber", LineNumber);
            Command.Parameters.AddWithValue("@BranchLineNumber", LineNumber + 0.5);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dtStations.Load(Reader);
                }
                Reader.Close();
            }
            catch { }
            finally
            {
                Connection.Close();
            }
            return dtStations;
        }

        static public float GetIntersectionLineBetweenTwoStations(string StationFrom, string StationTo)
        {
            float Line = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select Top 1 LineNumber From FullStationInfo
                             Where StationName in ( @StationFrom , @StationTo)
                             group by LineNumber
                             Having Count(LineNumber) =2";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StationFrom", StationFrom);
            Command.Parameters.AddWithValue("@StationTo", StationTo);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    Line = Convert.ToSingle(Result.ToString());
                }
            }
            catch { }
            finally
            {
                Connection.Close();
            }

            return Line;

        }
        static private void _Swap(ref short Num1, ref short Num2)
        {
            short Temp = Num1;
            Num1 = Num2;
            Num2 = Temp;
        }

        static public DataTable GetTheRoadBetweenTwoStationsInTheSameLine(float LineNumber, short StationFromOrder, short StationToOrder)
        {
            DataTable dtStations = new DataTable();
            string Order = "ASC";
            if (StationFromOrder > StationToOrder)
            {
                _Swap(ref StationFromOrder, ref StationToOrder);
                Order = "DESC";
            }
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select StationName , LineNumber  From FullStationInfo
                            Where StationOrder between (@StationFromOrder)  and (@StationToOrder)
                            and LineNumber =@LineNumber
                            Order By StationOrder " + Order;

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LineNumber", LineNumber);
            Command.Parameters.AddWithValue("@StationFromOrder", StationFromOrder);
            Command.Parameters.AddWithValue("@StationToOrder", StationToOrder);

            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dtStations.Load(Reader);
                }
                Reader.Close();
            }
            catch { }
            finally
            {
                Connection.Close();
            }
            return dtStations;
        }

        static public DataTable GetTheRoadBetweenTwoStationsInTheSameLine(float LineNumber, string StationFrom, string StationTo)
        {
            short StationFromOrder = GetStationOrderInLine(StationFrom, LineNumber);
            short StationToOrder = GetStationOrderInLine(StationTo, LineNumber);
            if (StationFromOrder != -1 && StationToOrder != -1)
            {
                return GetTheRoadBetweenTwoStationsInTheSameLine(LineNumber, StationFromOrder, StationToOrder);
            }
            else
            {
                return null;
            }
        }

        static public short GetStationOrderInLine(string StationName, float LineNumber)
        {
            short StationOrder = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select StationOrder From FullStationInfo
                             Where StationName = @StationName and LineNumber =@LineNumber";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StationName", StationName);
            Command.Parameters.AddWithValue("@LineNumber", LineNumber);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    StationOrder = Convert.ToInt16(Result.ToString());
                }
            }
            catch { }
            finally { Connection.Close(); }
            return StationOrder;
        }


        static public DataTable ListTransferStationsThatConnectTwoLines(float LineNumberFrom, float LineNumberTo)
        {
            DataTable dtStations = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select StationID , StationName,StationOrder , LineNumber From FullStationInfo
                             Where StationName in 
                             	  (
                             	  Select Distinct StationName From FullTransferStationInfo
                             	  Where LineNumber in (@LineNumberFrom,@LineNumberTO)
                             	  Group by StationName
                             	  having Count(LineNumber) =2
                             	  )
                             and LineNumber in(@LineNumberFrom);";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LineNumberFrom", LineNumberFrom);
            Command.Parameters.AddWithValue("@LineNumberTo", LineNumberTo);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dtStations.Load(Reader);
                }
                Reader.Close();
            }
            catch { }
            finally { Connection.Close(); }
            return dtStations;
        }

        static public DataTable GetStationLines(string StationName)
        {
            DataTable dtLines = new DataTable();
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select LineNumber From FullStationInfo
                            Where StationName = @StationName";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StationName", StationName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dtLines.Load(Reader);
                }
                Reader.Close();
            }
            catch { }
            finally { Connection.Close(); }
            return dtLines;
        }

        static public short GetRoadPrice(short NumberOfStations)
        {
            short Price = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"
                            Select Price From Prices
                            Where StationCount =
                            case
                                when @NumberOfStations <0 then null
                            	when (Select Top 1 StationCount From Prices
                            			Where @NumberOfStations<=StationCount) is not null
                            	then (Select Top 1 StationCount From Prices
                            					Where @NumberOfStations<=StationCount)
                            	else (Select Top 1  StationCount From Prices
                            		Order By StationCount DESC)
                            end ";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@NumberOfStations", NumberOfStations);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    Price = Convert.ToInt16(Result);
                }
            }
            catch { }
            finally { Connection.Close(); }
            return Price;
        }

        static public short GetStationsCountBetweenTwoStationsInTheSameLine(float LineNumber , short StationFromOrder , short StationToOrder)
        {
            short Count = -1;
            if (StationFromOrder > StationToOrder)
            {
                _Swap(ref StationFromOrder, ref StationToOrder);
            }
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select Count(StationID)  From FullStationInfo
                            Where StationOrder between (@StationFromOrder)  and (@StationToOrder)
                            and LineNumber =@LineNumber";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LineNumber", LineNumber);
            Command.Parameters.AddWithValue("@StationFromOrder", StationFromOrder);
            Command.Parameters.AddWithValue("@StationToOrder", StationToOrder);

            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if (Result != null)
                {
                    Count = Convert.ToInt16(Result.ToString());
                }
            }
            catch { }
            finally
            {
                Connection.Close();
            }
            return Count;
        }

        static public short GetStationsCountBetweenTwoStationsInTheSameLine(float LineNumber, string StationFrom, string StationTo)
        {
            short StationFromOrder = GetStationOrderInLine(StationFrom, LineNumber);
            short StationToOrder = GetStationOrderInLine(StationTo, LineNumber);
            if (StationFromOrder != -1 && StationToOrder != -1)
            {
                return GetStationsCountBetweenTwoStationsInTheSameLine(LineNumber, StationFromOrder, StationToOrder);
            }
            else
            {
                return -1;
            }
        }

        static public string GetDirectionOfLine(float Line , short StationFromOrder , short StationToOrder)
        {
            string DirectionName = null;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);
            string Query = @"
                            Select Direction =
                            case
                        	    when @StationFromOrder < @StationToOrder 
                                then (Select Top 1 StationName From FullStationInfo
                        	    			Where LineNumber =@LineNumber
                        	    			Order By StationOrder DESC)
                        	    else (Select Top 1 StationName From FullStationInfo
                        	    			Where LineNumber =@LineNumber
                        	    			Order By StationOrder ASC)
                            end";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@LineNumber", Line);
            Command.Parameters.AddWithValue("@StationFromOrder", StationFromOrder);
            Command.Parameters.AddWithValue("@StationToOrder", StationToOrder);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if(Result != null)
                {
                    DirectionName = Result.ToString();
                }
            }
            catch { }
            finally { Connection.Close(); }
            return DirectionName;

        }
        static public string GetDirectionOfLine(float Line, string StationFrom, string StationTo)
        {
            short StationFromOrder = GetStationOrderInLine(StationFrom, Line);
            short StationToOrder = GetStationOrderInLine(StationTo, Line);
            if (StationFromOrder != -1 && StationToOrder != -1)
            {
                return GetDirectionOfLine(Line, StationFromOrder, StationToOrder);
            }
            else
            {
                return null;
            }
        }
    }

    
}
