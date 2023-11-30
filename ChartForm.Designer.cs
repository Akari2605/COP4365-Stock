namespace Project_2
{
    partial class ChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.diffPrice = new System.Windows.Forms.Label();
            this.comboBox_modelChange = new System.Windows.Forms.ComboBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.end_date = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.period = new System.Windows.Forms.Label();
            this.stockName = new System.Windows.Forms.Label();
            this.candleStick_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.candleStick_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diffPrice
            // 
            this.diffPrice.AutoSize = true;
            this.diffPrice.Location = new System.Drawing.Point(582, 84);
            this.diffPrice.Name = "diffPrice";
            this.diffPrice.Size = new System.Drawing.Size(140, 16);
            this.diffPrice.TabIndex = 28;
            this.diffPrice.Text = "Different Price Change";
            // 
            // comboBox_modelChange
            // 
            this.comboBox_modelChange.FormattingEnabled = true;
            this.comboBox_modelChange.Location = new System.Drawing.Point(525, 38);
            this.comboBox_modelChange.Name = "comboBox_modelChange";
            this.comboBox_modelChange.Size = new System.Drawing.Size(254, 24);
            this.comboBox_modelChange.TabIndex = 27;
            this.comboBox_modelChange.SelectedIndexChanged += new System.EventHandler(this.comboBox_modelChange_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(836, 47);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(135, 53);
            this.refreshButton.TabIndex = 26;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // end_date
            // 
            this.end_date.AutoSize = true;
            this.end_date.Location = new System.Drawing.Point(126, 84);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(69, 16);
            this.end_date.TabIndex = 25;
            this.end_date.Text = "End Date: ";
            // 
            // start_date
            // 
            this.start_date.AutoSize = true;
            this.start_date.Location = new System.Drawing.Point(123, 43);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(72, 16);
            this.start_date.TabIndex = 24;
            this.start_date.Text = "Start Date: ";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(201, 79);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(254, 22);
            this.endDate.TabIndex = 23;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(201, 38);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(254, 22);
            this.startDate.TabIndex = 22;
            this.startDate.Value = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(733, 128);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(59, 22);
            this.period.TabIndex = 21;
            this.period.Text = "Period";
            // 
            // stockName
            // 
            this.stockName.AutoSize = true;
            this.stockName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockName.Location = new System.Drawing.Point(326, 128);
            this.stockName.Name = "stockName";
            this.stockName.Size = new System.Drawing.Size(101, 22);
            this.stockName.TabIndex = 20;
            this.stockName.Text = "Stock Name";
            // 
            // candleStick_chart
            // 
            this.candleStick_chart.BorderlineWidth = 0;
            chartArea1.Name = "AreaOHLC";
            chartArea2.AlignWithChartArea = "AreaOHLC";
            chartArea2.Name = "AreaVolume";
            this.candleStick_chart.ChartAreas.Add(chartArea1);
            this.candleStick_chart.ChartAreas.Add(chartArea2);
            this.candleStick_chart.Location = new System.Drawing.Point(42, 124);
            this.candleStick_chart.Margin = new System.Windows.Forms.Padding(0);
            this.candleStick_chart.Name = "candleStick_chart";
            series1.ChartArea = "AreaOHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime";
            series1.MarkerBorderColor = System.Drawing.Color.White;
            series1.Name = "Series_ohlc";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            series2.ChartArea = "AreaVolume";
            series2.Name = "Series_volume";
            series2.XValueMember = "date";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YValueMembers = "volume";
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int64;
            this.candleStick_chart.Series.Add(series1);
            this.candleStick_chart.Series.Add(series2);
            this.candleStick_chart.Size = new System.Drawing.Size(1088, 417);
            this.candleStick_chart.TabIndex = 30;
            this.candleStick_chart.Text = "chart1";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Project_2.Entity.smartCandleStick);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 664);
            this.Controls.Add(this.candleStick_chart);
            this.Controls.Add(this.diffPrice);
            this.Controls.Add(this.comboBox_modelChange);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.period);
            this.Controls.Add(this.stockName);
            this.Name = "ChartForm";
            this.Text = "Chart Form";
            ((System.ComponentModel.ISupportInitialize)(this.candleStick_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Label diffPrice;
        private System.Windows.Forms.ComboBox comboBox_modelChange;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label end_date;
        private System.Windows.Forms.Label start_date;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.Label stockName;
        private System.Windows.Forms.DataVisualization.Charting.Chart candleStick_chart;
    }
}