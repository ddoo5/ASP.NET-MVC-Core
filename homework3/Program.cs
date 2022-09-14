using ConsoleApp1;


Random rnd =new();

for (int i = 0; i < 40; i++)
{
    var employeeInsideSalary = EmployeesFactory.SalaryInside<Insider>();

    employeeInsideSalary
        .AddName(Convert.ToString((Names)rnd.Next(1, 20)))
        .AddSurname(Convert.ToString((Surnames)rnd.Next(1, 20)));

    
    var employeeOutsideSalary = EmployeesFactory.SalaryOutside<Outsider>(
        rnd.Next(1000, 2000), 
        rnd.Next(10, 20),
        rnd.Next(5, 9));
    
    employeeOutsideSalary
        .AddName(Convert.ToString((Names)rnd.Next(1, 20)))
        .AddSurname(Convert.ToString((Surnames)rnd.Next(1, 20)));
    
    
    Console.WriteLine($"Employee\n" +
                      $"Name: {employeeInsideSalary.Name}\n" +
                      $"Surname: {employeeInsideSalary.Surname}\n" +
                      $"Company: {employeeInsideSalary.Company}\n" +
                      $"Salary: {employeeInsideSalary.MonthSalary}\n");
    
    Console.WriteLine($"Freelancer\n" +
                      $"Name: {employeeOutsideSalary.Name}\n" +
                      $"Surname: {employeeOutsideSalary.Surname}\n" +
                      $"Company: {employeeOutsideSalary.Company}\n" +
                      $"Salary: {employeeOutsideSalary.MonthSalary}\n");
}
