using System;

namespace TeacherRatingApp
{
    class TeacherRatingApp
    {
        static void Main(string[] args)
        {
            
            DisplayInstructions();

            string teacherID = GetInfo("Teacher Number");
            string firstName = GetInfo("Teacher\'s First Name");
            string lastName = GetInfo("Teacher\'s Last Name");
            Console.WriteLine();
            int score1 = int.Parse(GetInfo("Easiness Rating"));
            int score2 = int.Parse(GetInfo("Helpfulness Rating"));
            int score3 = int.Parse(GetInfo("Clarity Rating"));
            TeacherRating firstStudent = new TeacherRating(teacherID,
                          firstName, lastName);

            firstStudent.EasinessRating = score1;
            firstStudent.HelpfulnessRating = score2;
            firstStudent.ClarityRating = score3;
            
            DisplayResults(firstStudent);
        }

        static void DisplayInstructions()
        {
            Console.WriteLine("You will be asked to enter a teacher ID number and three ratings.");
            Console.WriteLine("The ratings relate to easiness, helpfulness, and clarity - in that order.");
            Console.WriteLine("The information, including average rating will be displayed.");
            Console.WriteLine("\n Ratings are based on a 1-5 scale with 1 being the lowest and 5 being the highest");
            Console.WriteLine("\n\n Press any key when you are ready to begin...");
            Console.ReadKey();
        }

        static string GetInfo(string info) 
        {
            string inputValue;

            Console.Write("Please enter the {0}: ", info);
            inputValue = Console.ReadLine();
            return inputValue;
        }

        static void DisplayResults(TeacherRating tr)
        {
            Console.WriteLine(tr);
        }
        

    }
}
