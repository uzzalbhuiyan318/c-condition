using System;

class Test{
    static void Main(string[] args){
        int number;
        Console.WriteLine("Enter your desire number: ");
        number = Convert.ToInt32(Console.ReadLine());

        if(number % 2 == 0){
            Console.WriteLine("Given Number is even");
        }
        else{
            Console.WriteLine("Given Number is Odd");
        }

        int num1, num2;
        Console.WriteLine("Enter your first number for max function: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter your second number for max function: ");
        num2 = int.Parse(Console.ReadLine());

        MaxTwoNumber obj = new MaxTwoNumber();
        obj.display(num1,num2);
    }
}