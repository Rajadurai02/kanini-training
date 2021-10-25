﻿using EmployeeMVCApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EmployeeMVCApplication.Services
{
    public class EmployeeRepo : IRepo<Employee>
    {
        private readonly EmployeeContext _context;

        public EmployeeRepo(EmployeeContext context)
        {
            _context = context;
        }
        public Employee Add(Employee k)
        {
            try
            {
                _context.Employees.Add(k);
                _context.SaveChanges();
                return k;
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public Employee Delete(int id)
        {
            Employee employee = null;
            try
            {
                employee = _context.Employees.FirstOrDefault(e => e.Id == id);
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return employee;
        }

        public Employee Get(int id)
        {
            Employee employee = null;
            try
            {
                employee = _context.Employees.FirstOrDefault(e => e.Id == id);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return employee;
        }

        public ICollection<Employee> GetAll()
        {
            IList<Employee> employees = _context.Employees.ToList();
            if (employees.Count > 0)
                return employees;
            else
                return null;
        }

        public Employee Delete(Employee k)
        {
            Employee employee = null;
            try
            {
                employee = _context.Employees.FirstOrDefault(e => e.Id == k.Id);
                employee.Name = k.Name;
                employee.Salary = k.Salary;
                _context.SaveChanges();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return employee;
        }
    }
}
