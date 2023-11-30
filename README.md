## COP4365-Stock (Project 3)

Stock Analysis project. Part 3.
Goal: As in project #2, there is no datagridview and we will display multiple stock charts. We will also, as in project 2, identity some candlestick patterns. The difference, however, is that unlike in project #2 where the patterns were 1-candlestick patterns, project #3 introduces the recognition of multi-candlestick patterns (as well as single-candlestick patterns from project #2).

Now would be a good time to read about Polymorphism. Please refer to the w3schools.com chapter on polymorphism. It also has an example. If that doesn’t clarify things for you, it will provide you with a reason to ask for clarifications in class or during office hours.

Because of this change, you will have to create a new type of class called axxxRecognizer, whose role is to identify the location of its target pattern xxx where examples of xxx are: Doji, Hammer, Marubozu (the single-candlestick patterns you identified in project #2) or engulfing Pattern, Bullish engulfing Pattern, Bearish engulfing Pattern (see The Engulfing Candlestick Patterns - Bullish Engulfing, Bearish Engulfing - Aim ArrowLinks to an external site.) engulfing as well as bearish and bullish Haramis What Is a Harami Candle? Example Charts Help You Interpret Trend Reversal - Commodity.comLinks to an external site.

Mandatory Additional patterns: Added on(11/16/2023) As discussed in class, also add the 3-candlestick patterns called Peak and Valley. a Peak is when the high of the middle candlestick is higher than the high of the 2 candlesticks on its left and its right, and a Valley is when the low of the middle candlestick is lower than the lows of the 2 candlesticks on its left and its right.

Load and display stock data in candlestick format and allow for multiple stocks to be displayed on individual forms and identify and display some basic single-candlestick patterns.

You HAVE TO USE DATA BINDING. Do not load the data into the chart in code. Why write 10’s of lines of code to go through your list of candlesticks and Add each candlestick into the Chart (with all the complications and the lack of synchronization) when all you have to do is make a list of candlestick you wish to display and tell the chart: chart_display.DataSource = listOfCandlesticks then bind the chart to  the list with: chart_display.Bind() (That’s 2 lines of code!!!)

You might consider not changing the core of project 2. But because of the change in architecture due to the fact that we are now going to also recognize multi-candlestick patterns, we will discuss how to pick the appropriate recognizer when the user selects one particular one from the pattern selecting ComboBox.

Again, the user will pick a pattern from the pattern selecting ComboBox and your application will (as in project 2) identify the patterns amongst the candlesticks being displayed and then place an annotation on the chart around each candlesticks that form the desired pattern.

Feel free to ask ChatGPT to show you how to display those annotations on a chart control (it is pretty simple).

WARNING! Do not provide a solution that will differ MARKEDLY from what you will be given in class.

Do not use material obviously from some code writing program. So, DO NOT USE DataTables, LINQ, Databases or other complex data structures or classes that complicate your solution. Use what we COVER IN CLASS. Those other approaches will NOT BE ACCEPTED IN PROJECT3!

You will be using Abstract classes and concrete classes derived from those abstract classes to solve the problem, so PAY ATTENTION in class as EVERYTHING I will cover WILL BE USED in the project!

This project is to teach you what Polymorphism is and how powerful it is! I will not accept projects that do not use polymorphism or use material obviously obtained from other sources than the classroom!

This will show if you have fully understood the material in this course!

This project has to reflect what we did IN CLASS!!!!!

If you do not understand something (and there is much not to understand, at first, with Polymorphism), PLEASE RAISE YOUR HAND and ASK A QUESTION! But ultimately, if you do your work, you will understand it and it will open new horizons to your programming skills.


Do not worry about the location of your stock data folder. We will use the one in the TA’s machine. So, to save space, you can remove it from what you submit.

For this project, there are a couple of FUNDAMENTAL REQUIREMENTS.

DO NOT USE CHATGpt code as is (as in cut and paste). Instead, use it as SUGGESTIONS for your code. If your code is deemed too much from ChatGPT or uses LINQ, DataTables, SQL, you will receive a 0. This must be your project, based on all the solutions presented to you IN CLASS!
You MUST USE Data Binding. We based all of our class material on DataBinding which is clear, clean and concise. It was not created for nothing. USE IT! If not, you will receive a 0 on your project!
Be kind to your grader. Make sure that your initial start date is set to something like 1/1/2021. Many projects did not have the start date set so that each time the project was run, one had to go waste time to set an appropriate starting date. If you do not pay attention to this detail, you will lose 10 Points!
You MUST USE the OpenFileDialog. A project not using it will receive a 0. This is to show that you understand the use of a very powerful object and can leverage its power. Furthermore, we have been using it in class since project 2.
Your smart Candlestick class must be derived from the candlestick class and not written from scratch. You want to show that you understand inheritance and how to leverage it.
As shown in class, make sure you break up your functions into individual methods rather than one large method that does everything. In other words, make sure you have method to load one stock file, then have a method that loads multiple files. Have a method to filter the candlesticks by date. Have a smartCandlestick constructor that takes a candlestick as argument (so that you can build a smart candlestick from a regular candlestick). All of that has been or will be demonstrated in class. Pay attention, don’t miss and important point.
Make sure that your chart is properly displayed. Many project 1 had all their candlestick as Green or malformed. This is because the data was not presented properly in the series (The y member must be in the order High,Low,Open,Close. Yes, that is different than Open,High,Low,Close, but it takes 5 seconds to set it in the properties window. We did it in class. If you were not paying attention, you missed it. Having a malformed chart shows that you either did not test your app or that you did not care to fix it. Just asking for help during class about such a problem would have it resolved in 10 seconds. An obviously malformed chart will cost you 20 points and will probably make it difficult for your Annotations to look correct.

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
