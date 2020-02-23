using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Assignment_6
{
    /// <summary>
    /// this class will hold give the UI
    /// access to all of the information
    /// about the flight, flight number,
    /// type of plane and passenger names
    /// </summary>
    class flight
    {
        /// <summary>
        /// ds is the data set that will
        /// be loaded with our database after 
        /// the sql statements are executed
        /// </summary>
        public DataSet ds = new DataSet();

        /// <summary>
        /// sql is the object for the sql
        /// class that will hold all of the 
        /// sql queries
        /// </summary>
        public sql sql = new sql();

        /// <summary>
        /// flightNumL is a list of strings
        /// that will hold the flight numbers in
        /// ds
        /// </summary>
        public List<string> flightNumL = new List<string>();

        /// <summary>
        /// flightType is a list of strings
        /// that will hold the type of flight
        /// stored in ds
        /// </summary>
        public List<string> flightType = new List<string>();

        /// <summary>
        /// name is a string that will hold the
        /// first and last name for the people
        /// in ds
        /// </summary>
        public List<string> name = new List<string>();

        /// <summary>
        /// flight is the constructor 
        /// that is going to load
        /// flightType list and 
        /// flightNumL with the information
        /// for the flights in ds
        /// </summary>
        public flight()
        {
            ds = sql.loadFlights();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                flightNumL.Add(ds.Tables[0].Rows[i][1].ToString());
                flightType.Add(ds.Tables[0].Rows[i][2].ToString());
            }
        }

        /// <summary>
        /// getName gets the names of
        /// the passengers from ds then loads
        /// them into the name list
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>name</returns>
        public List<string> getName(int index)
        {
            name.Clear();
            ds = sql.loadPass(index);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                name.Add(ds.Tables[0].Rows[i][1].ToString() + " " + ds.Tables[0].Rows[i][2].ToString());
            }
            return name;
        }
    }
}
