namespace TrainControlSystem
{
    partial class FormCreateRoute
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
            this.labelRouteName = new System.Windows.Forms.Label();
            this.textBoxRouteName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAddStation = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectedStation = new System.Windows.Forms.Label();
            this.labelSelectedArrivalTime = new System.Windows.Forms.Label();
            this.labelSelectedDepartureTime = new System.Windows.Forms.Label();
            this.comboBoxSelectedStation = new System.Windows.Forms.ComboBox();
            this.dateTimePickerArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanelSelectedRoute = new System.Windows.Forms.TableLayoutPanel();
            this.labelSelectedRoute = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelSelectedRoute = new System.Windows.Forms.Panel();
            this.tableLayoutPanelHand = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanelAddStation.SuspendLayout();
            this.panelSelectedRoute.SuspendLayout();
            this.tableLayoutPanelHand.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelRouteName
            // 
            this.labelRouteName.AutoSize = true;
            this.labelRouteName.BackColor = System.Drawing.Color.Transparent;
            this.labelRouteName.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRouteName.Location = new System.Drawing.Point(23, 18);
            this.labelRouteName.Name = "labelRouteName";
            this.labelRouteName.Size = new System.Drawing.Size(153, 36);
            this.labelRouteName.TabIndex = 101;
            this.labelRouteName.Text = "Route name:";
            // 
            // textBoxRouteName
            // 
            this.textBoxRouteName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxRouteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRouteName.Location = new System.Drawing.Point(198, 31);
            this.textBoxRouteName.Name = "textBoxRouteName";
            this.textBoxRouteName.Size = new System.Drawing.Size(219, 22);
            this.textBoxRouteName.TabIndex = 0;
            // 
            // tableLayoutPanelAddStation
            // 
            this.tableLayoutPanelAddStation.AutoSize = true;
            this.tableLayoutPanelAddStation.BackColor = System.Drawing.Color.Beige;
            this.tableLayoutPanelAddStation.ColumnCount = 3;
            this.tableLayoutPanelAddStation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelAddStation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelAddStation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelAddStation.Controls.Add(this.labelSelectedStation, 0, 0);
            this.tableLayoutPanelAddStation.Controls.Add(this.labelSelectedArrivalTime, 1, 0);
            this.tableLayoutPanelAddStation.Controls.Add(this.labelSelectedDepartureTime, 2, 0);
            this.tableLayoutPanelAddStation.Controls.Add(this.comboBoxSelectedStation, 0, 1);
            this.tableLayoutPanelAddStation.Controls.Add(this.dateTimePickerArrivalTime, 1, 1);
            this.tableLayoutPanelAddStation.Controls.Add(this.dateTimePickerDepartureTime, 2, 1);
            this.tableLayoutPanelAddStation.Location = new System.Drawing.Point(29, 82);
            this.tableLayoutPanelAddStation.Name = "tableLayoutPanelAddStation";
            this.tableLayoutPanelAddStation.RowCount = 2;
            this.tableLayoutPanelAddStation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAddStation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelAddStation.Size = new System.Drawing.Size(651, 60);
            this.tableLayoutPanelAddStation.TabIndex = 103;
            // 
            // labelSelectedStation
            // 
            this.labelSelectedStation.AutoSize = true;
            this.labelSelectedStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectedStation.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectedStation.Location = new System.Drawing.Point(3, 0);
            this.labelSelectedStation.Name = "labelSelectedStation";
            this.labelSelectedStation.Size = new System.Drawing.Size(210, 30);
            this.labelSelectedStation.TabIndex = 0;
            this.labelSelectedStation.Text = "Station";
            this.labelSelectedStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelectedArrivalTime
            // 
            this.labelSelectedArrivalTime.AutoSize = true;
            this.labelSelectedArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectedArrivalTime.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectedArrivalTime.Location = new System.Drawing.Point(219, 0);
            this.labelSelectedArrivalTime.Name = "labelSelectedArrivalTime";
            this.labelSelectedArrivalTime.Size = new System.Drawing.Size(211, 30);
            this.labelSelectedArrivalTime.TabIndex = 1;
            this.labelSelectedArrivalTime.Text = "Arrival time";
            this.labelSelectedArrivalTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSelectedDepartureTime
            // 
            this.labelSelectedDepartureTime.AutoSize = true;
            this.labelSelectedDepartureTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSelectedDepartureTime.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectedDepartureTime.Location = new System.Drawing.Point(436, 0);
            this.labelSelectedDepartureTime.Name = "labelSelectedDepartureTime";
            this.labelSelectedDepartureTime.Size = new System.Drawing.Size(212, 30);
            this.labelSelectedDepartureTime.TabIndex = 2;
            this.labelSelectedDepartureTime.Text = "Departure time";
            this.labelSelectedDepartureTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxSelectedStation
            // 
            this.comboBoxSelectedStation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSelectedStation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectedStation.FormattingEnabled = true;
            this.comboBoxSelectedStation.Location = new System.Drawing.Point(3, 33);
            this.comboBoxSelectedStation.Name = "comboBoxSelectedStation";
            this.comboBoxSelectedStation.Size = new System.Drawing.Size(210, 21);
            this.comboBoxSelectedStation.TabIndex = 1;
            // 
            // dateTimePickerArrivalTime
            // 
            this.dateTimePickerArrivalTime.CustomFormat = "HH:mm";
            this.dateTimePickerArrivalTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerArrivalTime.Location = new System.Drawing.Point(219, 33);
            this.dateTimePickerArrivalTime.Name = "dateTimePickerArrivalTime";
            this.dateTimePickerArrivalTime.ShowUpDown = true;
            this.dateTimePickerArrivalTime.Size = new System.Drawing.Size(211, 20);
            this.dateTimePickerArrivalTime.TabIndex = 2;
            // 
            // dateTimePickerDepartureTime
            // 
            this.dateTimePickerDepartureTime.CustomFormat = "HH:mm";
            this.dateTimePickerDepartureTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimePickerDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDepartureTime.Location = new System.Drawing.Point(436, 33);
            this.dateTimePickerDepartureTime.Name = "dateTimePickerDepartureTime";
            this.dateTimePickerDepartureTime.ShowUpDown = true;
            this.dateTimePickerDepartureTime.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerDepartureTime.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(689, 96);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(89, 39);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tableLayoutPanelSelectedRoute
            // 
            this.tableLayoutPanelSelectedRoute.AutoSize = true;
            this.tableLayoutPanelSelectedRoute.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelSelectedRoute.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelSelectedRoute.ColumnCount = 3;
            this.tableLayoutPanelSelectedRoute.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSelectedRoute.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelSelectedRoute.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelSelectedRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelSelectedRoute.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelSelectedRoute.Name = "tableLayoutPanelSelectedRoute";
            this.tableLayoutPanelSelectedRoute.RowCount = 1;
            this.tableLayoutPanelSelectedRoute.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelSelectedRoute.Size = new System.Drawing.Size(882, 37);
            this.tableLayoutPanelSelectedRoute.TabIndex = 104;
            // 
            // labelSelectedRoute
            // 
            this.labelSelectedRoute.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelSelectedRoute.AutoSize = true;
            this.labelSelectedRoute.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectedRoute.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectedRoute.Location = new System.Drawing.Point(353, 152);
            this.labelSelectedRoute.Name = "labelSelectedRoute";
            this.labelSelectedRoute.Size = new System.Drawing.Size(270, 57);
            this.labelSelectedRoute.TabIndex = 105;
            this.labelSelectedRoute.Text = "Selected route";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSave.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(379, 425);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(177, 43);
            this.buttonSave.TabIndex = 106;
            this.buttonSave.Text = "Save route";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelSelectedRoute
            // 
            this.panelSelectedRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSelectedRoute.AutoScroll = true;
            this.panelSelectedRoute.BackColor = System.Drawing.Color.Transparent;
            this.panelSelectedRoute.Controls.Add(this.tableLayoutPanelSelectedRoute);
            this.panelSelectedRoute.Location = new System.Drawing.Point(32, 264);
            this.panelSelectedRoute.Name = "panelSelectedRoute";
            this.panelSelectedRoute.Size = new System.Drawing.Size(882, 141);
            this.panelSelectedRoute.TabIndex = 107;
            // 
            // tableLayoutPanelHand
            // 
            this.tableLayoutPanelHand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelHand.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelHand.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanelHand.ColumnCount = 3;
            this.tableLayoutPanelHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanelHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelHand.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHand.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanelHand.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanelHand.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanelHand.Location = new System.Drawing.Point(32, 214);
            this.tableLayoutPanelHand.Name = "tableLayoutPanelHand";
            this.tableLayoutPanelHand.RowCount = 1;
            this.tableLayoutPanelHand.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanelHand.Size = new System.Drawing.Size(882, 49);
            this.tableLayoutPanelHand.TabIndex = 108;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Station";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(298, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 53);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arrival time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(591, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 53);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure time";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCreateRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainControlSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(946, 489);
            this.Controls.Add(this.tableLayoutPanelHand);
            this.Controls.Add(this.panelSelectedRoute);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelSelectedRoute);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.tableLayoutPanelAddStation);
            this.Controls.Add(this.textBoxRouteName);
            this.Controls.Add(this.labelRouteName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCreateRoute";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainControlSystem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreateRoute_FormClosing);
            this.Load += new System.EventHandler(this.FormCreateRoute_Load);
            this.tableLayoutPanelAddStation.ResumeLayout(false);
            this.tableLayoutPanelAddStation.PerformLayout();
            this.panelSelectedRoute.ResumeLayout(false);
            this.panelSelectedRoute.PerformLayout();
            this.tableLayoutPanelHand.ResumeLayout(false);
            this.tableLayoutPanelHand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRouteName;
        private System.Windows.Forms.TextBox textBoxRouteName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAddStation;
        private System.Windows.Forms.Label labelSelectedStation;
        private System.Windows.Forms.Label labelSelectedArrivalTime;
        private System.Windows.Forms.Label labelSelectedDepartureTime;
        private System.Windows.Forms.ComboBox comboBoxSelectedStation;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivalTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepartureTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSelectedRoute;
        private System.Windows.Forms.Label labelSelectedRoute;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelSelectedRoute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}