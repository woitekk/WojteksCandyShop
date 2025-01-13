using WojteksCandyShop.HR;

namespace WojteksCandyShop.Tests
{
    public class EmployeeTests
    {
        [Fact]
        public void PerformWork_Adds_NumberOfHours()
        {
            //Arrange
            Employee employee = new Employee("Bogdan", "Frankowski", "base@email.com", new DateTime(1981, 1, 1), 25);

            int numberOfHours = 3;

            //Act
            employee.PerformWork(numberOfHours);

            //Assert
            Assert.Equal(numberOfHours, employee.NumberOfHoursWorked);
        }

        [Fact]
        public void PerformWork_Adds_DefaultNumberOfHours()
        {
            Employee employee = new("Bogdan", "Frankowski", "base@email.com", new DateTime(1981, 1, 1), 25);

            employee.PerformWork();

            Assert.Equal(1, employee.NumberOfHoursWorked);
        }
    }
}
