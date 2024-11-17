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
            Command.Parameters.AddWithValue("@StationName" , StationName);
            try
            {
                Connection.Open();
                SqlDataReader Reader = Command.ExecuteReader();
                if(Reader.HasRows) dt.Load(Reader);

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
            SqlConnection Connection = new SqlConnection( clsDataAccessLayerSettings._ConnectionString);
            string Query = @"Select StationID From Stations Where StationName = @StationName";
            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StationName", StationName);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar();
                if(Result !=null && int.TryParse(Result.ToString() , out int Test))
                {
                    StationID = Test;
                }

            }
            catch
            {

            }
            finally
            {
                Connection.Close() ;
            }
            return StationID;
        }

        static public bool SaveStationLineAndOrder(int StationID , float Line , short Order)
        {

            bool IsInserted = false;
            SqlConnection Connection = new SqlConnection(clsDataAccessLayerSettings._ConnectionString);

            string Query = @"Insert Into [Line'sStations] (StationID , StationOrder , LineNumber )
                            Values (@StationID , @Order , @Line)";
            SqlCommand Command = new SqlCommand(Query,Connection);  
            Command.Parameters.AddWithValue("@StationID" , StationID );
            Command.Parameters.AddWithValue("@Line" , Line );
            Command.Parameters.AddWithValue("@Order" , Order );
            try
            {
                Connection.Open();
                int RowsAffected = Command.ExecuteNonQuery();
                IsInserted = (RowsAffected > 0 );
            }
            catch
            {

            }
            finally
            {
                Connection.Close() ;
            }
            return IsInserted;
        }
    }
}
