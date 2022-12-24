using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Project
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        //------------------------------------------INSERT QUERIES---------------------------------------------
        public int InsertProgram(int id, string description, int capacity, string type, string location, string startDate, string endDate, float fees, int ssn)
        {
            string query = $"insert into HotelProgram values ( {id}, '{description}', {capacity}, '{type}', '{location}', '{startDate}', '{endDate}', {fees}, {ssn});";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertService(int id, string type, int capacity, float fees, int ssn)
        {
            string query = $"insert into Service values ( {id}, '{type}', {capacity}, {fees}, {ssn});";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertExpenses(int id, float price, string date, string description, int ssn)
        {
            string query = $"insert into Expense values ( {id}, {price}, '{date}', '{description}', {ssn});";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertRecEmployee(int ssn , string fname, string mini, string lname, int age, char Gen, string address, string mob, float salary, string marital)
        {
            string query = $"insert into Employee values({ssn}, 'r', 'r', '{fname}', '{mini}', '{lname}', {age}, '{Gen}', '{address}', '{mob}', {salary}, '{marital}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertMgrEmployee(int ssn , string fname, string mini, string lname, int age, char Gen, string address, string mob, float salary, string marital)
        {
            string query = $"insert into Employee values({ssn}, 'm', 'm', '{fname}', '{mini}', '{lname}', {age}, '{Gen}', '{address}', '{mob}', {salary}, '{marital}');";
            return dbMan.ExecuteNonQuery(query);
        }


        //------------------------------------------SELECT QUERIES---------------------------------------------
        public DataTable SelectManagerByUsr(string username, string password)
        {
            string query = $"SELECT * from Manager, Employee where ManagerSSN = Employee.EmployeeSSN and Employee.EmployeeUsrName = '" + username + "' and Employee.EmployeePass = '" + password + "'; ";
            return dbMan.ExecuteReader(query);
        }        
        public DataTable SelectManager(int ssn)
        {
            string query = $"SELECT * from Manager, Employee where ManagerSSN = {ssn};";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectManager()
        {
            string query = $"SELECT * from Manager";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectEmployee(string username, string password)
        {
            string query = $"SELECT * from Employee where Employee.EmployeeUsrName = '{username}' and Employee.EmployeePass = '{password}'; ";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectReceptionists()
        {
            string query = $"SELECT * from Receptionist;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectReceptionistBySSN(int SSN)
        {
            string query = $"SELECT Receptionist.*, Employee.* from Receptionist, Employee where ReceptionistSSN = EmployeeSSN and ReceptionistSSN = " + SSN + "; ";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectProgram(int id)
        {
            string query = $"SELECT * from HotelProgram where HotelProgram.ProgramId = {id};";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectService(int id)
        {
            string query = $"SELECT * from Service where Service.ServiceID = {id};";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectProfit()
        {
            string query = $"select Payments.Date, SUM(Payments.Price - Payments.Discount) As NetIncome from Payments group by Payments.Date order by Payments.Date;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectExpenses()
        {
            string query = $"select Expense.ExpenseDate, SUM(Expense.ExpensePrice) As NetExpenses from Expense group by ExpenseDate order by ExpenseDate;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectFeedBack()
        {
            string query = $"select FeedBack.Date, FeedBack.comment from FeedBack;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployessWithNoLogin()
        {
            string query = $"SELECT * from Employee where ((Employee.EmployeeUsrName = 'r' and Employee.EmployeePass = 'r') or ((Employee.EmployeeUsrName = 'm' and Employee.EmployeePass = 'm')));"; // r small for recptionist and m small for manager
            return dbMan.ExecuteReader(query);
        }
        public DataTable SelectEmployessWithNoLogin(int ssn)
        {
            string query = $"SELECT EmployeeUsrName from Employee where ((Employee.EmployeeUsrName = 'r' and Employee.EmployeePass = 'r') or ((Employee.EmployeeUsrName = 'm' and Employee.EmployeePass = 'm'))) and (EmployeeSSN = {ssn});;"; // r small for recptionist and m small for manager
            return dbMan.ExecuteReader(query);
        }

        //------------------------------------------UPDATE QUERIES---------------------------------------------

        public int UpdateProgram(int id, string description, int capacity, string type, string location, string startDate, string endDate, float fees, int ssn)
        {
            string query = $"UPDATE HotelProgram SET ProgramDescription = '{description}', ProgramCapacity = {capacity}, ProgramType = '{type}', ProgramLocation = '{location}',  ProgramStartTime = '{startDate}', ProgramEndTime = '{endDate}', ProgramFees = {fees} where ProgramId = {id} and ManagerSSN = {ssn}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateService(int id, string type, int capacity, float fees, int ssn)
        {
            string query = $"UPDATE Service SET ServiceType = '{type}', ServiceAmount = {capacity}, ServicePrice = {fees} where ServiceID = {id} and ManagerSSN = {ssn}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateBonus(int id, int bonus, int ssn)
        {
            string query = $"Update Receptionist SET BonusPoint = {bonus} WHERE ReceptionistSSN = {id} and ManagerSSN = {ssn}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateSalary(int id, int salary)
        {
            string query = $"Update Employee SET EmployeeSalary = {salary} WHERE  EXISTS (select * from Receptionist where Employee.EmployeeSSN = ReceptionistSSN and ReceptionistSSN = {id});";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateManagerInfo(string fname, string mName, string Lname, string address, int age, char g, string marital, string phone, int managerSSN)
        {
            string query = $"UPDATE Employee SET EmployeeFname = '{fname}', EmployeeMini = '{mName}', EmployeeLname = '{Lname}', EmployeeAge = {age}, EmployeeGender = '{g}', MaritalStat = '{marital}', EmployeePhone = '{phone}', EmployeeAddress = '{address}' WHERE EXISTS ( select * from Manager where Manager.ManagerSSN = Employee.EmployeeSSN and ManagerSSN = {managerSSN})";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateManagerPassword(string pass, int managerSSN)
        {
            string query = $"UPDATE Employee SET EmployeePass = '{pass}' where EXISTS (select * from Manager where ManagerSSN = {managerSSN} and Employee.EmployeeSSN = ManagerSSN);";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateAdminPassword(string pass, int ssn)
        {
            string query = $"UPDATE Employee SET EmployeePass = '{pass}' where Employee.EmployeeSSN = {ssn}";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateEmployeeAccount(string username, string password, int ssn)
        {
            string query = $"Update Employee Set EmployeeUsrName = '{username}' , EmployeePass = '{password}' where EmployeeSSN = {ssn};";
            return dbMan.ExecuteNonQuery(query);
        }



        //------------------------------------------DELETE QUERIES------------------------------------------
        public int DeleteEmployee(int ssn)
        {
            string query = $"DELETE  FROM Employee WHERE Employee.EmployeeSSN = {ssn} ";
            return dbMan.ExecuteNonQuery(query);
        }
    }
}
