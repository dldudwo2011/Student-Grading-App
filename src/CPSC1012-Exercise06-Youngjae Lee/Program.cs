/*
    Purpose: Write a program that reads student marks, determines the highest mark, and 
             then assigns grades.



    Input: studentCount (int), student name (string), and student mark (int).




    Process: Write 4 methods called EnterNamesAndMarks, HighestMark, DisplayGrades, and AssignGrade.

             In the EnterNamesAndMarks method, declare a for loop that starts from 0th index of the array
             to the length of the array(studentCount). Each for loop will ask the user to enter the 
             name of the student and the mark of the student. First ask the name of the student and
             store the user-input directly to the names array. Then ask the mark of the student and 
             store the user-input directly to the marks array.


             In the HighestMark method, declare two int variables named indexOfHighestMark and 
             HighestMark to store the index of the highest mark and the value of the highest mark.
             Then declare for loop to compare rest of the values in the array to the value of the
             current index(0). If the value in the array is higher than the current one, it will
             replace the indexOfHighestMark and HighestMark variables. Then the method will return
             the value of the highestMark variable.


             In the DisplayGrades method,  declare a for loop that starts from 0th index of the array
             to the length of the array(studentCount). Each for loop will determine the student grade
             of the current index using Assign grade method. Then, it will display the student name 
             and grade.

           
             In the AssignGrade method, declare a char variable named "grade" that will store the 
             grade letter. Then, use the if statements to give the variable a letter. The condition
             of the if statements will be mark >= (highestMark - (10~40)). If it doesn't fall to any
             of its category, an else statement will be used to give the variable letter 'F'. Then,
             the method will return the letter stored in the "grade" variable.


             In the main method, ask the user for the student count and store it in an int variable
             named studentCount. Then, declare required arrays based on the student count. Then, call
             the EnterNameAndMarks method to update the arrays. Then, determine the highest mark by 
             calling the HighestMark method. Store its return value in an int variable named "highestMark"
             to be used by the next method to be called, the DisplayGrades method.

 




    Output: 1.Enter the number of students to grade:

            2.Enter the name for student #1:

            3.Enter the mark for student #1: 

            4.{student name} mark is {student mark} and grade is {grade letter}



    Author: Youngjae Lee



    Last modified date: 2021 Mar 18
*/

using System;

namespace CPSC1012_Exercise06_Youngjae_Lee
{
    class Program
    {   
        //EnterNamesAndMarks method
        static void EnterNamesAndMarks(string[] names, int[] grades, int studentCount)
        {
            //for loop declaration
            for(int index = 0; index < studentCount; index++)
            {
                //ask the user to enter the name of the student
                Console.Write($"Enter the name for student #{index + 1}:");

                //add the user input(student name) to the names array
                names[index] = Console.ReadLine();

                //ask the user to enter the mark of the student
                Console.Write($"Enter the mark for student #{index + 1}:");

                //add the user input(student mark) to the grades array
                grades[index] = int.Parse(Console.ReadLine());
            }

        }
        //HighestMark method
        static int HighestMark(int[] marks, int studentCount)
        {
            //storing the index of highest mark
            int indexOfHighestMark = 0;

            //storing the value of the highest mark
            int HighestMark = marks[0];

            //for loop declaration
            for(int index =1; index < studentCount; index++)
            {
                //if the mark of the index is higher than the current mark
                if(marks[index] > HighestMark)
                {
                    //highest mark becomes the value of the index
                    HighestMark = marks[index];

                    //storing the index number
                    indexOfHighestMark = index;
                }
            }

            //returning the value of the highest mark
            return HighestMark;
        }

        //DisplayGrades method
        static void DisplayGrades(string[] names, int[] marks, int studentCount, int highestMark)
        {
            //for loop declaration
            for(int index = 0; index < studentCount; index++)
            {
                //determining and storing the student grade
                char grade = AssignGrade(highestMark, marks[index]);

                //displaying the student name and grade
                Console.WriteLine($"{names[index]} mark is {marks[index]} and grade is {grade}");
            }
        }

        //AssignGrade method
        static char AssignGrade(int highestMark, int mark)
        {   
            //storing the grade letter
            char grade;

            //grade A
            if(mark >= (highestMark - 10))
            {
                grade = 'A';
            }

            //grade B
            else if (mark >= (highestMark - 20))
            {
                grade = 'B';
            }

            //grade C
            else if (mark >= (highestMark - 30))
            {
                grade = 'C';
            }

            //grade D
            else if (mark >= (highestMark - 40))
            {
                grade = 'D';
            }

            //grade F
            else
            {
                grade = 'F';
            }

            //returning the grade letter
            return grade;
        }

        //assigngrade inside displaygrade.
        static void Main(string[] args)
        {
            //ask the user for the student count and store it
            Console.Write("Enter the number of students to grade:");
            int studentCount = int.Parse(Console.ReadLine());

            //creating arrays based on the student count
            string[] names = new string[studentCount];
            int[] marks = new int[studentCount];

            //calling the EnterNameAndMarks method
            EnterNamesAndMarks(names, marks, studentCount);

            //determining the highest mark
            int highestMark = HighestMark(marks, studentCount);

            //calling the DisplayGrades method
            DisplayGrades(names, marks, studentCount, highestMark);
        }
    }
}
