using System;

public struct Address
{
	public string Street { get; set; }
	public string City { get; set; }
	public string State { get; set; }
	public int ZipCode { get; set; }

	public Address(string street, string city, string state, int zipCode)
	{
		Street = street;
		City = city;
		State = state;
		ZipCode = zipCode;
	}

	public override string ToString()
	{
		return $"{Street}, {City}, {State}, {ZipCode}";
	}
}

public interface IEmployee
{
	void DisplayDetails();
	double CalculateSalary();
}

public abstract class Employee : IEmployee
{
	public int EmployeeId { get; set; }
	public string FullName { get; set; }
	public Address EmployeeAddress { get; set; }

	public Employee(int employeeId, string fullName, Address employeeAddress)
	{
		EmployeeId = employeeId;
		FullName = fullName;
		EmployeeAddress = employeeAddress;
	}

	// Abstract method to be overridden by derived classes
	public abstract double CalculateSalary();

	// Virtual method to display employee details
	public virtual void DisplayDetails()
	{
		Console.WriteLine($"Employee ID: {EmployeeId}");
		Console.WriteLine($"Full Name: {FullName}");
		Console.WriteLine($"Address: {EmployeeAddress}");
	}
}

public class FullTimeEmployee : Employee
{
	public double MonthlySalary { get; set; }

	public FullTimeEmployee(int employeeId, string fullName, Address employeeAddress, double monthlySalary)
		: base(employeeId, fullName, employeeAddress)
	{
		MonthlySalary = monthlySalary;
	}

	public override double CalculateSalary()
	{
		return MonthlySalary;
	}
}

public class PartTimeEmployee : Employee
{
	public double HourlyRate { get; set; }
	public int HoursWorked { get; set; }

	public PartTimeEmployee(int employeeId, string fullName, Address employeeAddress, double hourlyRate, int hoursWorked)
		: base(employeeId, fullName, employeeAddress)
	{
		HourlyRate = hourlyRate;
		HoursWorked = hoursWorked;
	}

	public override double CalculateSalary()
	{
		return HourlyRate * HoursWorked;
	}
}

public class ContractEmployee : Employee
{
	public double ContractAmount { get; set; }

	public ContractEmployee(int employeeId, string fullName, Address employeeAddress, double contractAmount)
		: base(employeeId, fullName, employeeAddress)
	{
		ContractAmount = contractAmount;
	}

	public override double CalculateSalary()
	{
		return ContractAmount;
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Address address1 = new Address("23 Avenue Street", "Durban", "KZN", 10001);
		Employee fullTimeEmployee = new FullTimeEmployee(1, "John Doe", address1, 5000);

		Address address2 = new Address("56 Cruise Road", "Bluff", "JHB", 90001);
		Employee partTimeEmployee = new PartTimeEmployee(2, "Jane Smith", address2, 20, 80);

		Address address3 = new Address("89 Llama Circle", "Tuff", "CPT", 60007);
		Employee contractEmployee = new ContractEmployee(3, "Bob Johnson", address3, 3000);

		fullTimeEmployee.DisplayDetails();
		Console.WriteLine($"Salary: {fullTimeEmployee.CalculateSalary()}\n");

		partTimeEmployee.DisplayDetails();
		Console.WriteLine($"Salary: {partTimeEmployee.CalculateSalary()}\n");

		contractEmployee.DisplayDetails();
		Console.WriteLine($"Salary: {contractEmployee.CalculateSalary()}\n");
	}
}