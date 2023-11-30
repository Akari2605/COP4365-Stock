﻿using System;

namespace Project_2.Entity
{
    //create a new aCandleStick object
    public class aCandleStick
    {
        //initial properties for the object
        public DateTime date { get; set; }      //date property that contain both date and time values
        public string ticker { get; set; }      //ticker symbol (stock name)
        public string period { get; set; }      //period symbole (daily, monthly, yearly)
        public Decimal open { get; set; }       //opening price of the stock in the selected time period
        public Decimal close { get; set; }      //closing price of the stock in the selected time period
        public Decimal high { get; set; }       //highest price during the selected time period
        public Decimal low { get; set; }        //lowest price during the selected time period
        public long volume { get; set; }        //volume of he stock trade during the selected time period

        public aCandleStick()
        {
            //default constructor which don't contain any properties
        }

        //constructor that takes in an array of string data and initialize the properties
        public aCandleStick(string[] data)
        {
            //if-else condition to make sure the array has at least 8 values
            if (data.Length >= 8)
            {
                try
                {
                    //parse and assign values from the input array and convert them to the appropriate data types
                    ticker = data[0].Trim('"');
                    period = data[1].Trim('"');
                    open = Convert.ToDecimal(data[4]);
                    high = Convert.ToDecimal(data[5]);
                    low = Convert.ToDecimal(data[6]);
                    close = Convert.ToDecimal(data[7]);
                    volume = Convert.ToInt64(data[8]);
                    //the DateTime property is the combination of date and time values from the input array
                    date = DateTime.Parse(data[2].Trim('"') + " " + data[3].Trim('"'));
                }
                //handling format exception during parsing and display error message
                catch (FormatException ex)
                {
                    throw new FormatException("Fail to parse candle stick values.", ex);
                }
            }
            //display am error message if there're not enough values
            else
            {
                throw new ArgumentException("Input values array should have t least 6 elements.");
            }
        }
    }
}
