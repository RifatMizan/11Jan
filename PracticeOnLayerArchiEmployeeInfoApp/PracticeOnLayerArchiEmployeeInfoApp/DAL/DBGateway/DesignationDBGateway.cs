using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticeOnLayerArchiEmployeeInfoApp.DAL.DAO;

namespace PracticeOnLayerArchiEmployeeInfoApp.DAL.DBGateway
{
    class DesignationDBGateway
    {
        public void Save(Designation aDesignation)
        {
            string connectionStr = @"Data Source=USER-PC\SQLEXPRESS; Database=EmployeeDB; Integrated Security=true";
            SqlConnection aSqlConnection=new SqlConnection(connectionStr);
            string query = "INSERT INTO tbl_Designation VALUES('" + aDesignation.Code + "','" + aDesignation.Title +"')";
            aSqlConnection.Open();
            SqlCommand aSqlCommand=new SqlCommand(query,aSqlConnection);
            aSqlCommand.ExecuteNonQuery();
            aSqlConnection.Close();
        }
    }
}
