namespace ÖV_App_GUI
{
    partial class ÖV_App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ÖV_App));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.dtGridConnection = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleisnummer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.lstStartDestinations = new System.Windows.Forms.ListBox();
            this.txtEndStation = new System.Windows.Forms.TextBox();
            this.lstEndDestinations = new System.Windows.Forms.ListBox();
            this.btnSwitchStation = new System.Windows.Forms.Button();
            this.btnShowConnectionFromStart = new System.Windows.Forms.Button();
            this.btnShowConnectionFromEndStation = new System.Windows.Forms.Button();
            this.dateTimeDeparture = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(472, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Nach:";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.BackColor = System.Drawing.Color.Red;
            this.btnSearchConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnection.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearchConnection.Location = new System.Drawing.Point(541, 174);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(169, 65);
            this.btnSearchConnection.TabIndex = 8;
            this.btnSearchConnection.Text = "Verbindung suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = false;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // dtGridConnection
            // 
            this.dtGridConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dtGridConnection.AllowUserToAddRows = false;
            this.dtGridConnection.AllowUserToDeleteRows = false;
            this.dtGridConnection.AllowUserToResizeColumns = false;
            this.dtGridConnection.AllowUserToResizeRows = false;
            this.dtGridConnection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtGridConnection.BackgroundColor = System.Drawing.Color.White;
            this.dtGridConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Departure,
            this.From,
            this.To,
            this.Gleisnummer,
            this.Duration});
            this.dtGridConnection.Location = new System.Drawing.Point(22, 248);
            this.dtGridConnection.Name = "dtGridConnection";
            this.dtGridConnection.ReadOnly = true;
            this.dtGridConnection.RowHeadersVisible = false;
            this.dtGridConnection.Size = new System.Drawing.Size(688, 308);
            this.dtGridConnection.TabIndex = 10;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum:";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Abfahrtszeit:";
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            // 
            // From
            // 
            this.From.HeaderText = "Von:";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // To
            // 
            this.To.HeaderText = "Nach:";
            this.To.Name = "To";
            this.To.ReadOnly = true;
            // 
            // Gleisnummer
            // 
            this.Gleisnummer.HeaderText = "Gleisnummer:";
            this.Gleisnummer.Name = "Gleisnummer";
            this.Gleisnummer.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Fahrtdauer:";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // txtStartStation
            // 
            this.txtStartStation.Location = new System.Drawing.Point(23, 84);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(235, 20);
            this.txtStartStation.TabIndex = 2;
            this.txtStartStation.TextChanged += new System.EventHandler(this.txtStartStation_TextChanged);
            this.txtStartStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartStation_KeyDown);
            this.txtStartStation.Leave += new System.EventHandler(this.txtStartStation_Leave);
            // 
            // lstStartDestinations
            // 
            this.lstStartDestinations.FormattingEnabled = true;
            this.lstStartDestinations.Location = new System.Drawing.Point(23, 102);
            this.lstStartDestinations.Name = "lstStartDestinations";
            this.lstStartDestinations.Size = new System.Drawing.Size(235, 95);
            this.lstStartDestinations.TabIndex = 11;
            this.lstStartDestinations.Visible = false;
            this.lstStartDestinations.Enter += new System.EventHandler(this.lstDestinations_Enter);
            // 
            // txtEndStation
            // 
            this.txtEndStation.Location = new System.Drawing.Point(475, 83);
            this.txtEndStation.Name = "txtEndStation";
            this.txtEndStation.Size = new System.Drawing.Size(235, 20);
            this.txtEndStation.TabIndex = 5;
            this.txtEndStation.TextChanged += new System.EventHandler(this.txtEndStation_TextChanged);
            this.txtEndStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEndStation_KeyDown);
            this.txtEndStation.Leave += new System.EventHandler(this.txtEndStation_Leave);
            // 
            // lstEndDestinations
            // 
            this.lstEndDestinations.FormattingEnabled = true;
            this.lstEndDestinations.Location = new System.Drawing.Point(475, 102);
            this.lstEndDestinations.Name = "lstEndDestinations";
            this.lstEndDestinations.Size = new System.Drawing.Size(235, 95);
            this.lstEndDestinations.TabIndex = 12;
            this.lstEndDestinations.Visible = false;
            this.lstEndDestinations.Enter += new System.EventHandler(this.lstEndDestinations_Enter);
            // 
            // btnSwitchStation
            // 
            this.btnSwitchStation.BackgroundImage = global::ÖV_App_GUI.Properties.Resources.Download1;
            this.btnSwitchStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSwitchStation.Location = new System.Drawing.Point(352, 73);
            this.btnSwitchStation.Name = "btnSwitchStation";
            this.btnSwitchStation.Size = new System.Drawing.Size(36, 38);
            this.btnSwitchStation.TabIndex = 9;
            this.btnSwitchStation.UseVisualStyleBackColor = true;
            this.btnSwitchStation.Click += new System.EventHandler(this.btnSwitchStation_Click);
            // 
            // btnShowConnectionFromStart
            // 
            this.btnShowConnectionFromStart.BackgroundImage = global::ÖV_App_GUI.Properties.Resources.Download;
            this.btnShowConnectionFromStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowConnectionFromStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnShowConnectionFromStart.Location = new System.Drawing.Point(23, 110);
            this.btnShowConnectionFromStart.Name = "btnShowConnectionFromStart";
            this.btnShowConnectionFromStart.Size = new System.Drawing.Size(48, 42);
            this.btnShowConnectionFromStart.TabIndex = 3;
            this.btnShowConnectionFromStart.UseVisualStyleBackColor = true;
            this.btnShowConnectionFromStart.Click += new System.EventHandler(this.btnShowConnectionFromStart_Click);
            // 
            // btnShowConnectionFromEndStation
            // 
            this.btnShowConnectionFromEndStation.BackgroundImage = global::ÖV_App_GUI.Properties.Resources.Download;
            this.btnShowConnectionFromEndStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowConnectionFromEndStation.Location = new System.Drawing.Point(475, 109);
            this.btnShowConnectionFromEndStation.Name = "btnShowConnectionFromEndStation";
            this.btnShowConnectionFromEndStation.Size = new System.Drawing.Size(48, 43);
            this.btnShowConnectionFromEndStation.TabIndex = 6;
            this.btnShowConnectionFromEndStation.UseVisualStyleBackColor = true;
            this.btnShowConnectionFromEndStation.Click += new System.EventHandler(this.btnShowConnectionFromEndStation_Click);
            // 
            // dateTimeDeparture
            // 
            this.dateTimeDeparture.CustomFormat = "HH:mm";
            this.dateTimeDeparture.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDeparture.Location = new System.Drawing.Point(22, 174);
            this.dateTimeDeparture.Name = "dateTimeDeparture";
            this.dateTimeDeparture.Size = new System.Drawing.Size(57, 20);
            this.dateTimeDeparture.TabIndex = 7;
            this.dateTimeDeparture.Value = new System.DateTime(2018, 12, 3, 14, 43, 22, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "&Zeit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(361, 44);
            this.label4.TabIndex = 14;
            this.label4.Text = "Wo solls hingehen?";
            // 
            // ÖV_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(729, 577);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSwitchStation);
            this.Controls.Add(this.lstEndDestinations);
            this.Controls.Add(this.txtEndStation);
            this.Controls.Add(this.lstStartDestinations);
            this.Controls.Add(this.txtStartStation);
            this.Controls.Add(this.dtGridConnection);
            this.Controls.Add(this.btnSearchConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowConnectionFromStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimeDeparture);
            this.Controls.Add(this.btnShowConnectionFromEndStation);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ÖV_App";
            this.Text = "ÖV App ";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.DataGridView dtGridConnection;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.ListBox lstStartDestinations;
        private System.Windows.Forms.TextBox txtEndStation;
        private System.Windows.Forms.ListBox lstEndDestinations;
        private System.Windows.Forms.Button btnShowConnectionFromStart;
        private System.Windows.Forms.Button btnSwitchStation;
        private System.Windows.Forms.Button btnShowConnectionFromEndStation;
        private System.Windows.Forms.DateTimePicker dateTimeDeparture;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleisnummer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
    }
}

