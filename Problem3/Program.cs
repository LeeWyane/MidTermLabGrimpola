using System;
struct StudentRequest{
	public string StudentNumber;
	public string StudentName;
	public string RequestType;
	}
class Program{
	static void Main(){
		Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();
		int choice;
		do{
			Console.WriteLine();
			Console.WriteLine("=== STUDENT REQUEST QUEUE ===");
			Console.WriteLine("1. Add a Request");
			Console.WriteLine("2. View Pending Request");
			Console.WriteLine("3. Process Request");
			Console.WriteLine("4. Exit");
			
			Console.Write("Enter choice: ");
			choice = Convert.ToInt32(Console.ReadLine());
			switch(choice){
				case 1:
					StudentRequest newrequest;
					
					Console.Write("Enter Student Number: ");
					newrequest.StudentNumber = Console.ReadLine();
					Console.Write("Enter Student Name: ");
					newrequest.StudentName = Console.ReadLine();
					Console.Write("Enter Request Type: ");
					newrequest.RequestType = Console.ReadLine();
					
					requestQueue.Enqueue(newrequest);
					break;
				case 2:
					int position = 1;
					Console.WriteLine();
					if(requestQueue.Count > 0){
						foreach(StudentRequest student in requestQueue){
							
							Console.WriteLine($"{position}. {requestQueue.Peek().StudentName} - {requestQueue.Peek().RequestType}");
							position++;
						}
						
					}
					else{
							Console.WriteLine("--- NO PENDING REQUEST ---");
							}
					break;
				case 3:
					if(requestQueue.Count > 0){
					Console.WriteLine($"Processing Request: {requestQueue.Peek().StudentName} - {requestQueue.Peek().RequestType}");
					string s =requestQueue.Dequeue().StudentName;
					}
					else{
						Console.WriteLine("--- NOTHING TO PROCESS ---");
						}
					break;
				}
			}while(choice != 4);
		}
	}

