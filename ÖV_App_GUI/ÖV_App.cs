using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace ÖV_App_GUI
{
    public partial class ÖV_App : Form
    {
        Transport transport = new Transport();
      
        public ÖV_App()
        {
            InitializeComponent();
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {

        }

        public Stations getStation(string input)
        {
            Stations stationList = transport.GetStations(input);
            return stationList;
        }

        public Connections getConnection(string fromStation, string toStattion)
        {
            Connections connectionList = transport.GetConnections(fromStation, toStattion);
            return connectionList;
        }

        public StationBoardRoot getStationBoard(string station, string id)
        {
            StationBoardRoot stationboard = transport.GetStationBoard(station, id);
            return stationboard;
        }

        private void cboStartStation_Click(object sender, EventArgs e)
        {
            cboStartStation.DroppedDown = true;
            cboStartStation.DataSource = getStation(cboStartStation.Text).StationList;
            cboStartStation.DisplayMember = "name";
        }

        private void cboEndDestination_Click(object sender, EventArgs e)
        {
            cboEndStation.DroppedDown = true;
            cboEndStation.DataSource = getStation(cboEndStation.Text).StationList;
            cboEndStation.DisplayMember = "name";
        }
    }
}
