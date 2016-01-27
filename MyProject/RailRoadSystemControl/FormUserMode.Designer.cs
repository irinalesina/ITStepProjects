namespace TrainControlSystem
{
    partial class FormUserMode
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
            this.labelStationFrom = new System.Windows.Forms.Label();
            this.comboBoxStationFrom = new System.Windows.Forms.ComboBox();
            this.comboBoxStationTo = new System.Windows.Forms.ComboBox();
            this.labelStationTo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonFind = new System.Windows.Forms.Button();
            this.tableLayoutPanelSchedule = new System.Windows.Forms.TableLayoutPanel();
            this.labelTrain = new System.Windows.Forms.Label();
            this.labelRoute = new System.Windows.Forms.Label();
            this.labelArrival = new System.Windows.Forms.Label();
            this.labelDeparture = new System.Windows.Forms.Label();
            this.buttonShowMap = new System.Windows.Forms.Button();
            this.tableLayoutPanelSchedule.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStationFrom
            // 
            this.labelStationFrom.AutoSize = true;
            this.labelStationFrom.BackColor = System.Drawing.Color.Transparent;
            this.labelStationFrom.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStationFrom.Location = new System.Drawing.Point(60, 13);
            this.labelStationFrom.Name = "labelStationFrom";
            this.labelStationFrom.Size = new System.Drawing.Size(197, 43);
            this.labelStationFrom.TabIndex = 0;
            this.labelStationFrom.Text = "Station from:";
            // 
            // comboBoxStationFrom
            // 
            this.comboBoxStationFrom.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxStationFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStationFrom.FormattingEnabled = true;
            this.comboBoxStationFrom.Location = new System.Drawing.Point(34, 69);
            this.comboBoxStationFrom.Name = "comboBoxStationFrom";
            this.comboBoxStationFrom.Size = new System.Drawing.Size(251, 21);
            this.comboBoxStationFrom.TabIndex = 0;
            // 
            // comboBoxStationTo
            // 
            this.comboBoxStationTo.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxStationTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStationTo.FormattingEnabled = true;
            this.comboBoxStationTo.Location = new System.Drawing.Point(305, 69);
            this.comboBoxStationTo.Name = "comboBoxStationTo";
            this.comboBoxStationTo.Size = new System.Drawing.Size(251, 21);
            this.comboBoxStationTo.TabIndex = 1;
            // 
            // labelStationTo
            // 
            this.labelStationTo.AutoSize = true;
            this.labelStationTo.BackColor = System.Drawing.Color.Transparent;
            this.labelStationTo.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStationTo.Location = new System.Drawing.Point(348, 13);
            this.labelStationTo.Name = "labelStationTo";
            this.labelStationTo.Size = new System.Drawing.Size(163, 43);
            this.labelStationTo.TabIndex = 2;
            this.labelStationTo.Text = "Station to:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(644, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(575, 70);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(251, 20);
            this.dateTimePickerDate.TabIndex = 2;
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonFind.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFind.Location = new System.Drawing.Point(850, 49);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(153, 41);
            this.buttonFind.TabIndex = 5;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
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
            this.tableLayoutPanelSchedule.Location = new System.Drawing.Point(29, 148);
            this.tableLayoutPanelSchedule.Name = "tableLayoutPanelSchedule";
            this.tableLayoutPanelSchedule.RowCount = 1;
            this.tableLayoutPanelSchedule.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanelSchedule.Size = new System.Drawing.Size(974, 56);
            this.tableLayoutPanelSchedule.TabIndex = 6;
            // 
            // labelTrain
            // 
            this.labelTrain.AutoSize = true;
            this.labelTrain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrain.Location = new System.Drawing.Point(4, 1);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(236, 54);
            this.labelTrain.TabIndex = 0;
            this.labelTrain.Text = "Train";
            this.labelTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRoute
            // 
            this.labelRoute.AutoSize = true;
            this.labelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoute.Location = new System.Drawing.Point(247, 1);
            this.labelRoute.Name = "labelRoute";
            this.labelRoute.Size = new System.Drawing.Size(236, 54);
            this.labelRoute.TabIndex = 1;
            this.labelRoute.Text = "Route";
            this.labelRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelArrival
            // 
            this.labelArrival.AutoSize = true;
            this.labelArrival.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArrival.Location = new System.Drawing.Point(490, 1);
            this.labelArrival.Name = "labelArrival";
            this.labelArrival.Size = new System.Drawing.Size(236, 54);
            this.labelArrival.TabIndex = 2;
            this.labelArrival.Text = "Arrival";
            this.labelArrival.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDeparture
            // 
            this.labelDeparture.AutoSize = true;
            this.labelDeparture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeparture.Location = new System.Drawing.Point(733, 1);
            this.labelDeparture.Name = "labelDeparture";
            this.labelDeparture.Size = new System.Drawing.Size(237, 54);
            this.labelDeparture.TabIndex = 3;
            this.labelDeparture.Text = "Departure";
            this.labelDeparture.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShowMap
            // 
            this.buttonShowMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowMap.Location = new System.Drawing.Point(172, 96);
            this.buttonShowMap.Name = "buttonShowMap";
            this.buttonShowMap.Size = new System.Drawing.Size(241, 23);
            this.buttonShowMap.TabIndex = 7;
            this.buttonShowMap.Text = "Show map";
            this.buttonShowMap.UseVisualStyleBackColor = true;
            this.buttonShowMap.Click += new System.EventHandler(this.buttonShowMap_Click);
            // 
            // FormUserMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainControlSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 498);
            this.Controls.Add(this.buttonShowMap);
            this.Controls.Add(this.tableLayoutPanelSchedule);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStationTo);
            this.Controls.Add(this.labelStationTo);
            this.Controls.Add(this.comboBoxStationFrom);
            this.Controls.Add(this.labelStationFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormUserMode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainControlSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUserMode_FormClosing);
            this.Load += new System.EventHandler(this.FormUserMode_Load);
            this.tableLayoutPanelSchedule.ResumeLayout(false);
            this.tableLayoutPanelSchedule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStationFrom;
        private System.Windows.Forms.ComboBox comboBoxStationFrom;
        private System.Windows.Forms.ComboBox comboBoxStationTo;
        private System.Windows.Forms.Label labelStationTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSchedule;
        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.Label labelRoute;
        private System.Windows.Forms.Label labelArrival;
        private System.Windows.Forms.Label labelDeparture;
        private System.Windows.Forms.Button buttonShowMap;
    }
}