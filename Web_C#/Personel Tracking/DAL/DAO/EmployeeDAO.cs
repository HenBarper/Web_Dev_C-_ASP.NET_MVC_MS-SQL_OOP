using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class EmployeeDAO : EmployeeContext {
        public static void AddEmployee(EMPLOYEE employee) {
			try {
                db.EMPLOYEEs.InsertOnSubmit(employee);
                db.SubmitChanges();
			}
            catch (Exception ex) {
				throw ex;
			}
        }

        public static List<EmployeeDetailDTO> GetEmployees() {
            List<EmployeeDetailDTO> employeeList = new List<EmployeeDetailDTO>();

            var list = (from e in db.EMPLOYEEs
                        join d in db.DEPARTMENTs on e.DepartmentID equals d.DepartmentID
                        join p in db.POSITIONs on e.PositionID equals p.PositionID
                        select new {
                            UserNo = e.UserNumber,
                            Name = e.Name,
                            Surname = e.Surname,
                            EmployeeID = e.EmployeeID,
                            Password = e.Password,
                            DepartmentName = d.DepartmentName,
                            DepartmentID = e.DepartmentID,
                            PositionName = p.PositionName,
                            PositionID = e.PositionID,
                            isAdmin = e.isAdmin,
                            Salary = e.Salaray,
                            ImagePath = e.ImagePath,
                            Birthday = e.Birthday,
                            Address = e.Address,
                        }).OrderBy(x => x.UserNo).ToList();

            foreach (var item in list) {
                EmployeeDetailDTO dto = new EmployeeDetailDTO();
                dto.Name = item.Name;
                dto.UserNo = item.UserNo;
                dto.Surname = item.Surname;
                dto.EmployeeID = item.EmployeeID;
                dto.Password = item.Password;
                dto.DepartmentName = item.DepartmentName;
                dto.DepartmentID = item.DepartmentID;
                dto.PositionName = item.PositionName;
                dto.PositionID = item.PositionID;
                dto.isAdmin = item.isAdmin;
                dto.Salary = item.Salary;
                dto.ImagePath = item.ImagePath;
                dto.BirthDay = item.Birthday;
                dto.Address = item.Address;
                employeeList.Add(dto);
            }

            return employeeList;
        }

        public static List<EMPLOYEE> GetUsers(int v) {
            return db.EMPLOYEEs.Where(x => x.UserNumber == v).ToList();
        }
    }
}
