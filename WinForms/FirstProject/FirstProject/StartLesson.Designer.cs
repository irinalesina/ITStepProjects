namespace FirstProject
{
    partial class StartLesson
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
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTopic = new System.Windows.Forms.Label();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelTeacherName = new System.Windows.Forms.Label();
            this.labelSabjectName = new System.Windows.Forms.Label();
            this.dateTimePickerLesson = new System.Windows.Forms.DateTimePicker();
            this.labelTime = new System.Windows.Forms.Label();
            this.comboBoxStartTime = new System.Windows.Forms.ComboBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.labelGroupName = new System.Windows.Forms.Label();
            this.labelGroup = new System.Windows.Forms.Label();
            this.labelSubjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(12, 64);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(36, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Date: ";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.Location = new System.Drawing.Point(12, 273);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(40, 13);
            this.labelTopic.TabIndex = 2;
            this.labelTopic.Text = "Topic: ";
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Location = new System.Drawing.Point(12, 18);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(53, 13);
            this.labelTeacher.TabIndex = 4;
            this.labelTeacher.Text = "Teacher: ";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(12, 168);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(49, 13);
            this.labelSubject.TabIndex = 5;
            this.labelSubject.Text = "Subject: ";
            // 
            // labelTeacherName
            // 
            this.labelTeacherName.AutoSize = true;
            this.labelTeacherName.Location = new System.Drawing.Point(76, 18);
            this.labelTeacherName.Name = "labelTeacherName";
            this.labelTeacherName.Size = new System.Drawing.Size(35, 13);
            this.labelTeacherName.TabIndex = 6;
            this.labelTeacherName.Text = "Name";
            // 
            // labelSabjectName
            // 
            this.labelSabjectName.AutoSize = true;
            this.labelSabjectName.Location = new System.Drawing.Point(76, 168);
            this.labelSabjectName.Name = "labelSabjectName";
            this.labelSabjectName.Size = new System.Drawing.Size(0, 13);
            this.labelSabjectName.TabIndex = 7;
            // 
            // dateTimePickerLesson
            // 
            this.dateTimePickerLesson.Location = new System.Drawing.Point(79, 58);
            this.dateTimePickerLesson.Name = "dateTimePickerLesson";
            this.dateTimePickerLesson.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerLesson.TabIndex = 8;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 115);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(36, 13);
            this.labelTime.TabIndex = 9;
            this.labelTime.Text = "Time: ";
            // 
            // comboBoxStartTime
            // 
            this.comboBoxStartTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStartTime.FormattingEnabled = true;
            this.comboBoxStartTime.Location = new System.Drawing.Point(79, 112);
            this.comboBoxStartTime.Name = "comboBoxStartTime";
            this.comboBoxStartTime.Size = new System.Drawing.Size(200, 21);
            this.comboBoxStartTime.TabIndex = 10;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSave.Location = new System.Drawing.Point(100, 338);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(112, 32);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Continue";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(79, 270);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(200, 20);
            this.textBoxTopic.TabIndex = 12;
            // 
            // labelGroupName
            // 
            this.labelGroupName.AutoSize = true;
            this.labelGroupName.Location = new System.Drawing.Point(76, 217);
            this.labelGroupName.Name = "labelGroupName";
            this.labelGroupName.Size = new System.Drawing.Size(10, 13);
            this.labelGroupName.TabIndex = 14;
            this.labelGroupName.Text = " ";
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Location = new System.Drawing.Point(12, 217);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(42, 13);
            this.labelGroup.TabIndex = 13;
            this.labelGroup.Text = "Group: ";
            // 
            // labelSubjectName
            // 
            this.labelSubjectName.AutoSize = true;
            this.labelSubjectName.Location = new System.Drawing.Point(76, 168);
            this.labelSubjectName.Name = "labelSubjectName";
            this.labelSubjectName.Size = new System.Drawing.Size(10, 13);
            this.labelSubjectName.TabIndex = 15;
            this.labelSubjectName.Text = " ";
            // 
            // StartLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(309, 390);
            this.Controls.Add(this.labelSubjectName);
            this.Controls.Add(this.labelGroupName);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.comboBoxStartTime);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.dateTimePickerLesson);
            this.Controls.Add(this.labelSabjectName);
            this.Controls.Add(this.labelTeacherName);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.labelDate);
            this.Name = "StartLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartLesson";
            this.Load += new System.EventHandler(this.StartLesson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelTeacherName;
        private System.Windows.Forms.Label labelSabjectName;
        private System.Windows.Forms.DateTimePicker dateTimePickerLesson;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.ComboBox comboBoxStartTime;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label labelGroupName;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Label labelSubjectName;
    }
}