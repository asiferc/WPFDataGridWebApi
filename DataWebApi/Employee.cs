using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataWebApi
{
    public class Employee
    {
        private int empID;
        private string ename;
        private string reportingManager;
        private string location;

        public int EmployeeID
        {
            get { return empID; }
            set { empID = value; }
        }

        public string EmployeeName
        {
            get { return ename; }
            set { ename = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public string ReportingManager
        {
            get { return reportingManager; }
            set { reportingManager = value; }
        }
    }
}
