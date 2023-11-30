namespace Project1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_stockStats = new System.Windows.Forms.DataGridView();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.start_date = new System.Windows.Forms.Label();
            this.end_date = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.stockName = new System.Windows.Forms.Label();
            this.openFileDialog_stockUpload = new System.Windows.Forms.OpenFileDialog();
            this.candleStick_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.period = new System.Windows.Forms.Label();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candleStick_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(991, 62);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(254, 22);
            this.startDate.TabIndex = 0;
            this.startDate.Value = new System.DateTime(2022, 11, 9, 0, 0, 0, 0);
            // 
            // dataGridView_stockStats
            // 
            this.dataGridView_stockStats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stockStats.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_stockStats.Name = "dataGridView_stockStats";
            this.dataGridView_stockStats.RowHeadersWidth = 51;
            this.dataGridView_stockStats.RowTemplate.Height = 24;
            this.dataGridView_stockStats.Size = new System.Drawing.Size(895, 269);
            this.dataGridView_stockStats.TabIndex = 1;
            this.dataGridView_stockStats.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(991, 103);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(254, 22);
            this.endDate.TabIndex = 2;
            // 
            // start_date
            // 
            this.start_date.AutoSize = true;
            this.start_date.Location = new System.Drawing.Point(913, 67);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(72, 16);
            this.start_date.TabIndex = 3;
            this.start_date.Text = "Start Date: ";
            this.start_date.Click += new System.EventHandler(this.label1_Click);
            // 
            // end_date
            // 
            this.end_date.AutoSize = true;
            this.end_date.Location = new System.Drawing.Point(916, 108);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(69, 16);
            this.end_date.TabIndex = 4;
            this.end_date.Text = "End Date: ";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(991, 142);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(104, 46);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1119, 142);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(104, 46);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refleshButton_Click);
            // 
            // stockName
            // 
            this.stockName.AutoSize = true;
            this.stockName.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockName.Location = new System.Drawing.Point(943, 259);
            this.stockName.Name = "stockName";
            this.stockName.Size = new System.Drawing.Size(101, 22);
            this.stockName.TabIndex = 7;
            this.stockName.Text = "Stock Name";
            // 
            // openFileDialog_stockUpload
            // 
            this.openFileDialog_stockUpload.FileName = "openFileDialog";
            this.openFileDialog_stockUpload.Filter = "All Stock files|*.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly Sto" +
    "cks|*-Month.csv";
            this.openFileDialog_stockUpload.InitialDirectory = "C:...\\Project1\\Stock Data";
            this.openFileDialog_stockUpload.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // candleStick_chart
            // 
            chartArea1.Name = "AreaOHLC";
            chartArea2.AlignWithChartArea = "AreaOHLC";
            chartArea2.Name = "AreaVolume";
            this.candleStick_chart.ChartAreas.Add(chartArea1);
            this.candleStick_chart.ChartAreas.Add(chartArea2);
            this.candleStick_chart.DataSource = this.bindingSource;
            legend1.Name = "Legend1";
            this.candleStick_chart.Legends.Add(legend1);
            this.candleStick_chart.Location = new System.Drawing.Point(12, 305);
            this.candleStick_chart.Name = "candleStick_chart";
            series1.ChartArea = "AreaOHLC";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=0\\, 192\\, 0, PointWidth=0.9";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "HLOC";
            series1.XValueMember = "date";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "high, low, open, close";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "AreaVolume";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Voume";
            series2.XValueMember = "date";
            series2.YValueMembers = "volume";
            series2.YValuesPerPoint = 4;
            this.candleStick_chart.Series.Add(series1);
            this.candleStick_chart.Series.Add(series2);
            this.candleStick_chart.Size = new System.Drawing.Size(1285, 510);
            this.candleStick_chart.TabIndex = 9;
            this.candleStick_chart.Text = "chart1";
            this.candleStick_chart.Click += new System.EventHandler(this.candleStick_chart_Click);
            // 
            // period
            // 
            this.period.AutoSize = true;
            this.period.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.Location = new System.Drawing.Point(1066, 259);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(59, 22);
            this.period.TabIndex = 10;
            this.period.Text = "Period";
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = typeof(Project1.Entity.aCandleStick);
            this.bindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 827);
            this.Controls.Add(this.period);
            this.Controls.Add(this.candleStick_chart);
            this.Controls.Add(this.stockName);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.dataGridView_stockStats);
            this.Controls.Add(this.startDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stockStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candleStick_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DataGridView dataGridView_stockStats;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label start_date;
        private System.Windows.Forms.Label end_date;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label stockName;
        private System.Windows.Forms.OpenFileDialog openFileDialog_stockUpload;
        private System.Windows.Forms.DataVisualization.Charting.Chart candleStick_chart;
        private System.Windows.Forms.Label period;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}

