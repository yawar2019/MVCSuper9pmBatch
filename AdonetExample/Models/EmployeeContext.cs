using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace AdonetExample.Models
{
    public class EmployeeContext
    {

        SqlConnection con = new SqlConnection("Data Source=AZAM-PC\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=true");

        public List<EmployeeModel> GetEmployeeList()
        {
            List<EmployeeModel> listObj = new List<EmployeeModel>();

            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                EmployeeModel emp = new EmployeeModel();
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);
                listObj.Add(emp);
            }
            return listObj;
        }

        public int SaveEmployee(EmployeeModel empObj)
        {
            SqlCommand cmd = new SqlCommand("spr_insertEmpDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@EmpName", empObj.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", empObj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }


        public EmployeeModel getEmployeeById(int? id)
        {
            EmployeeModel emp = new EmployeeModel();

            SqlCommand cmd = new SqlCommand("spr_getEmployeeDetailsbyId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empid", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                emp.EmpId = Convert.ToInt32(dr[0]);
                emp.EmpName = Convert.ToString(dr[1]);
                emp.EmpSalary = Convert.ToInt32(dr[2]);

            }
            return emp;
        }


        public int UpdateEmployee(EmployeeModel empObj)
        {
            SqlCommand cmd = new SqlCommand("spr_updateEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Empid", empObj.EmpId);
            cmd.Parameters.AddWithValue("@EmpName", empObj.EmpName);
            cmd.Parameters.AddWithValue("@EmpSalary", empObj.EmpSalary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int DeleteEmployee(int? id)
        {
            SqlCommand cmd = new SqlCommand("spr_deleteEmployeeDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Empid", id);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}