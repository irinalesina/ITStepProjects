namespace FirstProject
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.Login = new System.Windows.Forms.Button();
            this.buttonStartLesson = new System.Windows.Forms.Button();
            this.buttonСonductedLessons = new System.Windows.Forms.Button();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login
            // 
            resources.ApplyResources(this.Login, "Login");
            this.Login.BackColor = System.Drawing.Color.AliceBlue;
            this.Login.Name = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonStartLesson
            // 
            resources.ApplyResources(this.buttonStartLesson, "buttonStartLesson");
            this.buttonStartLesson.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonStartLesson.Name = "buttonStartLesson";
            this.buttonStartLesson.UseVisualStyleBackColor = false;
            this.buttonStartLesson.Click += new System.EventHandler(this.buttonStartLesson_Click);
            // 
            // buttonСonductedLessons
            // 
            resources.ApplyResources(this.buttonСonductedLessons, "buttonСonductedLessons");
            this.buttonСonductedLessons.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonСonductedLessons.Name = "buttonСonductedLessons";
            this.buttonСonductedLessons.UseVisualStyleBackColor = false;
            this.buttonСonductedLessons.Click += new System.EventHandler(this.buttonСonductedLessons_Click);
            // 
            // labelDateTime
            // 
            resources.ApplyResources(this.labelDateTime, "labelDateTime");
            this.labelDateTime.Name = "labelDateTime";
            // 
            // HomeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.labelDateTime);
            this.Controls.Add(this.buttonСonductedLessons);
            this.Controls.Add(this.buttonStartLesson);
            this.Controls.Add(this.Login);
            this.Name = "HomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button buttonStartLesson;
        private System.Windows.Forms.Button buttonСonductedLessons;
        private System.Windows.Forms.Label labelDateTime;

    }
}

