using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataHandler
    {
        SqlConnection con = new SqlConnection("Data Source=RICHTER\\SQLEXPRESS;Initial Catalog=shsDB;Integrated Security=True");
        SqlDataReader reader = null;
        //reads with out proc comment out to use
        //gets table name from class
        //public DataTable Read(string tblName)
        //{
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        using (SqlDataAdapter da = new SqlDataAdapter())
        //        {
        //            string SelectString = "Select * from " + tblName + "_tbl";
        //            //passes through command
        //            da.SelectCommand = new SqlCommand(SelectString, con);

        //            DataSet ds = new DataSet();
        //            da.Fill(ds, tblName);

        //            dt = ds.Tables[tblName];
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //    }
        //    finally
        //    {
        //        con.Close();
        //    }
        //    return dt;
        //}

            /// <summary>
            /// stored proc can be switched with commented code to do the same thing
          
        public DataTable Read(string tblName)
        {
            DataTable dt = new DataTable();
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    //name of stored proc
                    sda.SelectCommand = new SqlCommand("[dbo].[Read]", con);
                    //sends command so it knows its a proc
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //name of parameter and comma for table we getting from
                    sda.SelectCommand.Parameters.AddWithValue("@TableName", tblName);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, tblName);

                    dt = ds.Tables[tblName];
                }
            return dt;
        }

        public bool UpdateC<T>(string id, string columnName, T newValue, string tblName)
        {
            string updateString = string.Format(@"
                Update {0}
                Set {1} = @newValue
                Where ID = @ID", tblName, columnName);
            bool check = true;
            try
            {

                con.Open();
                //giving update params before executing
                SqlCommand cmdUpdate = new SqlCommand(updateString, con);
                //paramaters
                cmdUpdate.Parameters.Add(new SqlParameter("@newValue", newValue));
                cmdUpdate.Parameters.Add(new SqlParameter("@ID", id));
                cmdUpdate.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                check = false;
            }
            finally
            {
                con.Close();
            }
            return check;
        }

        public bool insert<T>(string tblName,List<string> columnName,List<T> values)
        {
            bool check = true;
            try
            {
                string ConString = "Insert into " + tblName + " (";
                //tbl_ToolList ([Tool Name]) Values ('{0}')";

                //inserts column names
                for (int i = 0; i < columnName.Count; i++)
                {
                    ConString += columnName[i];
                    if (i < columnName.Count - 1)
                    {
                        ConString += ",";
                    }
                }
                ConString += ") Values (";
                //inserts values
                for (int x = 0; x < values.Count; x++)
                {
                    ConString += "'" + values[x] + "'";
                    if (x < values.Count - 1)
                    {
                        ConString += ",";
                    }
                }
                ConString += ")";

                string InsertString = string.Format(ConString);
                SqlCommand cmd = new SqlCommand(InsertString, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception)
            {
                check = false;
                throw;
                
            }
            return check;
        }

        //stored proc
        public bool Delete(string tblName, int ID)
        {
            bool check = true;
            con.Open();
            try
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    //name of stored proc
                    sda.SelectCommand = new SqlCommand("[dbo].[Delete]", con);
                    //sends command so it knows its a proc
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //name of parameter and comma for table we getting from
                    sda.SelectCommand.Parameters.AddWithValue("@TableName", tblName);
                    sda.SelectCommand.Parameters.AddWithValue("@ID", ID);
                    sda.SelectCommand.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                check = false;
                throw;
            }
            finally
            {
                con.Close();
            }
            return check;
        }
    }
}
