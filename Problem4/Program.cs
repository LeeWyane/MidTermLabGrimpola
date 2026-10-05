using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}

struct Student
{
    public string StudentNumber;
    public string Name;
    public string program;
    public int YearLevel;
}

class Program
{
    static void Main()
    {
        Student[] student = new Student[10];

        int count = 0;

        Stack<Operation> operationHistory = new Stack<Operation>();

        int Choice;

        do
        {
            Console.WriteLine();
            Console.WriteLine("================================");
            Console.WriteLine("       STUDENT RECORD SYSTEM");
            Console.WriteLine("================================");

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. View Operation History");
            Console.WriteLine("7. View Last Operation");
            Console.WriteLine("8. Remove Last Operation");
            Console.WriteLine("9. Exit");

            Console.Write("Enter choice: ");
            Choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            switch (Choice)
            {
                case 1:

                    if (count >= 10)
                    {
                        Console.WriteLine("The database is full!");
                    }
                    else
                    {
                        Student newStudent = new Student();

                        Console.Write("Enter Student Number: ");
                        newStudent.StudentNumber = Console.ReadLine();

                        Console.Write("Enter Name: ");
                        newStudent.Name = Console.ReadLine();

                        Console.Write("Enter Program: ");
                        newStudent.program = Console.ReadLine();

                        Console.Write("Enter Year Level: ");
                        newStudent.YearLevel = Convert.ToInt32(Console.ReadLine());

                        student[count] = newStudent;

                        count++;

                        Operation operation = new Operation();

                        operation.Action = "Added";
                        operation.StudentNumber = newStudent.StudentNumber;
                        operation.StudentName = newStudent.Name;

                        operationHistory.Push(operation);

                        Console.WriteLine();
                        Console.WriteLine("Student added successfully!");
                    }

                    break;

                case 2:

                    Console.WriteLine("================================");
                    Console.WriteLine("       STUDENT RECORDS");
                    Console.WriteLine("================================");

                    if (count == 0)
                    {
                        Console.WriteLine("No student records.");
                    }
                    else
                    {
                        for (int i = 0; i < count; i++)
                        {
                            Console.WriteLine();

                            Console.WriteLine($"Student Number: {student[i].StudentNumber}");
                            Console.WriteLine($"Name: {student[i].Name}");
                            Console.WriteLine($"Program: {student[i].program}");
                            Console.WriteLine($"Year Level: {student[i].YearLevel}");

                            Console.WriteLine();
                        }
                    }

                    break;

                case 3:

                    Console.Write("Enter Student Number to Search: ");
                    string search = Console.ReadLine();

                    bool found = false;

                    for (int i = 0; i < count; i++)
                    {
                        if (student[i].StudentNumber == search)
                        {
                            Console.WriteLine();

                            Console.WriteLine("Student Found!");
                            Console.WriteLine($"Student Number: {student[i].StudentNumber}");
                            Console.WriteLine($"Name: {student[i].Name}");
                            Console.WriteLine($"Program: {student[i].program}");
                            Console.WriteLine($"Year Level: {student[i].YearLevel}");

                            found = true;

                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Student not found.");
                    }

                    break;

                case 4:

                    Console.Write("Enter Student Number to Update: ");
                    string update = Console.ReadLine();

                    bool updated = false;

                    for (int i = 0; i < count; i++)
                    {
                        if (student[i].StudentNumber == update)
                        {
                            Console.WriteLine("Student Found!");

                            Console.Write("Enter new Student Number: ");
                            student[i].StudentNumber = Console.ReadLine();

                            Console.Write("Enter new Name: ");
                            student[i].Name = Console.ReadLine();

                            Console.Write("Enter new Program: ");
                            student[i].program = Console.ReadLine();

                            Console.Write("Enter new Year Level: ");
                            student[i].YearLevel = Convert.ToInt32(Console.ReadLine());

                            Operation operation = new Operation();

                            operation.Action = "Updated";
                            operation.StudentNumber = student[i].StudentNumber;
                            operation.StudentName = student[i].Name;

                            operationHistory.Push(operation);

                            Console.WriteLine("Student updated successfully!");

                            updated = true;

                            break;
                        }
                    }

                    if (!updated)
                    {
                        Console.WriteLine("Student not found.");
                    }

                    break;

                case 5:

                    Console.Write("Enter Student Number to Delete: ");
                    string delete = Console.ReadLine();

                    bool deleted = false;

                    for (int i = 0; i < count; i++)
                    {
                        if (student[i].StudentNumber == delete)
                        {
                            Operation operation = new Operation();

                            operation.Action = "Deleted";
                            operation.StudentNumber = student[i].StudentNumber;
                            operation.StudentName = student[i].Name;

                            operationHistory.Push(operation);

                            Array.Copy(student, i + 1, student, i, count - i - 1);

                            count--;

                            Console.WriteLine("Student record deleted successfully!");

                            deleted = true;

                            break;
                        }
                    }

                    if (!deleted)
                    {
                        Console.WriteLine("Student not found.");
                    }

                    break;

                case 6:

                    Console.WriteLine("================================");
                    Console.WriteLine("        OPERATION HISTORY");
                    Console.WriteLine("================================");

                    if (operationHistory.Count == 0)
                    {
                        Console.WriteLine("No operations recorded.");
                    }
                    else
                    {
                        int num = 1;

                        foreach (Operation stud in operationHistory)
                        {
                            Console.WriteLine(
                                $"{num}. {stud.Action} {stud.StudentName}"
                            );

                            num++;
                        }
                    }

                    break;

                case 7:

                    if (operationHistory.Count > 0)
                    {
                        Operation peek = operationHistory.Peek();

                        Console.WriteLine(
                            $"Last Operation: {peek.Action} {peek.StudentName}"
                        );
                    }
                    else
                    {
                        Console.WriteLine("No operations recorded.");
                    }

                    break;

                case 8:

                    if (operationHistory.Count > 0)
                    {
                        Operation pop = operationHistory.Pop();

                        Console.WriteLine(
                            $"Last operation removed successfully: {pop.Action} {pop.StudentName}"
                        );
                    }
                    else
                    {
                        Console.WriteLine("No operations to remove.");
                    }

                    break;
            }

        } while (Choice != 9);
    }
}