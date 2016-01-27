namespace TrainControlSystem
{
    partial class FormSchedule
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
            this.components = new System.ComponentModel.Container();
            this.lableStation = new System.Windows.Forms.Label();
            this.tableLayoutPanelSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.labelTrain = new System.Windows.Forms.Label();
            this.labelRoute = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.comboBoxStations = new System.Windows.Forms.ComboBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lableStation
            // 
            this.lableStation.AutoSize = true;
            this.lableStation.BackColor = System.Drawing.Color.Transparent;
            this.lableStation.Dock = System.Windows.Forms.DockStyle.Left;
            this.lableStation.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableStation.Location = new System.Drawing.Point(0, 0);
            this.lableStation.Name = "lableStation";
            this.lableStation.Size = new System.Drawing.Size(263, 57);
            this.lableStation.TabIndex = 1;
            this.lableStation.Text = "Select station:";
            // 
            // tableLayoutPanelSchedule
            // 
            this.tableLayoutPanelSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelSchedule.AutoSize = true;
            this.tableLayoutPanelSchedule.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelSchedule.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelSchedule.ColumnCount = 4;
            this.tableLayoutPanelSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSchedule.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelSchedule.Controls.Add(this.labelTrain, 0, 0);
            this.tableLayoutPanelSchedule.Controls.Add(this.labelRoute, 1, 0);
            this.tableLayoutPanelSchedule.Controls.Add(this.labelArrival, 2, 0);
            this.tableLayoutPanelSchedule.Controls.Add(this.labelDeparture, 3, 0);
            this.tableLayoutPanelSchedule.Location = new System.Drawing.Point(2, 71);
            this.tableLayoutPanelSchedule.Name = "tableLayoutPanelSchedule";
            this.tableLayoutPanelSchedule.RowCount = 1;
            this.tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelSchedule.Size = new System.Drawing.Size(697, 57);
            this.tableLayoutPanelSchedule.TabIndex = 2;
            // 
            // labelTrain
            // 
            this.labelTrain.AutoSize = true;
            this.labelTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrain.Location = new System.Drawing.Point(4, 1);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(167, 55);
            this.labelTrain.TabIndex = 0;
            this.labelTrain.Text = "Train";
            this.labelTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoute.Location = new System.Drawing.Point(178, 1);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(167, 55);
            this.labelRoute.TabIndex = 1;
            this.labelRoute.Text = "Route";
            this.labelRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArrival.Location = new System.Drawing.Point(352, 1);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(167, 55);
            this.labelArrival.TabIndex = 2;
            this.labelArrival.Text = "Arrival";
            this.labelArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeparture.Location = new System.Drawing.Point(526, 1);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(167, 55);
            this.labelDeparture.TabIndex = 3;
            this.labelDeparture.Text = "Departure";
            this.labelDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labelDateTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDateTime.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateTime.Location = new System.Drawing.Point(520, 0);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(179, 57);
            this.labelDateTime.TabIndex = 3;
            this.labelDateTime.Text = "dateTime";
            // 
            // comboBoxStations
            // 
            this.comboBoxStations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStations.FormattingEnabled = true;
            this.comboBoxStations.Location = new System.Drawing.Point(279, 25);
            this.comboBoxStations.Name = "comboBoxStations";
            this.comboBoxStations.Size = new System.Drawing.Size(219, 21);
            this.comboBoxStations.TabIndex = 4;
            this.comboBoxStations.SelectedIndexChanged += new System.EventHandler(this.comboBoxStations_SelectedIndexChanged);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 60000;
            this.timerUpdate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSchedule
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainControlSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(699, 374);
            this.Controls.Add(this.comboBoxStations);
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.tableLayoutPanelSchedule);
            this.Controls.Add(this.lableStation);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "FormSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainControlSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUser_FormClosing);
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.tableLayoutPanelSchedule.ResumeLayout(false);
            this.tableLayoutPanelSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableStation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSchedule;
        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.ComboBox comboBoxStations;
        private System.Windows.Forms.Timer timerUpdate;
    }
}