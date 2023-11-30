using Project3.Entity;
using System;
using System.Collections.Generic;

namespace Project3.Recognizers
{
    abstract class candleStickRecognizer
    {
        public int patternSize;
        public string patternName;
        public candleStickRecognizer(int patternSize, string patternName)
        {
            this.patternSize = patternSize;
            this.patternName = patternName;
        }
        public List<smartCandleStick> Recognize(List<smartCandleStick> smartCandleSticks)
        {
            List<smartCandleStick> smartCandleSticksTmp = new List<smartCandleStick>();
            foreach (smartCandleStick cs in smartCandleSticks)
            {
                if (recognizedPattern(cs))
                {
                    smartCandleSticksTmp.Add(cs);
                }
            }
            return smartCandleSticksTmp;
        }

        public virtual bool recognizedPattern(smartCandleStick cs)
        {
            return false;
        }
        public virtual bool recognizedPattern(List<smartCandleStick> sc)
        {
            return false;
        }
    }

    class dojiRecognizer : candleStickRecognizer
    {
        public dojiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isDoji;
        }
    }

    class hammerRecognizer : candleStickRecognizer
    {
        public hammerRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isHammer;
        }
    }

    class bullishRecognizer : candleStickRecognizer
    {
        public bullishRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isBullish;
        }
    }

    class bearishRecognizer : candleStickRecognizer
    {
        public bearishRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isBearish;
        }
    }

    class neutralRecognizer : candleStickRecognizer
    {
        public neutralRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isNeutral;
        }
    }

    class marubozuRecognizer : candleStickRecognizer
    {
        public marubozuRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isMarubozu;
        }
    }

    class dragonflyDojiRecognizer : candleStickRecognizer
    {
        public dragonflyDojiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isDragonFlyDoji;
        }
    }

    class gravestoneDojiRecognizer : candleStickRecognizer
    {
        public gravestoneDojiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isGravestoneDoji;
        }
    }

    class invertedHammerRecognizer : candleStickRecognizer
    {
        public invertedHammerRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(smartCandleStick cs)
        {
            return cs.isInvertedHammer;
        }
    }

    class peakRecognizer : candleStickRecognizer
    {
        public peakRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }
        public override bool recognizedPattern(List<smartCandleStick> sc)
        {
            if (sc.Count == 3)
            {
                smartCandleStick sc1 = sc[0];
                smartCandleStick sc2 = sc[1];
                smartCandleStick sc3 = sc[2];

                return (sc2.high > sc1.high) && (sc2.high > sc3.high);
            }
            return false;
        }
    }

    class valleyRecognizer : candleStickRecognizer
    {
        public valleyRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizedPattern(List<smartCandleStick> sc)
        {
            if (sc.Count == 3)
            {
                smartCandleStick sc1 = sc[0];
                smartCandleStick sc2 = sc[1];
                smartCandleStick sc3 = sc[2];

                return (sc2.low < sc1.low) && (sc2.low < sc3.low);
            }

            return false;
        }
    }

    class bullishEngulfingRecognizer : candleStickRecognizer
    {
        public bullishEngulfingRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizedPattern(List<smartCandleStick> sc)
        {
            if (sc.Count == patternSize)
            {
                smartCandleStick sc1 = sc[0];
                smartCandleStick sc2 = sc[1];

                return (sc2.close > sc2.open) && (sc1.close < sc1.open) && (sc2.close > sc1.open) && (sc2.open < sc1.close);
            }

            return false;
        }
    }

    class bearishEngulfingRecognizer : candleStickRecognizer
    {
        public bearishEngulfingRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizedPattern(List<smartCandleStick> sc)
        {
            if (sc.Count == patternSize)
            {
                smartCandleStick sc1 = sc[0];
                smartCandleStick sc2 = sc[1];

                return (sc2.close < sc2.open) && (sc1.close > sc1.open) && (sc2.close < sc1.open) && (sc2.open > sc1.close);
            }

            return false;
        }
    }

    class bullishHaramiRecognizer : candleStickRecognizer
    {
        public bullishHaramiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizedPattern(List<smartCandleStick> sc)
        {
            if (sc.Count == patternSize)
            {
                smartCandleStick sc1 = sc[0];
                smartCandleStick sc2 = sc[1];

                return ((sc2.close > sc2.open) && (sc1.close < sc1.open) && (sc2.close < sc1.open) && (sc2.open > sc1.close));
            }

            return false;
        }
    }

    class bearishHaramiRecognizer : candleStickRecognizer
    {
        public bearishHaramiRecognizer(int patternSize, string patternName) : base(patternSize, patternName)
        {

        }

        public override bool recognizedPattern(List<smartCandleStick> sc)
        {
            if (sc.Count == patternSize)
            {
                smartCandleStick sc1 = sc[0];
                smartCandleStick sc2 = sc[1];

                return ((sc2.close < sc2.open) && (sc1.close > sc1.open) && (sc2.close > sc1.open) && (sc2.open < sc1.close));
            }

            return false;
        }
    }
}