using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class TaskDAO : EmployeeContext {
        public static void AddTask(TASK task) {
            try {
                db.TASKs.InsertOnSubmit(task);
                db.SubmitChanges();
            }
            catch (Exception ex) {

                throw ex;
            }
        }

        public static List<TaskDetailDTO> GetTasks() {
            List<TaskDetailDTO> taskList = new List<TaskDetailDTO>();

            var list = (from t in db.TASKs
                        join s in db.TASKSTATEs on t.TaskState equals s.TaskStateID
                        join e in db.EMPLOYEEs on t.EmployeeID equals e.EmployeeID
                        join d in db.DEPARTMENTs on e.DepartmentID equals d.DepartmentID
                        join p in db.POSITIONs on e.PositionID equals p.PositionID
                        select new {
                            taskID = t.TaskID,
                            title = t.TaskTitle,
                            content = t.TaskContent,
                            startDate = t.TaskStartDate,
                            deliveryDate = t.TaskDeliveryDate,
                            taskStateNames = s.StateName,
                            taskStateID = s.TaskStateID,
                            userNumber = e.UserNumber,
                            Name = e.Name,
                            EmployeeID = t.EmployeeID,
                            Surname = e.Surname,
                            positionName = p.PositionName,
                            departmentName = d.DepartmentName,
                            positionID = p.PositionID,
                            departmentID = d.DepartmentID
                        }).OrderBy(x => x.startDate).ToList();

            foreach (var item in list) {
                TaskDetailDTO dto = new TaskDetailDTO();
                dto.TaskID = item.taskID;
                dto.Title = item.title;
                dto.Content = item.content;
                dto.TaskStartDate = item.startDate;
                dto.TaskDeliveryDate = item.deliveryDate;
                dto.TaskStateName = item.taskStateNames;
                dto.taskStateID = item.taskStateID;
                dto.UserNo = item.userNumber;
                dto.Name = item.Name;
                dto.EmployeeID = (int)item.EmployeeID;
                dto.Surname = item.Surname;
                dto.PositionName = item.positionName;
                dto.DepartmentName = item.departmentName;
                dto.PositionID = item.positionID;
                dto.DepartmentID = item.departmentID;
                taskList.Add(dto);
            }

            return taskList;
        }

        public static List<TASKSTATE> GetTaskStates() {
            return db.TASKSTATEs.ToList();
        }
    }
}
