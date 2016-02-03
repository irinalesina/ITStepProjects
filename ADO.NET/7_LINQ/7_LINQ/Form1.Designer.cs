namespace _7_LINQ
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewCDs = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProducers = new System.Windows.Forms.DataGridView();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.artistAfterCCCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.counrtiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCDs
            // 
            this.dataGridViewCDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCDs.Location = new System.Drawing.Point(12, 74);
            this.dataGridViewCDs.Name = "dataGridViewCDs";
            this.dataGridViewCDs.Size = new System.Drawing.Size(1188, 161);
            this.dataGridViewCDs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CDs:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PRODUCERs:";
            // 
            // dataGridViewProducers
            // 
            this.dataGridViewProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducers.Location = new System.Drawing.Point(12, 284);
            this.dataGridViewProducers.Name = "dataGridViewProducers";
            this.dataGridViewProducers.Size = new System.Drawing.Size(1188, 161);
            this.dataGridViewProducers.TabIndex = 3;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Location = new System.Drawing.Point(12, 496);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.Size = new System.Drawing.Size(1188, 161);
            this.dataGridViewResult.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "RESULT:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.queryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1212, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDown = this.contextMenuStrip1;
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistAfterCCCPToolStripMenuItem,
            this.counrtiesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.queryToolStripMenuItem;
            this.contextMenuStrip1.Size = new System.Drawing.Size(160, 70);
            // 
            // artistAfterCCCPToolStripMenuItem
            // 
            this.artistAfterCCCPToolStripMenuItem.Name = "artistAfterCCCPToolStripMenuItem";
            this.artistAfterCCCPToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.artistAfterCCCPToolStripMenuItem.Text = "ArtistAfterCCCP";
            this.artistAfterCCCPToolStripMenuItem.Click += new System.EventHandler(this.artistAfterCCCPToolStripMenuItem_Click);
            // 
            // counrtiesToolStripMenuItem
            // 
            this.counrtiesToolStripMenuItem.Name = "counrtiesToolStripMenuItem";
            this.counrtiesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.counrtiesToolStripMenuItem.Text = "Counrties";
            this.counrtiesToolStripMenuItem.Click += new System.EventHandler(this.counrtiesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 719);
            this.Controls.Add(this.dataGridViewResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewProducers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCDs);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCDs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCDs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewProducers;
        private System.Windows.Forms.DataGridView dataGridViewResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem artistAfterCCCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem counrtiesToolStripMenuItem;
    }
}

