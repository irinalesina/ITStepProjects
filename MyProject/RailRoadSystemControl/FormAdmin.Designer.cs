namespace TrainControlSystem
{
    partial class FormAdmin
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
            this.labelTrainNumb = new System.Windows.Forms.Label();
            this.labelTrainDepartureDate = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.labelTrainDepartureTime = new System.Windows.Forms.Label();
            this.labelTrainRoute = new System.Windows.Forms.Label();
            this.comboBoxRoute = new System.Windows.Forms.ComboBox();
            this.buttonAddRecordInSchedule = new System.Windows.Forms.Button();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxTrain = new System.Windows.Forms.ComboBox();
            this.buttonCreateTrain = new System.Windows.Forms.Button();
            this.buttonCreateRoute = new System.Windows.Forms.Button();
            this.labelRouteStations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTrainNumb
            // 
            this.labelTrainNumb.AutoSize = true;
            this.labelTrainNumb.BackColor = System.Drawing.Color.Transparent;
            this.labelTrainNumb.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainNumb.Location = new System.Drawing.Point(32, 20);
            this.labelTrainNumb.Name = "labelTrainNumb";
            this.labelTrainNumb.Size = new System.Drawing.Size(84, 36);
            this.labelTrainNumb.TabIndex = 100;
            this.labelTrainNumb.Text = "Train:";
            // 
            // labelTrainDepartureDate
            // 
            this.labelTrainDepartureDate.AutoSize = true;
            this.labelTrainDepartureDate.BackColor = System.Drawing.Color.Transparent;
            this.labelTrainDepartureDate.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainDepartureDate.Location = new System.Drawing.Point(32, 96);
            this.labelTrainDepartureDate.Name = "labelTrainDepartureDate";
            this.labelTrainDepartureDate.Size = new System.Drawing.Size(193, 36);
            this.labelTrainDepartureDate.TabIndex = 2;
            this.labelTrainDepartureDate.Text = "Departure date:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDate.Location = new System.Drawing.Point(38, 153);
            this.dateTimePickerDate.MinDate = new System.DateTime(2015, 11, 3, 0, 0, 0, 0);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(245, 20);
            this.dateTimePickerDate.TabIndex = 2;
            this.dateTimePickerDate.Value = new System.DateTime(2015, 11, 24, 23, 59, 59, 0);
            // 
            // labelTrainDepartureTime
            // 
            this.labelTrainDepartureTime.AutoSize = true;
            this.labelTrainDepartureTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTrainDepartureTime.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainDepartureTime.Location = new System.Drawing.Point(31, 197);
            this.labelTrainDepartureTime.Name = "labelTrainDepartureTime";
            this.labelTrainDepartureTime.Size = new System.Drawing.Size(193, 36);
            this.labelTrainDepartureTime.TabIndex = 4;
            this.labelTrainDepartureTime.Text = "Departure time:";
            // 
            // labelTrainRoute
            // 
            this.labelTrainRoute.AutoSize = true;
            this.labelTrainRoute.BackColor = System.Drawing.Color.Transparent;
            this.labelTrainRoute.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainRoute.Location = new System.Drawing.Point(32, 283);
            this.labelTrainRoute.Name = "labelTrainRoute";
            this.labelTrainRoute.Size = new System.Drawing.Size(90, 36);
            this.labelTrainRoute.TabIndex = 105;
            this.labelTrainRoute.Text = "Route:";
            // 
            // comboBoxRoute
            // 
            this.comboBoxRoute.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoute.FormattingEnabled = true;
            this.comboBoxRoute.Location = new System.Drawing.Point(38, 334);
            this.comboBoxRoute.Name = "comboBoxRoute";
            this.comboBoxRoute.Size = new System.Drawing.Size(245, 21);
            this.comboBoxRoute.TabIndex = 4;
            this.comboBoxRoute.SelectedIndexChanged += new System.EventHandler(this.comboBoxRoute_SelectedIndexChanged);
            // 
            // buttonAddRecordInSchedule
            // 
            this.buttonAddRecordInSchedule.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAddRecordInSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRecordInSchedule.Location = new System.Drawing.Point(142, 450);
            this.buttonAddRecordInSchedule.Name = "buttonAddRecordInSchedule";
            this.buttonAddRecordInSchedule.Size = new System.Drawing.Size(207, 42);
            this.buttonAddRecordInSchedule.TabIndex = 6;
            this.buttonAddRecordInSchedule.Text = "Add record in schedule";
            this.buttonAddRecordInSchedule.UseVisualStyleBackColor = false;
            this.buttonAddRecordInSchedule.Click += new System.EventHandler(this.buttonAddRecordInSchedule_Click);
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dateTimePickerTime.Location = new System.Drawing.Point(38, 249);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.Size = new System.Drawing.Size(245, 20);
            this.dateTimePickerTime.TabIndex = 3;
            // 
            // comboBoxTrain
            // 
            this.comboBoxTrain.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrain.FormattingEnabled = true;
            this.comboBoxTrain.Location = new System.Drawing.Point(37, 59);
            this.comboBoxTrain.Name = "comboBoxTrain";
            this.comboBoxTrain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxTrain.Size = new System.Drawing.Size(244, 21);
            this.comboBoxTrain.TabIndex = 0;
            // 
            // buttonCreateTrain
            // 
            this.buttonCreateTrain.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCreateTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateTrain.Location = new System.Drawing.Point(328, 56);
            this.buttonCreateTrain.Name = "buttonCreateTrain";
            this.buttonCreateTrain.Size = new System.Drawing.Size(91, 25);
            this.buttonCreateTrain.TabIndex = 1;
            this.buttonCreateTrain.Text = "Create train";
            this.buttonCreateTrain.UseVisualStyleBackColor = false;
            this.buttonCreateTrain.Click += new System.EventHandler(this.buttonCreateTrain_Click);
            // 
            // buttonCreateRoute
            // 
            this.buttonCreateRoute.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonCreateRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateRoute.Location = new System.Drawing.Point(328, 331);
            this.buttonCreateRoute.Name = "buttonCreateRoute";
            this.buttonCreateRoute.Size = new System.Drawing.Size(91, 25);
            this.buttonCreateRoute.TabIndex = 5;
            this.buttonCreateRoute.Text = "Create route";
            this.buttonCreateRoute.UseVisualStyleBackColor = false;
            this.buttonCreateRoute.Click += new System.EventHandler(this.buttonCreateRoute_Click);
            // 
            // labelRouteStations
            // 
            this.labelRouteStations.AutoSize = true;
            this.labelRouteStations.BackColor = System.Drawing.Color.Transparent;
            this.labelRouteStations.Location = new System.Drawing.Point(37, 373);
            this.labelRouteStations.Name = "labelRouteStations";
            this.labelRouteStations.Size = new System.Drawing.Size(0, 13);
            this.labelRouteStations.TabIndex = 106;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainControlSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(495, 504);
            this.Controls.Add(this.labelRouteStations);
            this.Controls.Add(this.buttonCreateRoute);
            this.Controls.Add(this.buttonCreateTrain);
            this.Controls.Add(this.comboBoxTrain);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.buttonAddRecordInSchedule);
            this.Controls.Add(this.comboBoxRoute);
            this.Controls.Add(this.labelTrainRoute);
            this.Controls.Add(this.labelTrainDepartureTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.labelTrainDepartureDate);
            this.Controls.Add(this.labelTrainNumb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainControlSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTrainNumb;
        private System.Windows.Forms.Label labelTrainDepartureDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelTrainDepartureTime;
        private System.Windows.Forms.Label labelTrainRoute;
        private System.Windows.Forms.ComboBox comboBoxRoute;
        private System.Windows.Forms.Button buttonAddRecordInSchedule;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.ComboBox comboBoxTrain;
        private System.Windows.Forms.Button buttonCreateTrain;
        private System.Windows.Forms.Button buttonCreateRoute;
        private System.Windows.Forms.Label labelRouteStations;
    }
}