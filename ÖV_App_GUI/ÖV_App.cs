﻿using System;
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

            if (dtGridConnection.Rows.Count != 0 && dtGridConnection.Rows != null)
            {
                dtGridConnection.Rows.Clear();
            }
            if (!string.IsNullOrEmpty(txtStartStation.Text) && !string.IsNullOrEmpty(txtEndStation.Text))
            {
                string time = dateTimeDeparture.Value.ToString("HH:mm");
                railwayConnection = transport.GetConnections(txtStartStation.Text, txtEndStation.Text, time).ConnectionList;
                foreach (Connection connection in railwayConnection)
                {
                    string duration = connection.Duration.Substring(6, 2);
                    dtGridConnection.Rows.Add(Convert.ToDateTime(connection.From.Departure).ToShortDateString(), Convert.ToDateTime(connection.From.Departure).ToShortTimeString(), connection.From.Station.Name, connection.To.Station.Name, connection.From.Platform, duration + " Minuten");
                }
            }
        }

        private void btnShowConnectionFromStart_Click(object sender, EventArgs e)
        {
            ShowSationboard(txtStartStation);
        }
        private void btnShowConnectionFromEndStation_Click(object sender, EventArgs e)
        {
            ShowSationboard(txtEndStation);
        }
        private void ShowSationboard(TextBox textbox)
        {
            string time = dateTimeDeparture.Value.ToString("HH:mm");
            try
            {
                List<StationBoard> stationBoardEntries = GetStationBoardEntries(txtStartStation.Text, lstStartDestinations.SelectedValue.ToString(), time);
                if (dtGridConnection.Rows.Count != 0 && dtGridConnection.Rows != null)
                {
                    dtGridConnection.Rows.Clear();
                }
                foreach (StationBoard station in stationBoardEntries)
                {
                    string departureStation = textbox.Text;
                    string empty = "/";
                    dtGridConnection.Rows.Add(Convert.ToDateTime(station.Stop.Departure).ToShortDateString(), Convert.ToDateTime(station.Stop.Departure).ToShortTimeString(), departureStation, station.To, empty, empty, empty);
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Es wurde keine Station gewählt!");
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
                                       departureTime = stationBoardEntry.Stop.Departure.ToShortTimeString(),
                                       to = stationBoardEntry.To
                                   };

            dtGridConnection.DataSource = stationBoardList.ToList();
        }

        private Stations getStation(string input)
        {
            Stations stationList = transport.GetStations(input);
            return stationList;
        }
        private void txtStartStation_TextChanged(object sender, EventArgs e)
        {
            Textbox_TextChanged(txtStartStation, lstStartDestinations);
        }
        private void txtEndStation_TextChanged(object sender, EventArgs e)
        {
            Textbox_TextChanged(txtEndStation, lstEndDestinations);
        }

        private void setSearchButtonActive()
        {
            if (!String.IsNullOrEmpty(txtStartStation.Text) && !String.IsNullOrEmpty(txtEndStation.Text))
            {
                btnSearchConnection.Enabled = true;
            }
        }
        private void Textbox_TextChanged(TextBox textbox, ListBox lstBox)
        {
            lstBox.DisplayMember = "Name";
            lstBox.ValueMember = "Id";

            Stations toStations = getStation(textbox.Text);

            lstBox.DataSource = toStations.StationList;

            if (!(String.IsNullOrWhiteSpace(textbox.Text)))
            {
                lstBox.Visible = true;
            }
            else
            {
                lstBox.Visible = false;
            }
            textbox.Focus();
            setSearchButtonActive();
        }
        private void lstDestinations_Enter(object sender, EventArgs e)
        {
            txtStartStation.Text = lstStartDestinations.Text;
        }

        private void lstEndDestinations_Enter(object sender, EventArgs e)
        {
            txtEndStation.Text = lstEndDestinations.Text;
        }

        private void txtStartStation_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(txtStartStation, lstStartDestinations);
        }

        private void txtEndStation_Leave(object sender, EventArgs e)
        {
            TextBox_Leave(txtEndStation, lstEndDestinations);
        }

        private void TextBox_Leave(TextBox textbox, ListBox lstbox)
        {
            textbox.Text = lstbox.Text;
            lstbox.Visible = false;
        }

        private void txtStartStation_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDownEvent(txtStartStation, lstStartDestinations, e);
        }

        private void txtEndStation_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDownEvent(txtEndStation, lstEndDestinations, e);
        }

        private void KeyDownEvent(TextBox textbox, ListBox lstBox, KeyEventArgs e)
        {
            if (textbox.Focused)
            {
                if (lstBox.Items.Count != 0)
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        lstBox.Focus();
                        lstBox.SelectedIndex = 0;
                    }
                    if (lstBox.SelectedIndex != (lstBox.Items.Count - 1))
                    {
                        if (e.KeyCode == Keys.Down)
                        {
                            lstBox.SelectedIndex++;
                        }
                    }
                    if (lstBox.SelectedIndex != 0)
                    {
                        if (e.KeyCode == Keys.Up)
                        {
                            lstBox.SelectedIndex--;
                        }
                    }
                }
            }
        }

        private void btnSwitchStation_Click(object sender, EventArgs e)
        {
            if (txtStartStation.Text == txtEndStation.Text && String.IsNullOrEmpty(txtStartStation.Text) && String.IsNullOrEmpty(txtEndStation.Text))
            {
                MessageBox.Show("Die beiden Felder sind leer. Bitte geben führen Sie eine Eingabe aus.");
            }
            if (txtStartStation.Text == txtEndStation.Text && !String.IsNullOrEmpty(txtStartStation.Text) && !String.IsNullOrEmpty(txtEndStation.Text))
            {
                MessageBox.Show("Die beiden Felder sind gleich. Bitte ändern Sie Ihre Eingabe.");
            }
            if (String.IsNullOrEmpty(txtStartStation.Text) && !String.IsNullOrEmpty(txtEndStation.Text))
            {
                MessageBox.Show("Das Vor-feld ist leer. Bitte geben Sie einen Ort ein.");
                txtStartStation.Focus();
            }
            if (String.IsNullOrEmpty(txtEndStation.Text) && !String.IsNullOrEmpty(txtStartStation.Text))
            {
                MessageBox.Show("Das Nach-feld ist leer. Bitte geben Sie einen Ort ein.");
                txtEndStation.Focus();
            }
            if (!String.IsNullOrEmpty(txtEndStation.Text) && !String.IsNullOrEmpty(txtStartStation.Text))
            {
                string startStation, endStation;
                startStation = txtStartStation.Text;
                endStation = txtEndStation.Text;
                txtStartStation.Text = endStation;
                txtEndStation.Text = startStation;
                btnSearchConnection.Focus();
            }
        }
    }

}

