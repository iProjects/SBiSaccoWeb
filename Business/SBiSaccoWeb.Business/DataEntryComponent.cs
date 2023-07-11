//====================================================================================================
// Base code generated with Motion: BC Gen (Build 2.2.5049.15162)
// Layered Architecture Solution Guidance (http://layerguidance.codeplex.com)
//
// Generated by Administrator at SAPSERVER on 06/25/2014 06:49:38 
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SBiSaccoWeb.Entities;
using SBiSaccoWeb.Data;
using System.Configuration;

namespace SBiSaccoWeb.Business
{
    /// <summary>
    /// DataEntry business component.
    /// </summary>
    public partial class DataEntryComponent
    {
        #region "Employees"
        public List<Employee> GetAllEmployees()
        {
            List<Employee> result = default(List<Employee>);

            // Data access component declarations.
            EmployeeDAC _EmployeeDAC = new EmployeeDAC();

            result = _EmployeeDAC.Select();
            return result;

        }
        public Employee GetEmployeebyEmail(string email)
        {
            Employee result = default(Employee);

            // Data access component declarations.
            EmployeeDAC _EmployeeDAC = new EmployeeDAC();

            result = _EmployeeDAC.SelectByEmail(email);
            return result;
        }
        public Employee CreateEmployee(Employee model)
        {
            EmployeeDAC _EmployeeDAC = new EmployeeDAC();

            Employee _Employee = new Employee();
            _Employee.Email = model.Email;
            _Employee.Surname = model.Surname;
            _Employee.OtherNames = model.OtherNames;
            _Employee.EmpNo = model.EmpNo;
            _Employee.MaritalStatus = model.MaritalStatus;
            _Employee.Gender = model.Gender;
            _Employee.Photo = model.Photo;
            _Employee.DoB = model.DoB;
            _Employee.DoE = model.DoE;
            _Employee.CreatedOn = model.CreatedOn;
            _Employee.DateLeft = model.DateLeft;
            _Employee.TelephoneNo = model.TelephoneNo;
            _Employee.DepartmentId = model.DepartmentId;
            _Employee.EmployerId = model.EmployerId;
            _Employee.BasicComputation = model.BasicComputation;
            _Employee.BasicPay = model.BasicPay;
            _Employee.LeaveBalance = model.LeaveBalance;
            _Employee.PersonalRelief = model.PersonalRelief;
            _Employee.MortgageRelief = model.MortgageRelief;
            _Employee.InsuranceRelief = model.InsuranceRelief;
            _Employee.NSSFNo = model.NSSFNo;
            _Employee.NHIFNo = model.NHIFNo;
            _Employee.IDNo = model.IDNo;
            _Employee.PINNo = model.PINNo;
            _Employee.PayPoint = model.PayPoint;
            _Employee.EmpGroup = model.EmpGroup;
            _Employee.EmpPayroll = model.EmpPayroll;
            _Employee.PaymentMode = model.PaymentMode;
            _Employee.ChequeNo = model.ChequeNo;
            _Employee.BankCode = model.BankCode;
            _Employee.BankAccount = model.BankAccount;
            _Employee.CreatedBy = model.CreatedBy;
            _Employee.PrevEmployer = model.PrevEmployer;
            _Employee.IsActive = model.IsActive;
            _Employee.IsDeleted = model.IsDeleted;

            Employee EmployeeReturned = _EmployeeDAC.Create(_Employee);
             
            return EmployeeReturned;
        }
        public void DeleteEmployeeById(int Id)
        {
            EmployeeDAC _EmployeeDAC = new EmployeeDAC();
            _EmployeeDAC.DeleteById(Id);
        }
        public Employee GetEmployeebyId(int Id)
        {
            Employee result = default(Employee);

            // Data access component declarations.
            EmployeeDAC _EmployeeDAC = new EmployeeDAC();

            result = _EmployeeDAC.SelectById(Id);
            return result;

        }
        public void UpdateEmployee(Employee _Employee)
        {
            // Data access component declarations.
            EmployeeDAC _EmployeeDAC = new EmployeeDAC();

            _EmployeeDAC.UpdateById(_Employee);
        }
        public void UploadEmployeePhoto(Employee _Employee)
        {
            // Data access component declarations.
            EmployeeDAC _EmployeeDAC = new EmployeeDAC();

            _EmployeeDAC.UploadEmployeePhoto(_Employee);
        }
        #endregion "Employees"
        #region "Employers"
        public List<Employer> GetAllEmployers()
        {
            List<Employer> result = default(List<Employer>);

            // Data access component declarations.
            EmployerDAC _EmployerDAC = new EmployerDAC();

            result = _EmployerDAC.Select();
            return result;

        }
        public Employer CreateEmployer(Employer model)
        {
            EmployerDAC _EmployerDAC = new EmployerDAC();

            Employer _Employer = new Employer();
            _Employer.Name = model.Name;
            _Employer.Email = model.Email;
            _Employer.Telephone = model.Telephone;
            _Employer.Address1 = model.Address1;
            _Employer.Address2 = model.Address2;
            _Employer.Slogan = model.Slogan;
            _Employer.AuthorizedSignatory = model.AuthorizedSignatory;
            _Employer.PIN = model.PIN;
            _Employer.NHIF = model.NHIF;
            _Employer.NSSF = model.NSSF;
            _Employer.BankBranchSortCode = model.BankBranchSortCode;
            _Employer.AccountName = model.AccountName;
            _Employer.AccountNo = model.AccountNo;
            _Employer.Logo = model.Logo;
            _Employer.IsActive = model.IsActive;
            _Employer.IsDeleted = model.IsDeleted;
            _Employer.IsDefault = model.IsDefault;

            Employer EmployerReturned = _EmployerDAC.Create(_Employer);

            return EmployerReturned;
        }
        public void DeleteEmployerById(int Id)
        {
            EmployerDAC _EmployerDAC = new EmployerDAC();
            _EmployerDAC.DeleteById(Id);
        }
        public Employer GetEmployerbyId(int Id)
        {
            Employer result = default(Employer);

            // Data access component declarations.
            EmployerDAC _EmployerDAC = new EmployerDAC();

            result = _EmployerDAC.SelectById(Id);
            return result;

        }
        public Employer GetDefaultEmployer()
        {
            Employer result = default(Employer);

            // Data access component declarations.
            EmployerDAC _EmployerDAC = new EmployerDAC();

            result = _EmployerDAC.SelectDefaultEmployer();
            return result;

        }
        public void UpdateEmployer(Employer _Employer)
        {
            // Data access component declarations.
            EmployerDAC _EmployerDAC = new EmployerDAC();

            _EmployerDAC.UpdateById(_Employer);
        }
        public void UploadEmployerLogo(Employer _Employer)
        {
            // Data access component declarations.
            EmployerDAC _EmployerDAC = new EmployerDAC();

            _EmployerDAC.UploadEmployerLogo(_Employer);
        }
        #endregion "Employers"
         

    }
}