using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Assignment6AirlineReservation
{
    class SQL
    {
        /// <summary>
        /// db is the clsDatAccess class object
        /// which is used to access the data base
        /// </summary>
        public clsDataAccess db = new clsDataAccess();

        /// <summary>
        /// ds is the data set that will be used to match
        /// whatever db gets from the SQL statement
        /// </summary>
        DataSet ds = new DataSet();

        /// <summary>
        /// number of return rows
        /// </summary>
        public int NumRows = 0;

        /// <summary>
        /// this method gets all of the flight
        /// from the data base
        /// </summary>
        /// <returns>ds which will hold the flights</returns>
        public DataSet getFlights()
        {
            try
            {
                ds = db.ExecuteSQLStatement("SELECT Flight_ID, Flight_Number, Aircraft_Type FROM flight", ref NumRows);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// this method will get all of the passengers
        /// at the selected flight index
        /// </summary>
        /// <param name="index">flight number</param>
        /// <returns>ds which holds all of the passengers in that flight</returns>
        public DataSet getPassengers(int index)
        {
            try
            {
                ds = db.ExecuteSQLStatement("SELECT * FROM passenger p INNER JOIN flight_passenger_link fpl ON fpl.passenger_id = p.passenger_id WHERE fpl.flight_id = " + (index + 1), ref NumRows);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// this method will add a new person to the 
        /// data base, it will add them to the Passenger
        /// table and the flight_passenger_link table
        /// </summary>
        /// <param name="firstName">passenger first name</param>
        /// <param name="lastName">passenger last name</param>
        /// <param name="index">flight index</param>
        public void addPassenger(string firstName, string lastName, int index)
        {
            try
            {
                ds = db.ExecuteSQLStatement("SELECT MAX(passenger_id) + 1 FROM passenger", ref NumRows);//gets the max passenger id and increments it
                string newId = ds.Tables[0].Rows[0][0].ToString(); //assigns passenger id to newId

                index = index + 1; //gets correct flight
                                   //loads the new passenger into both tables
                db.ExecuteNonQuery("INSERT INTO Passenger (Passenger_id, First_Name, Last_Name) VALUES ('" + newId + "', '" + firstName + "', '" + lastName + "')");
                db.ExecuteNonQuery("INSERT INTO flight_passenger_link (Flight_id, Passenger_id) VALUES ('" + index + "', '" + newId + "')");

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// this method is used to delete a selected
        /// passenger
        /// </summary>
        /// <param name="passId">selected passenger id</param>
        public void deletePassenger(string passId)
        {
            try
            {
                //deletes the passenger from both tables in the data base
                db.ExecuteNonQuery("Delete FROM Flight_Passenger_Link WHERE PASSENGER_ID = " + passId);
                db.ExecuteNonQuery("Delete FROM PASSENGER WHERE PASSENGER_ID = " + passId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// this method gets all of the seats from
        /// the selected flight
        /// </summary>
        /// <param name="index">flight index</param>
        /// <returns>ds holding all of the seats and id's</returns>
        public DataSet getSeats(int index)
        {
            try
            {
                index = index + 1; //gets correct flight
                //gets everything from the flight_passenger_link table where the flight_id equals index
                ds = db.ExecuteSQLStatement("SELECT * FROM flight_passenger_link WHERE flight_id = " + index, ref NumRows);
                return ds;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// this method will update the passenger
        /// seat
        /// </summary>
        /// <param name="id">current passengers id</param>
        /// <param name="seatNum">current seat number</param>
        /// <param name="newSeatNum">new seat number that is assigned</param>
        /// <param name="flightNum">current flight number</param>
        public void updateSeat(string id, string newSeatNum, int flightNum)
        {
            try
            {
                flightNum = flightNum + 1; //gets the correct flight
                                           //updates the data base with the new seat number for the selected passenger
                db.ExecuteNonQuery("UPDATE Flight_Passenger_Link SET Seat_number = " + newSeatNum + " WHERE Flight_id = " + flightNum + " AND Passenger_id = " + id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
