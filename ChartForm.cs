using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Project3.Entity;
using Project3.Recognizers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project3
{
    public partial class ChartForm : Form
    {
        //initial a list for candlestick data
        List<smartCandleStick> stockStats = null;
        List<smartCandleStick> sortedCandleStick = null;
        List<candleStickRecognizer> recognizers = null;
        private BindingList<smartCandleStick> candleSticks { get; set; }
        //constructor for ChartForm
        public ChartForm(List<smartCandleStick> stats, DateTime start, DateTime end)
        {
            InitializeComponent();

            //initialize values
            stockStats = stats;

            startDate.Value = start;
            endDate.Value = end;

            InitialRecognizers();
            InitialComboBox();

            var tmpStats = stockStats.FirstOrDefault();
            var periodVal = tmpStats.period.ToLower() == "day" ? "Daily" : tmpStats.period.ToString() + "ly";

            stockName.Text = tmpStats.ticker;
            period.Text = periodVal;
            this.Text = tmpStats.ticker;
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
            sortedCandleStick = data;
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

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void comboBox_modelChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            candleStick_chart.Annotations.Clear();

            var selectedRecognizer = recognizers[comboBox_modelChange.SelectedIndex];
            if (sortedCandleStick == null) return;
            for(int i = 0; i < sortedCandleStick.Count; i++)
            {
                if (selectedRecognizer.recognizedPattern(sortedCandleStick[i]) && selectedRecognizer.patternSize == 1)
                {
                    CreateAnnotations(sortedCandleStick[i]);
                }
                else if (i < sortedCandleStick.Count - selectedRecognizer.patternSize + 1)
                {
                    List<smartCandleStick> subList = sortedCandleStick.GetRange(i, selectedRecognizer.patternSize);
                    if (selectedRecognizer.recognizedPattern(subList))
                    {
                        CreateListAnnotations(subList, selectedRecognizer.patternName);
                    }
                }
            }
        }

        public void CreateAnnotations(smartCandleStick cs, Color color1 = default, Color color2 = default, string patternName = "")
        {
            var arrowAnno = new ArrowAnnotation();
            arrowAnno.AxisX = candleStick_chart.ChartAreas["AreaOHLC"].AxisX;
            arrowAnno.AxisY = candleStick_chart.ChartAreas["AreaOHLC"].AxisY;

            arrowAnno.X = cs.date.ToOADate();
            arrowAnno.Y = (double)(cs.low) - 5;
            arrowAnno.LineWidth = 1;
            arrowAnno.Width = 0;
            arrowAnno.Height = 5;
            arrowAnno.ArrowSize = 2;
            arrowAnno.ForeColor = color1;
            arrowAnno.LineColor = color1 == default ? (cs.isBullish ? Color.Green : Color.Red) : color1;
            arrowAnno.BackColor = color2 == default ? default : color2;

            if (color2 != default)
            {
                double x1 = candleStick_chart.Series[0].Points[0].XValue;
                double x2 = candleStick_chart.Series[0].Points[1].XValue;
                double candlestickWidth = Math.Abs(x2 - x1);

                var textAnno = new TextAnnotation();
                textAnno.AxisX = candleStick_chart.ChartAreas["AreaOHLC"].AxisX;
                textAnno.AxisY = candleStick_chart.ChartAreas["AreaOHLC"].AxisY;
                textAnno.X = cs.date.ToOADate() - candlestickWidth;
                textAnno.Y = (double)(cs.high) * 1.1;
                textAnno.Text = patternName;
                textAnno.AnchorAlignment = ContentAlignment.MiddleLeft;
                textAnno.Alignment = ContentAlignment.MiddleLeft;
                candleStick_chart.Annotations.Add(textAnno);
            }

            candleStick_chart.Annotations.Add(arrowAnno);
        }

        public void CreateListAnnotations(List<smartCandleStick> cs, string patternName)
        {
            if (cs.Count == 2)
            {
                CreateAnnotations(cs[0], Color.LightGreen);
                CreateAnnotations(cs[1], Color.Red, Color.Red, patternName);
            }
            else if (cs.Count == 3)
            {
                CreateAnnotations(cs[0], Color.LightGreen);
                CreateAnnotations(cs[2], Color.LightGreen);
                CreateAnnotations(cs[1], Color.Red, Color.Red, patternName);
            }

        }

        public void InitialRecognizers()
        {
            List<candleStickRecognizer> csr = new List<candleStickRecognizer>();
            csr.Add(new bullishRecognizer(1, "Bullish"));
            csr.Add(new bearishRecognizer(1, "Bearish"));
            csr.Add(new neutralRecognizer(1, "Neutral"));
            csr.Add(new marubozuRecognizer(1, "Marubozu"));
            csr.Add(new dojiRecognizer(1, "Doji"));
            csr.Add(new dragonflyDojiRecognizer(1, "DragonFly Doji"));
            csr.Add(new gravestoneDojiRecognizer(1, "Gravestone Doji"));
            csr.Add(new hammerRecognizer(1, "Hammer"));
            csr.Add(new invertedHammerRecognizer(1, "Inverted Hammer"));
            csr.Add(new bullishEngulfingRecognizer(2, "Bullish Engulfing"));
            csr.Add(new bearishEngulfingRecognizer(2, "Bearish Engulfing"));
            csr.Add(new bullishHaramiRecognizer(2, "Bullish Harami"));
            csr.Add(new bearishHaramiRecognizer(2, "Bearish Harami"));
            csr.Add(new peakRecognizer(3, "Peak"));
            csr.Add(new valleyRecognizer(3, "Valley"));

            recognizers = csr;
        }

        public void InitialComboBox()
        {
            List<string> patternNames = new List<string>();
            foreach (candleStickRecognizer r in recognizers)
            {
                patternNames.Add(r.patternName);
            }

            comboBox_modelChange.DataSource = patternNames;

        }
    }
}
