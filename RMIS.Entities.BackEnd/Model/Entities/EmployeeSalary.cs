using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RMIS.Entities.BackEnd
{
    public class EmployeeSalary
    {
        private string _EmpSalaryID;
        private string _CustID;
        private string _EmployeeID;
        private string _MSalaryTypeID;
        private string _MEmpDsgID;
        private double _Salary;
        private string _LastModifiedBy;
        private DateTime _LastModifiedDate;
        private string _ObsInd;

        public virtual string EmpSalaryID
        {
            get { return _EmpSalaryID; }
            set { _EmpSalaryID = value; }
        }
        public virtual string CustID
        {
            get { return _CustID; }
            set { _CustID = value; }
        }
        public virtual string EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        public virtual string MSalaryTypeID
        {
            get { return _MSalaryTypeID; }
            set { _MSalaryTypeID = value; }
        }
        public virtual string MEmpDsgID
        {
            get { return _MEmpDsgID; }
            set { _MEmpDsgID = value; }
        }
        public virtual double Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        public virtual string LastModifiedBy
        {
            get { return _LastModifiedBy; }
            set { _LastModifiedBy = value; }
        }
        public virtual DateTime LastModifiedDate
        {
            get { return _LastModifiedDate; }
            set { _LastModifiedDate = value; }
        }
        public virtual string ObsInd
        {
            get { return _ObsInd; }
            set { _ObsInd = value; }
        }
    }
}
