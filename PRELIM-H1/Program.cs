List<string> names = new List<string>();
List<int[]> grades = new List<int[]>();

while (true)
{
    Console.WriteLine("===== STUDENT SYSTEM =====");
    Console.WriteLine("1. Add Student");
    Console.WriteLine("2. View Students");
    Console.WriteLine("3. Compute Average Grade");
    Console.WriteLine("4. Find Highest Grade");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");
    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine();
        Console.WriteLine("Enter student name:");
        string name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter grade 1:");
        int g1 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine();
        Console.WriteLine("Enter grade 2:");
        int g2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Enter grade 3:");
        int g3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Student added successfully!");
        Console.WriteLine();

        names.Add(name);
        grades.Add(new int[] { g1, g2, g3 });

    }

    else if (input == "2")
    {
        for (int i = 0; i < names.Count; i++)
        {
            double average = grades[i].Average();

            Console.WriteLine();
            Console.WriteLine("Name: " + names[i]);
            Console.WriteLine("Grades: " + grades[i][0] + ", " + grades[i][1] + ", " + grades[i][2]);
            Console.WriteLine("Average: " + average.ToString("F2"));
            Console.WriteLine();
        }
    }

    else if (input == "3")
    {
        double total = 0;
        int count = 0;

        for (int i = 0; i < grades.Count; i++)
        {
            total += grades[i][0] + grades[i][1] + grades[i][2];
            count += 3;
        }

        Console.WriteLine();
        Console.WriteLine("===== CLASS AVERAGE =====");
        Console.WriteLine("Overall Average Grade: " + (total / count).ToString("F2"));
        Console.WriteLine();
    }

    else if (input == "4")
    {
        int highestGrade = grades[0][0];
        string topStudent = names[0];

        for (int i = 0; i < names.Count; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (grades[i][j] > highestGrade)
                {
                    topStudent = names[i];
                    highestGrade = grades[i][j];
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("===== HIGHEST GRADE =====");
        Console.WriteLine("Top Student: " + topStudent);
        Console.WriteLine("Highest Grade: " + highestGrade);
        Console.WriteLine();
    }

    else if (input == "5")
    {
        Console.WriteLine("Exiting program...");
        Console.WriteLine("Goodbye!");
        break;
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("[ Invalid ]");
        Console.WriteLine();
    }
}