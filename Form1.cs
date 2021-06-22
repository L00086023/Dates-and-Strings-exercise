using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dates_and_Strings_exercise
{
    public partial class Form1 : Form
    {
        DateTime arrivalDate;
        DateTime departureDate;
        Decimal TotalPrice;
        int NoOfNights;
        double AvgPrice;


        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, System.EventArgs e)
        {
            DateTimePicker dtPikrArrivalDate  = new DateTimePicker();
            dtPikrArrivalDate.Text = DateTime.Now.ToShortDateString(); 
            dtPikrArrivalDate.Value.Date.ToString("M/d/yyyy");


            DateTimePicker dtPikrDepartureDate = new DateTimePicker();
            dtPkrDepartureDate.Value = DateTime.Today.AddDays(3); 
            dtPkrDepartureDate.Value.Date.ToString("M/d/yyyy");
          /*  dtPkrDepartureDate.Value = DateTime.Today.AddDays(3).ToString("M/d/yyyy"); */


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtPikrArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            arrivalDate = dtPikrArrivalDate.Value;

            arrivalDate = arrivalDate.Date;

        }
        public int NumberOfNights(DateTime startDate, DateTime endDate)
        {
            NoOfNights = Convert.ToInt32((endDate - startDate).TotalDays);

            return NoOfNights;
        }

        public Decimal TotalPriceOfStay(string DurationOfStay)

        {
            int Duration = Convert.ToInt32(DurationOfStay);
            TotalPrice = Duration * 120.00M;
            return TotalPrice;

        }
        public double AvgPricePerNight()
           {
            AvgPrice = Convert.ToDouble(TotalPrice / NoOfNights);
            return AvgPrice;

    }


        private void dtPkrDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            departureDate = dtPkrDepartureDate.Value;
            departureDate = departureDate.Date;

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtBxNoOfNights.Text = Convert.ToString(NumberOfNights(arrivalDate, departureDate));
            txtBxTotalPrice.Text = Convert.ToString(TotalPriceOfStay(Convert.ToString(NoOfNights)));
            txtBxAvgPricePerNight.Text = Convert.ToString(AvgPrice);/*This is not working at the moment. The AvgPrice field is not being updated? */
        }
    }
}
