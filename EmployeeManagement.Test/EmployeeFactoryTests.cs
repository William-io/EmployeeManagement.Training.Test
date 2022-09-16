using EmployeeManagement.Business;
using EmployeeManagement.DataAccess.Entities;
using Xunit;

namespace EmployeeManagement.Test;

public class EmployeeFactoryTests
{
    [Fact]
    public void CreateEmployee_ConstructInternalEmployee_SalaryMustBe2500()
    {
        var employeeFactory = new EmployeeFactory();

        var employee = (InternalEmployee)employeeFactory.CreateEmployee("William", "Silva");

        //Verifica se o valor esperedo conrresponde 
        Assert.Equal(2500, employee.Salary);
    }
}