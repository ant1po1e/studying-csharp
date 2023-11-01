using System;

public class App
{
   public static void Main(string[] args)
   {
      int examAssignments = 5;

      string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

      int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
      int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
      int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
      int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

      int[] studentScores = new int[10];

      string currentStudentLetterGrade = "";

      Console.Clear();
      Console.WriteLine("Student\t\tExam Score\t\tOverall\t\tGrade\t\tExtra Credit");
      Console.WriteLine("=======\t\t==========\t\t=======\t\t=====\t\t============");

      foreach (string name in studentNames)
      {
         string currentStudent = name;

         if (currentStudent == "Sophia")
            studentScores = sophiaScores;

         else if (currentStudent == "Andrew")
            studentScores = andrewScores;

         else if (currentStudent == "Emma")
            studentScores = emmaScores;

         else if (currentStudent == "Logan")
            studentScores = loganScores;

         int sumAssignmentScores = 0;

         decimal currentStudentGrade = 0;

         int gradedAssignments = 0;

         foreach (int score in studentScores)
         {
            gradedAssignments += 1;

            if (gradedAssignments <= examAssignments)
               sumAssignmentScores += score;

            else
               sumAssignmentScores += score / 10;
         }

         currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

         if (currentStudentGrade >= 97)
            currentStudentLetterGrade = "A+";

         else if (currentStudentGrade >= 93)
            currentStudentLetterGrade = "A";

         else if (currentStudentGrade >= 90)
            currentStudentLetterGrade = "A-";

         else if (currentStudentGrade >= 87)
            currentStudentLetterGrade = "B+";

         else if (currentStudentGrade >= 83)
            currentStudentLetterGrade = "B";

         else if (currentStudentGrade >= 80)
            currentStudentLetterGrade = "B-";

         else if (currentStudentGrade >= 77)
            currentStudentLetterGrade = "C+";

         else if (currentStudentGrade >= 73)
            currentStudentLetterGrade = "C";

         else if (currentStudentGrade >= 70)
            currentStudentLetterGrade = "C-";

         else if (currentStudentGrade >= 67)
            currentStudentLetterGrade = "D+";

         else if (currentStudentGrade >= 63)
            currentStudentLetterGrade = "D";

         else if (currentStudentGrade >= 60)
            currentStudentLetterGrade = "D-";

         else
            currentStudentLetterGrade = "F";

         // Student         Grade
         // Sophia:         92.2    A-

         Console.WriteLine($"{currentStudent}\t\t0\t\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}\t\t0 (0 pts)");
      }

      // required for running in VS Code (keeps the Output windows open to view results)
      Console.WriteLine("\n\rPress the Enter key to continue");
      Console.ReadLine();
   }
}