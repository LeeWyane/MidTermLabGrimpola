using System;

public struct Student{
	public string studentNumber;
	public string name;
	public string program;
	public int yearLevel;
	}

class program{
	static void Main(){
		Dictionary<string, Student> dict = new Dictionary<string, Student>();
		int choose;
		string num;
		
		do{
			Console.WriteLine("--");
			Console.WriteLine("==== STUDENT LOOKUP USING DICTIONARY ====");
			Console.WriteLine();
			Console.WriteLine("1. Add Student");
			Console.WriteLine("2. Search Student");
			Console.WriteLine("3. Display All Student");
			Console.WriteLine("4. Exit");
			Console.WriteLine();
			Console.Write("Enter Choice: ");
			choose = Convert.ToInt32(Console.ReadLine());
			
			switch(choose){
				case 1:
					
					Student student = new Student();
					Console.WriteLine();
					Console.Write("Enter Student Number: ");
					num = Console.ReadLine();
					
					if(dict.ContainsKey(num)){
						Console.WriteLine();
						Console.WriteLine("there is already an existing student!\n");
					}
					else{
						Console.Write("Enter Student Name: ");
						student.name = Console.ReadLine();
						Console.Write("Enter Program: ");
						student.program = Console.ReadLine();
						Console.Write("Enter Year Level: ");
						student.yearLevel = Convert.ToInt32(Console.ReadLine());
						
						student.studentNumber = num;
						dict.Add(num, student);
					}
					break;
				case 2:
					Console.WriteLine();
					Console.Write("Enter Student Number to Search: ");
					string search = Console.ReadLine();
					if(dict.ContainsKey(search)){
						Student stud = dict[search];
						Console.WriteLine("Student Found!");
						Console.WriteLine();
						Console.WriteLine($"student number: {stud.studentNumber}");
						Console.WriteLine($"student Name: {stud.name}");
						Console.WriteLine($"student progran: {stud.program}");
						Console.WriteLine($"student yearlevel: {stud.yearLevel}");
						}
						else{
							Console.WriteLine("This Student does not exist in the database!!");
							}
					break;
				case 3:
					foreach (var kvp in dict){
						Console.WriteLine();
						Console.WriteLine("All students records\n");
						Console.WriteLine($"Student Number: {kvp.Key}");
						Console.WriteLine($"Student Name {kvp.Value.name}");
						Console.WriteLine($"Student program {kvp.Value.program}");
						Console.WriteLine($"Student yearLevel {kvp.Value.yearLevel}");
						}
					break;
				}
		}while(choose != 4);
	}
}

