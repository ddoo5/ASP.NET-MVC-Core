using System.Collections.ObjectModel;

namespace ConsoleApp1;


public abstract class EmployeesSalary   //base class
{
    internal string Name { get; set; }
    internal string Surname { get; set; }
    internal string Company    //компании специально не добавляю потому, что рекламу не купили (JetBrains Rider 2022.2.2
    {                          //Licensed to Nordic IT School http://185.76.145.167:8080 (license server))(если не работает, то могу еще скинуть)
        get
        {
            return "LLC...";
        }
    }
    internal int MonthSalary { get; set; }

    protected internal abstract int Salary(int salary, int workDays, int workHours );  //abstract method for calculating month salary
}


public sealed class Insider : EmployeesSalary   //employee in company
{
    public Insider()
    {
        
    }
    
    protected internal override int Salary(int a, int b, int c)
    {
        b = 20;    //because fixed
        c = 10;    //because japan
        a = 1250;  //because JPY

        int result = b * c * a;

        return result;
    }
}


public sealed class Outsider : EmployeesSalary  //freelance
{
    public Outsider()
    {
        
    }
    
    protected internal override int Salary(int a, int b, int c)
    {
        int result = a * b * c;
        
        return result;
    }
}


public static class EmployeesFactory  //factory for creating employees
{
    internal static T SalaryInside<T>() where T : EmployeesSalary, new()
    {
        T _type = new T();

        _type.MonthSalary = _type.Salary(0, 0, 0);
        
        return _type;
    }
    
    internal static T SalaryOutside<T>(int salaryMonth, int days, int hours) where T : EmployeesSalary, new()
    {
        T _type = new T();
        
        _type.MonthSalary = _type.Salary(salaryMonth, days, hours);
        
        return _type;
    }
}


public static class EmployeeBuilder
{
    public static EmployeesSalary AddName(this EmployeesSalary _employee, string name)
    {
        _employee.Name = name;
        
        return _employee;
    }
    
    public static EmployeesSalary AddSurname(this EmployeesSalary _employee, string surname)
    {
        _employee.Surname = surname;
        
        return _employee;
    }
}