using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Project3.Entity;
using Project3.StockDataUpload;

namespace Project3
{
    public partial class LoadForm : Form
    {
        //initial a binding list to hold candlestick data
        private BindingList<aCandleStick> candleSticks { get; set; }
        //initialize the form
        public LoadForm()
        {
            InitializeComponent();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            openFileDialog_stockUpload.ShowDialog();
        }

        private void openFileDialog_stockUpload_FileOk(object sender, CancelEventArgs e)
        {
            foreach (string openedFile in openFileDialog_stockUpload.FileNames)
            {
                List<smartCandleStick> data = StockUpload.GetCSVdata(openedFile);

                ChartForm newChart = new ChartForm(data, startDate.Value, endDate.Value);
                newChart.Show();
            }
        }
    }
}
