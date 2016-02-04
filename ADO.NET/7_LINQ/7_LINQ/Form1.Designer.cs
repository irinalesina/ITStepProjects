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
            this.aldomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titlesPriceForCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyTitleCountGroupByYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.producerAndTitleWithMaxFeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.producerGotFeeLastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleWithMinPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allInfoAboutTitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCDs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCDs
            // 
            this.dataGridViewCDs.AllowUserToOrderColumns = true;
            this.dataGridViewCDs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridViewProducers.AllowUserToOrderColumns = true;
            this.dataGridViewProducers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProducers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducers.Location = new System.Drawing.Point(12, 284);
            this.dataGridViewProducers.Name = "dataGridViewProducers";
            this.dataGridViewProducers.Size = new System.Drawing.Size(1188, 161);
            this.dataGridViewProducers.TabIndex = 3;
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToOrderColumns = true;
            this.dataGridViewResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.counrtiesToolStripMenuItem,
            this.aldomsToolStripMenuItem,
            this.titlesPriceForCountryToolStripMenuItem,
            this.companyTitleCountGroupByYearToolStripMenuItem,
            this.producerAndTitleWithMaxFeeToolStripMenuItem,
            this.toolStripMenuItem2,
            this.producerGotFeeLastToolStripMenuItem,
            this.titleWithMinPriceToolStripMenuItem,
            this.allInfoAboutTitlesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(293, 224);
            // 
            // artistAfterCCCPToolStripMenuItem
            // 
            this.artistAfterCCCPToolStripMenuItem.Name = "artistAfterCCCPToolStripMenuItem";
            this.artistAfterCCCPToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.artistAfterCCCPToolStripMenuItem.Text = "1. ArtistAfterCCCP";
            this.artistAfterCCCPToolStripMenuItem.Click += new System.EventHandler(this.artistAfterCCCPToolStripMenuItem_Click);
            // 
            // counrtiesToolStripMenuItem
            // 
            this.counrtiesToolStripMenuItem.Name = "counrtiesToolStripMenuItem";
            this.counrtiesToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.counrtiesToolStripMenuItem.Text = "2. Counrties";
            this.counrtiesToolStripMenuItem.Click += new System.EventHandler(this.counrtiesToolStripMenuItem_Click);
            // 
            // aldomsToolStripMenuItem
            // 
            this.aldomsToolStripMenuItem.Name = "aldomsToolStripMenuItem";
            this.aldomsToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.aldomsToolStripMenuItem.Text = "3. TitlesOrderByYear";
            this.aldomsToolStripMenuItem.Click += new System.EventHandler(this.aldomsToolStripMenuItem_Click);
            // 
            // titlesPriceForCountryToolStripMenuItem
            // 
            this.titlesPriceForCountryToolStripMenuItem.Name = "titlesPriceForCountryToolStripMenuItem";
            this.titlesPriceForCountryToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.titlesPriceForCountryToolStripMenuItem.Text = "4. TitlesPriceForCountry";
            this.titlesPriceForCountryToolStripMenuItem.Click += new System.EventHandler(this.titlesPriceForCountryToolStripMenuItem_Click);
            // 
            // companyTitleCountGroupByYearToolStripMenuItem
            // 
            this.companyTitleCountGroupByYearToolStripMenuItem.Name = "companyTitleCountGroupByYearToolStripMenuItem";
            this.companyTitleCountGroupByYearToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.companyTitleCountGroupByYearToolStripMenuItem.Text = "5. CompanyTitleCountGroupByYear";
            this.companyTitleCountGroupByYearToolStripMenuItem.Click += new System.EventHandler(this.companyTitleCountGroupByYearToolStripMenuItem_Click);
            // 
            // producerAndTitleWithMaxFeeToolStripMenuItem
            // 
            this.producerAndTitleWithMaxFeeToolStripMenuItem.Name = "producerAndTitleWithMaxFeeToolStripMenuItem";
            this.producerAndTitleWithMaxFeeToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.producerAndTitleWithMaxFeeToolStripMenuItem.Text = "6. ProducerAndTitlesWithMaxFee";
            this.producerAndTitleWithMaxFeeToolStripMenuItem.Click += new System.EventHandler(this.producerAndTitleWithMaxFeeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(292, 22);
            this.toolStripMenuItem2.Text = "7. TitleCountsEchProdBetween1988-1990 ";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // producerGotFeeLastToolStripMenuItem
            // 
            this.producerGotFeeLastToolStripMenuItem.Name = "producerGotFeeLastToolStripMenuItem";
            this.producerGotFeeLastToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.producerGotFeeLastToolStripMenuItem.Text = "8. ProducerGotFeeLast";
            this.producerGotFeeLastToolStripMenuItem.Click += new System.EventHandler(this.producerGotFeeLastToolStripMenuItem_Click);
            // 
            // titleWithMinPriceToolStripMenuItem
            // 
            this.titleWithMinPriceToolStripMenuItem.Name = "titleWithMinPriceToolStripMenuItem";
            this.titleWithMinPriceToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.titleWithMinPriceToolStripMenuItem.Text = "9. TitleWithMinPrice";
            this.titleWithMinPriceToolStripMenuItem.Click += new System.EventHandler(this.titleWithMinPriceToolStripMenuItem_Click);
            // 
            // allInfoAboutTitlesToolStripMenuItem
            // 
            this.allInfoAboutTitlesToolStripMenuItem.Name = "allInfoAboutTitlesToolStripMenuItem";
            this.allInfoAboutTitlesToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.allInfoAboutTitlesToolStripMenuItem.Text = "10. AllInfoAboutTitles";
            this.allInfoAboutTitlesToolStripMenuItem.Click += new System.EventHandler(this.allInfoAboutTitlesToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem aldomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titlesPriceForCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyTitleCountGroupByYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem producerAndTitleWithMaxFeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem producerGotFeeLastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleWithMinPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allInfoAboutTitlesToolStripMenuItem;
    }
}

