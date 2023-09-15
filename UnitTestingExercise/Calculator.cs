﻿ using System;
namespace UnitTestingExercise
{
    public class Calculator
    {
        // DONE - Step 1: Add a reference to your UnitTestingExercise project:

        // Right-click on the 'Dependencies' folder in your UnitTestingExercise.Tests project
        // and add your reference to the UnitTestingExercise project



        //  DONE - Step 2: Create an Add method that accepts 3 integers, adds those integers, and returns an integer
         
        public int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }


        // DONE - Step 3: Navigate to the UnitTests.cs file and complete the AddTest unit test method 


        // DONE - Step 4: 
        // Create a Subtract method that accepts 2 integers
        // Keep track of which number is getting passed as minuend and subtrahend

        public int Subtract(int minuend, int subtrend)
        {
            return minuend - subtrend;
        }


        // DONE - Step 5: Navigate to the UnitTests.cs file and complete the SubtractTest unit test method


        // Step 6: 
        // Create a Multiply method that passes 2 integers
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        //DONE -  Step 7: Navigate to the UnitTests.cs file and complete the MultiplyTest unit test method 


        // Step 8: 
        // Create a Divide method that passes 2 integers
        public int Divide(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        // DONE -  Step 9: Navigate to the UnitTests.cs file and complete the DivideTest unit test method 


        //*****NOW RUN ALL OF YOUR TESTS*********//
    }
}
