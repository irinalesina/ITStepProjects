namespace TrainControlSystem
{
    partial class FormMap
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
            this.splitContainerMap = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxStationTo = new System.Windows.Forms.TextBox();
            this.labelStationTo = new System.Windows.Forms.Label();
            this.textBoxStationFrom = new System.Windows.Forms.TextBox();
            this.labelStationFrom = new System.Windows.Forms.Label();
            this.webBrowserGoogleMaps = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMap)).BeginInit();
            this.splitContainerMap.Panel1.SuspendLayout();
            this.splitContainerMap.Panel2.SuspendLayout();
            this.splitContainerMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMap
            // 
            this.splitContainerMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMap.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMap.Name = "splitContainerMap";
            // 
            // splitContainerMap.Panel1
            // 
            this.splitContainerMap.Panel1.Controls.Add(this.button1);
            this.splitContainerMap.Panel1.Controls.Add(this.textBoxStationTo);
            this.splitContainerMap.Panel1.Controls.Add(this.labelStationTo);
            this.splitContainerMap.Panel1.Controls.Add(this.textBoxStationFrom);
            this.splitContainerMap.Panel1.Controls.Add(this.labelStationFrom);
            // 
            // splitContainerMap.Panel2
            // 
            this.splitContainerMap.Panel2.Controls.Add(this.webBrowserGoogleMaps);
            this.splitContainerMap.Size = new System.Drawing.Size(721, 473);
            this.splitContainerMap.SplitterDistance = 180;
            this.splitContainerMap.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(51, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Find route";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxStationTo
            // 
            this.textBoxStationTo.Location = new System.Drawing.Point(16, 116);
            this.textBoxStationTo.Name = "textBoxStationTo";
            this.textBoxStationTo.Size = new System.Drawing.Size(152, 20);
            this.textBoxStationTo.TabIndex = 3;
            // 
            // labelStationTo
            // 
            this.labelStationTo.AutoSize = true;
            this.labelStationTo.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationTo.Location = new System.Drawing.Point(13, 82);
            this.labelStationTo.Name = "labelStationTo";
            this.labelStationTo.Size = new System.Drawing.Size(32, 18);
            this.labelStationTo.TabIndex = 2;
            this.labelStationTo.Text = "To:";
            // 
            // textBoxStationFrom
            // 
            this.textBoxStationFrom.Location = new System.Drawing.Point(16, 43);
            this.textBoxStationFrom.Name = "textBoxStationFrom";
            this.textBoxStationFrom.Size = new System.Drawing.Size(152, 20);
            this.textBoxStationFrom.TabIndex = 1;
            // 
            // labelStationFrom
            // 
            this.labelStationFrom.AutoSize = true;
            this.labelStationFrom.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStationFrom.Location = new System.Drawing.Point(13, 13);
            this.labelStationFrom.Name = "labelStationFrom";
            this.labelStationFrom.Size = new System.Drawing.Size(52, 18);
            this.labelStationFrom.TabIndex = 0;
            this.labelStationFrom.Text = "From:";
            // 
            // webBrowserGoogleMaps
            // 
            this.webBrowserGoogleMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserGoogleMaps.Location = new System.Drawing.Point(0, 0);
            this.webBrowserGoogleMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserGoogleMaps.Name = "webBrowserGoogleMaps";
            this.webBrowserGoogleMaps.Size = new System.Drawing.Size(537, 473);
            this.webBrowserGoogleMaps.TabIndex = 0;
            this.webBrowserGoogleMaps.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // FormMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 473);
            this.Controls.Add(this.splitContainerMap);
            this.Name = "FormMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMap_Load);
            this.splitContainerMap.Panel1.ResumeLayout(false);
            this.splitContainerMap.Panel1.PerformLayout();
            this.splitContainerMap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMap)).EndInit();
            this.splitContainerMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMap;
        private System.Windows.Forms.WebBrowser webBrowserGoogleMaps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxStationTo;
        private System.Windows.Forms.Label labelStationTo;
        private System.Windows.Forms.TextBox textBoxStationFrom;
        private System.Windows.Forms.Label labelStationFrom;
    }
}