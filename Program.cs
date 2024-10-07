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
    }
}