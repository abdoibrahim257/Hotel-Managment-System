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
        //Abod
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

        //HOS
        public int InsertG(string id, string fname, string mname, string lname, string gender, string phone)
        {
            string query = "INSERT INTO Guest " +
                            "Values ('" + id + "','" + fname + "','" + mname + "','" + lname + "','" + gender + "','" + phone + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        //join program
        public int JoinP(string Pid, string Gid, string date)
        {
            string query = "INSERT INTO JoinProgram " +
                            "Values ('" + Pid + "','" + Gid + "','" + date + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        //Request service
        public int RequestS(string Gid, string Sid, string amount, string date)
        {
            string query = "INSERT INTO Request " +
                            "Values ('" + Gid + "','" + Sid + "','" + amount + "','" + date + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        //Submit Feedback
        public int Feedback(string Gid, string Ftype, string date, string descrip)
        {
            string query = "INSERT INTO FeedBack " +
                            "Values ('" + Gid + "','" + Ftype + "','" + date + "','" + descrip + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        //Ashraf

        public int GuestAccount(string username, string password, string ssn)
        {
            string query = "INSERT INTO GuestAccount values ('" + username + "','" + password + "','" + ssn + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertGuest(string ssn, string fname, string minit, string lname, string gender, string mobile)
        {
            string query = "INSERT INTO Guest values ('" + ssn + "','" + fname + "','" + minit + "', '" + lname + "', '" + gender + "','" + mobile + "');";
            return dbMan.ExecuteNonQuery(query);

        }

        public int InsertMgrEmployee_FromADN(int ssn, string user_name, string pass, string fname, string mini, string lname, int age, string Gen, string address, string mob, int salary, string marital)
        {
            string query = $"insert into Employee values({ssn}, '{user_name}', '{pass}', '{fname}', '{mini}', '{lname}', {age}, '{Gen}', '{address}', '{mob}', {salary}, '{marital}');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int ManagerAccount(string ssn, string T)
        {
            string query = "INSERT INTO Manager values ('" + ssn + "','" + T + "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int InsertAdmin(int ssn, string user_name, string pass, string fname, string mini, string lname, int age, string Gen, string address, string mob, int salary, string marital)
        {
            string query = $"insert into Employee values({ssn}, '{user_name}', '{pass}', '{fname}', '{mini}', '{lname}', {age}, '{Gen}', '{address}', '{mob}', {salary}, '{marital}');";
            return dbMan.ExecuteNonQuery(query);
        }


        //------------------------------------------SELECT QUERIES---------------------------------------------
        //Abod
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

        //HOS
        public DataTable ShowP()
        {
            string query = "SELECT ProgramId, ProgramDescription, ProgramCapacity, ProgramType, ProgramLocation, ProgramStartTime, ProgramEndTime, ProgramFees FROM HotelProgram where ProgramCapacity > 0 ;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable PrID()
        {
            string query = "SELECT ProgramId FROM HotelProgram where ProgramCapacity > 0;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable ShowS()
        {
            string query = "SELECT ServiceID, ServiceType, ServiceAmount, ServicePrice FROM Service where ServiceAmount > 0;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SrID()
        {
            string query = "SELECT ServiceID FROM Service where ServiceAmount > 0;";
            return dbMan.ExecuteReader(query);
        }

        //
        public DataTable ShowAvailableRoom()
        {
            string query = "SELECT RoomID, RoomType, RoomCapacity, RoomPrice FROM Room "
                + " where RoomResevationStatus = 'U' ;";
            return dbMan.ExecuteReader(query);
        }

        public int getservAm(string Sid)
        {
            string query = "SELECT ServiceAmount FROM Service WHERE ServiceID='" + Sid + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int getprogca(string Pid)
        {
            string query = "SELECT ProgramCapacity FROM HotelProgram WHERE ProgramId='" + Pid + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DateTime getstartprog(string Pid)
        {
            string query = "SELECT ProgramStartTime FROM HotelProgram WHERE ProgramId='" + Pid + "';";
            return (DateTime)dbMan.ExecuteScalar(query);
        }
        //end program date
        public DateTime getendprog(string Pid)
        {
            string query = "SELECT ProgramEndTime FROM HotelProgram WHERE ProgramId='" + Pid + "';";
            return (DateTime)dbMan.ExecuteScalar(query);
        }

        ////for payments
        // for room
        public object TotalBook(string Gid)
        {
            string query = "SELECT SUM(RoomPrice) FROM Room "
             + " where GuestID='" + Gid + "';";
            return (object)dbMan.ExecuteScalar(query);
        }
        // for program
        public object TotalProg(string Gid)
        {
            string query = "SELECT SUM(ProgramFees) FROM HotelProgram H, JoinProgram P "
             + " where H.ProgramId=P.ProgramID and P.GuestID='" + Gid + "';";
            return (object)dbMan.ExecuteScalar(query);
        }

        // for service
        public object TotalSer(string Gid)
        {
            string query = "SELECT SUM(S.ServicePrice * R.Amount) FROM Service S, Request R "
             + " where S.ServiceID=R.ServiceID and R.GuestID='" + Gid + "';";
            return (object)dbMan.ExecuteScalar(query);
        }

        //Ashrof
        public int ExistAccount_MGR_Rec(string EmployeeUsrName, string EmployeePass)
        {

            string query = $"select 1 where EXISTS(select EmployeeUsrName from Employee where EmployeeUsrName = '{EmployeeUsrName}' AND [EmployeePass]= '{EmployeePass}');";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int ExistAccount(string UsrName, string password)
        {

            string query = $"select 1 where EXISTS(select UsrName from GuestAccount where UsrName = '{UsrName}' AND [password]= '{password}');";
            return (int)dbMan.ExecuteScalar(query);

        }
        public int CheckIfUserExists(string GuestId)
        {

            string query = $"select count(GuestId) from Guest where GuestId = '{GuestId}'";

            return (int)dbMan.ExecuteScalar(query);
        }
        public int CheckLoginPrimary(string user)
        {
            string query = $"select count(UsrName) from GuestAccount where UsrName = '{user}'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int CheckIfMGRExists(string EmployeeSSN)
        {

            string query = $"select count(EmployeeSSN) from Employee where EmployeeSSN = '{EmployeeSSN}'";

            return (int)dbMan.ExecuteScalar(query);
        }
        public int CheckLoginMGRPrimary(string EmployeeUsrName)
        {
            string query = $"select count(EmployeeUsrName) from Employee where EmployeeUsrName = '{EmployeeUsrName}'";
            return (int)dbMan.ExecuteScalar(query);
        }
        public DataTable SelectAdminByUsr(string username, string password)
        {
            string query = $"SELECT * from Manager, Employee where ManagerSSN = Employee.EmployeeSSN and Employee.EmployeeUsrName = '" + username + "' and Employee.EmployeePass = '" + password + "'; ";
            return dbMan.ExecuteReader(query);
        }
        public int CheckIfADNExists(string EmployeeSSN)
        {

            string query = $"select count(EmployeeSSN) from Employee where EmployeeSSN = '{EmployeeSSN}'";

            return (int)dbMan.ExecuteScalar(query);
        }
        public int CheckLoginADNPrimary(string EmployeeUsrName)
        {
            string query = $"select count(EmployeeUsrName) from Employee where EmployeeUsrName = '{EmployeeUsrName}'";
            return (int)dbMan.ExecuteScalar(query);
        }

        //------------------------------------------UPDATE QUERIES---------------------------------------------
        //Abod
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

        //HOS
        public int BookRoom(string Rid, string Gid, string sdate, string edate)
        {
            string query = "UPDATE Room SET GuestID='" + Gid + "' , RoomResevationStatus = 'R' , CheckIn='" + sdate + "' , CheckOut='" + edate + "' WHERE RoomID='" + Rid + "';";
            return dbMan.ExecuteNonQuery(query);

        }

        public int UpdateAmountS(string SA, string Sid)
        {
            string query = "UPDATE Service SET ServiceAmount = ServiceAmount - '" + SA + "' WHERE ServiceID='" + Sid + "';";
            return dbMan.ExecuteNonQuery(query);

        }
        public int UpdateProgramC(string Pid)
        {
            string query = "UPDATE HotelProgram SET ProgramCapacity = ProgramCapacity - 1  WHERE ProgramId='" + Pid + "';";
            return dbMan.ExecuteNonQuery(query);

        }

        //Ashraf 
        public int UpdateGuestAccount(string UsrName, string password)
        {
            string query = "UPDATE GuestAccount SET password='" + password + "' WHERE UsrName='" + UsrName + "';";
            return dbMan.ExecuteNonQuery(query);
        }
        public int UpdateAdminInfo(string fname, string mName, string Lname, string address, int age, char g, string marital, string phone, int ssn)
        {
            string query = $"UPDATE Employee SET EmployeeFname = '{fname}', EmployeeMini = '{mName}', EmployeeLname = '{Lname}', EmployeeAge = {age}, EmployeeGender = '{g}', MaritalStat = '{marital}', EmployeePhone = '{phone}', EmployeeAddress = '{address}' WHERE EmployeeSSN = {ssn} ";
            return dbMan.ExecuteNonQuery(query);
        }

        //------------------------------------------DELETE QUERIES------------------------------------------
        //Abod
        public int DeleteEmployee(int ssn)
        {
            string query = $"DELETE  FROM Employee WHERE Employee.EmployeeSSN = {ssn} ";
            return dbMan.ExecuteNonQuery(query);
        }
        
    }
}
