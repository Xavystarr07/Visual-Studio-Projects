using System;
using System.Collections.Generic;

// Define the Employee class
class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Department { get; set; }
}
class Program
{
	// Define the delegate
	delegate void EmployeeActionDelegate(Employee employee);

	// Collection to store employee records
	static List<Employee> employees = new List<Employee>();

	static void Main(string[] args)
	{
		while (true)
		{
			// Display menu to the user
			Console.WriteLine("Employee Management System");
			Console.WriteLine("1. Add Employee");
			Console.WriteLine("2. Update Employee");
			Console.WriteLine("3. Delete Employee");
			Console.WriteLine("4. Exit");
			Console.Write("Enter your choice: ");

			// Get user's choice
			int choice;
			if (!int.TryParse(Console.ReadLine(), out choice))
			{
				Console.WriteLine("Invalid input! Please enter a number.");
				continue;
			}
			// Perform action based on user's choice
			switch (choice)
			{
				case 1:
					PerformAction(AddEmployee);
					break;
				case 2:
					PerformAction(UpdateEmployee);
					break;
				case 3:
					PerformAction(DeleteEmployee);
					break;
				case 4:
					Console.WriteLine("Exiting...");
					return;
				default:
					Console.WriteLine("Invalid choice! Please enter a valid option.");
					break;
			}
		}
	}

	// Method to perform action based on user's choice
	static void PerformAction(EmployeeActionDelegate action)
	{
		// Prompt user for employee details
		Console.Write("Enter employee ID: ");
		int id = int.Parse(Console.ReadLine());
		Console.Write("Enter employee name: ");
		string name = Console.ReadLine();
		Console.Write("Enter employee department: ");
		string department = Console.ReadLine();

		// Create an employee object
		Employee emp = new Employee { Id = id, Name = name, Department = department };

		// Perform the action using delegate
		action(emp);

		// Display appropriate message
		Console.WriteLine("Action completed successfully.\n");
	}
	// Method to add an employee to the collection
	static void AddEmployee(Employee employee)
	{
		employees.Add(employee);
		Console.WriteLine("Employee added successfully.");
	}
	// Method to update an employee record
	static void UpdateEmployee(Employee employee)
	{
		// Find the employee by ID and update details
		Employee empToUpdate = employees.Find(emp => emp.Id == employee.Id);
		if (empToUpdate != null)
		{
			empToUpdate.Name = employee.Name;
			empToUpdate.Department = employee.Department;
			Console.WriteLine("Employee updated successfully.");
		}
		else
		{
			Console.WriteLine("Employee not found.");
		}
	}

	// Method to delete an employee record
	static void DeleteEmployee(Employee employee)
	{
		// Find and remove the employee by ID
		Employee empToDelete = employees.Find(emp => emp.Id == employee.Id);
		if (empToDelete != null)
		{
			employees.Remove(empToDelete);
			Console.WriteLine("Employee deleted successfully.");
		}
		else
		{
			Console.WriteLine("Employee not found.");
		}
	}
}
