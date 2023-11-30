using Project3.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Project3.Entity
{
    //create a new smartCandleStick object
    public class smartCandleStick : aCandleStick
    {
        //initial properties for the object
        public decimal range { get; set; }
        public decimal bodyRange { get; set; }
        public decimal topPrice { get; set; }
        public decimal bottomPrice { get; set; }
        public decimal topTail { get; set; }
        public decimal bottomTail { get; set; }
        public bool isBullish { get; set; }
        public bool isMarubozu { get; set; }
        public bool isBearish { get; set; }
        public bool isNeutral { get; set; }
        public bool isDoji { get; set; }
        public bool isDragonFlyDoji { get; set; }
        public bool isGravestoneDoji { get; set; }
        public bool isHammer { get; set; }
        public bool isInvertedHammer { get; set; }

        //constructor for smartCandleStick object that takes in an array of values as input
        public smartCandleStick(string[] vals) : base(vals)
        {
            //calculate candlesticks attributes based on input values
            range = high - low;
            bodyRange = Math.Abs(close - open);
            topPrice = Math.Max(open, close);
            bottomPrice = Math.Min(open, close);
            topTail = high - Math.Max(open, close);
            bottomTail = Math.Min(open, close) - low;

            //determine candlestick types based on the result of the above calulation
            isBullish = close > open;
            isBearish = open > close;
            isNeutral = open == close;

            //calculate ratios for upper and lower stick
            double lowerShadowRatio = (double)(close - low) / (double)range;
            double upperShadowRatio = (double)(high - close) / (double)range;

            isDoji = bodyRange <= range * 0.05m;
            isMarubozu = (bodyRange / range) >= 0.95m && topTail == 0 && bottomTail == 0;
            isDragonFlyDoji = lowerShadowRatio >= 0.98 && upperShadowRatio < 0.02;
            isGravestoneDoji = open == close && close == high;
            isHammer = bottomTail > range * 0.6m && topTail < range * 0.1m;
            isInvertedHammer = topTail > range * 0.6m && bottomTail < range * 0.1m;
        }
    }
}