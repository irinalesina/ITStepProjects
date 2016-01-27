namespace TrainControlSystem
{
    partial class FormHome
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
            this.labelMode = new System.Windows.Forms.Label();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.buttonSchedule = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMode
            // 
            this.labelMode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMode.AutoSize = true;
            this.labelMode.BackColor = System.Drawing.Color.Transparent;
            this.labelMode.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMode.Location = new System.Drawing.Point(240, 9);
            this.labelMode.Name = "labelMode";
            this.labelMode.Size = new System.Drawing.Size(323, 79);
            this.labelMode.TabIndex = 0;
            this.labelMode.Text = "Select mode:";
            this.labelMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdmin.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAdmin.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdmin.Location = new System.Drawing.Point(543, 391);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(241, 89);
            this.buttonAdmin.TabIndex = 1;
            this.buttonAdmin.Text = "Administrator";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // buttonSchedule
            // 
            this.buttonSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSchedule.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonSchedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSchedule.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSchedule.Location = new System.Drawing.Point(12, 391);
            this.buttonSchedule.Name = "buttonSchedule";
            this.buttonSchedule.Size = new System.Drawing.Size(241, 89);
            this.buttonSchedule.TabIndex = 2;
            this.buttonSchedule.Text = "Schedule";
            this.buttonSchedule.UseVisualStyleBackColor = false;
            this.buttonSchedule.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonUser.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUser.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUser.Location = new System.Drawing.Point(279, 391);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(241, 89);
            this.buttonUser.TabIndex = 3;
            this.buttonUser.Text = "UserMode";
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click_1);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::TrainControlSystem.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 492);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonSchedule);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.labelMode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainControlSystem";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormHome_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMode;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.Button buttonSchedule;
        private System.Windows.Forms.Button buttonUser;
    }
}

