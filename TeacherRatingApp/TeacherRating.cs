using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherRatingApp
{
    class TeacherRating
    {
        string teacherNo;
        string firstName;
        string lastName;

        //ratings
        int easinessRating;
        int helpfulnessRating;
        int clarityRating;
        double ratingAverage;

        //default constructor
        public TeacherRating()
        {
        }

        public TeacherRating(string tNumber, string fName, string lName) 
        {
            teacherNo = tNumber;
            firstName = fName;
            lastName = lName;
        }

        // get and set properties for easinessRating
        public int EasinessRating
        {
            get
            {
                return easinessRating;
            }

            set
            {
                easinessRating = value;
            }
        }

        // get and set properties for helpfulnessRating
        public int HelpfulnessRating
        {
            get
            {
                return helpfulnessRating;
            }

            set
            {
                helpfulnessRating = value;
            }
        }

        // get and set properties for clarityRating
       public int ClarityRating 
        {
            get
            {
                return clarityRating;
            }

            set
            {
                clarityRating = value;
            }
        }

        public double RatingAverage(int eRating, int hRating, int cRating)
        {
            eRating = easinessRating;
            hRating = helpfulnessRating;
            cRating = clarityRating;
            return (easinessRating + helpfulnessRating + clarityRating) / 3.0;
            
        }

        public override string ToString()
        {
            return "\nTeacher Number: " + teacherNo 
                + "\nTeacher Name: " + firstName + " " + lastName 
                + "\nEasiness: " + easinessRating
                + "\nHelpfulness: " + helpfulnessRating
                + "\nClarity: " + clarityRating
                + "\nAverage Rating: " + RatingAverage(EasinessRating, HelpfulnessRating, ClarityRating);
        }
    }
}
