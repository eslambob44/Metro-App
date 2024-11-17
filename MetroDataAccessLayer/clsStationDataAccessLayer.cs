using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
            SqlCommand Command = new SqlCommand(Query,Connection);
            Command.Parameters.AddWithValue("@LineNumber", LineNumber);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.HasRows)
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
    }
}
