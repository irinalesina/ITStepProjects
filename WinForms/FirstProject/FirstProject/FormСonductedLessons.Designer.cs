namespace FirstProject
{
    partial class FormСonductedLessons
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
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Topic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(13, 22);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(46, 13);
            this.labelSubject.TabIndex = 0;
            this.labelSubject.Text = "Subject:";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(79, 19);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(164, 21);
            this.comboBoxSubject.TabIndex = 1;
            this.comboBoxSubject.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubject_SelectedIndexChanged);
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(79, 65);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(164, 21);
            this.comboBoxGroup.TabIndex = 3;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(13, 68);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(39, 13);
            this.labelGroup.TabIndex = 2;
            this.labelGroup.Text = "Group:";
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AllowUserToAddRows = false;
            this.dataGridViewInfo.AllowUserToDeleteRows = false;
            this.dataGridViewInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Time,
            this.Group,
            this.Topic});
            this.dataGridViewInfo.Location = new System.Drawing.Point(12, 116);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.Size = new System.Drawing.Size(450, 250);
            this.dataGridViewInfo.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Topic
            // 
            this.Topic.HeaderText = "Topic";
            this.Topic.Name = "Topic";
            this.Topic.ReadOnly = true;
            // 
            // FormСonductedLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 417);
            this.Controls.Add(this.dataGridViewInfo);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.labelSubject);
            this.Name = "FormСonductedLessons";
            this.Text = "СonductedLessons";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Topic;
    }
}