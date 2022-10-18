// See https://aka.ms/new-console-template for more information
using System;
using System.Data;

interface IGovtRules
{
     double EmployeePF(double basicSalary);
     string leaveDetails();
     double gratuityAmount(float serviceCompleted, double basicSalary);

}

class TCS : IGovtRules
{
    public int empid
    {
        get; set;
    }
    public string dept   {
        get; set;
    }
    public string desg
    {
        get; set;
    }
    public string name
    {
        get; set;
    }
    public double basicSalary
    {
        get; set;
    }
    TCS(int Empid, string Dept, string Desg, string Name)
    {
        empid = Empid; dept = Dept;
        desg = Desg; name = Name;
    }
    public double EmployeePF(double basicSalary)
    {
        double pf = 0.12 * basicSalary + 0.0833 * basicSalary + 0.0367 * basicSalary;
        return pf;
    }
    string leaveDetails()
    {
        string details = "1 day of Casual leave per month \n 12 days of Sick leave per year \n 10 days of Pervilage leave per year";
        return details;
    }
    public double gratuityAmount(float serviceCompleted)
    {
        double gratuity;
        if (serviceCompleted > 20)
            gratuity = 3 * basicSalary;
        else if (serviceCompleted>10)
            gratuity = 2 * basicSalary;
        else if (serviceCompleted > 5)
            gratuity =  basicSalary;
        else
            gratuity = 0;
        return gratuity;

    }



}

class WellsFargo : IGovtRules
{
    public int empid
    {
        get; set;
    }
    public string dept
    {
        get; set;
    }
    public string desg
    {
        get; set;
    }
    public string name
    {
        get; set;
    }
    public double basicSalary
    {
        get; set;
    }
    TCS(int Empid, string Dept, string Desg, string Name)
    {
        empid = Empid; dept = Dept;
        desg = Desg; name = Name;
    }
    public double EmployeePF(double basicSalary)
    {
        double pf = 0.12 * basicSalary + 0.12 * basicSalary ;
        return pf;
    }
    string leaveDetails()
    {
        string details = "2 day of Casual leave per month \n 5 days of Sick leave per year \n 5 days of Pervilage leave per year";
        return details;
    }
    public double gratuityAmount(float serviceCompleted)
    {
        double gratuity;

            gratuity = 0;
        return gratuity;

    }



}


class Program
{
    static void main (string args[])
    {
        TCS obj1 = new TCS(1, "IT", "SDE", "Manish");
        WellsFargo obj2 = new WellsFargo(34, "HR", "HR", "Amit");
    }
}

