class GradePoint{
    public void Grade(int marks){
        if(marks >=0 && marks <=100){
            if (marks >= 80)
        {
            Console.WriteLine("Grade: A+");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade: A");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: A-");
        }
        else if (marks >= 50)
        {
            Console.WriteLine("Grade: B");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
        }
        else{
            Console.WriteLine("Enter a valid marks between 0 to 100");
        }
    }
}