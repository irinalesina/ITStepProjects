namespace TrainControlSystem
{
    partial class FormCreateTrain
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
            this.textBoxTrainNumber = new System.Windows.Forms.TextBox();
            this.labelTrainNumber = new System.Windows.Forms.Label();
            this.listBoxWagonTypes = new System.Windows.Forms.ListBox();
            this.listBoxTrain = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTrainNumber
            // 
            this.textBoxTrainNumber.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxTrainNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTrainNumber.Location = new System.Drawing.Point(200, 34);
            this.textBoxTrainNumber.Name = "textBoxTrainNumber";
            this.textBoxTrainNumber.Size = new System.Drawing.Size(234, 22);
            this.textBoxTrainNumber.TabIndex = 102;
            // 
            // labelTrainNumber
            // 
            this.labelTrainNumber.AutoSize = true;
            this.labelTrainNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelTrainNumber.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTrainNumber.Location = new System.Drawing.Point(25, 21);
            this.labelTrainNumber.Name = "labelTrainNumber";
            this.labelTrainNumber.Size = new System.Drawing.Size(171, 36);
            this.labelTrainNumber.TabIndex = 103;
            this.labelTrainNumber.Text = "Train number:";
            // 
            // listBoxWagonTypes
            // 
            this.listBoxWagonTypes.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxWagonTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxWagonTypes.FormattingEnabled = true;
            this.listBoxWagonTypes.ItemHeight = 20;
            this.listBoxWagonTypes.Location = new System.Drawing.Point(31, 93);
            this.listBoxWagonTypes.Name = "listBoxWagonTypes";
            this.listBoxWagonTypes.Size = new System.Drawing.Size(167, 224);
            this.listBoxWagonTypes.TabIndex = 104;
            this.listBoxWagonTypes.SelectedIndexChanged += new System.EventHandler(this.listBoxWagonTypes_SelectedIndexChanged);
            // 
            // listBoxTrain
            // 
            this.listBoxTrain.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxTrain.FormattingEnabled = true;
            this.listBoxTrain.ItemHeight = 20;
            this.listBoxTrain.Location = new System.Drawing.Point(267, 93);
            this.listBoxTrain.Name = "listBoxTrain";
            this.listBoxTrain.Size = new System.Drawing.Size(167, 224);
            this.listBoxTrain.TabIndex = 105;
            this.listBoxTrain.SelectedIndexChanged += new System.EventHandler(this.listBoxTrain_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdd.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(150, 372);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(161, 52);
            this.buttonAdd.TabIndex = 106;
            this.buttonAdd.Text = "Add train";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormCreateTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TrainControlSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 449);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxTrain);
            this.Controls.Add(this.listBoxWagonTypes);
            this.Controls.Add(this.textBoxTrainNumber);
            this.Controls.Add(this.labelTrainNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormCreateTrain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainControlSystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCreateTrain_FormClosing);
            this.Load += new System.EventHandler(this.FormCreateTrain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTrainNumber;
        private System.Windows.Forms.Label labelTrainNumber;
        private System.Windows.Forms.ListBox listBoxWagonTypes;
        private System.Windows.Forms.ListBox listBoxTrain;
        private System.Windows.Forms.Button buttonAdd;
    }
}