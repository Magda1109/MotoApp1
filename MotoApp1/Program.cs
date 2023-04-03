using MotoApp1.Entities;
using MotoApp1.Repositories;

var employeeRepository = new GenericRepository<Employee>();

employeeRepository.Add(new Employee() {FirstName = "Adam"});
employeeRepository.Add(new Employee() { FirstName = "Piotr" });
employeeRepository.Add(new Employee() { FirstName = "Zusia" });
employeeRepository.Save();