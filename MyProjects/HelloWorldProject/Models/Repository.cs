namespace HelloWorldApp.Models
{
    public class Repository
    {
        private static List<Employee> employeesList=new List<Employee>();
        public static IEnumerable<Employee> GetEmployees()
        {
            return employeesList;
        }
        public static void AddEmployee(Employee emp)
        {
             employeesList.Add(emp);
        }   
    }
}
