
namespace PruebaNetDeveloper
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearFilters = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNameObjectFilter = new System.Windows.Forms.TextBox();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.mcFilterCalendar = new System.Windows.Forms.MonthCalendar();
            this.dgvCompaniesList = new System.Windows.Forms.DataGridView();
            this.btnDownloadInfo = new System.Windows.Forms.Button();
            this.pbDownload = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDownloadLog = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompaniesList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblDownloadLog);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.pbDownload);
            this.splitContainer1.Panel1.Controls.Add(this.btnDownloadInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btnClearFilters);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.mcFilterCalendar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvCompaniesList);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 204;
            this.splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name / Social Object";
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(114, 414);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(87, 24);
            this.btnClearFilters.TabIndex = 5;
            this.btnClearFilters.Text = "Clear Filters";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbNameObjectFilter
            // 
            this.tbNameObjectFilter.Location = new System.Drawing.Point(2, 46);
            this.tbNameObjectFilter.Name = "tbNameObjectFilter";
            this.tbNameObjectFilter.Size = new System.Drawing.Size(183, 23);
            this.tbNameObjectFilter.TabIndex = 3;
            this.tbNameObjectFilter.TextChanged += new System.EventHandler(this.tbNameObjectFilter_TextChanged);
            // 
            // cbLocations
            // 
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(2, 105);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(183, 23);
            this.cbLocations.TabIndex = 2;
            this.cbLocations.SelectedIndexChanged += new System.EventHandler(this.cbLocations_SelectedIndexChanged);
            // 
            // mcFilterCalendar
            // 
            this.mcFilterCalendar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mcFilterCalendar.Location = new System.Drawing.Point(9, 9);
            this.mcFilterCalendar.Name = "mcFilterCalendar";
            this.mcFilterCalendar.TabIndex = 0;
            this.mcFilterCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcFilterCalendar_DateChanged);
            // 
            // dgvCompaniesList
            // 
            this.dgvCompaniesList.AllowUserToAddRows = false;
            this.dgvCompaniesList.AllowUserToDeleteRows = false;
            this.dgvCompaniesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompaniesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompaniesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCompaniesList.Location = new System.Drawing.Point(0, 0);
            this.dgvCompaniesList.Name = "dgvCompaniesList";
            this.dgvCompaniesList.ReadOnly = true;
            this.dgvCompaniesList.RowTemplate.Height = 25;
            this.dgvCompaniesList.Size = new System.Drawing.Size(592, 450);
            this.dgvCompaniesList.TabIndex = 0;
            // 
            // btnDownloadInfo
            // 
            this.btnDownloadInfo.Location = new System.Drawing.Point(9, 207);
            this.btnDownloadInfo.Name = "btnDownloadInfo";
            this.btnDownloadInfo.Size = new System.Drawing.Size(192, 24);
            this.btnDownloadInfo.TabIndex = 8;
            this.btnDownloadInfo.Text = "Download Info";
            this.btnDownloadInfo.UseVisualStyleBackColor = true;
            this.btnDownloadInfo.Click += new System.EventHandler(this.btnDownloadInfo_Click);
            // 
            // pbDownload
            // 
            this.pbDownload.Location = new System.Drawing.Point(9, 174);
            this.pbDownload.Name = "pbDownload";
            this.pbDownload.Size = new System.Drawing.Size(192, 11);
            this.pbDownload.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbLocations);
            this.groupBox1.Controls.Add(this.tbNameObjectFilter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 140);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // lblDownloadLog
            // 
            this.lblDownloadLog.AutoSize = true;
            this.lblDownloadLog.Location = new System.Drawing.Point(11, 188);
            this.lblDownloadLog.Name = "lblDownloadLog";
            this.lblDownloadLog.Size = new System.Drawing.Size(0, 15);
            this.lblDownloadLog.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "BORME Reader";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompaniesList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbNameObjectFilter;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.MonthCalendar mcFilterCalendar;
        private System.Windows.Forms.DataGridView dgvCompaniesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDownloadInfo;
        private System.Windows.Forms.ProgressBar pbDownload;
        private System.Windows.Forms.Label lblDownloadLog;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

