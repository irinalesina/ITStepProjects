namespace FirstProject
{
    partial class LessonForm
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
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tableLayoutPanelGroup1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelGroup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubject.Location = new System.Drawing.Point(12, 9);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(85, 26);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Subject";
            this.labelSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(14, 47);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(34, 13);
            this.labelTopic.TabIndex = 1;
            this.labelTopic.Text = "Topic";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSave.Location = new System.Drawing.Point(228, 364);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(101, 37);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // tableLayoutPanelGroup1
            // 
            this.tableLayoutPanelGroup1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelGroup1.AutoSize = true;
            this.tableLayoutPanelGroup1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelGroup1.ColumnCount = 5;
            this.tableLayoutPanelGroup1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGroup1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGroup1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGroup1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGroup1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelGroup1.Location = new System.Drawing.Point(0, 117);
            this.tableLayoutPanelGroup1.Name = "tableLayoutPanelGroup1";
            this.tableLayoutPanelGroup1.RowCount = 1;
            this.tableLayoutPanelGroup1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelGroup1.Size = new System.Drawing.Size(548, 27);
            this.tableLayoutPanelGroup1.TabIndex = 3;
            // 
            // labelGroup
            // 
            this.labelGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(12, 72);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(94, 20);
            this.labelGroup.TabIndex = 0;
            this.labelGroup.Text = "group name";
            this.labelGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(550, 413);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.tableLayoutPanelGroup1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.labelSubject);
            this.Name = "LessonForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LessonForm";
            this.Load += new System.EventHandler(this.LessonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGroup1;
        private System.Windows.Forms.Label labelGroup;
    }
}