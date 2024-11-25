using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO {
    public class PositionDAO : EmployeeContext {
        public static void AddPosition(POSITION position) {
            try {
                db.POSITIONs.InsertOnSubmit(position);
                db.SubmitChanges();
            }
            catch (Exception ex) {
                throw ex;
            }
        }

        public static List<PositionDTO> GetPositions() {
            try {
                var list = (from p in db.POSITIONs
                            join d in db.DEPARTMENTs on p.DepartmentID equals d.DepartmentID
                            select new {
                                positionID = p.PositionID,
                                positionName = p.PositionName,
                                departmentName = d.DepartmentName,
                                departmentID = d.DepartmentID,
                            }).OrderBy(x => x.positionID).ToList();

                List<PositionDTO> positionList = new List<PositionDTO>();

                foreach (var item in list) {
                    PositionDTO positionDTO = new PositionDTO();
                    positionDTO.PositionID = item.positionID;
                    positionDTO.PositionName = item.positionName;
                    positionDTO.DepartmentName = item.departmentName;
                    positionDTO.DepartmentID = item.departmentID;
                    positionList.Add(positionDTO);
                }
                return positionList;
            } catch (Exception ex) {

                throw ex;
            }
        }
    }
}
