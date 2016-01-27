namespace TicTacToe_2D
{
    partial class FormGame
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
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonRestart.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.Location = new System.Drawing.Point(266, 519);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonRestart.Size = new System.Drawing.Size(173, 40);
            this.buttonRestart.TabIndex = 0;
            this.buttonRestart.Text = "RESTART";
            this.buttonRestart.UseVisualStyleBackColor = false;
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScore.Location = new System.Drawing.Point(304, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelScore.Size = new System.Drawing.Size(64, 26);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "SCORE:";
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(695, 583);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.buttonRestart);
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe_2D";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelScore;


    }
}

