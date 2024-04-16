namespace Grading_Students
{
    internal class Program
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] < 38)
                {
                    grades[i] = grades[i];
                }
                else if (grades[i] >= 38 && grades[i] < 40)
                {
                    grades[i] = 40;
                }
                else if (grades[i] > 40)
                {
                    if (((grades[i] + 2) % 5 == 0))
                    {
                        grades[i] = (grades[i] + 2);
                    }
                    else if ((grades[i] + 1) % 5 == 0)
                    {
                        grades[i] = (grades[i] + 1);
                    }
                }
            }
            foreach (int i in grades)
            {
                Console.WriteLine(i);
            }
            return grades;

        }
        static void Main(string[] args)
        {

        }
    }
}
