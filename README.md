## COP4365-Stock (Project 2)

Stock Analysis project. Part 2.
Goal: Remove the DataGridView from your form (or better yet, make a new form)

Derive an improved candlestick class (to be called “smartCandlestick”)

Load and display stock data in candlestick format and allow for multiple stocks to be displayed on individual forms and identify and display some basic single-candlestick patterns.


As discussed in class, you the improved candlestick class will have some “higher level” properties such as range, bodyRange, topPrice, bottomPrice, topTail, bottomTail.

You can then use those higher level properties to add the isProperties discussed in class to ask if the smartCandlestick is:

  isBullish, isBearish, isNeutal, is Marubozu, isDoji, isDragonFlyDoji, isGravestoneDoji, isHammer, isInvertedHammer and any other pattern you wish to recognize.

You must provide the user with a way to select one of these pattern and then identify it on the chart.

To that purpose, use the Annotation class, more specifically the RectangleAnnotation class (RectangleAnnotation Class (System.Windows.Forms.DataVisualization.Charting) | Microsoft LearnLinks to an external site.) or the ArrowAnnotation class (ArrowAnnotation Class (System.Windows.Forms.DataVisualization.Charting) | Microsoft LearnLinks to an external site.)

1) The code must compile. Penalty: 100 points
2) The code must run. Penalty: 100 points
3) Your application must properly display the data. Penalty: 50 points
4) All functions and methods must be commented.

Penalty: 5 points
per uncommented function or method or class
5) The “Stock Data” folder must be in Solution Folder’s parent folder. Penalty: 10 points
6) Users of your application must be able to specify:
a) The stock symbol.
b) The starting and ending dates of interest.
c) The period for each candle (Daily, Weekly or Monthly)
