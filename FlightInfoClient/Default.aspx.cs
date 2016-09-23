using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FlightInfoEntityLibrary;
using FlightInfoClient.FlightInfoServiceReference;

namespace FlightInfoClient
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Shows all the Flights
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnShowAllFlights_Click(object sender, EventArgs e)
        {
            List<FlightInfoEntity> flightList = null;
            try
            {
                btnShowAllFlights.Visible = false;
                FlightInfoServiceClient client = new FlightInfoServiceClient();
                flightList = client.getFlightInformation().ToList();
                if (flightList != null)
                {
                    FlightListGrid.DataSource = flightList;
                    FlightListGrid.DataBind();
                } 

            }
            catch (Exception ex)
            {
                Response.Write("MESSAGE:" + ex.Message + "INNEREXCEPTION:" + ex.InnerException);
            }
        }

        /// <summary>
        /// Shows the Flight and details button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void FlightListGrid_OnRowCommand(object sender, GridViewCommandEventArgs e)
        {
            List<FlightInfoEntity> flightDetails = null;
            try
            {
                if (e.CommandName == "Show Details")
                {
                    FlightInfoServiceClient client = new FlightInfoServiceClient();
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = FlightListGrid.Rows[index];
                    string flightID = Server.HtmlDecode(row.Cells[0].Text);
                    flightDetails = client.getFlightDetails(flightID).ToList();
                    if (flightDetails != null)
                    {
                        FlightDetailsGrid.DataSource = flightDetails;
                        FlightDetailsGrid.DataBind();
                    }

                }

            }
            catch (Exception ex)
            {
                Response.Write("MESSAGE:" + ex.Message + "INNEREXCEPTION:" + ex.InnerException);
            }


        }

        
    }
}