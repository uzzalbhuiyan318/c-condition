class MaxTwoNumber{
    public void display(int number1, int number2){
        if(number1 > number2){
            Console.WriteLine($"{number1} is bigger.");
        }
        else if(number1 < number2){
            Console.WriteLine($"{number2} is bigger.");
        }
        else{
            Console.WriteLine($"{number1} and {number2} is equal.");
        }
    }
}