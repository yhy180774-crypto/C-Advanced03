namespace C_Advanced03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Exercise01

            //// Exercise 1: Student Grade Manager
            ///
            /// Create a program that manages student grades using One Of Collections.


            /// 01) Create a Collection with these grades: 85, 92, 78, 95, 88, 70, 100, 65.
            ///
            /// List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65]; 
           

            /// 02) Print the collection, Count, first and last grade.
            ///
            /// Console.WriteLine("Grades:");
            /// foreach (int grade in grades)
            /// {
            ///     Console.WriteLine(grade);
            /// }
            ///
            /// Console.WriteLine("Count: " + grades.Count);
            /// Console.WriteLine("First Grade: " + grades[0]);
            /// Console.WriteLine("Last Grade: " + grades[grades.Count - 1]);
           

            /// 03) Sort the grades ascending, then print.
            ///
            /// grades.Sort();
            ///
            /// Console.WriteLine("Sorted Grades:");
            /// foreach (int grade in grades)
            /// {
            ///     Console.WriteLine(grade);
            /// }
            

            /// 04) Get the first grade above 90.
            ///
            /// int firstAbove90 = grades.Find(grade => grade > 90);
            ///
            /// Console.WriteLine("First Grade Above 90: " + firstAbove90);
         

            /// 05) Get all grades below 75 (failing grades).
            ///
            /// List<int> failingGrades =
            ///     grades.FindAll(grade => grade < 75);
            ///
            /// Console.WriteLine("Failing Grades:");
            /// foreach (int grade in failingGrades)
            /// {
            ///     Console.WriteLine(grade);
            /// }
        

            /// 06) Remove all failing grades (below 75).
            ///
            /// grades.RemoveAll(grade => grade < 75);
            ///
            /// Console.WriteLine("Grades After Removing Failing Grades:");
            /// foreach (int grade in grades)
            /// {
            ///     Console.WriteLine(grade);
            /// }
         

            /// 07) Check if any grade equals 100.
            ///
            /// bool has100 = grades.Contains(100);
            ///
            /// Console.WriteLine("Contains 100: " + has100);
           

            /// 08) Create a List<string> where each grade becomes "Grade: X".
            ///
            /// List<string> gradeStrings =
            ///     grades.ConvertAll(grade => "Grade: " + grade);
            ///
            /// Console.WriteLine("Grade Strings:");
            /// foreach (string grade in gradeStrings)
            /// {
            ///     Console.WriteLine(grade);
            /// }

            #endregion

























































        }
    }
}
