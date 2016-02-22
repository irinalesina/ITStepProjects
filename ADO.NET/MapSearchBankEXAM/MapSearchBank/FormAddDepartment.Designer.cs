namespace MapSearchBank
{
    partial class FormAddDepartment
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
            this.dgVDepCerrency = new System.Windows.Forms.DataGridView();
            this.gMapControlAddDepartment = new GMap.NET.WindowsForms.GMapControl();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxBanks = new System.Windows.Forms.ComboBox();
            this.buttonAddBank = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sell = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgVDepCerrency)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVDepCerrency
            // 
            this.dgVDepCerrency.AllowUserToAddRows = false;
            this.dgVDepCerrency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgVDepCerrency.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgVDepCerrency.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVDepCerrency.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Currency,
            this.Buy,
            this.Sell,
            this.Use});
            this.dgVDepCerrency.Location = new System.Drawing.Point(883, 294);
            this.dgVDepCerrency.Name = "dgVDepCerrency";
            this.dgVDepCerrency.RowHeadersVisible = false;
            this.dgVDepCerrency.Size = new System.Drawing.Size(269, 158);
            this.dgVDepCerrency.TabIndex = 53;
            // 
            // gMapControlAddDepartment
            // 
            this.gMapControlAddDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gMapControlAddDepartment.Bearing = 0F;
            this.gMapControlAddDepartment.CanDragMap = true;
            this.gMapControlAddDepartment.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControlAddDepartment.GrayScaleMode = false;
            this.gMapControlAddDepartment.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlAddDepartment.LevelsKeepInMemmory = 5;
            this.gMapControlAddDepartment.Location = new System.Drawing.Point(-29, -9);
            this.gMapControlAddDepartment.MarkersEnabled = true;
            this.gMapControlAddDepartment.MaxZoom = 2;
            this.gMapControlAddDepartment.MinZoom = 2;
            this.gMapControlAddDepartment.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlAddDepartment.Name = "gMapControlAddDepartment";
            this.gMapControlAddDepartment.NegativeMode = false;
            this.gMapControlAddDepartment.PolygonsEnabled = true;
            this.gMapControlAddDepartment.RetryLoadTile = 0;
            this.gMapControlAddDepartment.RoutesEnabled = true;
            this.gMapControlAddDepartment.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControlAddDepartment.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlAddDepartment.ShowTileGridLines = false;
            this.gMapControlAddDepartment.Size = new System.Drawing.Size(851, 636);
            this.gMapControlAddDepartment.TabIndex = 38;
            this.gMapControlAddDepartment.Zoom = 0D;
            this.gMapControlAddDepartment.Load += new System.EventHandler(this.gMapControl1_Load);
            this.gMapControlAddDepartment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gMapControlAddDepartment_MouseClick);
            // 
            // elementHost1
            // 
            this.elementHost1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.elementHost1.BackColor = System.Drawing.Color.Transparent;
            this.elementHost1.BackColorTransparent = true;
            this.elementHost1.Location = new System.Drawing.Point(883, 12);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(269, 483);
            this.elementHost1.TabIndex = 39;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(958, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(955, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "X";
            // 
            // textBoxY
            // 
            this.textBoxY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxY.Location = new System.Drawing.Point(883, 248);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(269, 20);
            this.textBoxY.TabIndex = 50;
            // 
            // textBoxX
            // 
            this.textBoxX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxX.Location = new System.Drawing.Point(883, 206);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(269, 20);
            this.textBoxX.TabIndex = 49;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.Location = new System.Drawing.Point(883, 159);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(269, 20);
            this.textBoxPhone.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(948, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Телефон";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Location = new System.Drawing.Point(883, 118);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(269, 20);
            this.textBoxAddress.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(948, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Адресс";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(948, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Название отделения";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Выбор банка";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepartment.Location = new System.Drawing.Point(883, 74);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(269, 20);
            this.textBoxDepartment.TabIndex = 42;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(883, 458);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(269, 37);
            this.buttonSave.TabIndex = 41;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxBanks
            // 
            this.comboBoxBanks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxBanks.FormattingEnabled = true;
            this.comboBoxBanks.Location = new System.Drawing.Point(883, 31);
            this.comboBoxBanks.Name = "comboBoxBanks";
            this.comboBoxBanks.Size = new System.Drawing.Size(269, 21);
            this.comboBoxBanks.TabIndex = 40;
            // 
            // buttonAddBank
            // 
            this.buttonAddBank.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBank.Location = new System.Drawing.Point(1032, 11);
            this.buttonAddBank.Name = "buttonAddBank";
            this.buttonAddBank.Size = new System.Drawing.Size(120, 21);
            this.buttonAddBank.TabIndex = 55;
            this.buttonAddBank.Text = "Создать банк";
            this.buttonAddBank.UseVisualStyleBackColor = true;
            this.buttonAddBank.Click += new System.EventHandler(this.buttonAddBank_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(955, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Добавить курсы валют";
            // 
            // Currency
            // 
            this.Currency.HeaderText = "Валюта";
            this.Currency.Name = "Currency";
            this.Currency.ReadOnly = true;
            this.Currency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Buy
            // 
            this.Buy.HeaderText = "Покупка";
            this.Buy.Name = "Buy";
            // 
            // Sell
            // 
            this.Sell.HeaderText = "Продажа";
            this.Sell.Name = "Sell";
            // 
            // Use
            // 
            this.Use.HeaderText = "Use";
            this.Use.Name = "Use";
            // 
            // FormAddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonAddBank);
            this.Controls.Add(this.dgVDepCerrency);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxBanks);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.gMapControlAddDepartment);
            this.Name = "FormAddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.dgVDepCerrency)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControlAddDepartment;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxBanks;
        private System.Windows.Forms.Button buttonAddBank;
        private System.Windows.Forms.DataGridView dgVDepCerrency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sell;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Use;
    }
}