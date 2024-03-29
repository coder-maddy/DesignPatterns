﻿namespace ISP.Principle
{
    using ISP.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EmployeeBusinessLogic
    {
        IEmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
}
