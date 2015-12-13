using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EclipseZebra.Models
{
    public static class Search
    {
        public static string execute(string first_name, string last_name)
        {
            string result;
            //List<string> result = new List<string>();
            OdbcConnection db = new OdbcConnection();
            db.ConnectionString = "FIL=MS Access;DSN=FairCom 32bit Driver";
            try
            {
                db.Open();
                OdbcCommand query = new OdbcCommand("SELECT * FROM PATIENTS", db);
                result = query.ExecuteReader().ToString();

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
    }
}
