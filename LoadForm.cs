using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Project_2.Entity;
using Project_2.StockDataUpload;

namespace Project_2
{
    //partial class definition for LoadForm
    public partial class LoadForm : Form
    {
        //initial a binding list to hold candlestick data
        private BindingList<aCandleStick> candleSticks { get; set; }
        //initialize the form
        public LoadForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default constructor which don't contain any properties
        }

        //the load button that open a file dialog to upload the stock data
        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog_stockUpload.ShowDialog();
        }

        //this function handle the selected file via file dialog
        private void openFileDialog_stockUpload_FileOk(object sender, CancelEventArgs e)
        {
            //loop through selected file to retrieve data
            foreach (string openedFile in openFileDialog_stockUpload.FileNames)
            {
                List<smartCandleStick> data = StockUpload.GetCSVdata(openedFile);

                //create a new form and display it with the retrieved data
                ChartForm newChart = new ChartForm(data, startDate.Value, endDate.Value);
                newChart.Show();
            }
        }
    }
}
