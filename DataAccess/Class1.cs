using Dapper;
using DataAccess.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Class1
    {
        public IEnumerable<ExportDataModel> Get()
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["DemoApp.Properties.Settings.DemoAppDbConnectionString"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                {
                    db.Open();
                }
                return db.Query<ExportDataModel>("SELECT [Id] ,[Name] ,[Date] ,[UserName] ,[Local]  FROM [DemoAppDb].[dbo].[ExportsHistory]");
            }
        }
    }
}
