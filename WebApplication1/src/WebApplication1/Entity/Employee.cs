using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{

    public interface IEmployee
    {
        Task<Employee> GetEmployee(int Id);
        void AddEmployee(Employee employee);


    }
    public class Employee : IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        void IEmployee.AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }

        async Task<Employee> IEmployee.GetEmployee(int Id)
        {
            //return  await new Employee() { ID = Id, Name = "Nitin" };   
            Employee emp = new Employee();
            await Task.Run(() => {
                emp.ID = Id; emp.Name = "Niitn"; });
            return emp;
        }
    }
}
