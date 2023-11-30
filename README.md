## COP4365-Stock (Project 1)

Stock Analysis project. Part 1.
Goal: Load and display stock data in candlestick format.
As discussed in class, you are to write a Windows Form Application to load and display the price of a stock in the candlestick format.
Input: For this part of the project, you will be storing the stock .csv files in a folder named “Stock Data” (make sure you have a space between the words ‘Stock’ and ‘Data’).
The “Stock Data” folder is to be located in the parent folder of your Solution folder. As explained in class, the naming of the files in the “Stock Data” folder is to be as follows: Given a ticker named “BDX”, the files associated with it should be named:
BDX-Day.csv for daily data
BDX-Week.csv for weekly data
BDX-Month.csv for monthly data
The format of the CSV file will be as follows:
  The first line will be the header with columns: Ticker,Period,Date,Open,High,Low,Close,Volume
  Subsequent lines with contain the price information as stated in the header.
  After having loaded the stock data, you are to display it in a DataGridView and in a Chart     control. Requirements and penalties for non-compliance.
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
