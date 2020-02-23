using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Assignment_6
{
    /// <summary>
    /// this class will hold all of the
    /// SQL code that is being implemented
    /// in the program
    /// </summary>
    class sql
    {
        /// <summary>
        /// object for the DataAccess
        /// class this holds the database
        /// </summary>
        public clsDataAccess db = new clsDataAccess();

        /// <summary>
        /// object for the DataSet class
        /// this is the data set that will be returned
        /// </summary>
        public DataSet ds;

        /// <summary>
        /// NumRows will hold the number
        /// of rows returned from the SQL code
        /// </summary>
        int NumRows = 0;

        /// <summary>
        /// this method holds all of the information
        /// regarding the flight table
        /// </summary>
        /// <returns>data set holding the flight info</returns>
        public DataSet loadFlights()
        {
            ds = db.ExecuteSQLStatement("SELECT * FROM flight", ref NumRows);
            return ds;
        }

        /// <summary>
        /// this method will return all of the
        /// information about the passengers where
        /// the flight id is equal to the flight the
        /// passenger is on
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>data set holding the passenger info</returns>
        public DataSet loadPass(int index)
        {
            ds = db.ExecuteSQLStatement("SELECT * FROM passenger p INNER JOIN flight_passenger_link fpl ON fpl.passenger_id = p.passenger_id WHERE fpl.flight_id = " + (index + 1), ref NumRows);
            return ds;
        }


    }
}
