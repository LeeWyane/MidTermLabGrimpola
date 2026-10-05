using System;

public struct Student{
	public string StudentNumber;
	public string Name;
	public string program;
	public int YearLevel;
}
	
class Program{
	static void Main(){
		Student[] student = new Student[10];
		int count = 0;
		int choose;
		
		do{
			Console.WriteLine("=== STUDENT MANAGEMENT SYSTEM ===");
            Console.WriteLine("[1] Add Student");
            Console.WriteLine("[2] Display All Students");
            Console.WriteLine("[3] Search Student");
            Console.WriteLine("[4] Edit Student");
            Console.WriteLine("[5] Delete Student");
            Console.WriteLine("[6] Exit\n");
            Console.Write("Enter your choice: ");
			choose = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine(" ");
			
			switch(choose){
				case 1:
					if(count >= 10){
						Console.WriteLine("the database is full!!\n");
					}else{
					Console.WriteLine("Adding a Student");
					Console.Write("student number: ");
					string num = Console.ReadLine();
					Console.Write("Name: ");
					string name = Console.ReadLine();
					Console.Write("Program: ");
					string program = Console.ReadLine();
					Console.Write("Year Level: ");
					int year = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine(" ");
					Console.WriteLine("addded successfully!!\n");
					
					student[count].StudentNumber = num;
					student[count].Name = name;
					student[count].program = program;
					student[count].YearLevel = year;
					count++;
					}
					break;
				case 2:
					Console.WriteLine($"Student Record");
					for (int i = 0; i < count; i++){
						
						Console.WriteLine(" ");
						Console.WriteLine($"Student Number:{student[i].StudentNumber} ");
						Console.WriteLine($"Name: {student[i].Name} ");
						Console.WriteLine($"Program: {student[i].program} ");
						Console.WriteLine($"YearLevel: {student[i].YearLevel} ");
						Console.WriteLine(" ");
						Console.WriteLine("============\n");
						}
						if(count == 0){
						Console.WriteLine("empty!\n");
						}
					break;
				case 3:
					Console.Write("enter the student number to search: ");
					string search = Console.ReadLine();
					bool found = false;
					for (int i = 0; i < count; i++){
						if(search == student[i].StudentNumber){
							Console.WriteLine(" ");
							Console.WriteLine($"Student Number:{student[i].StudentNumber} ");
							Console.WriteLine($"Name: {student[i].Name} ");
							Console.WriteLine($"Program: {student[i].program} ");
							Console.WriteLine($"YearLevel{student[i].YearLevel} ");
							Console.WriteLine(" ");
							Console.WriteLine(" ");
							found = true;
								}
							}
							if(!found){
								Console.WriteLine("student is not in the data");
								}
						break;
				case 4:
					Console.Write("enter the student number to edit: ");
					string edit = Console.ReadLine();
					for (int i = 0; i < count; i++){
						if(edit == student[i].StudentNumber){
							Console.WriteLine("student found! ");
							Console.WriteLine($"{student[i].StudentNumber} ");
							Console.WriteLine($"{student[i].Name} ");
							Console.WriteLine($"{student[i].program} ");
							Console.WriteLine($"{student[i].YearLevel} ");
							Console.WriteLine(" ");
							Console.WriteLine("editing....\n");
							Console.Write("enter new student number: ");
							student[i].StudentNumber = Console.ReadLine();
							Console.Write("enter new Name: ");
							student[i].Name = Console.ReadLine();
							Console.Write("enter new Program: ");
							student[i].program = Console.ReadLine();
							Console.Write("enter new YearLevel: ");
							student[i].YearLevel = Convert.ToInt32(Console.ReadLine());
							Console.WriteLine("Edit sucessfully\n");
								}
							}
						break;
					case 5:
						Console.Write("enter the student number to delete: ");
						string delete = Console.ReadLine();
						for (int i = 0; i < count; i++){
							if(delete == student[i].StudentNumber){
								Array.Copy(student, i + 1, student, i, count - i - 1);
								count--;
								Console.WriteLine("Student record deleted successfully!\n");
								break; 
									}
							else{
								Console.WriteLine("no one to delete, not found\n");
								}
							}
							break;
						}
				}while(choose != 6);
			}
}


