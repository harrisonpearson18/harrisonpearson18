﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Dapper;

namespace BestBuyPracticeSQL
{
    public class DapperDepartmentRepository : IDepartmentRepository
    {
        private readonly IDbConnection _connection;


        //Constructor
        public DapperDepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }

        public void InsertDepartment(string newDepartmentName)
        {
            _connection.Execute("INSERT INTO DEPARTMENTS (Name) VALUES (@departmentName);",
              new { departmentName = newDepartmentName });
        }

        public void DeleteDepartment(string newDepartmentName)
        {
            _connection.Execute("DELETE INTO DEPARTMENTS (Name) VALUES (@departmentName);",
              new { departmentName = newDepartmentName });
        }

    }
}