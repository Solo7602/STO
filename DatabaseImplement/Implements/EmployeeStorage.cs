using BuisnessLogic.BindingModels;
using BuisnessLogic.StorageInterfaces;
using BuisnessLogic.ViewModels;
using DatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Implements
{
    public class EmployeeStorage : IEmployeeStorage
    {
        public List<EmployeeViewModel> GetFullList()
        {
            using var context = new StoDatabase();
            return context.Employees
            .Select(CreateModel)
            .ToList();
        }
        public List<EmployeeViewModel> GetFilteredList(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            return context.Employees
            .Where(rec => rec.EmployeeName.Contains(model.EmployeeName))
            .Select(CreateModel)
            .ToList();
        }
        public EmployeeViewModel GetElement(EmployeeBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using var context = new StoDatabase();
            var employee = context.Employees
            .FirstOrDefault(rec => rec.EmployeePhoneNumber == model.EmployeePhoneNumber);
            if (employee == null)
            {
                return null;
            }
            return employee.EmployeePassword == model.EmployeePassword ? CreateModel(employee) : null;
        }
        public void Insert(EmployeeBindingModel model)
        {
            using var context = new StoDatabase();
            Employee element = context.Employees.FirstOrDefault(rec => rec.EmployeePhoneNumber == model.EmployeePhoneNumber);
            context.Employees.Add(CreateModel(model, new Employee()));
            context.SaveChanges();
        }
        public void Update(EmployeeBindingModel model)
        {
            using var context = new StoDatabase();
            var element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            CreateModel(model, element);
            context.SaveChanges();
        }
        public void Delete(EmployeeBindingModel model)
        {
            using var context = new StoDatabase();
            Employee element = context.Employees.FirstOrDefault(rec => rec.Id ==
           model.Id);
            if (element != null)
            {
                context.Employees.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }
        private static Employee CreateModel(EmployeeBindingModel model, Employee
       employee)
        {
            employee.EmployeeName = model.EmployeeName;
            employee.EmployeeSurname = model.EmployeeSurname;
            employee.EmployeeMiddlename = model.EmployeeMiddlename;
            employee.EmployeePhoneNumber = model.EmployeePhoneNumber;
            employee.EmployeePassword = model.EmployeePassword;
            employee.EmployeePrize = (int)model.EmployeePrize;
            return employee;
        }
        private static EmployeeViewModel CreateModel(Employee employee)
        {
            return new EmployeeViewModel
            {
                Id = employee.Id,
                EmployeeName = employee.EmployeeName,
                EmployeeSurname = employee.EmployeeSurname,
                EmployeeMiddlename = employee.EmployeeMiddlename,
                EmployeePhoneNumber = employee.EmployeePhoneNumber,
                EmployeePassword = employee.EmployeePassword,
                EmployeePrize = employee.EmployeePrize,
            };
        }
    }
}
