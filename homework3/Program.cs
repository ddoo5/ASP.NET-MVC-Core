using ConsoleApp1;


Random rnd =new();

for (int i = 0; i < 40; i++)
{
    
    var employeeInside = EmployeesFactory.SalaryInside<Insider>(
        Convert.ToString((Names)rnd.Next(1, 20)), 
        Convert.ToString((Surnames)rnd.Next(1, 20)));
    
    
    var employeeOutside = EmployeesFactory.SalaryOutside<Outsider>(
        Convert.ToString((Names)rnd.Next(1, 20)), 
        Convert.ToString((Surnames)rnd.Next(1, 20)),
        rnd.Next(1000, 2000), 
        rnd.Next(10, 20),
        rnd.Next(5, 9));
    
    
    
    Console.WriteLine($"Employee\n" +    //это д/з 1; немного не понял, как заполнить без фабрики(если только !?напрямую, но за такое и по рукам можно получить)
                      $"Name: {employeeInside.Name}\n" +
                      $"Surname: {employeeInside.Surname}\n" +
                      $"Company: {employeeInside.Company}\n" +
                      $"Salary: {employeeInside.MonthSalary}\n");
    
    Console.WriteLine($"Freelancer\n" +
                      $"Name: {employeeOutside.Name}\n" +
                      $"Surname: {employeeOutside.Surname}\n" +
                      $"Company: {employeeOutside.Company}\n" +
                      $"Salary: {employeeOutside.MonthSalary}\n");
}
