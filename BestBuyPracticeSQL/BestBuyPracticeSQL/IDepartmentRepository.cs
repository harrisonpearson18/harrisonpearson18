using System;
using System.Collections.Generic;
using System.Text;

namespace BestBuyPracticeSQL
{
        public interface IDepartmentRepository
        {
            IEnumerable<Department> GetAllDepartments(); //Stubbed out method
            void InsertDepartment(string newDepartmentName);

            void DeleteDepartment(string newDepartmentName);
        }
}
