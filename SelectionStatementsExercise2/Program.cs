namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            SchoolSubect();
        }

        public static void SchoolSubect()
        {
            Console.WriteLine("What is your favorite subject in school?");
            string subject = Console.ReadLine();

            switch (subject.ToUpper())
            {
                case "ENGLISH":
                    Console.WriteLine("I used to love English!");
                    break;
                case "MATH":
                    Console.WriteLine("Math was always hard for me.");
                    break;
                case "HISTORY":
                    Console.WriteLine("History was very interesting!");
                    break;
                case "SCIENCE":
                    Console.WriteLine("Science was always fun!");
                    break;
                case "HEALTH":
                    Console.WriteLine("Health was my favorite too!");
                    break;
                default:
                    Console.WriteLine("Good choice!");
                    break;
            }
        }
    }
}