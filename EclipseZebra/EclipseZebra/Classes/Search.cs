using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EclipseZebra.Models
{
    public static class Search
    {
        public static List<string> execute(string first_name, string last_name)
        {
            List<string> result = new List<string>();
            //List<string> result = new List<string>();
            OdbcConnection db = new OdbcConnection();
            db.ConnectionString = "FIL=MS Access;DSN=" + File.ReadAllText("dbSettings.txt");
            try
            {
                db.Open();
                OdbcCommand query = new OdbcCommand("SELECT DISTINCT PATIENTS.PatientID, PATIENTS.LastName, PATIENTS.FirstName, APPOINTMENTS.\"Time\", APPOINTMENTS.\"Date\" FROM   PATIENTS, APPOINTMENTS WHERE PATIENTS.PatientID = APPOINTMENTS.PatientID AND(PATIENTS.FirstName = '" + first_name + "') AND(PATIENTS.LastName = '" + last_name + "')AND (APPOINTMENTS.\"Date\" > CURDATE()) ORDER BY APPOINTMENTS.\"Date\" DESC", db);
                OdbcDataReader reader = query.ExecuteReader();
                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        result.Add(reader.GetString(4) + " " + reader.GetTime(3).ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't connect to database, error: " + ex, "Connection Error", MessageBoxButtons.OK);
                return result;
            }
            finally
            {
                db.Close();
            }
            return result;
        }

        public static string schema()
        {
            string result;
            //List<string> result = new List<string>();
            OdbcConnection db = new OdbcConnection();
            db.ConnectionString = "FIL=MS Access;DSN=FairCom 32bit Driver";
            try
            {
                db.Open();
                result = db.GetSchema().ToString();
                
                //OdbcCommand query = new OdbcCommand("SELECT * FROM Patient", db);
                //result = query.ExecuteReader().ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't connect to database, error: " + ex, "Connection Error", MessageBoxButtons.OK);
                return string.Empty;
            }
            finally
            {
                db.Close();
            }
            return result;
        }

        public static AutoCompleteStringCollection setup_autocomplete()
        {
            AutoCompleteStringCollection result = new AutoCompleteStringCollection();
            OdbcConnection db = new OdbcConnection();
            if(File.Exists("dbSettings.txt"))
            {
                db.ConnectionString = "FIL=MS Access;DSN=" + File.ReadAllText("dbSettings.txt");
            } else
            {
                MessageBox.Show("Please configure Database");
                return result;
            }
            
            try
            {
                db.Open();
                OdbcCommand query = new OdbcCommand("SELECT DISTINCT FirstName, LastName FROM PATIENTS WHERE(FirstName IS NOT NULL) AND(LastName IS NOT NULL)", db);
                OdbcDataReader reader = query.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result.Add(reader.GetString(0).TrimEnd(' ') + " " + reader.GetString(1).TrimEnd(' '));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't connect to database, error" + ex, "Connection Error", MessageBoxButtons.OK);
                return result;
            }
            finally
            {
                db.Close();
            }
            return result;
        }
    }
}
