namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //TO DO:
            //change to inferred typing
            //use string interpolation
            //use ternary operator

            //answer below(changed)
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than nine";
            
            //original code
            //if (answer < 9)
            //{
                //response = answer + "is less than nine";
            //}
            //else
            //{
                //response = answer + "greater than or equal to nine";
            //}
            Console.WriteLine(response);
        }
    }
}
