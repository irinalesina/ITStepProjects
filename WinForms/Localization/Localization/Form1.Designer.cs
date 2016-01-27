namespace Localization
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonHome = new System.Windows.Forms.Button();
            this.buttonLocalization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.buttonHome, "buttonHome");
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.UseVisualStyleBackColor = false;
            // 
            // buttonLocalization
            // 
            resources.ApplyResources(this.buttonLocalization, "buttonLocalization");
            this.buttonLocalization.Name = "buttonLocalization";
            this.buttonLocalization.UseVisualStyleBackColor = true;
            this.buttonLocalization.Click += new System.EventHandler(this.buttonLocalization_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.buttonLocalization);
            this.Controls.Add(this.buttonHome);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonLocalization;
    }
}

