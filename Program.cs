/*  
         ASSESSMENT WEEK TWO

This assessment will be graded. 

Please read each questions carefully, visualize the solution before attempting to write the code.

Create a new project for this assessment (Project should be named: "AlphaApp")

Weight: 1

1. Write a program thats gets the value of two words from an input.
    a. Get the length of each word
    b. Add the result of the two lengths gotten from (a)
    c. Using the ternary operator, check if the resultant value from (b) is greater than 20
        i. If true multiply the result by 3.
        ii. Otherwise add 20 to the result.

    Example input:
        Input one: "Country"
        Input two: "Coding"

    Example output:
        33


2. Write a program to calculate the profit between the cost price of a product of $200.876 whose selling price is $255.425. The result should be in two decimal places.

3. Get the index of the third character of any given string. 
    - Add the value of the index to the length of the whole string.
    - Convert the result of the above to a character

4. Write a program that reads two numbers from the console and prints the 
greater of them. Solve the problem without using conditional or the tenary operator
statements.

5. Write a program that reads five integer numbers and prints their 
sum. If an invalid number is entered the program should prompt the user 
to enter another number. (Hint: use a while loop to solve the problem here. Also read about the Parse(), TryParse() method)

6. The sum of two numbers collected from user input, substracted from a constant value of 5.
(Sample expression: number1 + number2 - 5).

Write a program to prompt the user to input the correct answer from the above given expression.
    - If the user provides the correct answer print the text "Correct answer" to the console output.
    - Otherwise print the text "Wrong answer!" alongside the correct answer.

7. Write a program that asks for a digit (0-9), and depending on the input, 
shows the digit as a word (in English). Use a switch statement. */
         
         
         
         
         
         //Question 1

		     Console.WriteLine("----------------Question 1----------------");

          Console.WriteLine("Enter first word:");
          string firstWord = Console.ReadLine();
          int firstWordLength = firstWord.Length;

          Console.WriteLine("Enter second word:");
          string secondWord = Console.ReadLine();
          int secondWordLength = secondWord.Length;

        

          int bothWordLength = firstWordLength + secondWordLength;
          
          int result = bothWordLength > 20 ? bothWordLength * 3 : bothWordLength + 20;
          Console.WriteLine(result);
          Console.WriteLine();

          //Question 2
          Console.WriteLine("-----------Question 2-------------");
          double costPrice = 200.876;
          double sellingPrice = 255.425;
          double profit = sellingPrice - costPrice;

          Console.WriteLine($"The selling price - cost price is : ${sellingPrice - costPrice} ");
          Console.WriteLine($" The profit is : ${Math.Round(profit , 2)}");
          Console.WriteLine();



          // Question 3
          //Get the index of the third character of any given string. 
         	//- Add the value of the index to the length of the whole string.
	        //- Convert the result of the above to a character

          Console.WriteLine("-----------Question 3----------");
          
          string word = Console.ReadLine();
          int index = word.IndexOf( word[2]);

          int wordLength = word.Length;
        

          int newLength = index + wordLength;
          char result1 = (char)newLength;

          Console.WriteLine($"The third character in {word} is : {word[2]}");
          Console.WriteLine($"The Length of the {word} is {wordLength}");

          Console.WriteLine($"The index of the third character is {index} , the value added to the string is {wordLength} and the addition is {newLength}, the final unicode is {result1}");
         



          //Question 4
         Console.WriteLine("----------Question 4----------");

         Console.WriteLine("Enter your first number:");
         double firstNumber = double.Parse(Console.ReadLine());

         Console.WriteLine("Enter your second number:");
         double secondNumber = double.Parse(Console.ReadLine());

         double greaterNumber = Math.Max(firstNumber , secondNumber);

         Console.WriteLine($"The greater number is :{greaterNumber}" );
         Console.WriteLine();

          //Question 5
          
          //Write a program that reads five integer numbers and prints their 
          //sum. If an invalid number is entered the program should prompt the user 
         //to enter another number. Hint: use a while loop to solve the problem here.
           
         Console.WriteLine("----------Question 5---------");

         int sum = 0;
         int i = 0;
         while ( i <= 4)
         {
           Console.Write("Please enter number :");
        
           string
            input = Console.ReadLine();
           int x;
           bool isInteger = int.TryParse(input , out x);


           
           
           if (!isInteger)
           {
             i--;
             Console.Write("Invalid input! ");
             
           }
           
           
           sum += x;
           i++;
        
         }
         Console.WriteLine($"The sum of the numbers is :{sum}");





                 /*Question 6
                 6. The sum of two numbers collected from user input, substracted from a constant value of 5.
                 (Sample expression: number1 + number2 - 5).

             Write a program to prompt the user to input the correct answer from the above given expression.
	        - If the user provides the correct answer print the text "Correct answer" to the console output.
	        - Otherwise print the text "Wrong answer!" alongside the correct answer.*/


          Console.WriteLine("----------Question 6----------");

          const int value = 5;

          
         Console.WriteLine("Input your first number:");
         double firstNum = int.Parse(Console.ReadLine());

          
         Console.WriteLine("Input your second number:");
         double secondNum = int.Parse(Console.ReadLine());


          double result2 = firstNum + secondNum - value;
          
          Console.WriteLine("Enter the correct answer:");
          double correct = int.Parse(Console.ReadLine());

         if (result2 == correct)
         {
          
         Console.WriteLine("Correct Answer!");
          }
         else
         {
           Console.WriteLine($"Wrong Answer! The correct answer is {result2}");
         }

         // Question 7
           //Write a program that asks for a digit (0-9), and depending on the input, 
            //shows the digit as a word (in English). Use a switch statement.

            Console.WriteLine("Enter a number:");
           int num = int.Parse(Console.ReadLine());
           switch (num)
          {
            case 0:
            Console.WriteLine("Zero");
            break;
            case 1:
            Console.WriteLine("One");
            break;
            case 2:
            Console.WriteLine("Two");
            break;
            case 3:
            Console.WriteLine("Three");
            break;
            case 4:
            Console.WriteLine("Four");
            break;
            case 5:
            Console.WriteLine("Five");
            break;
            case 6:
            Console.WriteLine("Six");
            break;
            case 7:
            Console.WriteLine("Seven");
            break;
            case 8:
            Console.WriteLine("Eight");
            break;
            case 9:
            Console.WriteLine("Nine");
            break;
            default:
            Console.WriteLine("Invalid input!");
            break;

          }


           
           
           
          

        
    

