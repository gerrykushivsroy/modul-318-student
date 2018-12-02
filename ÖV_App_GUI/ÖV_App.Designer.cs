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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearchConnection = new System.Windows.Forms.Button();
            this.dataGridConnection = new System.Windows.Forms.DataGridView();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtStartStation = new System.Windows.Forms.TextBox();
            this.lstStartDestinations = new System.Windows.Forms.ListBox();
            this.txtEndStation = new System.Windows.Forms.TextBox();
            this.lstEndDestinations = new System.Windows.Forms.ListBox();
            this.btnShowConnectionFromStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnection)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Von:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(316, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Nach:";
            // 
            // btnSearchConnection
            // 
            this.btnSearchConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConnection.Location = new System.Drawing.Point(462, 145);
            this.btnSearchConnection.Name = "btnSearchConnection";
            this.btnSearchConnection.Size = new System.Drawing.Size(138, 55);
            this.btnSearchConnection.TabIndex = 6;
            this.btnSearchConnection.Text = "Verbindung suchen";
            this.btnSearchConnection.UseVisualStyleBackColor = true;
            this.btnSearchConnection.Click += new System.EventHandler(this.btnSearchConnection_Click);
            // 
            // dataGridConnection
            // 
            this.dataGridConnection.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridConnection.AllowUserToAddRows = false;
            this.dataGridConnection.AllowUserToDeleteRows = false;
            this.dataGridConnection.AllowUserToResizeColumns = false;
            this.dataGridConnection.AllowUserToResizeRows = false;
            this.dataGridConnection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridConnection.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Departure,
            this.From,
            this.To,
            this.Duration});
            this.dataGridConnection.Location = new System.Drawing.Point(22, 238);
            this.dataGridConnection.Name = "dataGridConnection";
            this.dataGridConnection.RowHeadersVisible = false;
            this.dataGridConnection.Size = new System.Drawing.Size(578, 307);
            this.dataGridConnection.TabIndex = 6;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.Name = "Departure";
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.Name = "From";
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.Name = "To";
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            // 
            // txtStartStation
            // 
            this.txtStartStation.Location = new System.Drawing.Point(22, 61);
            this.txtStartStation.Name = "txtStartStation";
            this.txtStartStation.Size = new System.Drawing.Size(175, 20);
            this.txtStartStation.TabIndex = 2;
            this.txtStartStation.TextChanged += new System.EventHandler(this.txtStartStation_TextChanged);
            this.txtStartStation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStartStation_KeyDown);
            this.txtStartStation.Leave += new System.EventHandler(this.txtStartStation_Leave);
            // 
            // lstStartDestinations
            // 
            this.lstStartDestinations.FormattingEnabled = true;
            this.lstStartDestinations.Location = new System.Drawing.Point(22, 79);
            this.lstStartDestinations.Name = "lstStartDestinations";
            this.lstStartDestinations.Size = new System.Drawing.Size(175, 95);
            this.lstStartDestinations.TabIndex = 8;
            this.lstStartDestinations.Visible = false;
            this.lstStartDestinations.Enter += new System.EventHandler(this.lstDestinations_Enter);
            // 
            // txtEndStation
            // 
            this.txtEndStation.Location = new System.Drawing.Point(320, 61);
            this.txtEndStation.Name = "txtEndStation";
            this.txtEndStation.Size = new System.Drawing.Size(175, 20);
            this.txtEndStation.TabIndex = 5;
            this.txtEndStation.TextChanged += new System.EventHandler(this.txtEndStation_TextChanged);
            this.txtEndStation.Leave += new System.EventHandler(this.txtEndStation_Leave);
            // 
            // lstEndDestinations
            // 
            this.lstEndDestinations.FormattingEnabled = true;
            this.lstEndDestinations.Location = new System.Drawing.Point(320, 79);
            this.lstEndDestinations.Name = "lstEndDestinations";
            this.lstEndDestinations.Size = new System.Drawing.Size(175, 95);
            this.lstEndDestinations.TabIndex = 10;
            this.lstEndDestinations.Visible = false;
            this.lstEndDestinations.Enter += new System.EventHandler(this.lstEndDestinations_Enter);
            // 
            // btnShowConnectionFromStart
            // 
            this.btnShowConnectionFromStart.Location = new System.Drawing.Point(203, 61);
            this.btnShowConnectionFromStart.Name = "btnShowConnectionFromStart";
            this.btnShowConnectionFromStart.Size = new System.Drawing.Size(81, 37);
            this.btnShowConnectionFromStart.TabIndex = 3;
            this.btnShowConnectionFromStart.Text = "Verbindung anzeigen";
            this.btnShowConnectionFromStart.UseVisualStyleBackColor = true;
            this.btnShowConnectionFromStart.Click += new System.EventHandler(this.btnShowConnectionFromStart_Click);
            // 
            // ÖV_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(648, 600);
            this.Controls.Add(this.btnShowConnectionFromStart);
            this.Controls.Add(this.lstEndDestinations);
            this.Controls.Add(this.txtEndStation);
            this.Controls.Add(this.lstStartDestinations);
            this.Controls.Add(this.txtStartStation);
            this.Controls.Add(this.dataGridConnection);
            this.Controls.Add(this.btnSearchConnection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ÖV_App";
            this.Text = "ÖV App V2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridConnection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearchConnection;
        private System.Windows.Forms.DataGridView dataGridConnection;
        private System.Windows.Forms.TextBox txtStartStation;
        private System.Windows.Forms.ListBox lstStartDestinations;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departure;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.TextBox txtEndStation;
        private System.Windows.Forms.ListBox lstEndDestinations;
        private System.Windows.Forms.Button btnShowConnectionFromStart;
    }
}

