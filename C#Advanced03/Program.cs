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


            #region Exercise02

            //// Exercise 2: Leaderboard
            ///
            /// Create a leaderboard that automatically sorts players by score.


            /// 01) Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona".
            ///
            /// SortedDictionary<int, string> leaderboard = new();
            ///
            /// leaderboard.Add(500, "Ahmed");
            /// leaderboard.Add(200, "Sara");
            /// leaderboard.Add(800, "Ali");
            /// leaderboard.Add(350, "Mona");


            /// 02) Print all entries.
            ///     They should be sorted by score automatically.
            ///
            /// Console.WriteLine("Leaderboard:");
            ///
            /// foreach (KeyValuePair<int, string> player in leaderboard)
            /// {
            ///     Console.WriteLine( player.Key + " = " + player.Value); 
            /// }


            /// 03) Access the first key and first value.
            ///
            /// Console.WriteLine("First Key: " + leaderboard.First().Key);
            /// Console.WriteLine("First Value: " + leaderboard.First().Value);


            /// 04) Check if score 500 exists.
            ///
            /// bool score500Exists = leaderboard.ContainsKey(500);
            ///
            /// Console.WriteLine( "Score 500 Exists: " + score500Exists);


            /// 05) Safely get the player with score 999.
            ///
            /// if (leaderboard.TryGetValue(999, out string player999))
            /// {
            ///     Console.WriteLine("Player: " + player999);
            /// }
            /// else
            /// {
            ///     Console.WriteLine("Score 999 not found.");
            /// }


            /// 06) Remove the player with score 200 and print the updated list.
            ///
            /// leaderboard.Remove(200);
            ///
            /// Console.WriteLine("Updated Leaderboard:");
            ///
            /// foreach (KeyValuePair<int, string> player in leaderboard)
            /// {
            ///     Console.WriteLine( player.Key + " = " + player.Value);
            /// }

            #endregion






















































        }
    }
}
