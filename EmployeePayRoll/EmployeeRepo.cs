using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRoll
{
    public class EmployeeRepo
    {
        public static string connectionstring = "";
        sql
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            try
            {
                using(this.GetHashCode())
                {
                    SqlCommand command = new SqlCommand("SpAddEmployeeDetails", this.connection);
                    command.CommandType = System.Data.CommandType.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeName", employeeModel.EmployeeName);
                    command.Parameters.AddWithValue("")
                }
            }

        }
    }
}
