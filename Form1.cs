using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Project1.Entity;
using Project1.StockDataUpload;

namespace Project1
{
    public partial class Form1 : Form
    {
        //initial a stockStats list for candlestick data
        List<aCandleStick> stockStats = null;
        //initial a binding list to hold candlestick data
        private BindingList<aCandleStick> candleSticks {  get; set; }
        //initialize the form
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //default constructor which don't contain any properties
        }

        //the load button that open a file dialog to upload the stock data
        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog_stockUpload.ShowDialog() == DialogResult.OK)
            {
                //call the stockUpload method to load the selected CSV file into the stockStats list
                stockStats = StockUpload.GetCSVdata(openFileDialog_stockUpload.FileName);

                //call the recursive function to refresh the display of data in dataGridView for the same loaded CSV file
                 refreshData();

                //hide the first and second columns
                dataGridView_stockStats.Columns[1].Visible = false;
                dataGridView_stockStats.Columns[2].Visible = false;

                //display the ticker and period from the first data entry as labels
                var stats = stockStats.FirstOrDefault();

                stockName.Text = stats.ticker;
                period.Text = stats.period;
            }
        }

        //this function refreshs the data in dataGridView every time a new date set is selected
        public void refreshData()
        {
            //check to clear data in the binding list if existed
            if(candleSticks != null)
            {
                candleSticks.Clear();
            }

            //check to return and do nothing if the stockStats list doesn't have data
            if (stockStats == null) return;

            //filter the date set range by using the dateTimePicker
            var data = stockStats.Where(d => d.date >= startDate.Value && d.date <= endDate.Value).ToList();
            //initial a new binding list for the filter data
            candleSticks = new BindingList<aCandleStick>();
            foreach (aCandleStick x in data)
            {
                candleSticks.Add(x);
            }
            //connect the data source to dataGridView and a chart to display the candlestick data
            dataGridView_stockStats.DataSource = candleSticks;
            bindingSource.DataSource = candleSticks;
            candleStick_chart.DataSource = candleSticks;
            candleStick_chart.DataBind();
        }

        //the refresh button which used to refreshing the data when a new date range is set
        private void refleshButton_Click(object sender, EventArgs e)
        {
            refreshData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //default constructor which don't contain any properties
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //default constructor which don't contain any properties
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            //default constructor which don't contain any properties
        }

        private void candleStick_chart_Click(object sender, EventArgs e)
        {
            //default constructor which don't contain any properties
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default constructor which don't contain any properties
        }
    }
}
