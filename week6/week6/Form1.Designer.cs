namespace week6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ratesDGW = new System.Windows.Forms.DataGridView();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.startDateDP = new System.Windows.Forms.DateTimePicker();
            this.endDateDP = new System.Windows.Forms.DateTimePicker();
            this.currencyCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ratesDGW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            this.SuspendLayout();
            // 
            // ratesDGW
            // 
            this.ratesDGW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratesDGW.Enabled = false;
            this.ratesDGW.Location = new System.Drawing.Point(12, 91);
            this.ratesDGW.Name = "ratesDGW";
            this.ratesDGW.Size = new System.Drawing.Size(327, 347);
            this.ratesDGW.TabIndex = 0;
            // 
            // chartRateData
            // 
            chartArea6.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartRateData.Legends.Add(legend6);
            this.chartRateData.Location = new System.Drawing.Point(345, 91);
            this.chartRateData.Name = "chartRateData";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartRateData.Series.Add(series6);
            this.chartRateData.Size = new System.Drawing.Size(443, 347);
            this.chartRateData.TabIndex = 1;
            this.chartRateData.Text = "chart1";
            // 
            // startDateDP
            // 
            this.startDateDP.Location = new System.Drawing.Point(12, 30);
            this.startDateDP.Name = "startDateDP";
            this.startDateDP.Size = new System.Drawing.Size(200, 20);
            this.startDateDP.TabIndex = 2;
            this.startDateDP.ValueChanged += new System.EventHandler(this.startDateDP_ValueChanged);
            // 
            // endDateDP
            // 
            this.endDateDP.Location = new System.Drawing.Point(231, 30);
            this.endDateDP.Name = "endDateDP";
            this.endDateDP.Size = new System.Drawing.Size(200, 20);
            this.endDateDP.TabIndex = 3;
            this.endDateDP.ValueChanged += new System.EventHandler(this.endDateDP_ValueChanged);
            // 
            // currencyCB
            // 
            this.currencyCB.FormattingEnabled = true;
            this.currencyCB.Location = new System.Drawing.Point(449, 30);
            this.currencyCB.Name = "currencyCB";
            this.currencyCB.Size = new System.Drawing.Size(121, 21);
            this.currencyCB.TabIndex = 4;
            this.currencyCB.Text = "EUR";
            this.currencyCB.SelectedIndexChanged += new System.EventHandler(this.currencyCB_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.currencyCB);
            this.Controls.Add(this.endDateDP);
            this.Controls.Add(this.startDateDP);
            this.Controls.Add(this.chartRateData);
            this.Controls.Add(this.ratesDGW);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ratesDGW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ratesDGW;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DateTimePicker startDateDP;
        private System.Windows.Forms.DateTimePicker endDateDP;
        private System.Windows.Forms.ComboBox currencyCB;
    }
}

