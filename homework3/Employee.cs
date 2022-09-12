namespace ConsoleApp1;


public abstract class Employee   //base class
{
    internal string Name { get; set; }
    internal string Surname { get; set; }
    internal string Company
    {
        get
        {
            return "LLC...";
        }
    }
    internal int MonthSalary { get; set; }

    protected internal abstract int Salary(int salary, int workDays, int workHours );  //abstract method for calculating month salary
}



public sealed class Insider : Employee   //employee in company
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



public sealed class Outsider : Employee  //freelance
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
    internal static T SalaryInside<T>(string name, string surname) where T : Employee, new()
    {
        T _type = new T();
        
        _type.Name = name;
        _type.Surname = surname;
        _type.MonthSalary = _type.Salary(0, 0, 0);
        
        return _type;
    }
    
    internal static T SalaryOutside<T>(string name, string surname, int salaryMonth, int days, int hours) where T : Employee, new()
    {
        T _type = new T();
        
        _type.Name = name;
        _type.Surname = surname;
        _type.MonthSalary = _type.Salary(salaryMonth, days, hours);
        
        return _type;
    }
}