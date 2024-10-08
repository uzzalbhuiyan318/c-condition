class PositiveOrNegative{
    public void PosOrNeg(int pnNum){
        if(pnNum > 0){
            Console.WriteLine($"{pnNum} is a positive number");
        }
        else if(pnNum == 0){
            Console.WriteLine($"{pnNum} is zero");

        }
        else{
            Console.WriteLine($"{pnNum} is a negative number");

        }
    }
}