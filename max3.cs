class MaxThree{
    public void Max_three(int num1, int num2, int num3){
        if(num1 > num2 && num1 > num3){
            Console.WriteLine($"{num1} is the maximum of three number");
        }

        else if(num2>num3){
            Console.WriteLine($"{num2} is the maximum of three number");
        }
        
        else{
            Console.WriteLine($"{num3} is the maximum of three number");
        }

        
    }
}