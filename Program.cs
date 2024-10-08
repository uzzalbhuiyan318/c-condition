using System;

class Test{
    static void Main(string[] args){

        // inside the main function input taking and show output
        int number;
        Console.WriteLine("Enter your desire number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if(number % 2 == 0){
            Console.WriteLine("Given Number is even");
        }
        else{
            Console.WriteLine("Given Number is Odd");
        }

    // MaxTwoNumber class object declaration and input taking from users
        int num1, num2;
        Console.WriteLine("Enter your first number for max function: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter your second number for max function: ");
        num2 = int.Parse(Console.ReadLine());

        MaxTwoNumber obj = new MaxTwoNumber();
        obj.display(num1,num2);

        // maximum of three number 
        // object creation taking input from users and call the function
        int Tnum1, Tnum2, Tnum3;

         Console.WriteLine("Enter your first number for max 3 function: ");
         Tnum1 = int.Parse(Console.ReadLine());
         
         Console.WriteLine("Enter your second number for max 3 function: ");
         Tnum2 = int.Parse(Console.ReadLine());

         Console.WriteLine("Enter your thrid number for max 3 function: ");
         Tnum3 = int.Parse(Console.ReadLine());

         MaxThree maxThree = new MaxThree();
         maxThree.Max_three(Tnum1,Tnum2,Tnum3);


         // declaring object for Positive_Negative class 
         // taking input from user for PosOrNeg() function

        int PnNumber;
         Console.WriteLine("Enter your second number for PosOrNeg function: ");
         PnNumber = int.Parse(Console.ReadLine());
         PositiveOrNegative Pos_or_Neg = new PositiveOrNegative();

         Pos_or_Neg.PosOrNeg(PnNumber);

         //declaring object for GradePoint class
         // taking input from user for GradeFunction
         int marks;

         Console.WriteLine("Enter your marks for Grade function: ");
         marks = int.Parse(Console.ReadLine());

         GradePoint gradePoint = new GradePoint();

         gradePoint.Grade(marks);


    }
}