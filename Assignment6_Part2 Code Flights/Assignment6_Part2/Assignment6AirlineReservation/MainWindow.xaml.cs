using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment6AirlineReservation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// creates an object for the wndAddPassenger
        /// window
        /// </summary>
        wndAddPassenger wndAddPass;

        /// <summary>
        /// list of flights used to access
        /// the public data members of the flight class
        /// </summary>
        List<flight> flights= new List<flight>();

        /// <summary>
        /// list of flights used to access
        /// the public data members of the flight class
        /// </summary>
        List<flight> flightSeatId= new List<flight>();

        /// <summary>
        /// flightObject is the object used to access 
        /// specific parts of the flight
        /// </summary>
        flight flightObject = new flight();

        /// <summary>
        /// list of flight 1 seat labels
        /// </summary>
        List<Label> seatListF1 = new List<Label>();
        
        /// <summary>
        /// list of flight 2 seat labels
        /// </summary>
        List<Label> seatListF2 = new List<Label>();

        /// <summary>
        /// determines if a seat has been selected
        /// </summary>
        bool seatSelected = false;

        /// <summary>
        /// this variable will hold the 
        /// id from our list of flight objects,
        /// or from flightObject
        /// </summary>
        string id;

        /// <summary>
        /// this variable will hold the 
        /// seat number from our list of flight objects,
        /// or from flightObject
        /// </summary>
        string seatNum;

        /// <summary>
        /// this variable will be used to
        /// determine the index for the seat number
        /// currently selected
        /// </summary>
        int indexForSeat = 0;

        /// <summary>
        /// this variable is the new seat number
        /// that will be passed into the data base
        /// </summary>
        string newSeatNum = "";

        /// <summary>
        /// this is the integer value
        /// of the seat number that
        /// will later be converted to a string seatNum
        /// </summary>
        int iSeatNum = 0;

        /// <summary>
        /// used to determine if a seat is
        /// taken or not
        /// </summary>
        bool seatTaken;

        public MainWindow()
        {
            try
            {
                InitializeComponent();
                Application.Current.ShutdownMode = ShutdownMode.OnMainWindowClose;
                addSeats();
                flights = flightObject.loadFlights(); //loads the list will the flights
                int i = 0;
                foreach (var item in flights) //for each item in flights we will populate the cbChooseFlight drop down
                {
                    cbChooseFlight.Items.Add(flights[i].flight_num.ToString() +" "+ flights[i].aircraft_type.ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// this method will determine what the
        /// current selected index is for the flight
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void cbChooseFlight_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                string selection = cbChooseFlight.SelectedIndex.ToString(); //selection is the cbChooseFlight drop down at its selected index
                cbChoosePassenger.IsEnabled = true;
                gPassengerCommands.IsEnabled = true;

                if (selection == "1")
                {
                    flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
                    foreach (var item in flights) //loops through all items to assign the seats to the labels
                    {
                        for (int j = 0; j < seatListF1.Count(); j++) //loop used to find each seat in the list and match it to the corresponding label
                        {
                            if (seatListF1[j].Content.ToString() == item.seatNum.ToString())
                            {
                                seatListF1[j].Background = new SolidColorBrush(Colors.Red); //assigns the correct seat label to have a red color
                            }
                        }
                    }
                    lblPassengersSeatNumber.Content = ""; //clears the lblPassengersSeatNumber label
                    CanvasA380.Visibility = Visibility.Hidden; //shows 767 flight panel
                    Canvas767.Visibility = Visibility.Visible;
                }
                else
                {
                    flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
                    foreach (var item in flights) //loops through all items to assign the seats to the labels
                    {
                        for (int j = 0; j < seatListF2.Count(); j++) //loop used to find each seat in the list and match it to the corresponding label
                        {
                            if (seatListF2[j].Content.ToString() == item.seatNum.ToString())
                            {
                                seatListF2[j].Background = new SolidColorBrush(Colors.Red); //assigns the correct seat label to have a red color
                            }
                        }
                    }
                    lblPassengersSeatNumber.Content = ""; //clears the lblPassengersSeatNumber label
                    Canvas767.Visibility = Visibility.Hidden; //shows the A380 flight panel
                    CanvasA380.Visibility = Visibility.Visible;
                }

                cbChoosePassenger.Items.Clear(); //clears the values in the cbChoosePassenger drop down            
                flights = flightObject.loadPass(cbChooseFlight.SelectedIndex); //loads passengers that match the corresponding flight
                int i = 0;
                foreach (var item in flights) //adds each flight item from the flights list into the cbChoosePassenger drop down
                {
                    cbChoosePassenger.Items.Add(flights[i].firstName.ToString() +" "+ flights[i].lastName.ToString());
                    i++;
                }
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        /// <summary>
        /// This method will pull up the 
        /// wndAddPassenger window then add
        /// the new user to the flights list
        /// and the cbChoosePassenger drop down
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/a</param>
        private void cmdAddPassenger_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                wndAddPass = new wndAddPassenger(cbChooseFlight.SelectedIndex); //instanciates wndAddPass with the selected flight index
                wndAddPass.ShowDialog(); //pulls up the wndAddPassenger window
                cbChoosePassenger.Items.Clear(); //clears the current passengers
                flights = flightObject.loadPass(cbChooseFlight.SelectedIndex); //reloads the list with the current passengers
                int i = 0;
                foreach (var item in flights) //re adds the cbChoosePassenger drop down with the new passenger included
                {
                    cbChoosePassenger.Items.Add(flights[i].firstName.ToString() + " " + flights[i].lastName.ToString());
                    i++;
                }
                cbChoosePassenger.SelectedIndex = i-1;
                id = flights[i - 1].passId;
                seatSelected = true; //enables the change seat option for the seat labels
                cbChooseFlight.IsEnabled = false; //disables all other commands
                cbChoosePassenger.IsEnabled = false;
                cmdAddPassenger.IsEnabled = false;
                cmdDeletePassenger.IsEnabled = false;
                cmdChangeSeat.IsEnabled = false;
            }
            catch (Exception ex)
            {
                HandleError(MethodInfo.GetCurrentMethod().DeclaringType.Name,
                    MethodInfo.GetCurrentMethod().Name, ex.Message);
            }
        }

        private void HandleError(string sClass, string sMethod, string sMessage)
        {
            try
            {
                MessageBox.Show(sClass + "." + sMethod + " -> " + sMessage);
            }
            catch (System.Exception ex)
            {
                System.IO.File.AppendAllText(@"C:\Error.txt", Environment.NewLine + "HandleError Exception: " + ex.Message);
            }
        }

        /// <summary>
        /// This method deletes a passenger from
        /// the data base and updates the label colors
        /// when the passenger is deleted
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        private void CmdDeletePassenger_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights with the seats and id's
                int pIndex = cbChoosePassenger.SelectedIndex; //gets the selected persons index
                string seatNum = flights[pIndex].seatNum; //gets the selected persons seat number
                if (cbChooseFlight.SelectedIndex.ToString() == "1") //determines which flight
                {
                    for (int j = 0; j < seatListF1.Count(); j++) //loops through all the seats in the list
                    {
                        if (seatListF1[j].Content.ToString() == seatNum) //if the loop reaches the deleted persons seat 
                        {
                            seatListF1[j].Background = new SolidColorBrush(Colors.Blue); //change their seat color to blue
                        }
                    }
                }
                else //determines which flight
                {
                    for (int j = 0; j < seatListF2.Count(); j++) //loops through all the seats in the list
                    {
                        if (seatListF2[j].Content.ToString() == seatNum) //if the loop reaches the deleted persons seat 
                        {
                            seatListF2[j].Background = new SolidColorBrush(Colors.Blue); //change their seat color to blue
                        }
                    }
                }
                flightObject.deletePassenger(flights[pIndex].passId); //deletes the passenger
                cbChoosePassenger.Items.Clear(); //clears the cbChoosePassenger drop down
                flights = flightObject.loadPass(cbChooseFlight.SelectedIndex); //gets all the current passengers
                int i = 0;
                foreach (var item in flights) //for each item in flights it loads the first name and last name to the cbChoosePassenger drop down
                {
                    cbChoosePassenger.Items.Add(flights[i].firstName.ToString() + " " + flights[i].lastName.ToString());
                    i++;
                }
            }
            catch (Exception)
            {
            }
        }

        /// <summary>
        /// This method will enable the user to change
        /// seats for the passengers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdChangeSeat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                flightSeatId = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the list with the seats and id's
                int pIndex = cbChoosePassenger.SelectedIndex; //gets the selected passenger index
                lblPassengersSeatNumber.Content = flightSeatId[pIndex].seatNum.ToString(); //updates the lblPassengersSeatNumber with the passengers seat number
                id = flights[pIndex].passId; //saves off the passenger id
                seatNum = flightSeatId[pIndex].seatNum; //saves of the passenger seat number
                if (cbChooseFlight.SelectedIndex == 1) //determines the flight
                {
                    for (int k = 0; k < seatListF1.Count(); k++) //loops through all of the seats
                    {
                        if (seatListF1[k].Content.ToString() == seatNum.ToString()) //once it finds the seat
                        {
                            indexForSeat = k; //save the index
                            seatListF1[k].Background = new SolidColorBrush(Colors.LimeGreen); //highlight
                            seatSelected = true; //enables the change seat option for the seat labels
                            cbChooseFlight.IsEnabled = false; //disables all other commands
                            cbChoosePassenger.IsEnabled = false;
                            cmdAddPassenger.IsEnabled = false;
                            cmdDeletePassenger.IsEnabled = false;
                            cmdChangeSeat.IsEnabled = false;
                        }
                        else
                        {
                            seatSelected = true; //enables the change seat option for the seat labels
                            cbChooseFlight.IsEnabled = false; //disables all other commands
                            cbChoosePassenger.IsEnabled = false;
                            cmdAddPassenger.IsEnabled = false;
                            cmdDeletePassenger.IsEnabled = false;
                            cmdChangeSeat.IsEnabled = false;
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < seatListF2.Count(); k++) //loops through all of the seats, flight 1
                    {
                        if (seatListF2[k].Content.ToString() == seatNum.ToString()) //once it finds the seat
                        {
                            indexForSeat = k;
                            seatListF2[k].Background = new SolidColorBrush(Colors.LimeGreen); //highlights seat
                            seatSelected = true; //enables the change seat option for the seat labels
                            cbChooseFlight.IsEnabled = false; //disables all other commands
                            cbChoosePassenger.IsEnabled = false;
                            cmdAddPassenger.IsEnabled = false;
                            cmdDeletePassenger.IsEnabled = false;
                            cmdChangeSeat.IsEnabled = false;
                        }
                        else
                        {
                            seatSelected = true; //enables the change seat option for the seat labels
                            cbChooseFlight.IsEnabled = false; //disables all other commands
                            cbChoosePassenger.IsEnabled = false;
                            cmdAddPassenger.IsEnabled = false;
                            cmdDeletePassenger.IsEnabled = false;
                            cmdChangeSeat.IsEnabled = false;
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
            //seat change for id and seatListF[k]
        }

        /// <summary>
        /// adds all of the seats to the seat label
        /// list
        /// </summary>
        private void addSeats()
        {
            seatListF1.Add(Seat1);
            seatListF1.Add(Seat2);
            seatListF1.Add(Seat3);
            seatListF1.Add(Seat4);
            seatListF1.Add(Seat5);
            seatListF1.Add(Seat6);
            seatListF1.Add(Seat7);
            seatListF1.Add(Seat8);
            seatListF1.Add(Seat9);
            seatListF1.Add(Seat10);
            seatListF1.Add(Seat11);
            seatListF1.Add(Seat12);
            seatListF1.Add(Seat13);
            seatListF1.Add(Seat14);
            seatListF1.Add(Seat15);
            seatListF1.Add(Seat16);

            seatListF2.Add(SeatA1);
            seatListF2.Add(SeatA2);
            seatListF2.Add(SeatA3);
            seatListF2.Add(SeatA4);
            seatListF2.Add(SeatA5);
            seatListF2.Add(SeatA6);
            seatListF2.Add(SeatA7);
            seatListF2.Add(SeatA8);
            seatListF2.Add(SeatA9);
            seatListF2.Add(SeatA10);
            seatListF2.Add(SeatA11);
            seatListF2.Add(SeatA12);
            seatListF2.Add(SeatA13);
            seatListF2.Add(SeatA14);
            seatListF2.Add(SeatA15);
        }

        /// <summary>
        /// region that has all of the seat number label clicks
        /// that update the data base with the new seat number
        /// depending on whether the seat is taken or not
        /// it will assign the background color to the new seat
        /// and it will make the old seat number blue
        /// then it will re enable all of the interface options
        /// </summary>
        /// <param name="sender">N/A</param>
        /// <param name="e">N/A</param>
        #region
        private void Seat1Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[0].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }

            newSeatNum = "1";
            if(seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[0].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat2Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[1].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }

            newSeatNum = "2";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[1].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat3Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[2].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }

            newSeatNum = "3";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[2].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat4Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[3].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }

            newSeatNum = "4";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[3].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat5Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[4].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "5";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[4].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat6Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[5].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "6";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[5].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat7Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[6].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "7";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[6].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat8Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[7].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "8";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[7].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat9Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[8].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "9";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[8].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;

            }
        }

        private void Seat10Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[9].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "10";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[9].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat11Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[10].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "11";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[10].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat12Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[11].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "12";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[11].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat13Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[12].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "13";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[12].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat14Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[13].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "14";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[13].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat15Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[14].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "15";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[14].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void Seat16Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF1[15].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "16";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF1[15].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF1[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA1Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[0].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "1";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[0].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA2Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[1].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "2";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[1].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA3Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[2].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "3";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[2].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA4Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[3].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "4";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[3].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA5Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[4].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "5";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[4].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA6Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[5].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "6";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[5].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA7Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[6].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "7";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[6].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA8Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[7].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "8";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[7].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA9Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[8].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "9";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[8].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA10Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[9].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "10";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[9].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA11Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[10].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "11";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[10].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA12Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[11].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "12";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[11].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA13Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[12].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "13";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[12].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA14Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[13].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "14";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[13].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }

        private void SeatA15Click(object sender, MouseButtonEventArgs e)
        {
            seatTaken = false;
            flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex); //loads the flights list with the seats and id's corresponding to those seats
            foreach (var item in flights) //loops through all items to assign the seats to the labels
            {
                if (seatListF2[14].Content.ToString() == item.seatNum.ToString())
                {
                    seatTaken = true;
                }
            }
            newSeatNum = "15";
            if (seatSelected == true && seatTaken == false)
            {
                flightObject.updateSeat(id, newSeatNum, cbChooseFlight.SelectedIndex);
                seatListF2[14].Background = new SolidColorBrush(Colors.Red);
                Int32.TryParse(seatNum, out iSeatNum);
                try
                {
                    seatListF2[iSeatNum - 1].Background = new SolidColorBrush(Colors.Blue);
                }
                catch (System.ArgumentOutOfRangeException)
                {
                }

                cbChooseFlight.IsEnabled = true;
                cbChoosePassenger.IsEnabled = true;
                cmdAddPassenger.IsEnabled = true;
                cmdDeletePassenger.IsEnabled = true;
                cmdChangeSeat.IsEnabled = true;
                seatSelected = false;
                lblPassengersSeatNumber.Content = newSeatNum;
            }
        }
        #endregion

        /// <summary>
        /// This method primarily updates the lblPassengersSeatNumber
        /// with the selected persons seat number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbChoosePassengerChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                flights = flightObject.loadSeats(cbChooseFlight.SelectedIndex);
                lblPassengersSeatNumber.Content = flights[cbChoosePassenger.SelectedIndex].seatNum;

                if (cbChooseFlight.SelectedIndex != 1) //determines the flight
                {
                    for (int k = 0; k < seatListF2.Count(); k++) //loops through all of the seats, flight 1
                    {
                        if (seatListF2[k].Content.ToString() == flights[cbChoosePassenger.SelectedIndex].seatNum) //once it finds the seat
                        {
                            indexForSeat = k;
                            seatListF2[k].Background = new SolidColorBrush(Colors.LimeGreen); //highlights seat
                        }
                        else
                        {
                            foreach (var item in flights) //loops through all items to assign the seats to the labels
                            {
                                if (item != flights[cbChoosePassenger.SelectedIndex])
                                {
                                    for (int j = 0; j < seatListF2.Count(); j++) //loop used to find each seat in the list and match it to the corresponding label
                                    {
                                        if (seatListF2[j].Content.ToString() == item.seatNum.ToString())
                                        {
                                            seatListF2[j].Background = new SolidColorBrush(Colors.Red); //assigns the correct seat label to have a red color
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    for (int k = 0; k < seatListF1.Count(); k++) //loops through all of the seats, flight 1
                    {
                        if (seatListF1[k].Content.ToString() == flights[cbChoosePassenger.SelectedIndex].seatNum) //once it finds the seat
                        {
                            indexForSeat = k;
                            seatListF1[k].Background = new SolidColorBrush(Colors.LimeGreen); //highlights seat
                        }
                        else
                        {
                            foreach (var item in flights) //loops through all items to assign the seats to the labels
                            {
                                if (item != flights[cbChoosePassenger.SelectedIndex])
                                {
                                    for (int j = 0; j < seatListF1.Count(); j++) //loop used to find each seat in the list and match it to the corresponding label
                                    {
                                        if (seatListF1[j].Content.ToString() == item.seatNum.ToString())
                                        {
                                            seatListF1[j].Background = new SolidColorBrush(Colors.Red); //assigns the correct seat label to have a red color
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            catch (Exception)
            {
            }
        }
    }
}
