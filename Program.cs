/*Perform all Mathematical operations (i.e., addition, subtraction, 
multiplication, division, Modulus division) with numbers.*/
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Threading;
using System.Xml.Linq;
using System;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Net;

class MainProgram
{
    public static void Main(string[] args)
    {
        //1task
        /*double Num1 = 0;
        double Num2 = 0;
        double result = 0;

        Console.WriteLine("------------------");
        Console.WriteLine("Calculator Program");
        Console.WriteLine("------------------");

        Console.WriteLine("Enter number 1: ");
        Num1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        Num2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an option: ");
        Console.WriteLine("\t+ :Add ");
        Console.WriteLine("\t- :subtract ");
        Console.WriteLine("\t/ :devide ");
        Console.WriteLine("\t* :multiply ");
        Console.WriteLine("\t% :Modulus ");

        switch(Console.ReadLine())
        {
          case "+":
          result = Num1 + Num2;
          Console.WriteLine($"Result: {Num1} + {Num2} = {result}");
          break;
          case "-":
          result = Num1 - Num2;
          Console.WriteLine($"Result: {Num1} - {Num2} = {result}");
          break;
          case "/":
          result = Num1 / Num2;
          Console.WriteLine($"Result: {Num1} / {Num2} = {result}");
          break;
          case "*":
          result = Num1 * Num2;
          Console.WriteLine($"Result: {Num1} * {Num2} = {result}");
          break;

          case "%":
          result = Num1 % Num2;
          Console.WriteLine($"Result: {Num1} % {Num2} = {result}");
          break;

          default:
          Console.WriteLine("That was not a valid option");
          break;

        }

        Console.ReadLine();*/
        //2task
        /*int a =20;
        int b =30;

        Console.WriteLine("Before Swaping Numbers A= "+a+" B= "+b);
        int temp=a;
        a=b;
        b=temp;

        Console.WriteLine("After Swaping Numbers A= "+a+" B= "+b);
        Console.ReadLine();*/

        //task3
        //. Find the greatest of three numbers.

        /*double Num1, Num2,Num3,Greatest;


        Console.WriteLine("Enter number 1: ");
        Num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number 2: ");
        Num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter number 3: ");
        Num3 = Convert.ToDouble(Console.ReadLine());

        if (Num1 > Num2 && Num1 > Num3)
            Greatest = Num1;
        else if (Num2 > Num3 && Num2 > Num3) 
            Greatest = Num2;
        else
            Greatest = Num3;
        Console.WriteLine("The Greatest among three is :" + Greatest);
        Console.ReadLine();*/


        //Task 4
        // Enter principal, no of years, rate of interest and calculate simple 
        // interest as well as compound interest.

        /*double principal, no_of_years, rate_of_interest,amount, simple_interest,compound_interest;

         Console.WriteLine("Enter Principal amount: ");
         principal = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("Enter number of years: ");
         no_of_years= Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("Enter rate of intrest: ");
         rate_of_interest = Convert.ToDouble(Console.ReadLine());

         amount = principal * Math.Pow(1 + rate_of_interest / 100 , no_of_years);


         simple_interest = (principal * rate_of_interest * no_of_years) / 100;
         Console.WriteLine("the simple intrest is " + simple_interest);
         compound_interest = amount - principal;
         Console.WriteLine("the compound intrest is " + compound_interest);

         Console.ReadLine();*/

        //Task 5
        //5. Enter number and check it is even-odd.

        /*double num1;

        Console.WriteLine("Enter a number : ");
        num1 = Convert.ToDouble(Console.ReadLine());

        if (num1 % 2 == 0)
        {
            Console.WriteLine(num1+" is an even number");
        }
        else
        {
            Console.WriteLine(num1 + " is an odd number");
        }
        Console.ReadLine();*/

        // Task 6
        // Enter 10 numbers and find sum of all numbers.
        //var numbers = new List<int>();
        //for(int i = 0;i <10;i++)
        //{
        //    int num = int.Parse(Console.ReadLine()!);
        //    numbers.Add(num);
        //}
        //int sum = 0;
        //foreach(var number in numbers)
        //{
        //    sum += number;
        //}
        //Console.WriteLine($"the sum of all 10 numbers is : {sum}");

        //Task 7
        //Enter number and find its factorial
        //Double Num1, factorial = 1;

        //Console.WriteLine("Enter number: ");
        //Num1 = Convert.ToDouble(Console.ReadLine());

        //for (int i = (int)Num1; i >= 1; i--)

        //{
        //    factorial = factorial * i;
        //}
        //Console.WriteLine($"the factorial of {Num1} is {factorial}");


        //Task 8
        //Print Fibonacci series. (0 1 1 2 3 5 8 ….)
        //Console.WriteLine("Enter the number of terms for the Fibonacci series: ");
        //int n = Convert.ToInt32(Console.ReadLine());

        //int firstNumber = 0, secondNumber = 1, nextNumber;

        //Console.Write("Fibonacci Series:");
        //Console.Write(firstNumber + " " + secondNumber + " ");

        //for (int i = 0; i < n-2; i++)
        //{
        //    nextNumber = firstNumber + secondNumber;
        //    Console.Write(nextNumber + " ");
        //    firstNumber = secondNumber;
        //    secondNumber = nextNumber;
        //}
        //Console.ReadLine();

        //Task 9
        //Enter three - digit number and display the sum of digits.
        //(Example: Input - 123 Output - 6)
        //Console.WriteLine("Enter a three-digit number: ");
        //int number = Convert.ToInt32(Console.ReadLine());
        //int sum = 0;
        //while (number != 0)
        //{
        //    sum = sum + number % 10;
        //    number = number / 10;
        //}
        //Console.WriteLine($"the sum of all three-digit is : {sum}");

        //Task 11
        //Enter a number and print its prime or not.
        //Console.Write("Enter number: ");
        //int Num1 = Convert.ToInt32(Console.ReadLine()); 
        //if (Num1 == 0)
        //{
        //    Console.Write("0 is not a prime number");
        //}
        //else if (Num1 == 1)
        //{
        //    Console.Write("1 is not a prime number");
        //}
        //else
        //{
        //    int i;
        //    for (i = 2; i < Num1; i++)
        //    {
        //        if (Num1 % i == 0)
        //        {
        //            Console.Write($"{Num1} is not a prime number");
        //            break;
        //        }
        //    }
        //        if (i == Num1)
        //    {
        //        Console.Write($"{Num1} is a prime number");
        //    }
        //}

        // Task 12
        // Print multiplication table of a number entered by user.
        //Console.Write("Enter a number: ");
        //int Num1 = Convert.ToInt32(Console.ReadLine());
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine($"{Num1} x {i} = {Num1 * i}");
        //}

        // Task 13
        // Enter year and print it is leap year or not.
        //    Console.WriteLine("Enter a year: ");
        //    int year = Convert.ToInt32(Console.ReadLine());

        //    if (IsLeapYear(year))
        //    {
        //        Console.WriteLine($"{year} is a Leap year");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{year} is not a Leap year");
        //    }
        //}
        //public static bool IsLeapYear(int year) 
        //{
        //    if (year % 4 == 0)
        //    {
        //        if (year % 100 == 0)
        //        {
        //            if (year % 400 == 0)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }

        // Task 14
        // Enter a number and print it is palindrome or not.
        //    Console.Write("Enter a number: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (IsPalindrome(number))
        //    {
        //        Console.WriteLine($"{number} is a palindrome.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not a palindrome.");
        //    }
        //}

        //public static bool IsPalindrome(int number)
        //{
        //    int originalNumber = number;
        //    int reverse = 0;

        //    while (number > 0)
        //    {
        //        int digit = number % 10;
        //        reverse = reverse * 10 + digit;
        //        number = number / 10;
        //    }

        //    return originalNumber == reverse;

        // Task15
        // Enter a number and print it is Armstrong or not.
        //    Console.Write("Enter a number: ");
        //    int number = Convert.ToInt32(Console.ReadLine());

        //    if (IsArmstrong(number))
        //    {
        //        Console.WriteLine($"{number} is a Armstrong Number .");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{number} is not a Armstrong Number .");
        //    }
        //}

        //public static bool IsArmstrong(int number)
        //{
        //    int originalNumber = number;
        //    int sum = 0;
        //    int numberofdigits =number.ToString().Length;


        //    while (number > 0)
        //    {
        //        int digit = number % 10;
        //        sum += (int)Math.Pow(digit, numberofdigits);
        //        number /= 10;

        //    }

        //    return originalNumber == sum;

        // Task 16
        // Create Calculator program using switch case.
        //double Num1 = 0;
        //double Num2 = 0;
        //double result = 0;

        //Console.WriteLine("------------------");
        //Console.WriteLine("Calculator Program");
        //Console.WriteLine("------------------");

        //Console.WriteLine("Enter number 1: ");
        //Num1 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Enter number 2: ");
        //Num2 = Convert.ToDouble(Console.ReadLine());

        //Console.WriteLine("Enter any Option from this");
        //Console.WriteLine("+ :Add ");
        //Console.WriteLine("- :subtract ");
        //Console.WriteLine("/ :divide ");
        //Console.WriteLine("* :multiply ");
        //Console.WriteLine("% :Modulus ");

        //i:
        //switch (Console.ReadLine())
        //{
        //    case "+":
        //        result = Num1 + Num2;
        //        Console.WriteLine($"Result: {Num1} + {Num2} = {result}");
        //        break;
        //    case "-":
        //        result = Num1 - Num2;
        //        Console.WriteLine($"Result: {Num1} - {Num2} = {result}");
        //        break;
        //    case "/":
        //        result = Num1 / Num2;
        //        Console.WriteLine($"Result: {Num1} / {Num2} = {result}");
        //        break;
        //    case "*":
        //        result = Num1 * Num2;
        //        Console.WriteLine($"Result: {Num1} * {Num2} = {result}");
        //        break;

        //    case "%":
        //        result = Num1 % Num2;
        //        Console.WriteLine($"Result: {Num1} % {Num2} = {result}");
        //        break;

        //    default:
        //        Console.WriteLine("That was not a valid option :( Please recorrect it");
        //        goto i;


        //}

        //Console.ReadLine();

        // Task 17
        // Print all whole numbers between 20 to 50.
        //for (int i = -1; i <= 50; i++)
        //{
        //    if (i >= 0)
        //    {
        //        Console.WriteLine($"{i} whole number");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{i} not a whole numbers");
        //    }
        //}
        //Console.ReadLine();

        // 18 Task
        // Print greater among two numbers using ternary operator.
        //Double a = 0;
        //Double b = 0;

        //Console.Write(" A: ");
        //a = Convert.ToDouble(Console.ReadLine());
        //Console.Write(" B: ");
        //b = Convert.ToDouble(Console.ReadLine());
        //Double max = (a>b)?a:b;
        //Console.WriteLine($"the greater among both A and B is {max}");
        //Console.ReadLine();

        // Task 19
        // Enter a number and print it is positive or negative.
        //Double num = 0;
        //Console.Write("Enter a number: ");
        //num = Convert.ToDouble(Console.ReadLine());

        //if (num >= 0)
        //{
        //    Console.WriteLine($"{num} is a positive number");
        //}
        //else
        //{
        //    Console.WriteLine($"{num} is a Negetive number");
        //}
        //Console.ReadLine();

        // Task 20
        // Enter marks and check pass or fail.
        //Double marks  = 0;
        //Console.Write("Enter your marks: ");
        //marks  = Convert.ToDouble(Console.ReadLine());
        //double passing = 35;
        //if (marks >= passing )
        //{
        //    Console.WriteLine($"You have passed by obtaining {marks} marks");
        //}
        //else
        //{
        //    Console.WriteLine($"You are failed to obtain Passing {passing} marks");
        //}
        //Console.ReadLine();

        // Task 21
        // Enter marks and print according to criteria: 
        //70 - 100->distinction
        //50 - 70->first class
        //40-45 -> second class
        //<40 -> fail
        //Double marks = 0;
        //Console.Write("Enter your marks: ");
        //marks = Convert.ToDouble(Console.ReadLine());

        //double fail = 40;
        //double secondclass = 45 ;
        //double firstclass = 70;
        //double distinction = 100;

        //if (marks < fail)
        //{
        //    Console.WriteLine("Fail");
        //}
        //else if (marks < secondclass)
        //{
        //    Console.WriteLine("Second Class");
        //}
        //else if (marks < firstclass)
        //{
        //    Console.WriteLine("First Class");
        //}
        //else if (marks < distinction)
        //{
        //    Console.WriteLine("Distintion");
        //}
        //else
        //{
        //    Console.WriteLine("Recheck Marks Entered");
        //}
        //Console.ReadLine();

        // 22 Task 
        // Print all prime numbers between 1 to 100.
        //    Console.Write("Prime numbers between 1 and 100 are: ");

        //    for (int i = 2; i <= 100; i++)
        //    {
        //        if (IsPrime(i))
        //        {
        //            Console.Write(i + " ");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //public static bool IsPrime(int number)
        //{
        //    if (number <= 1) return false;
        //    if (number == 2) return true;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0) return false;
        //    }
        //    return true;

        // Task 23
        // Enter day name (Example: Monday, Tuesday, etc.) and print it is 
        // weekday or weekend using switch case
        //Console.WriteLine("----------------------------");
        //Console.WriteLine("ENTER ANY WEEK DAY FROM THIS ");
        //Console.WriteLine("----------------------------");
        //Console.WriteLine("Monday ");
        //Console.WriteLine("Tuesday ");
        //Console.WriteLine("Wednesday ");
        //Console.WriteLine("Thursday ");
        //Console.WriteLine("Friday ");
        //Console.WriteLine("Saturday ");
        //Console.WriteLine("Sunday ");
        //{
        //    Console.Write("Enter a Day: ");
        //    string day = Console.ReadLine();
        //    switch (day.ToLower())
        //    {
        //        case "monday":
        //        case "tuesday":
        //        case "wednesday":
        //        case "thursday":
        //        case "friday":
        //            Console.WriteLine($"{day} is  a weekday.");
        //            break;
        //        case "saturaday":
        //        case "sunday":
        //            Console.WriteLine($"{day} is a weekend.");
        //            break;

        //        default:
        //            Console.WriteLine($"{day} is not a valid Week day");
        //            break;
        //    }
        //}
        //Console.ReadLine();


        // Task 24
        // Print all even numbers between 1 to 50.
        //Console.Write($"even numbers in range of 1 to 50 are: ");
        //for (int i =1;i<=50; i++)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.Write(i+" ");
        //    }
        //}
        //Console.ReadLine();


        // Task 25
        // Write a login program to enter username and password, continue 
        // the loop till the user enters correct credentials.


        //while (true)
        //{
        //    Console.WriteLine("-----------------------");
        //    Console.WriteLine("Please enter your username ");
        //    string username = Console.ReadLine();
        //    Console.WriteLine("Please enter your Password ");
        //    string password = Console.ReadLine();
        //    Console.WriteLine("-----------------------");

        //    if (username == "Aman" && password == "2003")
        //    {
        //        Console.WriteLine("welcome Aman! Good Morning");
        //        return;
        //    }

        //    Console.WriteLine("Enter correct credentials!");            
        //}

        // Task 26
        // Enter age and print the eligibility to vote using goto statement.
        //i:
        //    Console.Write("Enter Your Age: ");
        //    int number = Convert.ToInt32(Console.ReadLine());
        //    if (number > 18)
        //    {
        //        Console.WriteLine("||YOU ARE ELIGIBLE FOR VOTING||");
        //        return;
        //    }
        //    else
        //    {
        //        Console.WriteLine("||YOU ARE NOT ELIGIBLE FOR VOTING||");
        //    }  
        //    goto i;


        //Task 27
        // Find the minimum or maximum element from the Array.
        //int min= int.MaxValue;
        //int max = int.MinValue;
        //int[] numbers = { 20,42,2,3,45,67,1,2,3,4,5,6,7 };
        //foreach (int number in numbers)
        //{
        //    if (number >= max)
        //    {
        //        max= number;
        //    }         

        //}
        //foreach (int number2 in numbers)
        //{
        //    if (number2 <= min)
        //    {
        //        min = number2;
        //    }
        //}
        //Console.WriteLine($"minimum element is {min} and max element is {max}");

        // Task 28
        // Accept 10 numbers from the user in the array and perform sorting.
        //int[] numbers = new int[10];
        //Console.WriteLine("Please enter 10 numbers: ");

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    Console.Write($"Enter Number {i+1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}

        //Array.Sort(numbers);
        //Console.WriteLine("the sorted array :");
        //foreach(int number in numbers)
        //{
        //    Console.Write(number+" ");
        //}


        // Task 29
        // Accept 10 numbers in an array and reverse the values (without 
        // using any inbuilt functions)
        //int[] numbers = new int[10];
        //Console.WriteLine("Please enter 10 numbers: ");
        //for (int i = 0; i < numbers.Length; i++)//For 10 user input 
        //{
        //    Console.Write($"Enter Number {i+1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //for (int i = 0; i < numbers.Length / 2; i++)//For reversing the array
        //{
        //    int n = numbers[i];
        //    numbers[i] = numbers[numbers.Length - 1 - i];
        //    numbers[numbers.Length - 1 - i] = n;
        //}
        //Console.WriteLine("the Reversed array :");
        //foreach(int number in numbers)
        //{
        //    Console.Write(number+" ");
        //}



        // Task 30
        //  30. Accept 10 numbers in an array and print which numbers are even 
        // or odd.
        //int[] numbers = new int[10];
        //Console.WriteLine("Please enter 10 numbers: ");
        //for (int i = 0; i < numbers.Length; i++)//For 10 user input 
        //{
        //    Console.Write($"Enter Number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //foreach (int i in numbers)
        //{
        //    if (i % 2 == 0)
        //    {
        //        Console.WriteLine($"{i} is an even number");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{i} is an odd number");
        //    }
        //}
        //Console.WriteLine();

        // Task 31
        // Create two arrays with 5 numbers in each. Merge all the 
        // numbers in the third array in sorted order.
        //int[] num = new int[5];
        //Console.WriteLine("Please enter 5 numbers in num: ");
        //for (int i = 0; i < num.Length; i++)//For 10 user input 
        //{
        //    Console.Write($"Enter Number {i + 1}: ");
        //    num[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int[] num2 = new int[5];
        //Console.WriteLine("Please enter 5 numbers in num2: ");
        //for (int i = 0; i < num2.Length; i++)//For 10 user input 
        //{
        //    Console.Write($"Enter Number {i + 1}: ");
        //    num2[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //int[] numbers = num.Union(num2).ToArray();
        //Array.Sort(numbers);
        //Console.WriteLine("the Joined and sorted array :");
        //foreach (int number in numbers)
        //{
        //    Console.Write(number + " ");
        //}
        //Console.WriteLine();

        // Task 33
        // Accept 10 numbers in an array and calculate sum of all the 
        // elements.

        //int[] numbers = new int[10];
        //int sum = 0;
        //Console.WriteLine("Please enter 10 numbers: ");
        //for (int i = 0; i < numbers.Length; i++)//For 10 user input 
        //{
        //    Console.Write($"Enter Number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //foreach (int number in numbers)
        //{
        //    sum += number;
        //}
        //Console.WriteLine($"the sum of all numbers in array is {sum}");

        // Task 34
        // Accept 10 numbers in an array and calculate average of all the 
        // elements.
        //int[] numbers = new int[10];
        //int sum = 0;
        //int count = 0;
        //Console.WriteLine("Please enter 10 numbers: ");
        //for (int i = 0; i < numbers.Length; i++)//For 10 user input 
        //{
        //    Console.Write($"Enter Number {i + 1}: ");
        //    numbers[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //foreach (int number in numbers)
        //{
        //    sum += number;
        //    count = numbers.Count();
        //}
        //Console.WriteLine($"the AVG of the all numbers in the array is :{sum/count}");

        // Task 35
        // Insert a new element in a particular position of an array and 
        // display the array.
        //int[] numbers = { 10, 20, 40, 50 };
        //int indexToInsert = 2; // Insert at this index
        //int valueToInsert = 30;
        //int[] newNumbers = new int[numbers.Length + 1];
        //Array.Copy(numbers, 0, newNumbers, 0, indexToInsert);
        //newNumbers[indexToInsert] = valueToInsert;
        //Array.Copy(numbers, indexToInsert, newNumbers, indexToInsert + 1, numbers.Length - indexToInsert);
        //numbers = newNumbers; 
        //foreach (int number in numbers)
        //{
        //    Console.Write(number + " "); 
        //}
        //Console.WriteLine();


        // Task 36
        // Delete an already existing element from an array and display the 
        // array.
        //int[] numbers = { 10, 20, 30, 40, 50 };
        //int indexToDelete = 2; // Delete the element at this index
        //int[] newNumbers = new int[numbers.Length - 1];
        //Array.Copy(numbers, 0, newNumbers, 0, indexToDelete);
        //Array.Copy(numbers, indexToDelete + 1, newNumbers, indexToDelete, numbers.Length - indexToDelete - 1);
        //numbers = newNumbers;
        //foreach (int number in numbers)
        //{
        //    Console.Write(number + " ");
        //}
        //Console.WriteLine();   


        // Task 37
        // Print the following patterns:
        // Pattern 1
        //int n = 5;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write("* ");
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 2 

        //int n = 4;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}



        // Pattern 3
        //int n = 4;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(i);
        //    }
        //    Console.WriteLine();
        //}


        // Pattern 4    
        //1
        //23
        //456
        //78910

        //int n = 1;
        //for (int i = 1; i <= 4; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        Console.Write(n+" ");
        //        n++;
        //    }
        //    Console.WriteLine();

        // Pattern 5
        //    *
        //   * *
        //  * * *
        // * * * *
        //int n = 4;
        //int z = 1;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = n - 1; j >= i; j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k <= z; k++)
        //    {
        //        Console.Write("* ");
        //    }
        //    z += 1;
        //    Console.WriteLine();
        //}

        // Pattern 6
        //    *
        //   **
        //  ***
        // ****
        //int n = 4;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= n - i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k <= i; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 7
        //    *
        //   ***
        //  *****
        // *******
        //int n = 4;
        //int z = 1;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = n - 1; j >= i; j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k <= z; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    z += 2;
        //    Console.WriteLine();
        //}



        // Pattern 8
        //1
        //2*
        //33*
        //444*
        //5555*
        //int n = 5;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        if (j == i)
        //        {
        //            if (j == 1)
        //            {
        //                Console.Write(i);
        //            }
        //            else
        //            {
        //                Console.Write("*");
        //            }
        //        }
        //        else
        //        {
        //            Console.Write(i);
        //        }
        //    }
        //    Console.WriteLine();
        //}



        // Pattern 9
        //*******
        //*     *
        //*     *
        //*     *
        //*     *
        //*     *
        //*******
        //int n = 7;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= n; j++)
        //    {
        //        if (i == 1 || i == n || j == 1 || j == n)
        //        {
        //            Console.Write("*");
        //        }
        //        else
        //        {
        //            Console.Write(" ");
        //        }
        //    }
        //    Console.WriteLine();
        //}


        // Pattern 10
        //      *
        //     ***
        //    *****
        //   *******
        //  *********
        // ***********
        //*************
        // ***********
        //  *********
        //   *******
        //    *****
        //     ***
        //      *

        //int n = 7;
        //// Upper part of the diamond
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = n - i; j > 0; j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k <= 2 * i - 1; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        ////Lower part of the diamond
        //for (int i = n - 1; i >= 1; i--)
        //{
        //    for (int j = n - i; j > 0; j--)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = 1; k <= 2 * i - 1; k++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        // Second method for diamond pattern using tarnary operators
        //int n = 7;
        //for (int i = 1; i <= 2 * n - 1; i++)
        //{
        //    int Rows = i <= n ? i : 2 * n - i;
        //    for (int j = 1; j <= n - Rows; j++)
        //    {
        //        Console.Write("1");
        //    }
        //    for (int k = 1; k <= 2 * Rows - 1; k++)
        //    {
        //        Console.Write("0");
        //    }
        //    Console.WriteLine();
        //}







        // Pattern 11
        //int numbers = 1;
        //while (numbers <= 8)
        //{
        //    int num2 = numbers;
        //    while (num2 <= 8)
        //    {
        //        Console.Write("* ");
        //        num2++;
        //    }
        //    Console.WriteLine();
        //    numbers++;
        //}


        // Pattern 12 
        //int n = 21;
        //// Upper half of the diamond
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j < n - 1 - i; j++)
        //        Console.Write(" ");
        //    Console.Write("*");
        //    if (i > 0)
        //    {
        //        for (int j = 0; j < 2 * i - 1; j++)
        //            Console.Write(" ");
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}
        //// Lower half of the diamond
        //for (int i = n - 2; i >= 0; i--)
        //{
        //    for (int j = 0; j < n - 1 - i; j++)
        //        Console.Write(" ");

        //    Console.Write("*");
        //    if (i > 0)
        //    {
        //        for (int j = 0; j < 2 * i - 1; j++)
        //            Console.Write(" ");
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 13
        // 


        // Pattern 14
        // 5
        // 54
        // 543
        // 5432
        // 54321
        //int n = 5;
        //for (int i = 1; i <= n; i++)
        //{

        //        for (int k = n; k>=n-i+1; k--)
        //        {
        //            Console.Write(k);
        //        }

        //    Console.WriteLine();
        //}

        //15 Pattern 
        //1******
        //12*****
        //123****
        //1234***
        //12345**
        //123456*
        //1234567
        //int n = 7;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int k = 1; k <= i; k++)
        //    {
        //        Console.Write(k);
        //    }
        //    for (int j = n - i; j > 0; j--)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}


        // Pattern 16
        //1
        //21
        //321
        //4321
        //54321
        //int n = 5;
        //for (int i = 1;i <=n;i++)
        //{
        //    for (int j = i; j >= 1; j--)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 17
        //5
        //45
        //345
        //2345
        //12345
        //int n = 5;
        //for (int i = n ; i >= 1; i--)
        //{
        //    for (int j = i; j <= n; j++)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}



        // Pattern 18
        //int numbers = 1;
        //while (numbers < 6)
        //{
        //    int num2 = numbers;
        //    while (num2 < 6)
        //    {
        //        Console.Write(num2 + " ");
        //        num2++;
        //    }
        //    Console.WriteLine();
        //    numbers++;
        //}

        // Pattern 19
        // 54321
        //  5432
        //   543
        //    54
        //     5
        //int n = 5;
        //for (int i = 0; i < n; i++)
        //{
        //    for (int j = 0; j <i; j++)
        //    {
        //        Console.Write(" ");
        //    }
        //    for (int k = n; k > i; k--)
        //    {
        //        Console.Write(k);
        //    }
        //    Console.WriteLine();           
        //}

        // Pattern 20
        //$
        //##
        //$$$
        //####
        //int n = 4;
        //for (int i = 1; i <= n; i++)
        //{
        //    for (int j = 1; j <= i; j++)
        //    {
        //        if (i % 2 == 0)
        //        {
        //            Console.Write("#");
        //        }
        //        else
        //        {
        //            Console.Write("$");
        //        }
        //    }
        //    Console.WriteLine();
        //}

        //38. Print the following patterns using 2D Array :
        // 1 Pattern 
        // *
        // **
        // ***
        // ****
        // Method 1 *****************************
        //string [,] str = { {"*","**" }, {"***","****"} };
        //for (int i = 0; i < str.GetLength(0); i++)
        //{
        //    for (int j = 0; j < str.GetLength(1); j++)
        //    {
        //        Console.WriteLine (str[i,j]);
        //    }
        //}
        ///// Method 2 *****************************
        //string [,] pattern = new string[4, 4]
        //{
        //    { "*", " ", " ", " " },
        //    { "*", "*" ," ", " " },
        //    { "*" , "*", "*", " " },
        //    { "*", "*", "*", "*" }
        //};
        //for (int i = 0; i < pattern.GetLength(0); i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write(pattern[i, j]);
        //    }
        //    Console.WriteLine();
        //}


        // 2 Pattern 
        //1
        //12
        //123
        //1234
        ///////First method **********************
        //int [,] str = { { 1, 12 }, { 123, 1234 } };
        //for (int i = 0; i < str.GetLength(0); i++)
        //{
        //    for (int j = 0; j < str.GetLength(1); j++)
        //    {
        //        Console.WriteLine(str[i, j]);
        //    }
        //}
        //////// Second Method****************************
        //int[,] pattern = new int[4, 4]
        //{
        //    { 1, 0, 0, 0 },
        //    { 1, 2, 0, 0 },
        //    { 1, 2, 3, 0 },
        //    { 1, 2, 3, 4 }
        //};
        //for (int i = 0; i < pattern.GetLength(0); i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write(pattern[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 3
        //1
        //22
        //333
        //4444
        ///////First method *****************************
        //int[,] str = { { 1, 22 }, { 333, 4444 } };
        //for (int i = 0; i < str.GetLength(0); i++)
        //{
        //    for (int j = 0; j < str.GetLength(1); j++)
        //    {
        //        Console.WriteLine(str[i, j]);
        //    }
        //}
        //////// Second Method *****************************
        //int[,] pattern = new int[4, 4]
        //{
        //    { 1, 0, 0, 0 },
        //    { 2, 2, 0, 0 },
        //    { 3, 3, 3, 0 },
        //    { 4, 4, 4, 4 }
        //};
        //for (int i = 0; i < pattern.GetLength(0); i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write(pattern[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 4
        //1
        //23
        //456
        //78910
        ///////First method **********************************8
        //int[,] str = { { 1, 23 }, { 456, 78910} };
        //for (int i = 0; i < str.GetLength(0); i++)
        //{
        //    for (int j = 0; j < str.GetLength(1); j++)
        //    {
        //        Console.WriteLine(str[i, j]);
        //    }

        //}
        //////// Second Method ***********************************
        //int[,] pattern = new int[4, 4]
        //{
        //    { 1, 0, 0, 0 },
        //    { 2, 3, 0, 0 },
        //    { 4, 5, 6, 0 },
        //    { 7, 8, 9, 10 }
        //};
        //for (int i = 0; i < pattern.GetLength(0); i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write(pattern[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 5
        //   *
        //  * *
        // * * *
        //* * * *
        ////// method 1 ****************************************************
        //string[,] str = { { "   *", "  * *" }, { " * * *", "* * * *" } };
        //for (int i = 0; i < str.GetLength(0); i++)
        //{
        //    for (int j = 0; j < str.GetLength(1); j++)
        //    {
        //        Console.WriteLine(str[i, j]);
        //    }
        //}
        ////// Method 2 *******************************************************
        //string[,] pattern = new string[4,7]
        //{
        //    { " ", " ", " ", "*", " ", " ", " " },
        //    { " ", " ", "*", " ", "*", " ", " " },
        //    { " ", "*", " ", "*", " ", "*", " " },
        //    { "*", " ", "*", " ", "*", " ", "*" }
        //};
        //for (int i = 0; i < pattern.GetLength(0); i++)
        //{
        //    for (int j = 0; j < pattern.GetLength(1); j++)
        //    {
        //        Console.Write(pattern[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 6
        //      *
        //    * *
        //  * * *
        //* * * *
        ////// method 1 *****************************************************
        //string[,] str = { { "      *", "    * *" }, { "  * * *", "* * * *" } };
        //for (int i = 0; i < str.GetLength(0); i++)
        //{
        //    for (int j = 0; j < str.GetLength(1); j++)
        //    {
        //        Console.WriteLine(str[i, j]);
        //    }
        //}
        ////// Method 2 *****************************************************
        //string[,] pattern = new string[4, 7]
        //{
        //    { " ", " ", " ", " ", " " ," ", "*" },
        //    { " ", " ", " ", " ", "*", " ", "*" },
        //    { " ", " " , "*", " ", "*", " ", "*"},
        //    { "*", " ", "*", " ", "*", " ", "*" }
        //};
        //for (int i = 0; i < pattern.GetLength(0); i++)
        //{
        //    for (int j = 0; j < pattern.GetLength(1); j++)
        //    {
        //        Console.Write(pattern[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        // Pattern 7
        ////// method 1 *****************************************
        //string[,] str = { { "      *", "    * * *" }, { "  * * * * *", "* * * * * * *" } };
        //for (int i = 0; i < str.GetLength(0); i++)
        //{
        //    for (int j = 0; j < str.GetLength(1); j++)
        //    {
        //        Console.WriteLine(str[i, j]);
        //    }
        //}
        ////// Method 2 ********************************************
        //string[,] pattern = new string[4, 13]
        //{
        //    { " ", " ", " ", " ", " " ," ", "*"," ", " ", " ", " ", " " ," " },
        //    { " ", " ", " ", " ", "*", " ", "*"," ", "*", " ", " ", " ", " "},
        //    { " ", " " , "*", " ", "*", " ", "*"," ", "*" , " ", "*", " ", " "},
        //    { "*", " ", "*", " ", "*", " ", "*" ," ", "*", " ", "*", " ", "*"}
        //};
        //for (int i = 0; i < pattern.GetLength(0); i++)
        //{
        //    for (int j = 0; j < pattern.GetLength(1); j++)
        //    {
        //        Console.Write(pattern[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        // <<<<<<<<<<<<<<<<<LEVEL 3 TASK>>>>>>>>>>>>>>>>>>>>

        // Task 1
        //  Swap two number using Call by Value and Call by Reference.
        //int x = 5;
        //int y = 10;
        //{
        //    Console.WriteLine($"Original values: x = {x}, y = {y}");
        //    SwapByValue(x, y);
        //    Console.WriteLine($"After SwapByValue: x = {x}, y = {y}");
        //    SwapByReference(ref x, ref y);
        //    Console.WriteLine($"After SwapByReference: x = {x}, y = {y}");
        //}
        //static void SwapByValue(int a, int b)// swap by value 
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;

        //}
        //static void SwapByReference(ref int a, ref int b)// swap by reference
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}

        // Task 2
        // Calculate area and circumference of circle using functions
        // (with return type and without return type)
        //    double radius;
        //    Console.WriteLine("Enter the radius of the circle: ");
        //    radius = Convert.ToDouble(Console.ReadLine());
        //    double area = CalculateArea(radius);
        //    double circumference = CalculateCircumference(radius);
        //    Console.WriteLine($"Area (with return type): {area}");
        //    Console.WriteLine($"Circumference (with return type): {circumference}");
        //    CalculateAreaWithoutReturn(radius);
        //    CalculateCircumferenceWithoutReturn(radius);
        //}

        ////// Function to calculate area with return type
        //public static double CalculateArea(double radius)
        //{
        //    return Math.PI * radius * radius;
        //}

        ////// Function to calculate circumference with return type
        //public static double CalculateCircumference(double radius)
        //{
        //    return 2 * Math.PI * radius;
        //}

        ////// Function to calculate area without return type
        //public static void CalculateAreaWithoutReturn(double radius)
        //{
        //    double area = Math.PI * radius * radius;
        //    Console.WriteLine($"Area (without return type): {area}");
        //}

        ////// Function to calculate circumference without return type
        //public static void CalculateCircumferenceWithoutReturn(double radius)
        //{
        //    double circumference = 2 * Math.PI * radius;
        //    Console.WriteLine($"Circumference (without return type): {circumference}");
        //}


        //*********this  task 2 will work only after removing  the last parenthesis**********
        //********* Reenter the same parenthesis after running the program after **********



        // Task 3
        // Calculate area of rectangle using out parameter.

        // Other tasks...

        //    double length, width, area;

        //    Console.WriteLine("Enter the length of the rectangle: ");
        //    length = Convert.ToDouble(Console.ReadLine());

        //    Console.WriteLine("Enter the width of the rectangle: ");
        //    width = Convert.ToDouble(Console.ReadLine());

        //    // Calculate area using out parameter
        //    CalculateArea(length, width, out area);

        //    Console.WriteLine($"The area of the rectangle is: {area}");

        //}
        //// Function to calculate area using out parameter
        //public static void CalculateArea(double length, double width, out double area)
        //{
        //    area = length * width;
        //}
        //*********this  task 3 will work only after removing  the last parenthesis**********
        //********* Reenter the same parenthesis after running the program after **********


        // Task 4
        // Display max and min number from the following string array:
        // {“1”, “Rohan”, “Avinash”, “5”, “tina”, “100”, “Rahul”, “38”}
        //string[] array = { "1", "Rohan", "Avinash", "5", "tina", "100", "Rahul", "38" };

        //// Filter out numeric values and convert them to integers
        //// using Linq
        //var numbers = array.Where(item => int.TryParse(item, out _)).Select(int.Parse).ToArray();
        //if (numbers.Length > 0)
        //{
        //    int min = numbers.Min();
        //    int max = numbers.Max();

        //    Console.WriteLine($"Minimum number: {min}");
        //    Console.WriteLine($"Maximum number: {max}");
        //}
        //else
        //{
        //    Console.WriteLine("No numeric values found in the array.");
        //}

        //// using if 
        //string[] array = { "1", "Rohan", "Avinash", "5", "tina", "100", "Rahul", "38" };

        //int max = int.MinValue; // Start with the smallest possible integer
        //int min = int.MaxValue; // Start with the largest possible integer
        //foreach (string item in array)
        //{
        //    // Check if the item can be parsed as an integer
        //    if (int.TryParse(item, out int number))
        //    {
        //        // Update max if the current number is greater
        //        if (number > max)
        //        {
        //            max = number;
        //        }

        //        // Update min if the current number is smaller
        //        if (number < min)
        //        {
        //            min = number;
        //        }
        //    }
        //}
        //// Display the results
        //Console.WriteLine($"Maximum number: {max}");
        //Console.WriteLine($"Minimum number: {min}");

        // Task 5
        // Calculate sum of numbers from the string array:
        // {“1”, “Sona”, “David”, “50”, “Fardeen”, “19”, “Rishi”, “68”}

        ////using Linq
        //string[] array = { "1", "Sona", "David", "50", "Fardeen", "19", "Rishi", "68" };
        //var numbers =array.Where(item => int.TryParse(item, out _)).Select(int.Parse).ToArray();
        //int sum = (numbers.Sum());
        //Console.WriteLine($"the sum of all the numbers in array is : {sum}");

        ////using Out
        //string[] array = { "1", "Sona", "David", "50", "Fardeen", "19", "Rishi", "68" };
        //int sum = 0;
        //foreach (string item in array)
        //{
        //    // Check if the item can be parsed as an integer
        //    if (int.TryParse(item, out int number))
        //    {
        //        sum += number;

        //    }       
        //}
        //Console.WriteLine($"sum of all the numbers in the array is:{sum}");



        // Task 6
        // Calculate the sum of Integer values as well as decimal values
        // separately from the given string array:
        // {“1”,”10.5”,”11”,”12.5”,”14”,”15.5”,”16”,”17”,”18.5”}

        //string[] numbers = { "1", "10.5", "11", "12.5", "14", "15.5", "16", "17", "18.5" };
        //decimal sumdec = 0;
        //int sumint = 0;
        //foreach (string number in numbers)
        //{
        //    if (decimal.TryParse(number, out decimal decimalValue))
        //    {
        //        if (decimalValue % 1 == 0)
        //        {
        //            sumint += (int)decimalValue;
        //        }
        //        else
        //        {
        //            sumdec += decimalValue;
        //        }
        //    }
        //}

        //Console.WriteLine($"Sum of integers: {sumint}");
        //Console.WriteLine($"Sum of decimals: {sumdec}");


        // Task 7 
        // Accept the Number of Students from 1st std to 5th std, Accept their 
        // Name and Roll no from user and display them using Jagged Array.


        //////////LEVEL 4 TASK//////////

        // Task 1
        // Enter a sentence and find the number of spaces, words, vowels and 
        // consonants.

        //Console.Write("Enter a Sentence: ");
        //string st = Console.ReadLine();
        //int vcount = 0, ccount = 0, scount = 0, wcount = 0;
        //foreach (char s in st)
        //{
        //    if ((s >= 'a' || s <= 'z') || (s >= 'A' || s <= 'Z'))
        //    {
        //        if (s == 'a' || s == 'e' || s == 'i' || s == 'o' || s == 'o')
        //        {
        //            vcount++;
        //        }
        //        else if (s == 'A' || s == 'E' || s == 'I' || s == 'O' || s == 'U')
        //        {
        //            vcount++;
        //        }
        //        if (s == ' ')
        //        {
        //            scount++;
        //        }

        //        else
        //            ccount++;
        //    }
        //    //string[] words = st.Split(" ");
        //    //wcount = words.Length;

        //}
        //Console.WriteLine($"count of vowels ={vcount}\ncount of consonants ={ccount}\ncount of space ={scount}\ncount of words ={scount+1}");

        // Task 2
        // Enter a sentence and capitalize first letter of each word
        // Input: my name is tom.
        // Output: My Name Is Tom.

        //Console.Write("Enter a sentence: ");
        //string sentence = Console.ReadLine();
        //string[] words = sentence.Split(' ');
        //for (int i = 0; i < words.Length; i++)
        //{
        //    words[i] = words[i].Substring(0,1).ToUpper() + words[i].Substring(1).ToLower();
        //}
        //string Formated  = string.Join(" ", words);
        //Console.WriteLine("Output: " + Formated);

        // Task 3
        // Input: Rohan.Singh@featsystems.com
        // Output: First name: Rohan
        // Last name: Singh
        // Company: featsystems
        //string firstname, lastname, company;
        //Console.Write("Enter your email: ");
        //string sentence = Console.ReadLine();
        //string[] words = sentence.Split('.', '@');
        //    firstname = words[0];
        //    lastname = words[1];
        //    company = words[2];
        //Console.WriteLine($"Input : {sentence}\nFirst name: {firstname}\nLast name: {lastname}\nCompany: {company}");

        // Task 4
        // Input: “Please feel free to contact me on abhishek.solanki@gmail.com 
        // anytime between 10 am to 6 pm.”
        // Output: abhishek.solanki @gmail.com

        //string email;
        //string str = "Please feel free to contact me on abhishek.solanki@gmail.com anytime between 10 am to 6 pm.";
        //string[] words = str.Split(' ', '.', '@');
        //email = words[7] + "." + words[8] + "@" + words[9] + "." + words[10];
        //Console.WriteLine("Found: " + email);

        ////// //Using Regex for pattern matching

        //string input = "Please feel free to contact me on abhishek.solanki@gmail.com anytime between 10 am to 6 pm.";
        //string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; 

        ////(?<= h | H).*
        //Match match = Regex.Match(input, pattern);
        //if (match.Success)
        //{
        //    Console.WriteLine("Found: " + match.Value);
        //}


        // Task 5
        // Enter a name and display the frequency of each letter.
        // Input: address
        // Output: a = 01, d = 02, r = 01, e = 01, s = 02

        //Console.Write("Enter a name: ");
        //string name = Console.ReadLine().ToLower(); // Convert to lowercase to count letters case-insensitively
        //foreach (char item in name)
        //{
        //    if (Char.IsLetter(item))
        //    {
        //        int count = 0;
        //        foreach (char compareLetter in name)
        //        {
        //            if (item == compareLetter)
        //            {
        //                count += 1;
        //            }
        //        }
        //        if (count > 0)
        //        {
        //            Console.WriteLine($"{item}: {count}");
        //            name = name.Replace(item.ToString(), ""); // Remove the letter from the name to avoid duplicate counting
        //        }
        //    }
        //}

        // Task 6
        // Enter a word and reverse it. 
        // Input: Sunday Output: yadnus
        //Console.Write("Enter a name: ");
        //string name = Console.ReadLine();
        //string reversed = new string(name.Reverse().ToArray());
        //Console.WriteLine($"Reversed Successfully: {reversed}"); 

        // Task 7
        // Enter a word and check it is palindrome or not. 
        // Input: dad = palindrome
        // Input: mom = palindrome
        // Input: good = not a palindrome

        //Console.Write("Enter a word : ");
        //string word = Console.ReadLine().ToLower();
        //string reversed = new string(word.Reverse().ToArray());
        //if (word == reversed)
        //{
        //    Console.WriteLine($"{word} is a palindrome word");
        //}
        //else
        //{
        //    Console.WriteLine($"{word} is not a palindrome word");
        //}
        //Console.ReadLine();

        //Task 8
        //Console.Write("Enter a sentence: ");
        //string sentence = Console.ReadLine();
        //// Define delimiters
        //char[] delimiters = new char[] { ' ', ',', '.', '!', '?' };

        //// Split sentence into words and group them
        //var wcount = sentence
        //    .Split(delimiters, StringSplitOptions.RemoveEmptyEntries) // Split words and remove empty entries
        //    .GroupBy(word => word) // Group by each unique word
        //    .ToDictionary(group => group.Key, group => group.Count()); // Convert to dictionary with count

        //// Display the word occurrences
        //Console.WriteLine("Word occurrences:");
        //foreach (var pair in wcount)
        //{
        //    Console.WriteLine($"{pair.Key}: {pair.Value}");
        //}

        // Task 9
        // Enter a word and remove the duplicate letters. 
        // Input: teen Output: tn
        //{
        //    Console.Write("Enter a word: ");
        //    string input = Console.ReadLine().ToLower();

        //    string result = new string(input.ToCharArray().Distinct().ToArray());
        //    Console.WriteLine("Result: " + result);
        //}
        //1.Read the input word and convert it to lowercase.
        //2.Convert the word into a character array.
        //3.Use LINQ's Distinct method to remove duplicate characters.
        //4.Convert the resulting character array back into a string.
        //5.Display the result.

        // Task 10
        // Enter 10 names in a string array and display only those names 
        // which are starting with “H”.

        //string[] names = new string[10]; // Array to store 10 names
        //Console.WriteLine("Enter 10 names:");
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write($"Name {i + 1}: ");
        //    names[i] = Console.ReadLine().ToUpper(); // Read input and convert to uppercase
        //}
        //Console.WriteLine("\nNames starting with 'H':");
        //foreach (string name in names)
        //{
        //    if (name.StartsWith("H"))
        //    {
        //        Console.WriteLine(name.ToLower());
        //    }
        //}

        // Task 11
        // Replace (.) with (,) and vice versa in the following string:
        // Input: “Sanjay.Rahul.Gautam,tina.farooq,yash.ketan” 
        // Output: “Sanjay,Rahul,Gautam.tina,farooq.yash,ketan” 
        //{
        //    string input = "Sanjay.Rahul.Gautam,tina.farooq,yash.ketan";
        //    string output = input.Replace('.', '#').Replace(',', '.').Replace('#', ',');
        //    Console.WriteLine("Input: " + input);
        //    Console.WriteLine("Output: " + output);
        //}

        // Task 12
        // String str = “Client ID: A1234
        // Account Number: P12345
        // Account Amount: 5690350”
        // Extract the Client ID, Account Number and Account amount and
        // display them.
        //string str = "Client ID: A1234\nAccount Number: P12345\nAccount Amount: 5690350";
        //// Split the string into lines
        //string[] lines = str.Split('\n');
        //// Extract and display the values
        //foreach (string line in lines)
        //{
        //    string[] parts = line.Split(':');
        //    if (parts.Length == 2)
        //    {
        //        string key = parts[0].Trim();
        //        string value = parts[1].Trim();
        //        Console.WriteLine($"{key}: {value}");
        //    }
        //}


        // Task 13
        // Extract the last 10 numbers from the following phone numbers using
        // string functions:
        // Input: +91 9892345679 Output: 9892345679
        // Input: +913 9862343629 Output: 9862343629
        // Input: 986 - 234 - 3629 Output: 9862343629
        // Input: 986 234 362 8 Output: 9862343628

        //string Phonenumber;
        //Console.Write("Enter your phone number : ");
        //Phonenumber = Console.ReadLine();
        //Console.WriteLine("Input : " + Phonenumber);

        //Phonenumber = Phonenumber.Replace("-", "").Replace(" ", "").Replace("+913", "").Replace("+91", "");
        //if (Phonenumber.Length <= 10)
        //{
        //    Console.WriteLine("Output : " + Phonenumber); // Output the whole thing if it's less than 10 digits.
        //}
        //else
        //{
        //    string last10Digits = Phonenumber.Substring(Phonenumber.Length - 10);
        //    Console.WriteLine("Output : " + last10Digits);
        //} 



        // ***************************************** Regex Task ******************************************************

        // Task 1
        // 1. Enter the following input and validate it:
        // Email id, URL, PAN Card no, Aadhaar Card no, Phone no.

        //string Addhar = @"^[0-9]{12}$";
        //string phoneno = @"^[0-9]{10}$";
        //string pancard = @"^[A-Z||a-z]{5}[0-9]{4}[A-Z||a-z]{1}$";
        //string url = @"^https:\/\/.*$";
        //string email = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

        //Console.WriteLine("Enter any option what you want to validate");
        //Console.WriteLine("\t1 :Addhar ");
        //Console.WriteLine("\t2 :Phone number ");
        //Console.WriteLine("\t3 :Pan card number ");
        //Console.WriteLine("\t4 :Url");
        //Console.WriteLine("\t5 :email  ");
        //string option = Console.ReadLine();

        //string input;
        //Console.Write("Enter details : ");
        //input = Console.ReadLine();

        //switch (option)
        //{
        //    case "1":
        //        if (Regex.IsMatch(input, Addhar))
        //            Console.WriteLine($"{input} is a valid Aadhaar number.");
        //        else
        //            Console.WriteLine($"{input} is not a valid Aadhaar number.");
        //        break;
        //    case "2":
        //        if (Regex.IsMatch(input, phoneno))
        //            Console.WriteLine($"{input} is a valid Phone number.");
        //        else
        //            Console.WriteLine($"{input} is not a valid Phone number.");
        //        break;
        //    case "3":
        //        if (Regex.IsMatch(input, pancard))
        //            Console.WriteLine($"{input} is a valid Pancard number.");
        //        else
        //            Console.WriteLine($"{input} is not a valid Pancard number.");
        //        break;
        //    case "4":
        //        if (Regex.IsMatch(input, url))
        //            Console.WriteLine($"{input} is a valid url.");
        //        else
        //            Console.WriteLine($"{input} is not a valid url.");
        //        break;
        //    case "5":
        //        if (Regex.IsMatch(input, email))
        //            Console.WriteLine($"{input} is a valid email.");
        //        else
        //            Console.WriteLine($"{input} is not a valid email.");
        //        break;

        //    default:
        //        Console.WriteLine("That was not a valid option");
        //        break;

        //}
        //Console.ReadLine();


        /// <summary>
        /// ^               : Asserts the position at the start of the string.
        /// \w+             : Matches one or more word characters (letters, digits, and underscores).
        /// ([-+.']\w+)*    : Matches zero or more sequences of a hyphen, plus, dot, or apostrophe followed by one or more word characters.
        /// @               : Matches the "@" symbol.
        /// \w+             : Matches one or more word characters.
        /// ([-.]\w+)*      : Matches zero or more sequences of a hyphen or dot followed by one or more word characters.
        /// \.              : Matches a literal dot.
        /// \w+             : Matches one or more word characters.
        /// ([-.]\w+)*      : Matches zero or more sequences of a hyphen or dot followed by one or more word characters.
        /// $               : Asserts the position at the end of the string.

        // Task 2
        // Input: “Please feel free to contact me on abhishek.solanki @gmail.com
        // anytime between 10 am to 6 pm.”
        // Extract email id and timings using Regex.

        // ****************************************COLLECTION TASK:**************************************************************** 
        // 1.Create a List / Array List of Stationary items and perform insert, 
        // delete and search operation.

        List<string> stationary = new List<string>();
        stationary.Add("books");//Added elements
        stationary.Add("pens");//Added elements
        stationary.Add("cloths");//Added elements
        foreach (string item in stationary)
        {
            Console.Write($"Added three elements : {item}");
        } 
        stationary.Remove(stationary[2]);//Removed elements
        foreach (string str in stationary)
        {
            Console.Write($"After Deleting one element : {str}");
        }       
        Console.WriteLine(stationary);
        int index =stationary.IndexOf("books");
        Console.WriteLine($"index of books : {index}");













    }

}








