# Welcome to the DevTest


This is a developer test for new candidates at all levels and is designed to gauge overall levels of understanding for web development

###General

Create a work folder and clone the code in this repository. Create a new local branch for this repository for your work, and calling the branch your name and the date in the format yyyy-mm-dd

Complete the tasks below, committing your code at suitable intervals. 

You may wish to also edit the ignore file so that unnecessary code that does not need to be committed is not included.

At the end of the test commit your branch locally for review using a pull or merge request


###Fizz Buzz Test - Suggested time : 5 minutes
***

Task : Write an app which will print the numbers from 1 to 100. Complete as many of these criteria as possible
* For multiples of three print "Fizz" instead of the number. 
* For the multiples of five print "Buzz" as well as the number. 
* For numbers which are multiples of both three and five print "FizzBuzz" instead of the number.
* For numbers which are a multiple of 10, introduce a half second pause before continuing
* Calculate and display the total execution time in seconds for the program executing


###Luhn Test - Suggested time : 20 minutes
***
The Luhn test is used by some credit card companies to distinguish valid credit card numbers from what could be a random selection of digits.

Those companies using credit card numbers that can be validated by the Luhn test have numbers that pass the following test:
* Reverse the order of the digits in the number.
* Take the first, third, ... and every other odd digit in the reversed digits and sum them to form the partial sum s1
* Taking the second, fourth ... and every other even digit in the reversed digits:
* Multiply each digit by two. Sum the digits if the answer to any one number is greater than nine to form partial sums for the even digits.
* Sum the partial sums of the even digits to form s2
* If s1 + s2 ends in zero then the original number is in the form of a valid credit card number as verified by the Luhn test.


For example, if the trial number is 49927398716:
* Reverse the digits: 61789372994
* Sum the odd digits: 6 + 7 + 9 + 7 + 9 + 4 = 42 = s1
* The even digits: 1,  8,  3,  2,  9
* Two times each even digit: 2, 16,  6,  4, 18
* Sum the digits of each multiplication: 2,  7,  6,  4,  9
* Sum the last: 2 + 7 + 6 + 4 + 9 = 28 = s2

s1 + s2 = 70 which ends in zero which means that 49927398716 passes the Luhn test

The task is to write a function/method/procedure/subroutine that will validate a number with the Luhn test, and use it to validate the 

following numbers:
49927398716
49927398717
1234567812345678
1234567812345670



###MVC Test - Suggested Time : 30 minutes
***

####Task : The project is a basic web site, and a library but there are a few compilation errors and the program needs to be improved.
* Fix any issues and get the project compiling
* Make all controllers inherit from `MyControllerBase`. This base class contains a lot of methods which allow messages to be passed back to the view for the user - the Alerts

####Controller Test

* Add a message to the Index action of the Home controller to display the current time to the user. Use the code already included which is designed to report Alerts back to the view from controlller actions. You will need to
   1. Amend the Shared layout, and insert the line @Html.Alerts() above the @RenderBody
   2. In the ActionMethod for Home.Index, add the line AddInfoAlert("XXX"); where XXX is the current date and time
   3. (optional) Use the DateTime Extensions to display the date in 3 different time zones
   4. (optional) Write a HTMLHelper instead of writing directly to the view to display the date in 3 different time zones. There is a HTML Helper already in the project for reference
   
* Add a new Controller and associated view to the project. The name should be DaysOfTheWeekController. This is a simple controller test to list the days of the week on the URL /DaysOfWeek
   1. In the index view of that controller, print full name days for every day of the week (eg Monday, Tuesday, Wednesday)
   2. Add a get action to that controller which accepts a number and translates that to a named weekday, where 0 is Sunday, and 6 is Saturday. eg /DaysOfTheWeek/4 would output Thursday
   3. (Optional) Change the name of the route which this controller responds to without changing the controller name. The new route should be /Days

####ViewModel Test
This uses the HelloViewModel class, and the associated actions on the Home controller
* Create a link from the Homepage to the new action (/Home/Hello/)
* Make the Name property Mandatory, and with a maximum length of 30
* Write a post method for the Hello action which validates the posted view model and displays the information back to the user above the form

####Membership Test
Add new fields to the Acccount class, capture the first and last name. We already capture age as an integer. You will need to amend the ApplicationUser class
  1. Add First and Last names as public properties
  2. Add constraints to those fields - max string length (100)
  3. Amend the views models and the form for registration to ask for and capture First and Last name, as well as Age. 

Finally - think of any improvements we could make to this test to make it more challenging
