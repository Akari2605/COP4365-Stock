using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Project_2.Entity;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace Project_2
{
    //partial class definition for ChartForm
    public partial class ChartForm : Form
    {
        //initial a list for candlestick data
        List<smartCandleStick> stockStats = null;
        List<smartCandleStick> tmp = null;
        private BindingList<smartCandleStick> candleSticks { get; set; }
        //constructor for ChartForm
        public ChartForm(List<smartCandleStick> stats, DateTime start, DateTime end)
        {
            InitializeComponent();

            //initialize values
            stockStats = stats;

            startDate.Value = start;
            endDate.Value = end;

            //initialize a list of candlestick and bind it with the combo box
            List<string> candleStickModel = new List<string>
            {
                "",
                "Bullish",
                "Bearish",
                "Neutral",
                "Marubozu",
                "Doji",
                "DragonFly Doji",
                "Gravestone Doji",
                "Hammer",
                "Inverted Hammer"
            };
            comboBox_modelChange.DataSource = candleStickModel;

            var tmpStats = stockStats.FirstOrDefault();
            var periodVal = tmpStats.period.ToLower() == "day" ? "Daily" : tmpStats.period.ToString() + "ly";

            stockName.Text = tmpStats.ticker;
            period.Text = periodVal;
            refreshData();
        }

        //this method refreshs the data in the chart every time a new date set is selected
        public void refreshData()
        {
            //check to clear data in the binding list if existed
            if (candleSticks != null)
            {
                candleSticks.Clear();
            }

            //check to return and do nothing if the stockStats list doesn't have data
            if (stockStats == null) return;

            //filter the date set range by using the dateTimePicker
            var data = stockStats.Where(d => d.date >= startDate.Value && d.date <= endDate.Value).ToList();
            tmp = data;
            if (data == null || data.Count == 0)
            {
                MessageBox.Show("Invalid Data Range!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //initial a new binding list for the filter data
            candleSticks = new BindingList<smartCandleStick>();
            decimal max = 0, min = 9999999;
            foreach (smartCandleStick x in data)
            {
                if (x.high > max)
                {
                    max = x.high;
                }
                if (x.low < max)
                {
                    min = x.low;
                }
                candleSticks.Add(x);
            }

            //candleStick_chart.ChartAreas["AreaOHLC"].AxisY.Minimum = (double)min - 10;
            //candleStick_chart.ChartAreas["AreaOHLC"].AxisY.Maximum = (double)max + 10;
            candleStick_chart.DataSource = candleSticks;
            candleStick_chart.DataBind();

            var stats = stockStats.FirstOrDefault();

            var diff = Math.Round(candleSticks.Last().close - candleSticks.First().close, 2);
            diffPrice.ForeColor = diff < 0 ? Color.Red : Color.Green;
            diffPrice.Text = diff > 0 ? diff.ToString() + "$ up" : diff.ToString() + "$ down";
        }

        //the refresh button which used to refreshing the data when a new date range is set
        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        //the comboBox which used for selection of candlesticks types
        //it will filter and create annotations based on the selected candlestick model
        private void comboBox_modelChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            candleStick_chart.Annotations.Clear();

            if (comboBox_modelChange.SelectedValue.ToString() == "Bullish")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isBullish)
                    {
                        CreateAnnotations(x);
                    }
                }
            }

            if (comboBox_modelChange.SelectedValue.ToString() == "Bearish")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isBearish)
                    {
                        CreateAnnotations(x);
                    }
                }
            }

            if (comboBox_modelChange.SelectedValue.ToString() == "Neutral")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isNeutral)
                    {
                        CreateAnnotations(x);
                    }
                }
            }

            if (comboBox_modelChange.SelectedValue.ToString() == "Marubozu")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isMarubozu)
                    {
                        CreateAnnotations(x);
                    }
                }
            }

            if (comboBox_modelChange.SelectedValue.ToString() == "Doji")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isDoji)
                    {
                        CreateAnnotations(x);
                    }
                }
            }

            if (comboBox_modelChange.SelectedValue.ToString() == "DragonFly Doji")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isDragonFlyDoji)
                    {
                        CreateAnnotations(x);
                    }
                }
            }

            if (comboBox_modelChange.SelectedValue.ToString() == "Gravestone Doji")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isGravestoneDoji)
                    {
                        CreateAnnotations(x);
                    }
                }
            }

            if (comboBox_modelChange.SelectedValue.ToString() == "Hammer")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isHammer)
                    {
                        CreateAnnotations(x);
                    }
                }
            }

            if (comboBox_modelChange.SelectedValue.ToString() == "Inverted Hammer")
            {
                foreach (smartCandleStick x in tmp)
                {
                    if (x.isInvertedHammer)
                    {
                        CreateAnnotations(x);
                    }
                }
            }
        }

        //this method create annotations for candlestick based on specific criteria
        public void CreateAnnotations(smartCandleStick x)
        {
            var rectangleAnno = new ArrowAnnotation();
            rectangleAnno.AxisX = candleStick_chart.ChartAreas["AreaOHLC"].AxisX;
            rectangleAnno.AxisY = candleStick_chart.ChartAreas["AreaOHLC"].AxisY;

            rectangleAnno.X = x.date.ToOADate();
            rectangleAnno.Y = (double)(x.low) - 5;

            rectangleAnno.LineWidth = 1;
            rectangleAnno.Width = 0;
            rectangleAnno.Height = 5;
            rectangleAnno.ArrowSize = 2;
            rectangleAnno.Alignment = ContentAlignment.TopCenter;

            rectangleAnno.LineColor = Color.Red;

            candleStick_chart.Annotations.Add(rectangleAnno);
        }
    }
}
