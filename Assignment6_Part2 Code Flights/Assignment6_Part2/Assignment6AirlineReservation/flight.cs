using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Assignment6AirlineReservation
{
    class flight
    {
        /// <summary>
        /// this variable will be used to hold
        /// the flight_id from the database
        /// </summary>
        public string flight_id;

        /// <summary>
        /// this variable will be used to hold
        /// the flight_num from the data base
        /// </summary>
        public string flight_num;
        
        /// <summary>
        /// this variable will be used to hold
        /// the aircraft_type from the data base
        /// </summary>
        public string aircraft_type;

        /// <summary>
        /// firstName will hold the users first name
        /// from the database
        /// </summary>
        public string firstName;

        /// <summary>
        /// lastName will hold the users last name from
        /// the data base
        /// </summary>
        public string lastName;
        
        /// <summary>
        /// passId will hold the users passenger id
        /// </summary>
        public string passId;

        /// <summary>
        /// seatNum will hold the users seat number
        /// </summary>
        public string seatNum;

        /// <summary>
        /// ds will be used to hold any
        /// values that are being pulled from the data
        /// base
        /// </summary>
        private DataSet ds = new DataSet();

        /// <summary>
        /// sql is a SQL object that will
        /// be used to access each data base method
        /// </summary>
        private SQL sql = new SQL();

        public flight()
        {
            //ds = sql.getFlights();
        }

        /// <summary>
        /// this method will load the flights from the
        /// database to a list
        /// </summary>
        /// <returns>List<flights></returns>
        public List<flight> loadFlights()
        {
            try
            {
                List<flight> flightObj = new List<flight>(); //instanciates flightObj
                ds = sql.getFlights(); //gets the flights from the database and loads them into ds

                for (int i = 0; i < sql.NumRows; i++) //loads the flight information into flightObj
                {
                    flightObj.Add(new flight
                    {
                        flight_id = ds.Tables[0].Rows[i][0].ToString(),
                        flight_num = ds.Tables[0].Rows[i][1].ToString(),
                        aircraft_type = ds.Tables[0].Rows[i][2].ToString()
                    });
                }
                return flightObj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// This method will load all of the passengers
        /// from the selected flight into a list of flight objects
        /// </summary>
        /// <param name="index">index</param>
        /// <returns>List<flight></returns>
        public List<flight> loadPass(int index)
        {
            try
            {
                List<flight> passObj = new List<flight>(); //instanciates the passObj list
                ds = sql.getPassengers(index); //gets the passengers from the selected flight

                for (int i = 0; i < sql.NumRows; i++) //loads the passengers into the passObj list
                {
                    passObj.Add(new flight
                    {
                        passId = ds.Tables[0].Rows[i][0].ToString(),
                        firstName = ds.Tables[0].Rows[i][1].ToString(),
                        lastName = ds.Tables[0].Rows[i][2].ToString()
                    });
                }
                return passObj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// this method is used to add
        /// a passenger to the data base
        /// </summary>
        /// <param name="firstName">passengers first name</param>
        /// <param name="lastName">passenger last name</param>
        /// <param name="index">flight index number</param>
        public void addPassenger(string firstName, string lastName, int index)
        {
            try
            {
                sql.addPassenger(firstName, lastName, index); //calls the addPassenger and passes it firstName, lastName, and index

            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// this method is used to delete a passenger from the data bases
        /// </summary>
        /// <param name="passId"></param>
        public void deletePassenger(string passId)
        {
            try
            {
                sql.deletePassenger(passId); //deletes the passenger with the corresponding passId
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// this method takes in the passenger
        /// information and updates the seat in the data base
        /// </summary>
        /// <param name="passId">passenger id</param>
        /// <param name="seatNum">current seat number</param>
        /// <param name="newSeatNum">new seat number</param>
        /// <param name="flightNum">current flight number</param>
        public void updateSeat(string passId, string newSeatNum, int flightNum)
        {
            try
            {
                sql.updateSeat(passId, newSeatNum, flightNum); //updates the passenger with the new seat number

            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// this method is used to load all of the passengers
        /// at the selected flight into the seatObj list
        /// </summary>
        /// <param name="index">flight index</param>
        /// <returns>seatObj list</returns>
        public List<flight> loadSeats(int index)
        {
            try
            {
                List<flight> seatObj = new List<flight>(); //instanciates seatObj
                ds = sql.getSeats(index); //loads the seats and id's at the flight index

                for (int i = 0; i < sql.NumRows; i++) //loops through the returned rows 
                {
                    seatObj.Add(new flight //adds passenger id's and seat numbers to the list
                    {
                        passId = ds.Tables[0].Rows[i][1].ToString(),
                        seatNum = ds.Tables[0].Rows[i][2].ToString()
                    });
                }
                return seatObj;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
