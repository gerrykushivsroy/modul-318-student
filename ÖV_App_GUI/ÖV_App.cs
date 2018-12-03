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
            List<StationBoard> stationConnection = new List<StationBoard>();
            List<Connection> railwayConnection = new List<Connection>();
            

            if (dataGridConnection.Rows.Count != 0 && dataGridConnection.Rows != null)
            {
                dataGridConnection.Rows.Clear();
            }
            if (!string.IsNullOrEmpty(txtStartStation.Text) && !string.IsNullOrEmpty(txtEndStation.Text))
            {
                string time = dateTimeDeparture.Value.ToString("HH:mm");
                railwayConnection = transport.GetConnections(txtStartStation.Text, txtEndStation.Text, time).ConnectionList;
                foreach (Connection connection in railwayConnection)
                {
                    string duration = connection.Duration.Substring(6, 2);
                    dataGridConnection.Rows.Add(Convert.ToDateTime(connection.From.Departure).ToShortTimeString(), connection.From.Station.Name, connection.To.Station.Name, connection.To.Platform, duration + " Minuten");
                }
            }
        }

        private void btnShowConnectionFromStart_Click(object sender, EventArgs e)
        {
            string time = dateTimeDeparture.Value.ToString("HH:mm");
            List<StationBoard> stationBoardEntries = GetStationBoardEntries(txtStartStation.Text, lstStartDestinations.SelectedValue.ToString(), time);
            if (txtStartStation.Text == "")
            {
                MessageBox.Show("Es wurde kein Abfahrtsort gewählt!");
                txtStartStation.Focus();
            }
            else
            {
                if (dataGridConnection.Rows.Count != 0 && dataGridConnection.Rows != null)
                {
                    dataGridConnection.Rows.Clear();
                }
                foreach (StationBoard station in stationBoardEntries)
                {
                    string departureStation = txtStartStation.Text;
                    dataGridConnection.Rows.Add(station.Stop.Departure, departureStation, station.To);
                }
            }
        }
        private void btnShowConnectionFromEndStation_Click(object sender, EventArgs e)
        {
            string time = dateTimeDeparture.Value.ToString("HH:mm");
            List<StationBoard> stationBoardEntries = GetStationBoardEntries(txtStartStation.Text, lstEndDestinations.SelectedValue.ToString(), time);
            if (txtEndStation.Text == "")
            {
                MessageBox.Show("Es wurde kein Abfahrtsort gewählt!");
                txtEndStation.Focus();
            }
            else
            {
                if (dataGridConnection.Rows.Count != 0 && dataGridConnection.Rows != null)
                {
                    dataGridConnection.Rows.Clear();
                }
                foreach (StationBoard station in stationBoardEntries)
                {
                    string departureStation = txtEndStation.Text;
                    dataGridConnection.Rows.Add(station.Stop.Departure, departureStation, station.To);

                }
            }
        }
        private List<StationBoard> GetStationBoardEntries(string station, string id, string datetime)
        {
            bool stationAndIdNotNullOrWhiteSpaces =
                (string.IsNullOrWhiteSpace(station) && string.IsNullOrWhiteSpace(id));

            if (!stationAndIdNotNullOrWhiteSpaces)
            {
                return transport.GetStationBoard(station, id, datetime).Entries;
            }
            return null;
        }

        private void ShowStationBoardEntries(string stationName, string stationId, string datetime)
        {
            List<StationBoard> stationBoardEntries = GetStationBoardEntries(stationName, stationId, datetime);

            var stationBoardList = from stationBoardEntry in stationBoardEntries
                                   select new
                                   {
                                       Abfahrtszeit = stationBoardEntry.Stop.Departure.ToShortTimeString(),
                                       Nach = stationBoardEntry.To
                                   };

            dataGridConnection.DataSource = stationBoardList.ToList();
        }


        private Stations getStation(string input)
        {
            Stations stationList = transport.GetStations(input);
            return stationList;
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
                    if (e.KeyCode == Keys.Enter)
                    {
                        lstStartDestinations.Focus();
                        lstStartDestinations.SelectedIndex = 0;
                    }
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

        private void txtEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtEndStation.Focused)
            {
                if (lstEndDestinations.Items.Count != 0)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        lstEndDestinations.Focus();
                        lstEndDestinations.SelectedIndex = 0;
                    }
                    if (lstEndDestinations.SelectedIndex != (lstEndDestinations.Items.Count - 1))
                    {
                        if (e.KeyCode == Keys.Down)
                        {
                            lstEndDestinations.SelectedIndex++;
                        }
                    }
                    if (lstEndDestinations.SelectedIndex != 0)
                    {
                        if (e.KeyCode == Keys.Up)
                        {
                            lstEndDestinations.SelectedIndex--;
                        }
                    }
                }
            }
        }

        private void btnSwitchStation_Click(object sender, EventArgs e)
        {
            if (txtStartStation.Text == txtEndStation.Text)
            {
                MessageBox.Show("Der Ort ist gleich.");
            }
            if (String.IsNullOrEmpty(txtStartStation.Text) )
            {
                MessageBox.Show("Das Vor-feld ist leer. Bitte geben Sie einen Ort ein.");
                txtStartStation.Focus();
            }
            if(String.IsNullOrEmpty(txtEndStation.Text))
            {
                MessageBox.Show("Das Nach-feld ist leer. Bitte geben Sie einen Ort ein.");
                txtEndStation.Focus();
            }
            if(!String.IsNullOrEmpty(txtEndStation.Text) && !String.IsNullOrEmpty(txtStartStation.Text))
            {
                string startStation, endStation;
                startStation = txtStartStation.Text;
                endStation = txtEndStation.Text;
                txtStartStation.Text = endStation;
                txtEndStation.Text = startStation;
                btnSearchConnection.Focus();
            }
        }

        private void lstStartDestinations_Click(object sender, EventArgs e)
        {
            txtStartStation.Text = lstStartDestinations.Text;
        }
    }

}

