namespace FirstProject
{
    partial class EditPassword
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
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(12, 35);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(209, 20);
            this.textBoxNewPassword.TabIndex = 3;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(64, 9);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(103, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Enter new password";
            // 
            // Submit
            // 
            this.Submit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Submit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Submit.Location = new System.Drawing.Point(146, 61);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Save";
            this.Submit.UseVisualStyleBackColor = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // EditPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 105);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Name = "EditPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button Submit;
    }
}