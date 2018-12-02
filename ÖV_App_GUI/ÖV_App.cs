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
        StationBoardRoot stationBoard = new StationBoardRoot();

        public ÖV_App()
        {
            InitializeComponent();
        }

        private void btnSearchConnection_Click(object sender, EventArgs e)
        {
            List<StationBoard> stationConnection = new List<StationBoard>();
            List<Connection> railwayConnection = new List<Connection>();
            dataGridConnection.Rows.Clear();

            if (!string.IsNullOrEmpty(txtStartStation.Text) && !string.IsNullOrEmpty(txtEndStation.Text))
            {
                railwayConnection = transport.GetConnections(txtStartStation.Text, txtEndStation.Text).ConnectionList;
                foreach (Connection connection in railwayConnection)
                {
                    string duration = connection.Duration.Substring(6, 2);
                    dataGridConnection.Rows.Add(connection.From.Departure, connection.From.Station.Name, connection.To.Station.Name, duration + " Minutes" );
                }
            }
        }
        
        private void btnShowConnectionFromStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtEndStation.Text))
            {
                List<StationBoard> stationBoardEntries = GetStationBoardEntries(txtStartStation.Text, lstStartDestinations.SelectedValue.ToString());
                foreach (StationBoard station in stationBoardEntries)
                {
                    string departureStation = txtStartStation.Text;
                    dataGridConnection.Rows.Add(station.Stop.Departure, departureStation, station.To);
                }
            }
        }

        private List<StationBoard> GetStationBoardEntries(string station, string id)
        {
            bool stationAndIdNotNullOrWhiteSpaces =
                (string.IsNullOrWhiteSpace(station) && string.IsNullOrWhiteSpace(id));

            if (!stationAndIdNotNullOrWhiteSpaces)
            {
                stationBoard = transport.GetStationBoard(station, id);
            }

            return stationBoard.Entries;
        }
        private void ShowStationBoardEntries(string stationName, string stationId)
        {
            List<StationBoard> stationBoardEntries = GetStationBoardEntries(stationName, stationId);

            var stationBoardList = from stationBoardEntry in stationBoardEntries
                                   select new
                                   {
                                       Abfahrtszeit = stationBoardEntry.Stop.Departure.ToShortTimeString(),
                                       Nach = stationBoardEntry.To
                                   };

            dataGridConnection.DataSource = stationBoardList.ToList();
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
        private void txtStartStation_TextChanged(object sender, EventArgs e)
        {
            lstStartDestinations.DisplayMember = "Name";
            lstStartDestinations.ValueMember = "Id";

            Stations toStations = getStation(txtStartStation.Text);

            lstStartDestinations.DataSource = toStations.StationList;

            if (!(String.IsNullOrWhiteSpace(txtStartStation.Text)))
            {
                lstStartDestinations.Visible = true;
            }
            else
            {
                lstStartDestinations.Visible = false;
            }
            txtStartStation.Focus();
        }
        private void txtEndStation_TextChanged(object sender, EventArgs e)
        {
            lstEndDestinations.DisplayMember = "Name";
            lstEndDestinations.ValueMember = "Id";

            Stations toStations = getStation(txtEndStation.Text);

            lstEndDestinations.DataSource = toStations.StationList;

            if (!(String.IsNullOrWhiteSpace(txtEndStation.Text)))
            {
                lstEndDestinations.Visible = true;
            }
            else
            {
                lstEndDestinations.Visible = false;
            }
            txtEndStation.Focus();
        }

        private void lstDestinations_Enter(object sender, EventArgs e)
        {
            txtStartStation.Text = lstStartDestinations.Text;
        }

        private void txtStartStation_Leave(object sender, EventArgs e)
        {
            txtStartStation.Text = lstStartDestinations.Text;
            lstStartDestinations.Visible = false;
        }

        private void lstEndDestinations_Enter(object sender, EventArgs e)
        {
            txtEndStation.Text = lstEndDestinations.Text;
        }

        private void txtEndStation_Leave(object sender, EventArgs e)
        {
            txtEndStation.Text = lstEndDestinations.Text;
            lstEndDestinations.Visible = false;
        }
        private void txtStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtStartStation.Focused)
            {
                if (lstStartDestinations.Items.Count != 0)
                {
                    if (lstStartDestinations.SelectedIndex != (lstStartDestinations.Items.Count - 1))
                    {
                        if (e.KeyCode == Keys.Down)
                        {
                            lstStartDestinations.SelectedIndex++;
                        }
                    }
                    if (lstStartDestinations.SelectedIndex != 0)
                    {
                        if (e.KeyCode == Keys.Up)
                        {
                            lstStartDestinations.SelectedIndex--;
                        }
                    }
                }
            }
        }


    }
}


